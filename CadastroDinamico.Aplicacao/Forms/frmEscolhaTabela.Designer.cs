namespace CadastroDinamico.Aplicacao.Forms
{
    partial class frmEscolhaTabela
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
            this.pnCombos = new System.Windows.Forms.Panel();
            this.lblTabela = new System.Windows.Forms.Label();
            this.lblSchema = new System.Windows.Forms.Label();
            this.cbxTabela = new System.Windows.Forms.ComboBox();
            this.cbxSchema = new System.Windows.Forms.ComboBox();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.pnCamposTabela = new System.Windows.Forms.Panel();
            this.dgvColunasSelecionadas = new System.Windows.Forms.DataGridView();
            this.dgvColunas = new System.Windows.Forms.DataGridView();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.pnCombos.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.pnCamposTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColunasSelecionadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColunas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCombos
            // 
            this.pnCombos.Controls.Add(this.lblTabela);
            this.pnCombos.Controls.Add(this.lblSchema);
            this.pnCombos.Controls.Add(this.cbxTabela);
            this.pnCombos.Controls.Add(this.cbxSchema);
            this.pnCombos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCombos.Location = new System.Drawing.Point(0, 0);
            this.pnCombos.Name = "pnCombos";
            this.pnCombos.Size = new System.Drawing.Size(443, 99);
            this.pnCombos.TabIndex = 6;
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
            this.cbxTabela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTabela.FormattingEnabled = true;
            this.cbxTabela.Location = new System.Drawing.Point(72, 60);
            this.cbxTabela.Name = "cbxTabela";
            this.cbxTabela.Size = new System.Drawing.Size(275, 21);
            this.cbxTabela.TabIndex = 5;
            this.cbxTabela.SelectedIndexChanged += new System.EventHandler(this.cbxTabela_SelectedIndexChanged);
            // 
            // cbxSchema
            // 
            this.cbxSchema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSchema.FormattingEnabled = true;
            this.cbxSchema.Location = new System.Drawing.Point(72, 17);
            this.cbxSchema.Name = "cbxSchema";
            this.cbxSchema.Size = new System.Drawing.Size(275, 21);
            this.cbxSchema.TabIndex = 4;
            this.cbxSchema.SelectedIndexChanged += new System.EventHandler(this.cbxSchema_SelectedIndexChanged);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Controls.Add(this.btnCancelar);
            this.pnBotoes.Controls.Add(this.btnAvancar);
            this.pnBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBotoes.Location = new System.Drawing.Point(0, 301);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(443, 45);
            this.pnBotoes.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(56, 11);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(271, 11);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(115, 23);
            this.btnAvancar.TabIndex = 6;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // pnCamposTabela
            // 
            this.pnCamposTabela.Controls.Add(this.dgvColunasSelecionadas);
            this.pnCamposTabela.Controls.Add(this.dgvColunas);
            this.pnCamposTabela.Controls.Add(this.btnRemover);
            this.pnCamposTabela.Controls.Add(this.btnAdicionar);
            this.pnCamposTabela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCamposTabela.Location = new System.Drawing.Point(0, 99);
            this.pnCamposTabela.Name = "pnCamposTabela";
            this.pnCamposTabela.Size = new System.Drawing.Size(443, 202);
            this.pnCamposTabela.TabIndex = 8;
            // 
            // dgvColunasSelecionadas
            // 
            this.dgvColunasSelecionadas.AllowUserToAddRows = false;
            this.dgvColunasSelecionadas.AllowUserToDeleteRows = false;
            this.dgvColunasSelecionadas.AllowUserToResizeColumns = false;
            this.dgvColunasSelecionadas.AllowUserToResizeRows = false;
            this.dgvColunasSelecionadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColunasSelecionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColunasSelecionadas.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvColunasSelecionadas.Location = new System.Drawing.Point(249, 6);
            this.dgvColunasSelecionadas.Name = "dgvColunasSelecionadas";
            this.dgvColunasSelecionadas.ReadOnly = true;
            this.dgvColunasSelecionadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColunasSelecionadas.Size = new System.Drawing.Size(182, 190);
            this.dgvColunasSelecionadas.TabIndex = 12;
            // 
            // dgvColunas
            // 
            this.dgvColunas.AllowUserToAddRows = false;
            this.dgvColunas.AllowUserToDeleteRows = false;
            this.dgvColunas.AllowUserToResizeColumns = false;
            this.dgvColunas.AllowUserToResizeRows = false;
            this.dgvColunas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColunas.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvColunas.Location = new System.Drawing.Point(12, 6);
            this.dgvColunas.Name = "dgvColunas";
            this.dgvColunas.ReadOnly = true;
            this.dgvColunas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColunas.Size = new System.Drawing.Size(182, 190);
            this.dgvColunas.TabIndex = 11;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(200, 109);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(43, 23);
            this.btnRemover.TabIndex = 10;
            this.btnRemover.Text = "<-";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(200, 38);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(43, 23);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "->";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // frmEscolhaTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 346);
            this.Controls.Add(this.pnCamposTabela);
            this.Controls.Add(this.pnBotoes);
            this.Controls.Add(this.pnCombos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEscolhaTabela";
            this.Text = "Selecionar Tabela";
            this.Load += new System.EventHandler(this.frmEscolhaTabela_Load);
            this.pnCombos.ResumeLayout(false);
            this.pnCombos.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.pnCamposTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColunasSelecionadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColunas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCombos;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.Label lblSchema;
        private System.Windows.Forms.ComboBox cbxTabela;
        private System.Windows.Forms.ComboBox cbxSchema;
        private System.Windows.Forms.Panel pnBotoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Panel pnCamposTabela;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgvColunas;
        private System.Windows.Forms.DataGridView dgvColunasSelecionadas;
    }
}