namespace ConversorFolhaDePonto.UI
{
    partial class ManutencaoeventoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManutencaoeventoForm));
            this.cadastroeventoGroupBox = new System.Windows.Forms.GroupBox();
            this.excluireventoButton = new System.Windows.Forms.Button();
            this.codigoempresaComboBox = new System.Windows.Forms.ComboBox();
            this.alterareventoButton = new System.Windows.Forms.Button();
            this.nomeempresaTextBox = new System.Windows.Forms.TextBox();
            this.codigoempresaLabel = new System.Windows.Forms.Label();
            this.nomeempresaLabel = new System.Windows.Forms.Label();
            this.eventoGroupBox = new System.Windows.Forms.GroupBox();
            this.eventotrensferivelCheckBox = new System.Windows.Forms.CheckBox();
            this.statuseventoLabel = new System.Windows.Forms.Label();
            this.eventointernoTextBox = new System.Windows.Forms.TextBox();
            this.eventoexternoLabel = new System.Windows.Forms.Label();
            this.eventoexternoTextBox = new System.Windows.Forms.TextBox();
            this.eventointernoLabel = new System.Windows.Forms.Label();
            this.cadastroeventoGroupBox.SuspendLayout();
            this.eventoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastroeventoGroupBox
            // 
            this.cadastroeventoGroupBox.Controls.Add(this.excluireventoButton);
            this.cadastroeventoGroupBox.Controls.Add(this.codigoempresaComboBox);
            this.cadastroeventoGroupBox.Controls.Add(this.alterareventoButton);
            this.cadastroeventoGroupBox.Controls.Add(this.nomeempresaTextBox);
            this.cadastroeventoGroupBox.Controls.Add(this.codigoempresaLabel);
            this.cadastroeventoGroupBox.Controls.Add(this.nomeempresaLabel);
            this.cadastroeventoGroupBox.Controls.Add(this.eventoGroupBox);
            this.cadastroeventoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.cadastroeventoGroupBox.Name = "cadastroeventoGroupBox";
            this.cadastroeventoGroupBox.Size = new System.Drawing.Size(400, 160);
            this.cadastroeventoGroupBox.TabIndex = 19;
            this.cadastroeventoGroupBox.TabStop = false;
            // 
            // excluireventoButton
            // 
            this.excluireventoButton.BackColor = System.Drawing.Color.Transparent;
            this.excluireventoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.excluireventoButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluireventoButton.ForeColor = System.Drawing.Color.Black;
            this.excluireventoButton.Image = ((System.Drawing.Image)(resources.GetObject("excluireventoButton.Image")));
            this.excluireventoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excluireventoButton.Location = new System.Drawing.Point(324, 129);
            this.excluireventoButton.Name = "excluireventoButton";
            this.excluireventoButton.Size = new System.Drawing.Size(69, 26);
            this.excluireventoButton.TabIndex = 22;
            this.excluireventoButton.Text = "Excluir";
            this.excluireventoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.excluireventoButton.UseVisualStyleBackColor = false;
            // 
            // codigoempresaComboBox
            // 
            this.codigoempresaComboBox.DisplayMember = "Id";
            this.codigoempresaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codigoempresaComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoempresaComboBox.FormattingEnabled = true;
            this.codigoempresaComboBox.Location = new System.Drawing.Point(9, 36);
            this.codigoempresaComboBox.Name = "codigoempresaComboBox";
            this.codigoempresaComboBox.Size = new System.Drawing.Size(68, 25);
            this.codigoempresaComboBox.TabIndex = 15;
            this.codigoempresaComboBox.ValueMember = "Nome";
            this.codigoempresaComboBox.SelectedIndexChanged += new System.EventHandler(this.CodigoempresaComboBox_SelectedIndexChanged);
            // 
            // alterareventoButton
            // 
            this.alterareventoButton.BackColor = System.Drawing.Color.Transparent;
            this.alterareventoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alterareventoButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterareventoButton.ForeColor = System.Drawing.Color.Black;
            this.alterareventoButton.Image = ((System.Drawing.Image)(resources.GetObject("alterareventoButton.Image")));
            this.alterareventoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alterareventoButton.Location = new System.Drawing.Point(245, 128);
            this.alterareventoButton.Name = "alterareventoButton";
            this.alterareventoButton.Size = new System.Drawing.Size(73, 26);
            this.alterareventoButton.TabIndex = 21;
            this.alterareventoButton.Text = "Alterar";
            this.alterareventoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.alterareventoButton.UseVisualStyleBackColor = false;
            // 
            // nomeempresaTextBox
            // 
            this.nomeempresaTextBox.AccessibleName = "Nome da Empresa";
            this.nomeempresaTextBox.Enabled = false;
            this.nomeempresaTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeempresaTextBox.Location = new System.Drawing.Point(128, 39);
            this.nomeempresaTextBox.MaxLength = 200;
            this.nomeempresaTextBox.Name = "nomeempresaTextBox";
            this.nomeempresaTextBox.Size = new System.Drawing.Size(265, 22);
            this.nomeempresaTextBox.TabIndex = 9;
            // 
            // codigoempresaLabel
            // 
            this.codigoempresaLabel.AutoSize = true;
            this.codigoempresaLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoempresaLabel.Location = new System.Drawing.Point(6, 16);
            this.codigoempresaLabel.Name = "codigoempresaLabel";
            this.codigoempresaLabel.Size = new System.Drawing.Size(105, 17);
            this.codigoempresaLabel.TabIndex = 4;
            this.codigoempresaLabel.Text = "Código Empresa";
            // 
            // nomeempresaLabel
            // 
            this.nomeempresaLabel.AutoSize = true;
            this.nomeempresaLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeempresaLabel.Location = new System.Drawing.Point(127, 16);
            this.nomeempresaLabel.Name = "nomeempresaLabel";
            this.nomeempresaLabel.Size = new System.Drawing.Size(97, 17);
            this.nomeempresaLabel.TabIndex = 7;
            this.nomeempresaLabel.Text = "Nome Empresa";
            // 
            // eventoGroupBox
            // 
            this.eventoGroupBox.Controls.Add(this.eventotrensferivelCheckBox);
            this.eventoGroupBox.Controls.Add(this.statuseventoLabel);
            this.eventoGroupBox.Controls.Add(this.eventointernoTextBox);
            this.eventoGroupBox.Controls.Add(this.eventoexternoLabel);
            this.eventoGroupBox.Controls.Add(this.eventoexternoTextBox);
            this.eventoGroupBox.Controls.Add(this.eventointernoLabel);
            this.eventoGroupBox.Enabled = false;
            this.eventoGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventoGroupBox.Location = new System.Drawing.Point(9, 67);
            this.eventoGroupBox.Name = "eventoGroupBox";
            this.eventoGroupBox.Size = new System.Drawing.Size(230, 87);
            this.eventoGroupBox.TabIndex = 6;
            this.eventoGroupBox.TabStop = false;
            this.eventoGroupBox.Text = "Evento";
            // 
            // eventotrensferivelCheckBox
            // 
            this.eventotrensferivelCheckBox.AutoSize = true;
            this.eventotrensferivelCheckBox.Location = new System.Drawing.Point(9, 45);
            this.eventotrensferivelCheckBox.Name = "eventotrensferivelCheckBox";
            this.eventotrensferivelCheckBox.Size = new System.Drawing.Size(139, 21);
            this.eventotrensferivelCheckBox.TabIndex = 4;
            this.eventotrensferivelCheckBox.Text = "Evento Transferível";
            this.eventotrensferivelCheckBox.UseVisualStyleBackColor = true;
            // 
            // statuseventoLabel
            // 
            this.statuseventoLabel.AutoSize = true;
            this.statuseventoLabel.Location = new System.Drawing.Point(6, 67);
            this.statuseventoLabel.Name = "statuseventoLabel";
            this.statuseventoLabel.Size = new System.Drawing.Size(45, 17);
            this.statuseventoLabel.TabIndex = 6;
            this.statuseventoLabel.Text = "Status";
            this.statuseventoLabel.Visible = false;
            // 
            // eventointernoTextBox
            // 
            this.eventointernoTextBox.AccessibleName = "Evento BuddyWin";
            this.eventointernoTextBox.Location = new System.Drawing.Point(175, 19);
            this.eventointernoTextBox.MaxLength = 4;
            this.eventointernoTextBox.Name = "eventointernoTextBox";
            this.eventointernoTextBox.Size = new System.Drawing.Size(49, 22);
            this.eventointernoTextBox.TabIndex = 3;
            // 
            // eventoexternoLabel
            // 
            this.eventoexternoLabel.AutoSize = true;
            this.eventoexternoLabel.Location = new System.Drawing.Point(6, 22);
            this.eventoexternoLabel.Name = "eventoexternoLabel";
            this.eventoexternoLabel.Size = new System.Drawing.Size(52, 17);
            this.eventoexternoLabel.TabIndex = 0;
            this.eventoexternoLabel.Text = "Externo";
            // 
            // eventoexternoTextBox
            // 
            this.eventoexternoTextBox.AccessibleName = "Evento Externo";
            this.eventoexternoTextBox.Location = new System.Drawing.Point(64, 19);
            this.eventoexternoTextBox.MaxLength = 3;
            this.eventoexternoTextBox.Name = "eventoexternoTextBox";
            this.eventoexternoTextBox.Size = new System.Drawing.Size(49, 22);
            this.eventoexternoTextBox.TabIndex = 1;
            // 
            // eventointernoLabel
            // 
            this.eventointernoLabel.AutoSize = true;
            this.eventointernoLabel.Location = new System.Drawing.Point(119, 22);
            this.eventointernoLabel.Name = "eventointernoLabel";
            this.eventointernoLabel.Size = new System.Drawing.Size(50, 17);
            this.eventointernoLabel.TabIndex = 2;
            this.eventointernoLabel.Text = "Interno";
            // 
            // ManutencaoeventoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 177);
            this.Controls.Add(this.cadastroeventoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManutencaoeventoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Manutenção Evento";
            this.Load += new System.EventHandler(this.CadastroeventoForm_Load);
            this.cadastroeventoGroupBox.ResumeLayout(false);
            this.cadastroeventoGroupBox.PerformLayout();
            this.eventoGroupBox.ResumeLayout(false);
            this.eventoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox cadastroeventoGroupBox;
        private System.Windows.Forms.TextBox nomeempresaTextBox;
        private System.Windows.Forms.Label codigoempresaLabel;
        private System.Windows.Forms.Label nomeempresaLabel;
        private System.Windows.Forms.GroupBox eventoGroupBox;
        private System.Windows.Forms.CheckBox eventotrensferivelCheckBox;
        private System.Windows.Forms.Label statuseventoLabel;
        private System.Windows.Forms.TextBox eventointernoTextBox;
        private System.Windows.Forms.Label eventoexternoLabel;
        private System.Windows.Forms.TextBox eventoexternoTextBox;
        private System.Windows.Forms.Label eventointernoLabel;
        private System.Windows.Forms.ComboBox codigoempresaComboBox;
        private System.Windows.Forms.Button excluireventoButton;
        private System.Windows.Forms.Button alterareventoButton;
    }
}