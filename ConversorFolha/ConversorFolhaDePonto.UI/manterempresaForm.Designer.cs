namespace ConversorFolhaDePonto.UI
{
    partial class manutencaoempresaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manutencaoempresaForm));
            this.empresaGroupBox = new System.Windows.Forms.GroupBox();
            this.codigoempresaComboBox = new System.Windows.Forms.ComboBox();
            this.excluirempresaButton = new System.Windows.Forms.Button();
            this.alterarempresaButton = new System.Windows.Forms.Button();
            this.layoutempresaGroupBox = new System.Windows.Forms.GroupBox();
            this.posicaofuncionarioGroupBox = new System.Windows.Forms.GroupBox();
            this.tamanhofuncionarioTextBox = new System.Windows.Forms.TextBox();
            this.iniciofuncionarioLabel = new System.Windows.Forms.Label();
            this.iniciofuncionarioTextBox = new System.Windows.Forms.TextBox();
            this.tamanhofuncionarioLabel = new System.Windows.Forms.Label();
            this.posicaoeventoGroupBox = new System.Windows.Forms.GroupBox();
            this.tamanhoeventoLabel = new System.Windows.Forms.Label();
            this.inicioeventoLabel = new System.Windows.Forms.Label();
            this.inicioeventoTextBox = new System.Windows.Forms.TextBox();
            this.tamanhoeventoTextBox = new System.Windows.Forms.TextBox();
            this.statusempresaLabel = new System.Windows.Forms.Label();
            this.posicaohorasGroupBox = new System.Windows.Forms.GroupBox();
            this.iniciohorasTextBox = new System.Windows.Forms.TextBox();
            this.tamanhohorasTextBox = new System.Windows.Forms.TextBox();
            this.iniciohorasLabel = new System.Windows.Forms.Label();
            this.tamanhovaloreventoLabel = new System.Windows.Forms.Label();
            this.nomeempresaTextBox = new System.Windows.Forms.TextBox();
            this.codigoempresaLabel = new System.Windows.Forms.Label();
            this.nomeempresaLabel = new System.Windows.Forms.Label();
            this.empresaGroupBox.SuspendLayout();
            this.layoutempresaGroupBox.SuspendLayout();
            this.posicaofuncionarioGroupBox.SuspendLayout();
            this.posicaoeventoGroupBox.SuspendLayout();
            this.posicaohorasGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // empresaGroupBox
            // 
            this.empresaGroupBox.Controls.Add(this.codigoempresaComboBox);
            this.empresaGroupBox.Controls.Add(this.excluirempresaButton);
            this.empresaGroupBox.Controls.Add(this.alterarempresaButton);
            this.empresaGroupBox.Controls.Add(this.layoutempresaGroupBox);
            this.empresaGroupBox.Controls.Add(this.nomeempresaTextBox);
            this.empresaGroupBox.Controls.Add(this.codigoempresaLabel);
            this.empresaGroupBox.Controls.Add(this.nomeempresaLabel);
            this.empresaGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresaGroupBox.Location = new System.Drawing.Point(12, 12);
            this.empresaGroupBox.Name = "empresaGroupBox";
            this.empresaGroupBox.Size = new System.Drawing.Size(502, 230);
            this.empresaGroupBox.TabIndex = 1;
            this.empresaGroupBox.TabStop = false;
            this.empresaGroupBox.Text = "Empresa";
            // 
            // codigoempresaComboBox
            // 
            this.codigoempresaComboBox.DisplayMember = "Id";
            this.codigoempresaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codigoempresaComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoempresaComboBox.FormattingEnabled = true;
            this.codigoempresaComboBox.Location = new System.Drawing.Point(15, 36);
            this.codigoempresaComboBox.Name = "codigoempresaComboBox";
            this.codigoempresaComboBox.Size = new System.Drawing.Size(68, 25);
            this.codigoempresaComboBox.TabIndex = 19;
            this.codigoempresaComboBox.ValueMember = "Nome";
            this.codigoempresaComboBox.SelectedIndexChanged += new System.EventHandler(this.CodigoempresaComboBox_SelectedIndexChanged);
            // 
            // excluirempresaButton
            // 
            this.excluirempresaButton.BackColor = System.Drawing.Color.Transparent;
            this.excluirempresaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.excluirempresaButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirempresaButton.ForeColor = System.Drawing.Color.Black;
            this.excluirempresaButton.Image = ((System.Drawing.Image)(resources.GetObject("excluirempresaButton.Image")));
            this.excluirempresaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excluirempresaButton.Location = new System.Drawing.Point(424, 195);
            this.excluirempresaButton.Name = "excluirempresaButton";
            this.excluirempresaButton.Size = new System.Drawing.Size(70, 26);
            this.excluirempresaButton.TabIndex = 18;
            this.excluirempresaButton.Text = "Excluir";
            this.excluirempresaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.excluirempresaButton.UseVisualStyleBackColor = false;
            // 
            // alterarempresaButton
            // 
            this.alterarempresaButton.BackColor = System.Drawing.Color.Transparent;
            this.alterarempresaButton.Enabled = false;
            this.alterarempresaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alterarempresaButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarempresaButton.ForeColor = System.Drawing.Color.Black;
            this.alterarempresaButton.Image = ((System.Drawing.Image)(resources.GetObject("alterarempresaButton.Image")));
            this.alterarempresaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alterarempresaButton.Location = new System.Drawing.Point(343, 195);
            this.alterarempresaButton.Name = "alterarempresaButton";
            this.alterarempresaButton.Size = new System.Drawing.Size(73, 26);
            this.alterarempresaButton.TabIndex = 17;
            this.alterarempresaButton.Text = "Alterar";
            this.alterarempresaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.alterarempresaButton.UseVisualStyleBackColor = false;
            this.alterarempresaButton.Click += new System.EventHandler(this.AlterarempresaButton_Click);
            // 
            // layoutempresaGroupBox
            // 
            this.layoutempresaGroupBox.Controls.Add(this.posicaofuncionarioGroupBox);
            this.layoutempresaGroupBox.Controls.Add(this.posicaoeventoGroupBox);
            this.layoutempresaGroupBox.Controls.Add(this.statusempresaLabel);
            this.layoutempresaGroupBox.Controls.Add(this.posicaohorasGroupBox);
            this.layoutempresaGroupBox.Location = new System.Drawing.Point(15, 67);
            this.layoutempresaGroupBox.Name = "layoutempresaGroupBox";
            this.layoutempresaGroupBox.Size = new System.Drawing.Size(479, 122);
            this.layoutempresaGroupBox.TabIndex = 5;
            this.layoutempresaGroupBox.TabStop = false;
            this.layoutempresaGroupBox.Text = "Layout Empresa";
            // 
            // posicaofuncionarioGroupBox
            // 
            this.posicaofuncionarioGroupBox.Controls.Add(this.tamanhofuncionarioTextBox);
            this.posicaofuncionarioGroupBox.Controls.Add(this.iniciofuncionarioLabel);
            this.posicaofuncionarioGroupBox.Controls.Add(this.iniciofuncionarioTextBox);
            this.posicaofuncionarioGroupBox.Controls.Add(this.tamanhofuncionarioLabel);
            this.posicaofuncionarioGroupBox.Location = new System.Drawing.Point(324, 21);
            this.posicaofuncionarioGroupBox.Name = "posicaofuncionarioGroupBox";
            this.posicaofuncionarioGroupBox.Size = new System.Drawing.Size(141, 77);
            this.posicaofuncionarioGroupBox.TabIndex = 2;
            this.posicaofuncionarioGroupBox.TabStop = false;
            this.posicaofuncionarioGroupBox.Text = "Funcionário";
            // 
            // tamanhofuncionarioTextBox
            // 
            this.tamanhofuncionarioTextBox.AccessibleName = "Tamanho do Funcionário";
            this.tamanhofuncionarioTextBox.Location = new System.Drawing.Point(76, 43);
            this.tamanhofuncionarioTextBox.MaxLength = 4;
            this.tamanhofuncionarioTextBox.Name = "tamanhofuncionarioTextBox";
            this.tamanhofuncionarioTextBox.Size = new System.Drawing.Size(47, 22);
            this.tamanhofuncionarioTextBox.TabIndex = 3;
            // 
            // iniciofuncionarioLabel
            // 
            this.iniciofuncionarioLabel.AutoSize = true;
            this.iniciofuncionarioLabel.Location = new System.Drawing.Point(8, 18);
            this.iniciofuncionarioLabel.Name = "iniciofuncionarioLabel";
            this.iniciofuncionarioLabel.Size = new System.Drawing.Size(40, 17);
            this.iniciofuncionarioLabel.TabIndex = 0;
            this.iniciofuncionarioLabel.Text = "Início";
            // 
            // iniciofuncionarioTextBox
            // 
            this.iniciofuncionarioTextBox.AccessibleName = "Inicio do Funcionário";
            this.iniciofuncionarioTextBox.Location = new System.Drawing.Point(76, 15);
            this.iniciofuncionarioTextBox.MaxLength = 4;
            this.iniciofuncionarioTextBox.Name = "iniciofuncionarioTextBox";
            this.iniciofuncionarioTextBox.Size = new System.Drawing.Size(47, 22);
            this.iniciofuncionarioTextBox.TabIndex = 1;
            // 
            // tamanhofuncionarioLabel
            // 
            this.tamanhofuncionarioLabel.AutoSize = true;
            this.tamanhofuncionarioLabel.Location = new System.Drawing.Point(8, 43);
            this.tamanhofuncionarioLabel.Name = "tamanhofuncionarioLabel";
            this.tamanhofuncionarioLabel.Size = new System.Drawing.Size(62, 17);
            this.tamanhofuncionarioLabel.TabIndex = 2;
            this.tamanhofuncionarioLabel.Text = "Tamanho";
            // 
            // posicaoeventoGroupBox
            // 
            this.posicaoeventoGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.posicaoeventoGroupBox.CausesValidation = false;
            this.posicaoeventoGroupBox.Controls.Add(this.tamanhoeventoLabel);
            this.posicaoeventoGroupBox.Controls.Add(this.inicioeventoLabel);
            this.posicaoeventoGroupBox.Controls.Add(this.inicioeventoTextBox);
            this.posicaoeventoGroupBox.Controls.Add(this.tamanhoeventoTextBox);
            this.posicaoeventoGroupBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.posicaoeventoGroupBox.Location = new System.Drawing.Point(15, 21);
            this.posicaoeventoGroupBox.Name = "posicaoeventoGroupBox";
            this.posicaoeventoGroupBox.Size = new System.Drawing.Size(141, 77);
            this.posicaoeventoGroupBox.TabIndex = 0;
            this.posicaoeventoGroupBox.TabStop = false;
            this.posicaoeventoGroupBox.Text = "Evento";
            // 
            // tamanhoeventoLabel
            // 
            this.tamanhoeventoLabel.AutoSize = true;
            this.tamanhoeventoLabel.Location = new System.Drawing.Point(8, 43);
            this.tamanhoeventoLabel.Name = "tamanhoeventoLabel";
            this.tamanhoeventoLabel.Size = new System.Drawing.Size(62, 17);
            this.tamanhoeventoLabel.TabIndex = 2;
            this.tamanhoeventoLabel.Text = "Tamanho";
            // 
            // inicioeventoLabel
            // 
            this.inicioeventoLabel.AutoSize = true;
            this.inicioeventoLabel.Location = new System.Drawing.Point(8, 18);
            this.inicioeventoLabel.Name = "inicioeventoLabel";
            this.inicioeventoLabel.Size = new System.Drawing.Size(40, 17);
            this.inicioeventoLabel.TabIndex = 0;
            this.inicioeventoLabel.Text = "Início";
            // 
            // inicioeventoTextBox
            // 
            this.inicioeventoTextBox.AccessibleName = "Inicio do Evento";
            this.inicioeventoTextBox.Location = new System.Drawing.Point(76, 16);
            this.inicioeventoTextBox.MaxLength = 4;
            this.inicioeventoTextBox.Name = "inicioeventoTextBox";
            this.inicioeventoTextBox.Size = new System.Drawing.Size(47, 22);
            this.inicioeventoTextBox.TabIndex = 1;
            this.inicioeventoTextBox.Validated += new System.EventHandler(this.inicioeventoTextBox_Validated);
            // 
            // tamanhoeventoTextBox
            // 
            this.tamanhoeventoTextBox.AccessibleName = "Tamanho Evento";
            this.tamanhoeventoTextBox.Location = new System.Drawing.Point(76, 43);
            this.tamanhoeventoTextBox.MaxLength = 4;
            this.tamanhoeventoTextBox.Name = "tamanhoeventoTextBox";
            this.tamanhoeventoTextBox.Size = new System.Drawing.Size(47, 22);
            this.tamanhoeventoTextBox.TabIndex = 3;
            // 
            // statusempresaLabel
            // 
            this.statusempresaLabel.AutoSize = true;
            this.statusempresaLabel.Location = new System.Drawing.Point(18, 101);
            this.statusempresaLabel.Name = "statusempresaLabel";
            this.statusempresaLabel.Size = new System.Drawing.Size(45, 17);
            this.statusempresaLabel.TabIndex = 3;
            this.statusempresaLabel.Text = "Status";
            this.statusempresaLabel.Visible = false;
            // 
            // posicaohorasGroupBox
            // 
            this.posicaohorasGroupBox.Controls.Add(this.iniciohorasTextBox);
            this.posicaohorasGroupBox.Controls.Add(this.tamanhohorasTextBox);
            this.posicaohorasGroupBox.Controls.Add(this.iniciohorasLabel);
            this.posicaohorasGroupBox.Controls.Add(this.tamanhovaloreventoLabel);
            this.posicaohorasGroupBox.Location = new System.Drawing.Point(169, 21);
            this.posicaohorasGroupBox.Name = "posicaohorasGroupBox";
            this.posicaohorasGroupBox.Size = new System.Drawing.Size(141, 77);
            this.posicaohorasGroupBox.TabIndex = 1;
            this.posicaohorasGroupBox.TabStop = false;
            this.posicaohorasGroupBox.Text = "Horas";
            // 
            // iniciohorasTextBox
            // 
            this.iniciohorasTextBox.AccessibleName = "Inicio Horas";
            this.iniciohorasTextBox.Location = new System.Drawing.Point(76, 15);
            this.iniciohorasTextBox.MaxLength = 4;
            this.iniciohorasTextBox.Name = "iniciohorasTextBox";
            this.iniciohorasTextBox.Size = new System.Drawing.Size(47, 22);
            this.iniciohorasTextBox.TabIndex = 1;
            // 
            // tamanhohorasTextBox
            // 
            this.tamanhohorasTextBox.AccessibleName = "Tamanho da Horas";
            this.tamanhohorasTextBox.Location = new System.Drawing.Point(76, 43);
            this.tamanhohorasTextBox.MaxLength = 4;
            this.tamanhohorasTextBox.Name = "tamanhohorasTextBox";
            this.tamanhohorasTextBox.Size = new System.Drawing.Size(47, 22);
            this.tamanhohorasTextBox.TabIndex = 3;
            // 
            // iniciohorasLabel
            // 
            this.iniciohorasLabel.AutoSize = true;
            this.iniciohorasLabel.Location = new System.Drawing.Point(8, 18);
            this.iniciohorasLabel.Name = "iniciohorasLabel";
            this.iniciohorasLabel.Size = new System.Drawing.Size(40, 17);
            this.iniciohorasLabel.TabIndex = 0;
            this.iniciohorasLabel.Text = "Início";
            // 
            // tamanhovaloreventoLabel
            // 
            this.tamanhovaloreventoLabel.AutoSize = true;
            this.tamanhovaloreventoLabel.Location = new System.Drawing.Point(8, 43);
            this.tamanhovaloreventoLabel.Name = "tamanhovaloreventoLabel";
            this.tamanhovaloreventoLabel.Size = new System.Drawing.Size(62, 17);
            this.tamanhovaloreventoLabel.TabIndex = 2;
            this.tamanhovaloreventoLabel.Text = "Tamanho";
            // 
            // nomeempresaTextBox
            // 
            this.nomeempresaTextBox.AccessibleName = "Nome Empresa";
            this.nomeempresaTextBox.Enabled = false;
            this.nomeempresaTextBox.Location = new System.Drawing.Point(169, 39);
            this.nomeempresaTextBox.MaxLength = 200;
            this.nomeempresaTextBox.Name = "nomeempresaTextBox";
            this.nomeempresaTextBox.Size = new System.Drawing.Size(325, 22);
            this.nomeempresaTextBox.TabIndex = 3;
            // 
            // codigoempresaLabel
            // 
            this.codigoempresaLabel.AutoSize = true;
            this.codigoempresaLabel.Location = new System.Drawing.Point(12, 19);
            this.codigoempresaLabel.Name = "codigoempresaLabel";
            this.codigoempresaLabel.Size = new System.Drawing.Size(105, 17);
            this.codigoempresaLabel.TabIndex = 0;
            this.codigoempresaLabel.Text = "Código Empresa";
            // 
            // nomeempresaLabel
            // 
            this.nomeempresaLabel.AutoSize = true;
            this.nomeempresaLabel.Location = new System.Drawing.Point(166, 19);
            this.nomeempresaLabel.Name = "nomeempresaLabel";
            this.nomeempresaLabel.Size = new System.Drawing.Size(97, 17);
            this.nomeempresaLabel.TabIndex = 2;
            this.nomeempresaLabel.Text = "Nome Empresa";
            // 
            // manutencaoempresaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 249);
            this.Controls.Add(this.empresaGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "manutencaoempresaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção Empresa ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.manutencaoempresaForm_FormClosing);
            this.empresaGroupBox.ResumeLayout(false);
            this.empresaGroupBox.PerformLayout();
            this.layoutempresaGroupBox.ResumeLayout(false);
            this.layoutempresaGroupBox.PerformLayout();
            this.posicaofuncionarioGroupBox.ResumeLayout(false);
            this.posicaofuncionarioGroupBox.PerformLayout();
            this.posicaoeventoGroupBox.ResumeLayout(false);
            this.posicaoeventoGroupBox.PerformLayout();
            this.posicaohorasGroupBox.ResumeLayout(false);
            this.posicaohorasGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox empresaGroupBox;
        private System.Windows.Forms.GroupBox layoutempresaGroupBox;
        private System.Windows.Forms.GroupBox posicaofuncionarioGroupBox;
        private System.Windows.Forms.TextBox tamanhofuncionarioTextBox;
        private System.Windows.Forms.Label iniciofuncionarioLabel;
        private System.Windows.Forms.TextBox iniciofuncionarioTextBox;
        private System.Windows.Forms.Label tamanhofuncionarioLabel;
        private System.Windows.Forms.GroupBox posicaoeventoGroupBox;
        private System.Windows.Forms.Label tamanhoeventoLabel;
        private System.Windows.Forms.Label inicioeventoLabel;
        private System.Windows.Forms.TextBox inicioeventoTextBox;
        private System.Windows.Forms.TextBox tamanhoeventoTextBox;
        private System.Windows.Forms.Label statusempresaLabel;
        private System.Windows.Forms.GroupBox posicaohorasGroupBox;
        private System.Windows.Forms.TextBox iniciohorasTextBox;
        private System.Windows.Forms.TextBox tamanhohorasTextBox;
        private System.Windows.Forms.Label iniciohorasLabel;
        private System.Windows.Forms.Label tamanhovaloreventoLabel;
        private System.Windows.Forms.TextBox nomeempresaTextBox;
        private System.Windows.Forms.Label codigoempresaLabel;
        private System.Windows.Forms.Label nomeempresaLabel;
        private System.Windows.Forms.Button excluirempresaButton;
        private System.Windows.Forms.Button alterarempresaButton;
        private System.Windows.Forms.ComboBox codigoempresaComboBox;
    }
}