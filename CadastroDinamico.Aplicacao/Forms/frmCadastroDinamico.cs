using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CadastroDinamico.Core;
using CadastroDinamico.Dominio;
using CadastroDinamico.Utils;

namespace CadastroDinamico.Aplicacao.Forms
{
    public partial class frmCadastroDinamico : Form
    {
        public string NomeTabela { get; set; }
        public string SchemaTabela { get; set; }

        private Tabela tabela;
        private DataGridView dgvDados;
        private List<Control> controles;
        private List<Panel> panels;
        private List<string> TiposMaskedTextBox;
        private List<string> TiposCheckBox;
        private List<string> TiposDateTimePicker;
        private List<string> CamposNaoExibir;

        public frmCadastroDinamico()
        {
            InitializeComponent();
            CamposNaoExibir = new List<string>();
            controles = new List<Control>();
            panels = new List<Panel>();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            TiposMaskedTextBox = new List<string>
            {
                eTiposDados.@int.ToString(),
                eTiposDados.tinyint.ToString(),
                eTiposDados.bigint.ToString(),
                eTiposDados.smallint.ToString(),
                eTiposDados.text.ToString(),
                eTiposDados.ntext.ToString(),
                eTiposDados.@char.ToString(),
                eTiposDados.nchar.ToString(),
                eTiposDados.varchar.ToString(),
                eTiposDados.nvarchar.ToString(),
                eTiposDados.sysname.ToString(),

                eTiposDados.date.ToString(),
                eTiposDados.datetime.ToString(),
                eTiposDados.datetime2.ToString(),
                eTiposDados.datetimeoffset.ToString(),
                eTiposDados.time.ToString(),
                eTiposDados.timestamp.ToString()
            };

            TiposCheckBox = new List<string>()
            {
                eTiposDados.bit.ToString()
            };

            TiposDateTimePicker = new List<string>()
            {
                //eTiposDados.date.ToString(),
                //eTiposDados.datetime.ToString(),
                //eTiposDados.datetime2.ToString(),
                //eTiposDados.datetimeoffset.ToString(),
                //eTiposDados.time.ToString(),
                //eTiposDados.timestamp.ToString()
            };

            Carregar();
        }

        private async void Carregar()
        {
            tabela = new Tabela(NomeTabela);
            List<Panel> panels = new List<Panel>();

            await tabela.CarregarAsync();
            DataTable dadosAmostra = tabela.RetornarAmostraDados(CamposNaoExibir);

            SuspendLayout();
            foreach (var coluna in tabela.Colunas)
            {
                Panel panel = new Panel();
                panel.Dock = DockStyle.Top;
                panel.Location = new Point(0, 175);
                panel.Name = "pnCampo_" + coluna.Nome;
                panel.Size = new Size(733, 30);
                panel.SuspendLayout();
                panel.Tag = coluna.Nome;

                Control control = null;
                if (TiposMaskedTextBox.Where(p => p.Equals(coluna.Tipo)).ToList().Count > 0)
                {
                    MaskedTextBox maskedTextBox = new MaskedTextBox();
                    control = maskedTextBox;
                    // 
                    // MaskedTextBox
                    // 
                    maskedTextBox.Location = new Point(182, 10);
                    maskedTextBox.Name = "txb" + coluna.Nome.ToLower();
                    maskedTextBox.Size = new Size(278, 23);
                    maskedTextBox.Tag = coluna.Posicao;

                    if (coluna.Tipo.ToUpper().Equals("INT"))
                    {
                        maskedTextBox.Mask = "000000000000000";
                        maskedTextBox.ValidatingType = typeof(int);
                    }
                    else if (coluna.Tipo.ToUpper().Equals("SMALLINT") ||
                             coluna.Tipo.ToUpper().Equals("TINYINT"))
                    {
                        maskedTextBox.Mask = "0000000000";
                        maskedTextBox.ValidatingType = typeof(short);
                    }
                    else if (coluna.Tipo.ToUpper().Equals("BIGINT"))
                    {
                        maskedTextBox.Mask = "00000000000000000000";
                        maskedTextBox.ValidatingType = typeof(long);
                    }
                    else if (coluna.Tipo.ToUpper().Equals("DATETIME"))
                    {
                        maskedTextBox.Mask = "00/00/0000 90:00";
                        maskedTextBox.ValidatingType = typeof(DateTime);
                    }
                    else if (coluna.Tipo.ToUpper().Equals("DATE"))
                    {
                        maskedTextBox.Mask = "00/00/0000";
                        maskedTextBox.ValidatingType = typeof(DateTime);
                    }
                    else if (coluna.Tipo.ToUpper().Equals("TIME"))
                    {
                        maskedTextBox.Mask = "90:00";
                        maskedTextBox.ValidatingType = typeof(DateTime);
                    }

                    controles.Add(maskedTextBox);
                    panel.Controls.Add(maskedTextBox);
                }
                else if (TiposCheckBox.Where(p => p.Equals(coluna.Tipo)).ToList().Count > 0)
                {
                    CheckBox checkBox = new CheckBox();
                    control = checkBox;
                    checkBox.Location = new Point(182, 10);
                    checkBox.Name = "ckb" + coluna.Nome;
                    checkBox.Size = new Size(14, 23);
                    checkBox.Tag = coluna.Posicao;

                    controles.Add(checkBox);
                    panel.Controls.Add(checkBox);
                }
                else if (TiposDateTimePicker.Where(p => p.Equals(coluna.Tipo)).ToList().Count > 0)
                {
                    DateTimePicker dateTimePicker = new DateTimePicker();
                    control = dateTimePicker;
                    dateTimePicker.Location = new Point(182, 10);
                    dateTimePicker.Name = "dtp" + coluna.Nome;
                    dateTimePicker.Size = new Size(278, 23);
                    dateTimePicker.Tag = coluna.Posicao;

                    controles.Add(dateTimePicker);
                    panel.Controls.Add(dateTimePicker);
                }

                //
                // label
                //
                Label label = new Label();
                label.AutoSize = false;
                label.Location = new Point(80, 10);
                label.Name = "lb" + coluna.Nome;
                label.Size = new Size(100, 13);
                label.Text = coluna.Nome;
                label.TextAlign = ContentAlignment.TopRight;
                label.Tag = control;
                if (!coluna.AceitaNull)
                {
                    label.ForeColor = Color.Red;
                    label.Font = new Font(label.Font, FontStyle.Bold);
                    label.Text += " *";
                }

                panel.Controls.Add(label);
                panels.Add(panel);
                panel.ResumeLayout();
                this.panels.Add(panel);
            }
            panels.Reverse();
            foreach (Panel control in panels)
            {
                Controls.Add(control);
            }
            Controls.Add(RetornarGridDados());
            ResumeLayout(false);
            PerformLayout();

            dgvDados.DataSource = dadosAmostra;
            OcultarCampos();
        }

