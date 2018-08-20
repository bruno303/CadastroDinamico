using CadastroDinamico.Core;
using CadastroDinamico.Dominio;
using CadastroDinamico.Persistencia;
using CadastroDinamico.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace CadastroDinamico.Aplicacao.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tclPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tclPrincipal.SelectedTab == tpgConfiguracao)
            {
                RealinharBotoesConfiguracao();
                CarregarDadosAsync();
            }
            else if (tclPrincipal.SelectedTab == tpgCadastroDinamico)
            {
                RealinharBotoesCadDinamico();
                RealinharGridsCadDinamico();
                CarregarDadosCadDinamico();
            }
        }

        private async void CarregarDadosAsync()
        {
            Cursor = Cursors.AppStarting;
            Configurador configurador = new Configurador();
            Dominio.Configuracao configuracao = await configurador.RetornarConfiguracaoAsync();
            if (configuracao != null)
            {
                txbServidor.Text = configuracao.Servidor;
                txbDatabase.Text = configuracao.Banco;
                txbUsuario.Text = configuracao.Usuario;
                txbSenha.Text = configuracao.Senha;
                ckbGravarLog.Checked = configuracao.RegistrarLog;
            }
            Cursor = Cursors.Default;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (ConfirmarOperacao("Deseja realmente limpar a configuração?"))
            {
                txbServidor.Clear();
                txbDatabase.Clear();
                txbUsuario.Clear();
                txbSenha.Clear();
                ckbGravarLog.Checked = false;
                LimparArquivoAsync();
            }
        }

        private bool ConfirmarOperacao(string texto)
        {
            return MessageBox.Show(texto, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private async void LimparArquivoAsync()
        {
            string resultado = string.Empty;

            Cursor = Cursors.AppStarting;

            resultado = await new Configurador().AlterarConfiguracaoAsync(null);

            Cursor = Cursors.Default;

            if (resultado != string.Empty)
            {
                MessageBox.Show(resultado);
            }
            else
            {
                MessageBox.Show("Arquivo alterado com sucesso!");
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ConfirmarOperacao("Deseja realmente salvar a configuração?"))
            {
                SalvarDadosAsync();
            }
        }

        private async void SalvarDadosAsync()
        {
            string resultado = string.Empty;

            Cursor = Cursors.AppStarting;

            Configurador configurador = new Configurador();
            Configuracao configuracao = new Configuracao()
            {
                Servidor = txbServidor.Text.ToUpper().Trim(),
                Banco = txbDatabase.Text.ToUpper().Trim(),
                Usuario = txbUsuario.Text.Trim(),
                Senha = txbSenha.Text,
                RegistrarLog = ckbGravarLog.Checked
            };

            resultado = await configurador.AlterarConfiguracaoAsync(configuracao);
            Cursor = Cursors.Default;
            if (resultado != string.Empty)
            {
                MessageBox.Show(resultado);
            }
            else
            {
                MessageBox.Show("Registros gravados com sucesso!");
            }
        }

        private void tclPrincipal_SizeChanged(object sender, EventArgs e)
        {
            RealinharBotoesConfiguracao();
            RealinharBotoesCadDinamico();
            RealinharGridsCadDinamico();
        }

        private void RealinharBotoesConfiguracao()
        {
            btnLimpar.Left = Convert.ToInt32((btnLimpar.Parent.Width / 4) - (btnLimpar.Width / 2));
            btnGravar.Left = Convert.ToInt32((btnGravar.Parent.Width / 2) + (btnGravar.Parent.Width / 4) - (btnGravar.Width / 2));
        }

        private void RealinharBotoesCadDinamico()
        {
            btnCancelar.Left = Convert.ToInt32((btnCancelar.Parent.Width / 4) - (btnCancelar.Width / 2));
            btnAvancar.Left = Convert.ToInt32((btnAvancar.Parent.Width / 2) + (btnAvancar.Parent.Width / 4) - (btnAvancar.Width / 2));
            btnAdicionar.Left = Convert.ToInt32((btnAdicionar.Parent.Width / 2) - (btnAdicionar.Width / 2));
            btnRemover.Left = Convert.ToInt32((btnRemover.Parent.Width / 2) - (btnRemover.Width / 2));
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tclPrincipal.SelectedTab = tpgConfiguracao;
            CarregarDadosAsync();
            RealinharBotoesConfiguracao();
            RealinharBotoesCadDinamico();
        }

        private void RealinharGridsCadDinamico()
        {
            dgvColunas.Width = Convert.ToInt32((dgvColunas.Parent.Width / 2) - 85);
            dgvColunasSelecionadas.Left = Convert.ToInt32((dgvColunasSelecionadas.Parent.Width / 2) + 85);
            dgvColunasSelecionadas.Width = Convert.ToInt32((dgvColunasSelecionadas.Parent.Width / 2) - 85);
        }

        private void CarregarDadosCadDinamico()
        {
            CarregarSchemasAsync();
            DataTable colunasSelecionadas = new DataTable("COLUNAS");
            colunasSelecionadas.Columns.Add("COLUNA");
            dgvColunasSelecionadas.DataSource = colunasSelecionadas;
        }

        private async void CarregarSchemasAsync()
        {
            try
            {
                Cursor = Cursors.AppStarting;
                Conexao conexao = new Conexao(new Configurador().RetornarConfiguracao());

                ((DataTable)dgvColunas.DataSource)?.Clear();
                ((DataTable)dgvColunasSelecionadas.DataSource)?.Clear();
                cbxTabela.Items.Clear();

                DataTable schemas = await conexao.RetornarDadosAsync("SELECT NAME FROM SYS.SCHEMAS WITH(NOLOCK)");
                if (schemas.TemRegistros())
                {
                    foreach (DataRow linha in schemas.Rows)
                    {
                        cbxSchema.Items.Add(linha[0].ToString());
                    }
                    cbxSchema.SelectedIndex = 0;
                    cbxSchema_SelectedIndexChanged(null, null);
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
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
                Cursor = Cursors.AppStarting;
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
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
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

            Cursor = Cursors.AppStarting;

            Dominio.Configuracao configuracao = configurador.RetornarConfiguracao();
            Conexao conexao = new Conexao(configuracao);

            string query = string.Format(@" SELECT C.COLUMN_NAME AS COLUNA
                                            FROM INFORMATION_SCHEMA.TABLES T WITH(NOLOCK)
                                            INNER JOIN INFORMATION_SCHEMA.COLUMNS C WITH(NOLOCK) ON T.TABLE_CATALOG = C.TABLE_CATALOG AND
	                                            T.TABLE_NAME = C.TABLE_NAME
                                            WHERE T.TABLE_SCHEMA = '{1}' AND C.TABLE_NAME = '{0}'", tabela, schema);
            colunas = await conexao.RetornarDadosAsync(query);
            dgvColunas.DataSource = colunas;
            Cursor = Cursors.Default;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tclPrincipal.SelectedTab = tpgConfiguracao;
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
                form.ShowDialog();
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

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tclPrincipal.SelectedTab == tpgConfiguracao)
                {
                    btnGravar_Click(sender, e);
                }
            }
        }
    }
}
