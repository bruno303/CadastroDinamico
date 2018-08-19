using CadastroDinamico.Dominio;
using CadastroDinamico.Persistencia;
using CadastroDinamico.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CadastroDinamico.Core
{
    public class Tabela : ITabela
    {
        public string Nome { get; set; }
        public string Schema { get; set; }
        public bool TemChavePrimaria { get; set; }
        public bool TemChaveEstrangeira { get; set; }
        public int QuantidadeCampos { get; set; }
        public List<Coluna> Colunas { get; set; }
        //public List<string> CamposCriptografados { get; set; }
        public List<string> CamposNaoExibir { get; set; }

        public Tabela(string tabela, string schema)
        {
            Nome = tabela;
            Schema = schema;
        }

        public Tabela(string tabela)
        {
            Nome = tabela;
        }

        public Task<string> CarregarAsync()
        {
            return Task.Run(() =>
            {
                return Carregar();
            });
        }

        public string Carregar()
        {
            string retorno = string.Empty;
            DataTable dadosCampos = null;

            if (string.IsNullOrEmpty(Schema))
            {
                Schema = "dbo";
            }

            try
            {
                Colunas = new List<Coluna>();

                string query = string.Format(
                    @"SELECT COL.COLUMN_NAME, COL.ORDINAL_POSITION, COL.COLUMN_DEFAULT,
	                  COL.IS_NULLABLE, COL.DATA_TYPE, COL.CHARACTER_MAXIMUM_LENGTH,
	                  COL.NUMERIC_PRECISION, COL.NUMERIC_PRECISION_RADIX
                  FROM INFORMATION_SCHEMA.COLUMNS COL WITH(NOLOCK)
                  WHERE COL.TABLE_NAME = '{0}'", Nome);
                dadosCampos = new Conexao(new Configurador().RetornarConfiguracao()).RetornarDados(query);
                if (dadosCampos.TemRegistros())
                {
                    foreach (DataRow registro in dadosCampos.Rows)
                    {
                        Coluna campo = new Coluna()
                        {
                            AceitaNull = (registro["IS_NULLABLE"].ToString().ToUpper().Equals("YES")),
                            Nome = registro["COLUMN_NAME"].ToString(),
                            Posicao = Convert.ToInt32(registro["ORDINAL_POSITION"].ToString()),
                            ExpressaoValorDefault = registro["COLUMN_DEFAULT"].ToString(),
                            PrecisaoNumerica = registro["NUMERIC_PRECISION"].ToString() == string.Empty ? -1 : Convert.ToInt32(registro["NUMERIC_PRECISION"].ToString()),
                            Tipo = registro["DATA_TYPE"].ToString(),
                            TamanhoMaximo = registro["CHARACTER_MAXIMUM_LENGTH"].ToString() != string.Empty ? Convert.ToInt32(registro["CHARACTER_MAXIMUM_LENGTH"].ToString()) : 0,
                            PrecisaoNumericaRadix = registro["NUMERIC_PRECISION_RADIX"].ToString() != string.Empty ? Convert.ToInt32(registro["NUMERIC_PRECISION_RADIX"].ToString()) : 0
                        };

                        object[] dadosChaveEstrangeira = RetornarDadosFK(campo.Nome);

                        if (dadosChaveEstrangeira != null)
                        {
                            campo.IsChaveEstrangeira = (bool)dadosChaveEstrangeira[0];
                            campo.TabelaReferenciada = dadosChaveEstrangeira[1].ToString();
                            campo.ColunaReferenciada = dadosChaveEstrangeira[2].ToString();
                        }
                        else
                        {
                            campo.IsChaveEstrangeira = false;
                        }

                        campo.IsChavePrimaria = RetornarDadoChavePrimaria(campo.Nome);

                        Colunas.Add(campo);
                    }
                }
            }
            catch (Exception ex)
            {
                retorno = ex.Message;
            }

            return retorno;
        }

        public DataTable RetornarAmostraDados(List<string> camposNaoExibir)
        {
            return new Conexao(new Configurador().RetornarConfiguracao()).RetornarDados(RetornarSelect(true));
        }

        public string RetornarSelect(bool amostra = false)
        {
            string query = string.Empty;

            query = "SELECT " + (amostra ? "TOP(10) " : "");
            foreach (var coluna in Colunas)
            {
                query += coluna.Nome + ", ";
            }
            query = query.Remove(query.Length - 2, 2);
            query += string.Format(" FROM {0} WITH(NOLOCK)", Nome);

            return query;
        }

        public object[] RetornarDadosFK(string coluna)
        {
            object[] retorno = null;

            string query = string.Format(@"
                SELECT TAB2.NAME AS TABELA_REFERENCIADA,
	                   COL2.NAME AS COLUNA_REFERENCIADA
                FROM SYS.FOREIGN_KEY_COLUMNS FKC WITH(NOLOCK)
                INNER JOIN SYS.TABLES TAB WITH(NOLOCK) ON FKC.PARENT_OBJECT_ID = TAB.OBJECT_ID
                INNER JOIN SYS.TABLES TAB2 WITH(NOLOCK) ON FKC.REFERENCED_OBJECT_ID = TAB2.OBJECT_ID
                INNER JOIN SYS.COLUMNS COL WITH(NOLOCK) ON FKC.PARENT_OBJECT_ID = COL.OBJECT_ID

                    AND FKC.PARENT_COLUMN_ID = COL.COLUMN_ID
                INNER JOIN SYS.COLUMNS COL2 WITH(NOLOCK) ON FKC.REFERENCED_OBJECT_ID = COL2.OBJECT_ID

                    AND FKC.REFERENCED_COLUMN_ID = COL2.COLUMN_ID
                WHERE TAB.NAME = '{0}' AND COL.NAME = '{1}'", Nome, coluna);
            DataTable dados = new Conexao(new Configurador().RetornarConfiguracao()).RetornarDados(query);
            if (dados.TemRegistros())
            {
                retorno = new object[3];

                retorno[0] = true;                          // IsForeignKey
                retorno[1] = dados.Rows[0][0].ToString();   // TabelaReferenciada
                retorno[2] = dados.Rows[0][1].ToString();   // ColunaReferenciada
            }

            return retorno;
        }

        public bool RetornarDadoChavePrimaria(string coluna)
        {
            bool retorno = false;

            string query = string.Format(@"
                SELECT CCU.COLUMN_NAME
                FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS TC WITH(NOLOCK)
                INNER JOIN INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE CCU WITH(NOLOCK) ON
	                TC.CONSTRAINT_NAME = CCU.CONSTRAINT_NAME AND TC.TABLE_CATALOG = CCU.TABLE_CATALOG
	                AND TC.TABLE_SCHEMA = CCU.TABLE_SCHEMA AND TC.TABLE_NAME = CCU.TABLE_NAME
                WHERE TC.TABLE_NAME = '{0}' AND TC.CONSTRAINT_TYPE = 'PRIMARY KEY'", Nome);

            DataTable dados = new Conexao(new Configurador().RetornarConfiguracao()).RetornarDados(query);
            if (dados.TemRegistros())
            {
                retorno = dados.Rows[0][0].ToString().Equals(coluna);
            }

            return retorno;
        }
    }
}