        private void OcultarCampos()
        {
            foreach (DataGridViewColumn coluna in dgvDados.Columns)
            {
                coluna.Visible = (CamposNaoExibir.Where(p => p.Igual(coluna.HeaderText)).FirstOrDefault() == null);
            }

            foreach (Control panel in panels)
            {
                panel.Visible = (CamposNaoExibir.Where(p => p.Igual(panel.Tag.ToString())).FirstOrDefault() == null);
            }
        }

        private void dgvDados_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDados != null)
            {
                for (int i = 0; i < dgvDados.SelectedRows[0].Cells.Count; i++)
                {
                    DataGridViewCell coluna = dgvDados.SelectedRows[0].Cells[i];
                    Control control = RetornarControlePorTag(i + 1);
                    if (control != null)
                    {
                        if (control is MaskedTextBox)
                        {
                            (control as MaskedTextBox).Text = coluna.Value.ToString();
                        }
                        else if (control is CheckBox)
                        {
                            (control as CheckBox).Checked = (bool)coluna.Value;
                        }
                        else if (control is DateTimePicker)
                        {
                            var data = (coluna.Value as DateTime?);
                            (control as DateTimePicker).Value = (data == null ? (control as DateTimePicker).MinDate : (DateTime)data);
                        }
                    }
                }
            }
        }

        private Control RetornarControlePorTag(int tag)
        {
            Control retorno = null;

            foreach (Control item in controles)
            {
                if (item.Tag != null)
                {
                    if (item.Tag.ToString().Equals(tag.ToString()))
                    {
                        retorno = item;
                        break;
                    }
                }
            }

            return retorno;
        }

        private Panel RetornarGridDados()
        {
            dgvDados = new DataGridView();
            Panel pnGrid = new Panel();

            ((ISupportInitialize)(dgvDados)).BeginInit();

            pnGrid.SuspendLayout();
            pnGrid.Controls.Add(dgvDados);
            pnGrid.Dock = DockStyle.Top;
            pnGrid.Location = new Point(0, 0);
            pnGrid.Name = "pnGrid";
            pnGrid.Size = new Size(733, 175);
            pnGrid.TabIndex = 1;

            dgvDados.AllowUserToAddRows = false;
            dgvDados.AllowUserToDeleteRows = false;
            dgvDados.AllowUserToOrderColumns = true;
            dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Dock = DockStyle.Fill;
            dgvDados.Location = new Point(0, 0);
            dgvDados.MultiSelect = false;
            dgvDados.Name = "dgvDados";
            dgvDados.ReadOnly = true;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.Size = new Size(733, 175);
            dgvDados.TabIndex = 1;
            dgvDados.DoubleClick += new EventHandler(dgvDados_DoubleClick);

            ((ISupportInitialize)(dgvDados)).EndInit();

            pnGrid.Controls.Add(dgvDados);
            pnGrid.ResumeLayout();

            return pnGrid;
        }

        public bool AdicionarColunaOculta(string coluna)
        {
            try
            {
                CamposNaoExibir.Add(coluna);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
