namespace ConversorFolhaDePonto.UI
{
    partial class converterlayoutForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(converterlayoutForm));
            this.codigoempresaLabel = new System.Windows.Forms.Label();
            this.diretoriogravacaoLabel = new System.Windows.Forms.Label();
            this.diretorioarquivoLabel = new System.Windows.Forms.Label();
            this.diretoriogravarTextBox = new System.Windows.Forms.TextBox();
            this.lerdiretorioTextBox = new System.Windows.Forms.TextBox();
            this.nomeempresaTextBox = new System.Windows.Forms.TextBox();
            this.nomeempresaLabel = new System.Windows.Forms.Label();
            this.codigopontoGroupBox = new System.Windows.Forms.GroupBox();
            this.nomelayoutComboBox = new System.Windows.Forms.ComboBox();
            this.layoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomelayoutLabel = new System.Windows.Forms.Label();
            this.codigoempresaComboBox = new System.Windows.Forms.ComboBox();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerarpontoButton = new System.Windows.Forms.Button();
            this.diretoriogravarButton = new System.Windows.Forms.Button();
            this.lerdiretoriodoButton = new System.Windows.Forms.Button();
            this.lerOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gravarFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.codigopontoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoempresaLabel
            // 
            this.codigoempresaLabel.AutoSize = true;
            this.codigoempresaLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoempresaLabel.Location = new System.Drawing.Point(7, 18);
            this.codigoempresaLabel.Name = "codigoempresaLabel";
            this.codigoempresaLabel.Size = new System.Drawing.Size(105, 17);
            this.codigoempresaLabel.TabIndex = 0;
            this.codigoempresaLabel.Text = "Código Empresa";
            // 
            // diretoriogravacaoLabel
            // 
            this.diretoriogravacaoLabel.AutoSize = true;
            this.diretoriogravacaoLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diretoriogravacaoLabel.Location = new System.Drawing.Point(7, 115);
            this.diretoriogravacaoLabel.Name = "diretoriogravacaoLabel";
            this.diretoriogravacaoLabel.Size = new System.Drawing.Size(125, 17);
            this.diretoriogravacaoLabel.TabIndex = 7;
            this.diretoriogravacaoLabel.Text = "Diretório Gravação";
            // 
            // diretorioarquivoLabel
            // 
            this.diretorioarquivoLabel.AutoSize = true;
            this.diretorioarquivoLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diretorioarquivoLabel.Location = new System.Drawing.Point(7, 77);
            this.diretorioarquivoLabel.Name = "diretorioarquivoLabel";
            this.diretorioarquivoLabel.Size = new System.Drawing.Size(110, 17);
            this.diretorioarquivoLabel.TabIndex = 4;
            this.diretorioarquivoLabel.Text = "Diretório Arquivo";
            // 
            // diretoriogravarTextBox
            // 
            this.diretoriogravarTextBox.AccessibleName = "Diretório Gravação";
            this.diretoriogravarTextBox.Location = new System.Drawing.Point(138, 112);
            this.diretoriogravarTextBox.Name = "diretoriogravarTextBox";
            this.diretoriogravarTextBox.Size = new System.Drawing.Size(482, 22);
            this.diretoriogravarTextBox.TabIndex = 8;
            // 
            // lerdiretorioTextBox
            // 
            this.lerdiretorioTextBox.AccessibleName = "Diretório Arquivo";
            this.lerdiretorioTextBox.Location = new System.Drawing.Point(138, 77);
            this.lerdiretorioTextBox.Name = "lerdiretorioTextBox";
            this.lerdiretorioTextBox.Size = new System.Drawing.Size(482, 22);
            this.lerdiretorioTextBox.TabIndex = 5;
            // 
            // nomeempresaTextBox
            // 
            this.nomeempresaTextBox.AccessibleDescription = "";
            this.nomeempresaTextBox.AccessibleName = "Nome Empresa";
            this.nomeempresaTextBox.Enabled = false;
            this.nomeempresaTextBox.Location = new System.Drawing.Point(138, 41);
            this.nomeempresaTextBox.Name = "nomeempresaTextBox";
            this.nomeempresaTextBox.Size = new System.Drawing.Size(324, 22);
            this.nomeempresaTextBox.TabIndex = 3;
            // 
            // nomeempresaLabel
            // 
            this.nomeempresaLabel.AutoSize = true;
            this.nomeempresaLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeempresaLabel.Location = new System.Drawing.Point(135, 20);
            this.nomeempresaLabel.Name = "nomeempresaLabel";
            this.nomeempresaLabel.Size = new System.Drawing.Size(97, 17);
            this.nomeempresaLabel.TabIndex = 2;
            this.nomeempresaLabel.Text = "Nome Empresa";
            // 
            // codigopontoGroupBox
            // 
            this.codigopontoGroupBox.Controls.Add(this.nomelayoutComboBox);
            this.codigopontoGroupBox.Controls.Add(this.nomelayoutLabel);
            this.codigopontoGroupBox.Controls.Add(this.codigoempresaComboBox);
            this.codigopontoGroupBox.Controls.Add(this.gerarpontoButton);
            this.codigopontoGroupBox.Controls.Add(this.diretoriogravarButton);
            this.codigopontoGroupBox.Controls.Add(this.lerdiretoriodoButton);
            this.codigopontoGroupBox.Controls.Add(this.nomeempresaLabel);
            this.codigopontoGroupBox.Controls.Add(this.diretoriogravarTextBox);
            this.codigopontoGroupBox.Controls.Add(this.diretoriogravacaoLabel);
            this.codigopontoGroupBox.Controls.Add(this.diretorioarquivoLabel);
            this.codigopontoGroupBox.Controls.Add(this.lerdiretorioTextBox);
            this.codigopontoGroupBox.Controls.Add(this.nomeempresaTextBox);
            this.codigopontoGroupBox.Controls.Add(this.codigoempresaLabel);
            this.codigopontoGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigopontoGroupBox.Location = new System.Drawing.Point(11, 12);
            this.codigopontoGroupBox.Name = "codigopontoGroupBox";
            this.codigopontoGroupBox.Size = new System.Drawing.Size(673, 181);
            this.codigopontoGroupBox.TabIndex = 0;
            this.codigopontoGroupBox.TabStop = false;
            // 
            // nomelayoutComboBox
            // 
            this.nomelayoutComboBox.AccessibleName = "Nome Layout";
            this.nomelayoutComboBox.DataSource = this.layoutBindingSource;
            this.nomelayoutComboBox.DisplayMember = "Nome";
            this.nomelayoutComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nomelayoutComboBox.FormattingEnabled = true;
            this.nomelayoutComboBox.Location = new System.Drawing.Point(507, 38);
            this.nomelayoutComboBox.Name = "nomelayoutComboBox";
            this.nomelayoutComboBox.Size = new System.Drawing.Size(140, 25);
            this.nomelayoutComboBox.TabIndex = 12;
            this.nomelayoutComboBox.ValueMember = "Nome";
            // 
            // layoutBindingSource
            // 
            this.layoutBindingSource.DataSource = typeof(ConversorFolhaDePonto.Modelo.Layout);
            // 
            // nomelayoutLabel
            // 
            this.nomelayoutLabel.AutoSize = true;
            this.nomelayoutLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomelayoutLabel.Location = new System.Drawing.Point(504, 18);
            this.nomelayoutLabel.Name = "nomelayoutLabel";
            this.nomelayoutLabel.Size = new System.Drawing.Size(48, 17);
            this.nomelayoutLabel.TabIndex = 11;
            this.nomelayoutLabel.Text = "Layout";
            // 
            // codigoempresaComboBox
            // 
            this.codigoempresaComboBox.AccessibleName = "Código Empresa";
            this.codigoempresaComboBox.DataSource = this.empresaBindingSource;
            this.codigoempresaComboBox.DisplayMember = "Id";
            this.codigoempresaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codigoempresaComboBox.FormattingEnabled = true;
            this.codigoempresaComboBox.Location = new System.Drawing.Point(10, 38);
            this.codigoempresaComboBox.Name = "codigoempresaComboBox";
            this.codigoempresaComboBox.Size = new System.Drawing.Size(68, 25);
            this.codigoempresaComboBox.TabIndex = 1;
            this.codigoempresaComboBox.ValueMember = "Nome";
            this.codigoempresaComboBox.SelectedIndexChanged += new System.EventHandler(this.codigoempresaComboBox_SelectedIndexChanged);
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataSource = typeof(ConversorFolhaDePonto.Modelo.Empresa);
            // 
            // gerarpontoButton
            // 
            this.gerarpontoButton.BackColor = System.Drawing.Color.Transparent;
            this.gerarpontoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gerarpontoButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerarpontoButton.ForeColor = System.Drawing.Color.Black;
            this.gerarpontoButton.Image = ((System.Drawing.Image)(resources.GetObject("gerarpontoButton.Image")));
            this.gerarpontoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gerarpontoButton.Location = new System.Drawing.Point(595, 141);
            this.gerarpontoButton.Name = "gerarpontoButton";
            this.gerarpontoButton.Size = new System.Drawing.Size(68, 26);
            this.gerarpontoButton.TabIndex = 10;
            this.gerarpontoButton.Text = "Gerar";
            this.gerarpontoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gerarpontoButton.UseVisualStyleBackColor = false;
            this.gerarpontoButton.Click += new System.EventHandler(this.gerarpontoButton_Click);
            // 
            // diretoriogravarButton
            // 
            this.diretoriogravarButton.BackColor = System.Drawing.Color.Transparent;
            this.diretoriogravarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.diretoriogravarButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diretoriogravarButton.ForeColor = System.Drawing.Color.Black;
            this.diretoriogravarButton.Image = ((System.Drawing.Image)(resources.GetObject("diretoriogravarButton.Image")));
            this.diretoriogravarButton.Location = new System.Drawing.Point(630, 109);
            this.diretoriogravarButton.Name = "diretoriogravarButton";
            this.diretoriogravarButton.Size = new System.Drawing.Size(33, 26);
            this.diretoriogravarButton.TabIndex = 9;
            this.diretoriogravarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.diretoriogravarButton.UseVisualStyleBackColor = false;
            this.diretoriogravarButton.Click += new System.EventHandler(this.diretoriogravarButton_Click);
            // 
            // lerdiretoriodoButton
            // 
            this.lerdiretoriodoButton.BackColor = System.Drawing.Color.Transparent;
            this.lerdiretoriodoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lerdiretoriodoButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lerdiretoriodoButton.ForeColor = System.Drawing.Color.Black;
            this.lerdiretoriodoButton.Image = ((System.Drawing.Image)(resources.GetObject("lerdiretoriodoButton.Image")));
            this.lerdiretoriodoButton.Location = new System.Drawing.Point(630, 72);
            this.lerdiretoriodoButton.Name = "lerdiretoriodoButton";
            this.lerdiretoriodoButton.Size = new System.Drawing.Size(33, 27);
            this.lerdiretoriodoButton.TabIndex = 6;
            this.lerdiretoriodoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lerdiretoriodoButton.UseVisualStyleBackColor = false;
            this.lerdiretoriodoButton.Click += new System.EventHandler(this.lerdiretorioButton_Click);
            // 
            // lerOpenFileDialog
            // 
            this.lerOpenFileDialog.Filter = "txt files (*.txt)|";
            this.lerOpenFileDialog.RestoreDirectory = true;
            this.lerOpenFileDialog.Title = "Abrir arquivo para conversão .txt";
            // 
            // gravarFolderBrowserDialog
            // 
            this.gravarFolderBrowserDialog.Description = "Selecione diretório de gravação do novo arquivo.";
            // 
            // converterlayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(692, 202);
            this.Controls.Add(this.codigopontoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "converterlayoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.conversorForm_Load);
            this.codigopontoGroupBox.ResumeLayout(false);
            this.codigopontoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label codigoempresaLabel;
        private System.Windows.Forms.Label diretoriogravacaoLabel;
        private System.Windows.Forms.Label diretorioarquivoLabel;
        private System.Windows.Forms.TextBox diretoriogravarTextBox;
        private System.Windows.Forms.TextBox lerdiretorioTextBox;
        private System.Windows.Forms.TextBox nomeempresaTextBox;
        private System.Windows.Forms.Label nomeempresaLabel;
        private System.Windows.Forms.GroupBox codigopontoGroupBox;
        private System.Windows.Forms.Button diretoriogravarButton;
        private System.Windows.Forms.Button lerdiretoriodoButton;
        private System.Windows.Forms.Button gerarpontoButton;
        private System.Windows.Forms.OpenFileDialog lerOpenFileDialog;
        private System.Windows.Forms.ComboBox codigoempresaComboBox;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private System.Windows.Forms.FolderBrowserDialog gravarFolderBrowserDialog;
        private System.Windows.Forms.ComboBox nomelayoutComboBox;
        private System.Windows.Forms.Label nomelayoutLabel;
        private System.Windows.Forms.BindingSource layoutBindingSource;
    }
}