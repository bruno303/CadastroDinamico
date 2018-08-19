using System;
using System.Data;
using System.Windows.Forms;
using CadastroDinamico.Persistencia;
using CadastroDinamico.Core;
using CadastroDinamico.Utils;

namespace CadastroDinamico.Aplicacao.Forms
{
    public partial class frmEscolhaTabela : Form
    {
        public frmEscolhaTabela()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEscolhaTabela_Load(object sender, EventArgs e)
        {
            CarregarSchemasAsync();
            DataTable dt = new DataTable("COLUNAS");
            dt.Columns.Add("COLUNA");
            dgvColunasSelecionadas.DataSource = dt;
        }

        private async void CarregarSchemasAsync()
        {
            try
            {
                Conexao conexao = new Conexao(new Configurador().RetornarConfiguracao());
                DataTable schemas = await conexao.RetornarDadosAsync("SELECT NAME FROM SYS.SCHEMAS WITH(NOLOCK)");
                if (schemas.TemRegistros())
                {
                    foreach (DataRow linha in schemas.Rows)
                    {
                        cbxSchema.Items.Add(linha[0].ToString());
                    }
                    cbxSchema.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxSchema_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarTabelasAsync(cbxSchema.Text);
        }

        private async void CarregarTabelasAsync(string schema)
        {
            try
            {
                Conexao conexao = new Conexao(new Configurador().RetornarConfiguracao());
                string query = string.Format("SELECT TABLE_NAME AS TABELA FROM INFORMATION_SCHEMA.TABLES WITH(NOLOCK) WHERE TABLE_SCHEMA = '{0}'", schema);

                DataTable tabelas = await conexao.RetornarDadosAsync(query);
                cbxTabela.Items.Clear();
                if (tabelas.TemRegistros())
                {
                    foreach (DataRow linha in tabelas.Rows)
                    {
                        cbxTabela.Items.Add(linha[0].ToString());
                    }
                    cbxTabela.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            string validacao = DadosValidos();
            if (validacao == string.Empty)
            {
                frmCadastroDinamico form = new frmCadastroDinamico();
                form.NomeTabela = cbxTabela.Text;
                form.SchemaTabela = cbxSchema.Text;
                foreach (DataGridViewRow item in dgvColunasSelecionadas.Rows)
                {
                    form.AdicionarColunaOculta(item.Cells[0].Value.ToString());
                }
                form.Show();
                Close();
            }
            else
            {
                MessageBox.Show(validacao);
            }
        }

        private string DadosValidos()
        {
            if (string.IsNullOrEmpty(cbxSchema.Text))
            {
                return "É necessário escolher um schema!";
            }
            else if (string.IsNullOrEmpty(cbxTabela.Text))
            {
                return "É necessário escolher uma tabela!";
            }
            else
            {
                return string.Empty;
            }
        }

        private void cbxTabela_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarCamposAsync(cbxSchema.Text, cbxTabela.Text);
        }

        private async void CarregarCamposAsync(string schema, string tabela)
        {
            DataTable colunas;
            Configurador configurador = new Configurador();
            Dominio.Configuracao configuracao = configurador.RetornarConfiguracao();
            Conexao conexao = new Conexao(configuracao);

            string query = string.Format(@" SELECT C.COLUMN_NAME AS COLUNA
                                            FROM INFORMATION_SCHEMA.TABLES T WITH(NOLOCK)
                                            INNER JOIN INFORMATION_SCHEMA.COLUMNS C WITH(NOLOCK) ON T.TABLE_CATALOG = C.TABLE_CATALOG AND
	                                            T.TABLE_NAME = C.TABLE_NAME
                                            WHERE T.TABLE_SCHEMA = '{1}' AND C.TABLE_NAME = '{0}'", tabela, schema);
            colunas = await conexao.RetornarDadosAsync(query);
            dgvColunas.DataSource = colunas;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (dgvColunas.SelectedRows.Count > 0)
            {
                for (int cont = 0; cont < dgvColunas.Rows.Count; cont++)
                {
                    if (dgvColunas.Rows[cont].Selected)
                    {
                        ((DataTable)dgvColunasSelecionadas.DataSource).Rows.Add(dgvColunas.Rows[cont].Cells[0].Value.ToString());
                        ((DataTable)dgvColunasSelecionadas.DataSource).AcceptChanges();
                        ((DataTable)dgvColunas.DataSource).Rows.RemoveAt(cont);
                        ((DataTable)dgvColunas.DataSource).AcceptChanges();
                    }
                }
                dgvColunasSelecionadas.Update();
                dgvColunasSelecionadas.Refresh();
                dgvColunas.Update();
                dgvColunas.Refresh();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvColunasSelecionadas.SelectedRows.Count > 0)
            {
                for (int cont = 0; cont < dgvColunasSelecionadas.Rows.Count; cont++)
                {
                    if (dgvColunasSelecionadas.Rows[cont].Selected)
                    {
                        ((DataTable)dgvColunas.DataSource).Rows.Add(dgvColunasSelecionadas.Rows[cont].Cells[0].Value.ToString());
                        ((DataTable)dgvColunas.DataSource).AcceptChanges();
                        ((DataTable)dgvColunasSelecionadas.DataSource).Rows.RemoveAt(cont);
                        ((DataTable)dgvColunasSelecionadas.DataSource).AcceptChanges();
                    }
                }
                dgvColunasSelecionadas.Update();
                dgvColunasSelecionadas.Refresh();
                dgvColunas.Update();
                dgvColunas.Refresh();
            }
        }
    }
}
