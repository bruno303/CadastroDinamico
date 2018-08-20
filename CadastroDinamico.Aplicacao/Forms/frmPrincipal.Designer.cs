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
            this.tclPrincipal = new System.Windows.Forms.TabControl();
            this.tpgConfiguracao = new System.Windows.Forms.TabPage();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.pnGravarLog = new System.Windows.Forms.Panel();
            this.ckbGravarLog = new System.Windows.Forms.CheckBox();
            this.lblGravarLog = new System.Windows.Forms.Label();
            this.pnSenha = new System.Windows.Forms.Panel();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.pnUsuario = new System.Windows.Forms.Panel();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnDatabase = new System.Windows.Forms.Panel();
            this.txbDatabase = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.pnServidor = new System.Windows.Forms.Panel();
            this.txbServidor = new System.Windows.Forms.TextBox();
            this.lblServidor = new System.Windows.Forms.Label();
            this.tpgCadastroDinamico = new System.Windows.Forms.TabPage();
            this.pnCamposTabela = new System.Windows.Forms.Panel();
            this.dgvColunasSelecionadas = new System.Windows.Forms.DataGridView();
            this.dgvColunas = new System.Windows.Forms.DataGridView();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.pnBotoesCadDinamico = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.pnCombos = new System.Windows.Forms.Panel();
            this.lblTabela = new System.Windows.Forms.Label();
            this.lblSchema = new System.Windows.Forms.Label();
            this.cbxTabela = new System.Windows.Forms.ComboBox();
            this.cbxSchema = new System.Windows.Forms.ComboBox();
            this.lblTodasColunas = new System.Windows.Forms.Label();
            this.lblColunasNaoExibir = new System.Windows.Forms.Label();
            this.tclPrincipal.SuspendLayout();
            this.tpgConfiguracao.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.pnGravarLog.SuspendLayout();
            this.pnSenha.SuspendLayout();
            this.pnUsuario.SuspendLayout();
            this.pnDatabase.SuspendLayout();
            this.pnServidor.SuspendLayout();
            this.tpgCadastroDinamico.SuspendLayout();
            this.pnCamposTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColunasSelecionadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColunas)).BeginInit();
            this.pnBotoesCadDinamico.SuspendLayout();
            this.pnCombos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tclPrincipal
            // 
            this.tclPrincipal.Controls.Add(this.tpgConfiguracao);
            this.tclPrincipal.Controls.Add(this.tpgCadastroDinamico);
            this.tclPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tclPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tclPrincipal.Name = "tclPrincipal";
            this.tclPrincipal.SelectedIndex = 0;
            this.tclPrincipal.Size = new System.Drawing.Size(800, 485);
            this.tclPrincipal.TabIndex = 2;
            this.tclPrincipal.SelectedIndexChanged += new System.EventHandler(this.tclPrincipal_SelectedIndexChanged);
            this.tclPrincipal.SizeChanged += new System.EventHandler(this.tclPrincipal_SizeChanged);
            // 
            // tpgConfiguracao
            // 
            this.tpgConfiguracao.Controls.Add(this.pnBotoes);
            this.tpgConfiguracao.Controls.Add(this.pnGravarLog);
            this.tpgConfiguracao.Controls.Add(this.pnSenha);
            this.tpgConfiguracao.Controls.Add(this.pnUsuario);
            this.tpgConfiguracao.Controls.Add(this.pnDatabase);
            this.tpgConfiguracao.Controls.Add(this.pnServidor);
            this.tpgConfiguracao.Location = new System.Drawing.Point(4, 22);
            this.tpgConfiguracao.Name = "tpgConfiguracao";
            this.tpgConfiguracao.Padding = new System.Windows.Forms.Padding(3);
            this.tpgConfiguracao.Size = new System.Drawing.Size(792, 459);
            this.tpgConfiguracao.TabIndex = 0;
            this.tpgConfiguracao.Text = "Configuração";
            this.tpgConfiguracao.UseVisualStyleBackColor = true;
            // 
            // pnBotoes
            // 
            this.pnBotoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnBotoes.Controls.Add(this.btnLimpar);
            this.pnBotoes.Controls.Add(this.btnGravar);
            this.pnBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBotoes.Location = new System.Drawing.Point(3, 373);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(786, 83);
            this.pnBotoes.TabIndex = 17;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(152, 22);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(130, 39);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(491, 22);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(130, 39);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // pnGravarLog
            // 
            this.pnGravarLog.Controls.Add(this.ckbGravarLog);
            this.pnGravarLog.Controls.Add(this.lblGravarLog);
            this.pnGravarLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnGravarLog.Location = new System.Drawing.Point(3, 251);
            this.pnGravarLog.Name = "pnGravarLog";
            this.pnGravarLog.Size = new System.Drawing.Size(786, 62);
            this.pnGravarLog.TabIndex = 14;
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
            // pnSenha
            // 
            this.pnSenha.Controls.Add(this.txbSenha);
            this.pnSenha.Controls.Add(this.lblSenha);
            this.pnSenha.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSenha.Location = new System.Drawing.Point(3, 189);
            this.pnSenha.Name = "pnSenha";
            this.pnSenha.Size = new System.Drawing.Size(786, 62);
            this.pnSenha.TabIndex = 13;
            // 
            // txbSenha
            // 
            this.txbSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSenha.Location = new System.Drawing.Point(73, 21);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(701, 20);
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
            // pnUsuario
            // 
            this.pnUsuario.Controls.Add(this.txbUsuario);
            this.pnUsuario.Controls.Add(this.lblUsuario);
            this.pnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnUsuario.Location = new System.Drawing.Point(3, 127);
            this.pnUsuario.Name = "pnUsuario";
            this.pnUsuario.Size = new System.Drawing.Size(786, 62);
            this.pnUsuario.TabIndex = 12;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUsuario.Location = new System.Drawing.Point(73, 21);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(701, 20);
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
            // pnDatabase
            // 
            this.pnDatabase.Controls.Add(this.txbDatabase);
            this.pnDatabase.Controls.Add(this.lblDatabase);
            this.pnDatabase.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDatabase.Location = new System.Drawing.Point(3, 65);
            this.pnDatabase.Name = "pnDatabase";
            this.pnDatabase.Size = new System.Drawing.Size(786, 62);
            this.pnDatabase.TabIndex = 11;
            // 
            // txbDatabase
            // 
            this.txbDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDatabase.Location = new System.Drawing.Point(73, 21);
            this.txbDatabase.Name = "txbDatabase";
            this.txbDatabase.Size = new System.Drawing.Size(701, 20);
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
            // pnServidor
            // 
            this.pnServidor.Controls.Add(this.txbServidor);
            this.pnServidor.Controls.Add(this.lblServidor);
            this.pnServidor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnServidor.Location = new System.Drawing.Point(3, 3);
            this.pnServidor.Name = "pnServidor";
            this.pnServidor.Size = new System.Drawing.Size(786, 62);
            this.pnServidor.TabIndex = 10;
            // 
            // txbServidor
            // 
            this.txbServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbServidor.Location = new System.Drawing.Point(73, 21);
            this.txbServidor.Name = "txbServidor";
            this.txbServidor.Size = new System.Drawing.Size(701, 20);
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
            // tpgCadastroDinamico
            // 
            this.tpgCadastroDinamico.Controls.Add(this.pnCamposTabela);
            this.tpgCadastroDinamico.Controls.Add(this.pnBotoesCadDinamico);
            this.tpgCadastroDinamico.Controls.Add(this.pnCombos);
            this.tpgCadastroDinamico.Location = new System.Drawing.Point(4, 22);
            this.tpgCadastroDinamico.Name = "tpgCadastroDinamico";
            this.tpgCadastroDinamico.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCadastroDinamico.Size = new System.Drawing.Size(792, 459);
            this.tpgCadastroDinamico.TabIndex = 1;
            this.tpgCadastroDinamico.Text = "Cadastro Dinâmico";
            this.tpgCadastroDinamico.UseVisualStyleBackColor = true;
            // 
            // pnCamposTabela
            // 
            this.pnCamposTabela.Controls.Add(this.lblColunasNaoExibir);
            this.pnCamposTabela.Controls.Add(this.lblTodasColunas);
            this.pnCamposTabela.Controls.Add(this.dgvColunasSelecionadas);
            this.pnCamposTabela.Controls.Add(this.dgvColunas);
            this.pnCamposTabela.Controls.Add(this.btnRemover);
            this.pnCamposTabela.Controls.Add(this.btnAdicionar);
            this.pnCamposTabela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCamposTabela.Location = new System.Drawing.Point(3, 114);
            this.pnCamposTabela.Name = "pnCamposTabela";
            this.pnCamposTabela.Size = new System.Drawing.Size(786, 272);
            this.pnCamposTabela.TabIndex = 9;
            // 
            // dgvColunasSelecionadas
            // 
            this.dgvColunasSelecionadas.AllowUserToAddRows = false;
            this.dgvColunasSelecionadas.AllowUserToDeleteRows = false;
            this.dgvColunasSelecionadas.AllowUserToResizeColumns = false;
            this.dgvColunasSelecionadas.AllowUserToResizeRows = false;
            this.dgvColunasSelecionadas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvColunasSelecionadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColunasSelecionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColunasSelecionadas.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvColunasSelecionadas.Location = new System.Drawing.Point(473, 26);
            this.dgvColunasSelecionadas.Name = "dgvColunasSelecionadas";
            this.dgvColunasSelecionadas.ReadOnly = true;
            this.dgvColunasSelecionadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColunasSelecionadas.Size = new System.Drawing.Size(308, 240);
            this.dgvColunasSelecionadas.TabIndex = 12;
            // 
            // dgvColunas
            // 
            this.dgvColunas.AllowUserToAddRows = false;
            this.dgvColunas.AllowUserToDeleteRows = false;
            this.dgvColunas.AllowUserToResizeColumns = false;
            this.dgvColunas.AllowUserToResizeRows = false;
            this.dgvColunas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvColunas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColunas.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvColunas.Location = new System.Drawing.Point(5, 26);
            this.dgvColunas.Name = "dgvColunas";
            this.dgvColunas.ReadOnly = true;
            this.dgvColunas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColunas.Size = new System.Drawing.Size(308, 240);
            this.dgvColunas.TabIndex = 11;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(374, 130);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(43, 23);
            this.btnRemover.TabIndex = 10;
            this.btnRemover.Text = "<-";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(374, 64);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(43, 23);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "->";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // pnBotoesCadDinamico
            // 
            this.pnBotoesCadDinamico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnBotoesCadDinamico.Controls.Add(this.btnCancelar);
            this.pnBotoesCadDinamico.Controls.Add(this.btnAvancar);
            this.pnBotoesCadDinamico.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBotoesCadDinamico.Location = new System.Drawing.Point(3, 386);
            this.pnBotoesCadDinamico.Name = "pnBotoesCadDinamico";
            this.pnBotoesCadDinamico.Size = new System.Drawing.Size(786, 70);
            this.pnBotoesCadDinamico.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(148, 18);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 34);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(551, 18);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(115, 34);
            this.btnAvancar.TabIndex = 6;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // pnCombos
            // 
            this.pnCombos.Controls.Add(this.lblTabela);
            this.pnCombos.Controls.Add(this.lblSchema);
            this.pnCombos.Controls.Add(this.cbxTabela);
            this.pnCombos.Controls.Add(this.cbxSchema);
            this.pnCombos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCombos.Location = new System.Drawing.Point(3, 3);
            this.pnCombos.Name = "pnCombos";
            this.pnCombos.Size = new System.Drawing.Size(786, 111);
            this.pnCombos.TabIndex = 7;
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Location = new System.Drawing.Point(14, 63);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(43, 13);
            this.lblTabela.TabIndex = 7;
            this.lblTabela.Text = "Tabela:";
            // 
            // lblSchema
            // 
            this.lblSchema.AutoSize = true;
            this.lblSchema.Location = new System.Drawing.Point(14, 20);
            this.lblSchema.Name = "lblSchema";
            this.lblSchema.Size = new System.Drawing.Size(49, 13);
            this.lblSchema.TabIndex = 6;
            this.lblSchema.Text = "Schema:";
            // 
            // cbxTabela
            // 
            this.cbxTabela.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTabela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTabela.FormattingEnabled = true;
            this.cbxTabela.Location = new System.Drawing.Point(72, 60);
            this.cbxTabela.Name = "cbxTabela";
            this.cbxTabela.Size = new System.Drawing.Size(695, 21);
            this.cbxTabela.TabIndex = 5;
            this.cbxTabela.SelectedIndexChanged += new System.EventHandler(this.cbxTabela_SelectedIndexChanged);
            // 
            // cbxSchema
            // 
            this.cbxSchema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSchema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSchema.FormattingEnabled = true;
            this.cbxSchema.Location = new System.Drawing.Point(72, 17);
            this.cbxSchema.Name = "cbxSchema";
            this.cbxSchema.Size = new System.Drawing.Size(695, 21);
            this.cbxSchema.TabIndex = 4;
            this.cbxSchema.SelectedIndexChanged += new System.EventHandler(this.cbxSchema_SelectedIndexChanged);
            // 
            // lblTodasColunas
            // 
            this.lblTodasColunas.AutoSize = true;
            this.lblTodasColunas.Location = new System.Drawing.Point(5, 10);
            this.lblTodasColunas.Name = "lblTodasColunas";
            this.lblTodasColunas.Size = new System.Drawing.Size(81, 13);
            this.lblTodasColunas.TabIndex = 13;
            this.lblTodasColunas.Text = "Todas Colunas:";
            // 
            // lblColunasNaoExibir
            // 
            this.lblColunasNaoExibir.AutoSize = true;
            this.lblColunasNaoExibir.Location = new System.Drawing.Point(470, 10);
            this.lblColunasNaoExibir.Name = "lblColunasNaoExibir";
            this.lblColunasNaoExibir.Size = new System.Drawing.Size(99, 13);
            this.lblColunasNaoExibir.TabIndex = 14;
            this.lblColunasNaoExibir.Text = "Colunas Não Exibir:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.tclPrincipal);
            this.KeyPreview = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Dinâmico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrincipal_KeyDown);
            this.tclPrincipal.ResumeLayout(false);
            this.tpgConfiguracao.ResumeLayout(false);
            this.pnBotoes.ResumeLayout(false);
            this.pnGravarLog.ResumeLayout(false);
            this.pnGravarLog.PerformLayout();
            this.pnSenha.ResumeLayout(false);
            this.pnSenha.PerformLayout();
            this.pnUsuario.ResumeLayout(false);
            this.pnUsuario.PerformLayout();
            this.pnDatabase.ResumeLayout(false);
            this.pnDatabase.PerformLayout();
            this.pnServidor.ResumeLayout(false);
            this.pnServidor.PerformLayout();
            this.tpgCadastroDinamico.ResumeLayout(false);
            this.pnCamposTabela.ResumeLayout(false);
            this.pnCamposTabela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColunasSelecionadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColunas)).EndInit();
            this.pnBotoesCadDinamico.ResumeLayout(false);
            this.pnCombos.ResumeLayout(false);
            this.pnCombos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tclPrincipal;
        private System.Windows.Forms.TabPage tpgConfiguracao;
        private System.Windows.Forms.TabPage tpgCadastroDinamico;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Panel pnGravarLog;
        private System.Windows.Forms.CheckBox ckbGravarLog;
        private System.Windows.Forms.Label lblGravarLog;
        private System.Windows.Forms.Panel pnSenha;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Panel pnUsuario;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel pnDatabase;
        private System.Windows.Forms.TextBox txbDatabase;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Panel pnServidor;
        private System.Windows.Forms.TextBox txbServidor;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Panel pnBotoes;
        private System.Windows.Forms.Panel pnCombos;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.Label lblSchema;
        private System.Windows.Forms.ComboBox cbxTabela;
        private System.Windows.Forms.ComboBox cbxSchema;
        private System.Windows.Forms.Panel pnBotoesCadDinamico;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Panel pnCamposTabela;
        private System.Windows.Forms.DataGridView dgvColunasSelecionadas;
        private System.Windows.Forms.DataGridView dgvColunas;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblColunasNaoExibir;
        private System.Windows.Forms.Label lblTodasColunas;
    }
}