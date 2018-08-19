using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDinamico.Aplicacao.Forms
{
    public partial class frmConfiguracao : Form
    {
        public frmConfiguracao()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            SalvarDadosAsync();
        }

        private async void SalvarDadosAsync()
        {
            string resultado = string.Empty;

            resultado = await SalvarConfiguracao();

            if (resultado != string.Empty)
            {
                MessageBox.Show(resultado);
            }
            else
            {
                MessageBox.Show("Registros gravados com sucesso!");
            }
        }

        private Task<string> SalvarConfiguracao()
        {
            return Task.Run(() =>
            {
                Core.Configurador configurador = new Core.Configurador();
                Dominio.Configuracao configuracao = new Dominio.Configuracao()
                {
                    Servidor = txbServidor.Text.ToUpper().Trim(),
                    Banco = txbDatabase.Text.ToUpper().Trim(),
                    Usuario = txbUsuario.Text.Trim(),
                    Senha = txbSenha.Text,
                    RegistrarLog = ckbGravarLog.Checked
                };
                return configurador.AlterarConfiguracao(configuracao);
            });
        }

        private void frmConfiguracao_Load(object sender, EventArgs e)
        {
            CarregarDadosAsync();
        }

        private async void CarregarDadosAsync()
        {
            Dominio.Configuracao configuracao = await CarregarConfiguracao();
            if (configuracao != null)
            {
                txbServidor.Text = configuracao.Servidor;
                txbDatabase.Text = configuracao.Banco;
                txbUsuario.Text = configuracao.Usuario;
                txbSenha.Text = configuracao.Senha;
                ckbGravarLog.Checked = configuracao.RegistrarLog;
            }
        }

        private Task<Dominio.Configuracao> CarregarConfiguracao()
        {
            return Task.Run(() =>
            {
                Core.Configurador configurador = new Core.Configurador();
                return configurador.RetornarConfiguracao();
            });
        }
    }
}
