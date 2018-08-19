using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using CadastroDinamico.Dominio;
using CadastroDinamico.Utils;

namespace CadastroDinamico.Persistencia
{
    public class Conexao
    {
        private Configuracao Config = null;

        public Conexao(Configuracao configuracao)
        {
            Config = configuracao;
        }

        public DataTable RetornarDados(string query)
        {
            DataTable dados = new DataTable("DADOS");
            try
            {
                using (SqlConnection conexao = new SqlConnection(RetornarStringConexao()))
                {
                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                        {
                            adapter.Fill(dados);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dados;
        }

        public Task<DataTable> RetornarDadosAsync(string query)
        {
            return Task.Run(() =>
            {
                return RetornarDados(query);
            });
        }

        public string RetornarDadoUnico(string query)
        {
            try
            {
                DataTable dados = RetornarDados(query);
                return (dados.TemRegistros() ? dados.Rows[0][0].ToString() : string.Empty);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string RetornarStringConexao()
        {
            if (Config == null)
            {
                throw new Exception("Erro em Conexao. Mensagem: Não foram carregadas configurações válidas.");
            }
            else
            {
                return string.Format("Server = {0}; Database = {1}; User Id = {2};Password = {3};", Config.Servidor, Config.Banco,
                    Config.Usuario, Config.Senha);
            }
        }
    }
}
