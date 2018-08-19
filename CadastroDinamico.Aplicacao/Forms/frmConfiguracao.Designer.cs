namespace CadastroDinamico.Aplicacao.Forms
{
    partial class frmConfiguracao
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
            this.pnServidor = new System.Windows.Forms.Panel();
            this.txbServidor = new System.Windows.Forms.TextBox();
            this.lblServidor = new System.Windows.Forms.Label();
            this.pnDatabase = new System.Windows.Forms.Panel();
            this.txbDatabase = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.pnUsuario = new System.Windows.Forms.Panel();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnSenha = new System.Windows.Forms.Panel();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.pnGravarLog = new System.Windows.Forms.Panel();
            this.ckbGravarLog = new System.Windows.Forms.CheckBox();
            this.lblGravarLog = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pnServidor.SuspendLayout();
            this.pnDatabase.SuspendLayout();
            this.pnUsuario.SuspendLayout();
            this.pnSenha.SuspendLayout();
            this.pnGravarLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnServidor
            // 
            this.pnServidor.Controls.Add(this.txbServidor);
            this.pnServidor.Controls.Add(this.lblServidor);
            this.pnServidor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnServidor.Location = new System.Drawing.Point(0, 0);
            this.pnServidor.Name = "pnServidor";
            this.pnServidor.Size = new System.Drawing.Size(800, 62);
            this.pnServidor.TabIndex = 3;
            // 
            // txbServidor
            // 
            this.txbServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbServidor.Location = new System.Drawing.Point(73, 21);
            this.txbServidor.Name = "txbServidor";
            this.txbServidor.Size = new System.Drawing.Size(715, 20);
            this.txbServidor.TabIndex = 4;
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(18, 24);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(49, 13);
            this.lblServidor.TabIndex = 3;
            this.lblServidor.Text = "Servidor:";
            // 
            // pnDatabase
            // 
            this.pnDatabase.Controls.Add(this.txbDatabase);
            this.pnDatabase.Controls.Add(this.lblDatabase);
            this.pnDatabase.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDatabase.Location = new System.Drawing.Point(0, 62);
            this.pnDatabase.Name = "pnDatabase";
            this.pnDatabase.Size = new System.Drawing.Size(800, 62);
            this.pnDatabase.TabIndex = 4;
            // 
            // txbDatabase
            // 
            this.txbDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDatabase.Location = new System.Drawing.Point(73, 21);
            this.txbDatabase.Name = "txbDatabase";
            this.txbDatabase.Size = new System.Drawing.Size(715, 20);
            this.txbDatabase.TabIndex = 4;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(18, 24);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(41, 13);
            this.lblDatabase.TabIndex = 3;
            this.lblDatabase.Text = "Banco:";
            // 
            // pnUsuario
            // 
            this.pnUsuario.Controls.Add(this.txbUsuario);
            this.pnUsuario.Controls.Add(this.lblUsuario);
            this.pnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnUsuario.Location = new System.Drawing.Point(0, 124);
            this.pnUsuario.Name = "pnUsuario";
            this.pnUsuario.Size = new System.Drawing.Size(800, 62);
            this.pnUsuario.TabIndex = 5;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUsuario.Location = new System.Drawing.Point(73, 21);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(715, 20);
            this.txbUsuario.TabIndex = 4;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(18, 24);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuário:";
            // 
            // pnSenha
            // 
            this.pnSenha.Controls.Add(this.txbSenha);
            this.pnSenha.Controls.Add(this.lblSenha);
            this.pnSenha.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSenha.Location = new System.Drawing.Point(0, 186);
            this.pnSenha.Name = "pnSenha";
            this.pnSenha.Size = new System.Drawing.Size(800, 62);
            this.pnSenha.TabIndex = 6;
            // 
            // txbSenha
            // 
            this.txbSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSenha.Location = new System.Drawing.Point(73, 21);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(715, 20);
            this.txbSenha.TabIndex = 4;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(18, 24);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // pnGravarLog
            // 
            this.pnGravarLog.Controls.Add(this.ckbGravarLog);
            this.pnGravarLog.Controls.Add(this.lblGravarLog);
            this.pnGravarLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnGravarLog.Location = new System.Drawing.Point(0, 248);
            this.pnGravarLog.Name = "pnGravarLog";
            this.pnGravarLog.Size = new System.Drawing.Size(800, 62);
            this.pnGravarLog.TabIndex = 7;
            // 
            // ckbGravarLog
            // 
            this.ckbGravarLog.AutoSize = true;
            this.ckbGravarLog.Location = new System.Drawing.Point(87, 25);
            this.ckbGravarLog.Name = "ckbGravarLog";
            this.ckbGravarLog.Size = new System.Drawing.Size(15, 14);
            this.ckbGravarLog.TabIndex = 4;
            this.ckbGravarLog.UseVisualStyleBackColor = true;
            // 
            // lblGravarLog
            // 
            this.lblGravarLog.AutoSize = true;
            this.lblGravarLog.Location = new System.Drawing.Point(18, 25);
            this.lblGravarLog.Name = "lblGravarLog";
            this.lblGravarLog.Size = new System.Drawing.Size(63, 13);
            this.lblGravarLog.TabIndex = 3;
            this.lblGravarLog.Text = "Gravar Log:";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(502, 341);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(130, 39);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(171, 341);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(130, 39);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // frmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.pnGravarLog);
            this.Controls.Add(this.pnSenha);
            this.Controls.Add(this.pnUsuario);
            this.Controls.Add(this.pnDatabase);
            this.Controls.Add(this.pnServidor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmConfiguracao";
            this.Text = "Configuração";
            this.Load += new System.EventHandler(this.frmConfiguracao_Load);
            this.pnServidor.ResumeLayout(false);
            this.pnServidor.PerformLayout();
            this.pnDatabase.ResumeLayout(false);
            this.pnDatabase.PerformLayout();
            this.pnUsuario.ResumeLayout(false);
            this.pnUsuario.PerformLayout();
            this.pnSenha.ResumeLayout(false);
            this.pnSenha.PerformLayout();
            this.pnGravarLog.ResumeLayout(false);
            this.pnGravarLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnServidor;
        private System.Windows.Forms.TextBox txbServidor;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Panel pnDatabase;
        private System.Windows.Forms.TextBox txbDatabase;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Panel pnUsuario;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel pnSenha;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Panel pnGravarLog;
        private System.Windows.Forms.Label lblGravarLog;
        private System.Windows.Forms.CheckBox ckbGravarLog;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLimpar;
    }
}