namespace CadastroDinamico.Aplicacao.Forms
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConfiguracao = new System.Windows.Forms.Button();
            this.btnCadastroDinamico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.Location = new System.Drawing.Point(12, 12);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Size = new System.Drawing.Size(81, 33);
            this.btnConfiguracao.TabIndex = 0;
            this.btnConfiguracao.Text = "Configuração";
            this.btnConfiguracao.UseVisualStyleBackColor = true;
            this.btnConfiguracao.Click += new System.EventHandler(this.btnConfiguracao_Click);
            // 
            // btnCadastroDinamico
            // 
            this.btnCadastroDinamico.Location = new System.Drawing.Point(99, 12);
            this.btnCadastroDinamico.Name = "btnCadastroDinamico";
            this.btnCadastroDinamico.Size = new System.Drawing.Size(81, 33);
            this.btnCadastroDinamico.TabIndex = 1;
            this.btnCadastroDinamico.Text = "Cad Din";
            this.btnCadastroDinamico.UseVisualStyleBackColor = true;
            this.btnCadastroDinamico.Click += new System.EventHandler(this.btnCadastroDinamico_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastroDinamico);
            this.Controls.Add(this.btnConfiguracao);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfiguracao;
        private System.Windows.Forms.Button btnCadastroDinamico;
    }
}