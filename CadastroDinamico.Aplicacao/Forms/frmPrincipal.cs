using System;
using System.Windows.Forms;

namespace CadastroDinamico.Aplicacao.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastroDinamico_Click(object sender, EventArgs e)
        {
            frmEscolhaTabela form = new frmEscolhaTabela();
            form.Show();
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            frmConfiguracao form = new frmConfiguracao();
            form.Show();
        }
    }
}
