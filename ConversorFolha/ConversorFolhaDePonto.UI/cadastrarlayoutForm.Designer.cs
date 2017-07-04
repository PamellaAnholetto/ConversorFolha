namespace ConversorFolhaDePonto.UI
{
    partial class cadastrarlayoutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrarlayoutForm));
            this.nomelayoutTextBox = new System.Windows.Forms.TextBox();
            this.nomelayoutLabel = new System.Windows.Forms.Label();
            this.cadastrolayoutGroupBox = new System.Windows.Forms.GroupBox();
            this.excluirlayoutButton = new System.Windows.Forms.Button();
            this.alterarlayoutButton = new System.Windows.Forms.Button();
            this.incluirlayoutButton = new System.Windows.Forms.Button();
            this.conteudoGroupBox = new System.Windows.Forms.GroupBox();
            this.statuslayoutLabel = new System.Windows.Forms.Label();
            this.tamanho3ComboBox = new System.Windows.Forms.ComboBox();
            this.tamanho2ComboBox = new System.Windows.Forms.ComboBox();
            this.tamanho1ComboBox = new System.Windows.Forms.ComboBox();
            this.inicioLabel = new System.Windows.Forms.Label();
            this.tamanhoLabel = new System.Windows.Forms.Label();
            this.inicio1ComboBox = new System.Windows.Forms.ComboBox();
            this.conteudo4ComboBox = new System.Windows.Forms.ComboBox();
            this.conteudo3ComboBox = new System.Windows.Forms.ComboBox();
            this.conteudo2ComboBox = new System.Windows.Forms.ComboBox();
            this.inicio2ComboBox = new System.Windows.Forms.ComboBox();
            this.conteudo1ComboBox = new System.Windows.Forms.ComboBox();
            this.conteudoLabel = new System.Windows.Forms.Label();
            this.tamanho4ComboBox = new System.Windows.Forms.ComboBox();
            this.inicio3ComboBox = new System.Windows.Forms.ComboBox();
            this.inicio4ComboBox = new System.Windows.Forms.ComboBox();
            this.cadastrolayoutGroupBox.SuspendLayout();
            this.conteudoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomelayoutTextBox
            // 
            this.nomelayoutTextBox.AccessibleName = "Nome da Empresa";
            this.nomelayoutTextBox.BackColor = System.Drawing.Color.White;
            this.nomelayoutTextBox.Location = new System.Drawing.Point(82, 13);
            this.nomelayoutTextBox.MaxLength = 200;
            this.nomelayoutTextBox.Name = "nomelayoutTextBox";
            this.nomelayoutTextBox.Size = new System.Drawing.Size(234, 20);
            this.nomelayoutTextBox.TabIndex = 1;
            this.nomelayoutTextBox.TextChanged += new System.EventHandler(this.nomelayoutTextBox_TextChanged);
            // 
            // nomelayoutLabel
            // 
            this.nomelayoutLabel.AutoSize = true;
            this.nomelayoutLabel.Location = new System.Drawing.Point(6, 16);
            this.nomelayoutLabel.Name = "nomelayoutLabel";
            this.nomelayoutLabel.Size = new System.Drawing.Size(70, 13);
            this.nomelayoutLabel.TabIndex = 0;
            this.nomelayoutLabel.Text = "Nome Layout";
            // 
            // cadastrolayoutGroupBox
            // 
            this.cadastrolayoutGroupBox.Controls.Add(this.excluirlayoutButton);
            this.cadastrolayoutGroupBox.Controls.Add(this.alterarlayoutButton);
            this.cadastrolayoutGroupBox.Controls.Add(this.incluirlayoutButton);
            this.cadastrolayoutGroupBox.Controls.Add(this.conteudoGroupBox);
            this.cadastrolayoutGroupBox.Controls.Add(this.nomelayoutTextBox);
            this.cadastrolayoutGroupBox.Controls.Add(this.nomelayoutLabel);
            this.cadastrolayoutGroupBox.Location = new System.Drawing.Point(12, 7);
            this.cadastrolayoutGroupBox.Name = "cadastrolayoutGroupBox";
            this.cadastrolayoutGroupBox.Size = new System.Drawing.Size(343, 231);
            this.cadastrolayoutGroupBox.TabIndex = 0;
            this.cadastrolayoutGroupBox.TabStop = false;
            // 
            // excluirlayoutButton
            // 
            this.excluirlayoutButton.BackColor = System.Drawing.Color.Transparent;
            this.excluirlayoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.excluirlayoutButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirlayoutButton.ForeColor = System.Drawing.Color.Black;
            this.excluirlayoutButton.Image = ((System.Drawing.Image)(resources.GetObject("excluirlayoutButton.Image")));
            this.excluirlayoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excluirlayoutButton.Location = new System.Drawing.Point(186, 198);
            this.excluirlayoutButton.Name = "excluirlayoutButton";
            this.excluirlayoutButton.Size = new System.Drawing.Size(69, 26);
            this.excluirlayoutButton.TabIndex = 28;
            this.excluirlayoutButton.Text = "Excluir";
            this.excluirlayoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.excluirlayoutButton.UseVisualStyleBackColor = false;
            this.excluirlayoutButton.Click += new System.EventHandler(this.ExcluirlayoutButton_Click);
            // 
            // alterarlayoutButton
            // 
            this.alterarlayoutButton.BackColor = System.Drawing.Color.Transparent;
            this.alterarlayoutButton.Enabled = false;
            this.alterarlayoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alterarlayoutButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarlayoutButton.ForeColor = System.Drawing.Color.Black;
            this.alterarlayoutButton.Image = ((System.Drawing.Image)(resources.GetObject("alterarlayoutButton.Image")));
            this.alterarlayoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alterarlayoutButton.Location = new System.Drawing.Point(106, 198);
            this.alterarlayoutButton.Name = "alterarlayoutButton";
            this.alterarlayoutButton.Size = new System.Drawing.Size(73, 26);
            this.alterarlayoutButton.TabIndex = 27;
            this.alterarlayoutButton.Text = "Alterar";
            this.alterarlayoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.alterarlayoutButton.UseVisualStyleBackColor = false;
            this.alterarlayoutButton.Click += new System.EventHandler(this.AlterarlayoutButton_Click);
            // 
            // incluirlayoutButton
            // 
            this.incluirlayoutButton.BackColor = System.Drawing.Color.Transparent;
            this.incluirlayoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.incluirlayoutButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incluirlayoutButton.Image = ((System.Drawing.Image)(resources.GetObject("incluirlayoutButton.Image")));
            this.incluirlayoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incluirlayoutButton.Location = new System.Drawing.Point(261, 198);
            this.incluirlayoutButton.Name = "incluirlayoutButton";
            this.incluirlayoutButton.Size = new System.Drawing.Size(72, 26);
            this.incluirlayoutButton.TabIndex = 5;
            this.incluirlayoutButton.Text = "Incluir";
            this.incluirlayoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.incluirlayoutButton.UseVisualStyleBackColor = false;
            this.incluirlayoutButton.Click += new System.EventHandler(this.IncluirlayoutButton_Click);
            // 
            // conteudoGroupBox
            // 
            this.conteudoGroupBox.Controls.Add(this.statuslayoutLabel);
            this.conteudoGroupBox.Controls.Add(this.tamanho3ComboBox);
            this.conteudoGroupBox.Controls.Add(this.tamanho2ComboBox);
            this.conteudoGroupBox.Controls.Add(this.tamanho1ComboBox);
            this.conteudoGroupBox.Controls.Add(this.inicioLabel);
            this.conteudoGroupBox.Controls.Add(this.tamanhoLabel);
            this.conteudoGroupBox.Controls.Add(this.inicio1ComboBox);
            this.conteudoGroupBox.Controls.Add(this.conteudo4ComboBox);
            this.conteudoGroupBox.Controls.Add(this.conteudo3ComboBox);
            this.conteudoGroupBox.Controls.Add(this.conteudo2ComboBox);
            this.conteudoGroupBox.Controls.Add(this.inicio2ComboBox);
            this.conteudoGroupBox.Controls.Add(this.conteudo1ComboBox);
            this.conteudoGroupBox.Controls.Add(this.conteudoLabel);
            this.conteudoGroupBox.Controls.Add(this.tamanho4ComboBox);
            this.conteudoGroupBox.Controls.Add(this.inicio3ComboBox);
            this.conteudoGroupBox.Controls.Add(this.inicio4ComboBox);
            this.conteudoGroupBox.Location = new System.Drawing.Point(9, 39);
            this.conteudoGroupBox.Name = "conteudoGroupBox";
            this.conteudoGroupBox.Size = new System.Drawing.Size(323, 153);
            this.conteudoGroupBox.TabIndex = 2;
            this.conteudoGroupBox.TabStop = false;
            // 
            // statuslayoutLabel
            // 
            this.statuslayoutLabel.AutoSize = true;
            this.statuslayoutLabel.Location = new System.Drawing.Point(14, 135);
            this.statuslayoutLabel.Name = "statuslayoutLabel";
            this.statuslayoutLabel.Size = new System.Drawing.Size(37, 13);
            this.statuslayoutLabel.TabIndex = 15;
            this.statuslayoutLabel.Text = "Status";
            this.statuslayoutLabel.Visible = false;
            // 
            // tamanho3ComboBox
            // 
            this.tamanho3ComboBox.AccessibleDescription = "2";
            this.tamanho3ComboBox.AccessibleName = "3";
            this.tamanho3ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tamanho3ComboBox.Enabled = false;
            this.tamanho3ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tamanho3ComboBox.FormattingEnabled = true;
            this.tamanho3ComboBox.Location = new System.Drawing.Point(253, 84);
            this.tamanho3ComboBox.Name = "tamanho3ComboBox";
            this.tamanho3ComboBox.Size = new System.Drawing.Size(54, 21);
            this.tamanho3ComboBox.TabIndex = 11;
            // 
            // tamanho2ComboBox
            // 
            this.tamanho2ComboBox.AccessibleDescription = "1";
            this.tamanho2ComboBox.AccessibleName = "3";
            this.tamanho2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tamanho2ComboBox.Enabled = false;
            this.tamanho2ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tamanho2ComboBox.FormattingEnabled = true;
            this.tamanho2ComboBox.Location = new System.Drawing.Point(253, 57);
            this.tamanho2ComboBox.Name = "tamanho2ComboBox";
            this.tamanho2ComboBox.Size = new System.Drawing.Size(54, 21);
            this.tamanho2ComboBox.TabIndex = 8;
            // 
            // tamanho1ComboBox
            // 
            this.tamanho1ComboBox.AccessibleDescription = "0";
            this.tamanho1ComboBox.AccessibleName = "3";
            this.tamanho1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tamanho1ComboBox.Enabled = false;
            this.tamanho1ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tamanho1ComboBox.FormattingEnabled = true;
            this.tamanho1ComboBox.Location = new System.Drawing.Point(253, 29);
            this.tamanho1ComboBox.Name = "tamanho1ComboBox";
            this.tamanho1ComboBox.Size = new System.Drawing.Size(54, 21);
            this.tamanho1ComboBox.TabIndex = 5;
            // 
            // inicioLabel
            // 
            this.inicioLabel.AutoSize = true;
            this.inicioLabel.Location = new System.Drawing.Point(172, 14);
            this.inicioLabel.Name = "inicioLabel";
            this.inicioLabel.Size = new System.Drawing.Size(34, 13);
            this.inicioLabel.TabIndex = 1;
            this.inicioLabel.Text = "Início";
            // 
            // tamanhoLabel
            // 
            this.tamanhoLabel.AutoSize = true;
            this.tamanhoLabel.Location = new System.Drawing.Point(250, 14);
            this.tamanhoLabel.Name = "tamanhoLabel";
            this.tamanhoLabel.Size = new System.Drawing.Size(52, 13);
            this.tamanhoLabel.TabIndex = 2;
            this.tamanhoLabel.Text = "Tamanho";
            // 
            // inicio1ComboBox
            // 
            this.inicio1ComboBox.AccessibleDescription = "0";
            this.inicio1ComboBox.AccessibleName = "2";
            this.inicio1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inicio1ComboBox.Enabled = false;
            this.inicio1ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.inicio1ComboBox.FormattingEnabled = true;
            this.inicio1ComboBox.Location = new System.Drawing.Point(175, 29);
            this.inicio1ComboBox.Name = "inicio1ComboBox";
            this.inicio1ComboBox.Size = new System.Drawing.Size(54, 21);
            this.inicio1ComboBox.TabIndex = 4;
            // 
            // conteudo4ComboBox
            // 
            this.conteudo4ComboBox.AccessibleDescription = "3";
            this.conteudo4ComboBox.AccessibleName = "1";
            this.conteudo4ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conteudo4ComboBox.FormattingEnabled = true;
            this.conteudo4ComboBox.Location = new System.Drawing.Point(17, 111);
            this.conteudo4ComboBox.Name = "conteudo4ComboBox";
            this.conteudo4ComboBox.Size = new System.Drawing.Size(128, 21);
            this.conteudo4ComboBox.TabIndex = 12;
            // 
            // conteudo3ComboBox
            // 
            this.conteudo3ComboBox.AccessibleDescription = "2";
            this.conteudo3ComboBox.AccessibleName = "1";
            this.conteudo3ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conteudo3ComboBox.FormattingEnabled = true;
            this.conteudo3ComboBox.Location = new System.Drawing.Point(17, 84);
            this.conteudo3ComboBox.Name = "conteudo3ComboBox";
            this.conteudo3ComboBox.Size = new System.Drawing.Size(128, 21);
            this.conteudo3ComboBox.TabIndex = 9;
            // 
            // conteudo2ComboBox
            // 
            this.conteudo2ComboBox.AccessibleDescription = "1";
            this.conteudo2ComboBox.AccessibleName = "1";
            this.conteudo2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conteudo2ComboBox.FormattingEnabled = true;
            this.conteudo2ComboBox.Location = new System.Drawing.Point(17, 57);
            this.conteudo2ComboBox.Name = "conteudo2ComboBox";
            this.conteudo2ComboBox.Size = new System.Drawing.Size(128, 21);
            this.conteudo2ComboBox.TabIndex = 6;
            // 
            // inicio2ComboBox
            // 
            this.inicio2ComboBox.AccessibleDescription = "1";
            this.inicio2ComboBox.AccessibleName = "2";
            this.inicio2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inicio2ComboBox.Enabled = false;
            this.inicio2ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.inicio2ComboBox.FormattingEnabled = true;
            this.inicio2ComboBox.Location = new System.Drawing.Point(175, 56);
            this.inicio2ComboBox.Name = "inicio2ComboBox";
            this.inicio2ComboBox.Size = new System.Drawing.Size(54, 21);
            this.inicio2ComboBox.TabIndex = 7;
            // 
            // conteudo1ComboBox
            // 
            this.conteudo1ComboBox.AccessibleDescription = "0";
            this.conteudo1ComboBox.AccessibleName = "1";
            this.conteudo1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conteudo1ComboBox.FormattingEnabled = true;
            this.conteudo1ComboBox.Location = new System.Drawing.Point(17, 30);
            this.conteudo1ComboBox.Name = "conteudo1ComboBox";
            this.conteudo1ComboBox.Size = new System.Drawing.Size(128, 21);
            this.conteudo1ComboBox.TabIndex = 3;
            // 
            // conteudoLabel
            // 
            this.conteudoLabel.AutoSize = true;
            this.conteudoLabel.Location = new System.Drawing.Point(14, 14);
            this.conteudoLabel.Name = "conteudoLabel";
            this.conteudoLabel.Size = new System.Drawing.Size(53, 13);
            this.conteudoLabel.TabIndex = 0;
            this.conteudoLabel.Text = "Conteúdo";
            // 
            // tamanho4ComboBox
            // 
            this.tamanho4ComboBox.AccessibleDescription = "3";
            this.tamanho4ComboBox.AccessibleName = "3";
            this.tamanho4ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tamanho4ComboBox.Enabled = false;
            this.tamanho4ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tamanho4ComboBox.FormattingEnabled = true;
            this.tamanho4ComboBox.Location = new System.Drawing.Point(253, 111);
            this.tamanho4ComboBox.Name = "tamanho4ComboBox";
            this.tamanho4ComboBox.Size = new System.Drawing.Size(54, 21);
            this.tamanho4ComboBox.TabIndex = 14;
            // 
            // inicio3ComboBox
            // 
            this.inicio3ComboBox.AccessibleDescription = "2";
            this.inicio3ComboBox.AccessibleName = "2";
            this.inicio3ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inicio3ComboBox.Enabled = false;
            this.inicio3ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.inicio3ComboBox.FormattingEnabled = true;
            this.inicio3ComboBox.Location = new System.Drawing.Point(175, 83);
            this.inicio3ComboBox.Name = "inicio3ComboBox";
            this.inicio3ComboBox.Size = new System.Drawing.Size(54, 21);
            this.inicio3ComboBox.TabIndex = 10;
            // 
            // inicio4ComboBox
            // 
            this.inicio4ComboBox.AccessibleDescription = "3";
            this.inicio4ComboBox.AccessibleName = "2";
            this.inicio4ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inicio4ComboBox.Enabled = false;
            this.inicio4ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.inicio4ComboBox.FormattingEnabled = true;
            this.inicio4ComboBox.Location = new System.Drawing.Point(175, 110);
            this.inicio4ComboBox.Name = "inicio4ComboBox";
            this.inicio4ComboBox.Size = new System.Drawing.Size(54, 21);
            this.inicio4ComboBox.TabIndex = 13;
            // 
            // cadastrarlayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 249);
            this.Controls.Add(this.cadastrolayoutGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cadastrarlayoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Layout";
            this.Load += new System.EventHandler(this.CadastrolayoutForm_Load);
            this.cadastrolayoutGroupBox.ResumeLayout(false);
            this.cadastrolayoutGroupBox.PerformLayout();
            this.conteudoGroupBox.ResumeLayout(false);
            this.conteudoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nomelayoutTextBox;
        private System.Windows.Forms.Label nomelayoutLabel;
        private System.Windows.Forms.GroupBox cadastrolayoutGroupBox;
        private System.Windows.Forms.GroupBox conteudoGroupBox;
        private System.Windows.Forms.ComboBox inicio1ComboBox;
        private System.Windows.Forms.ComboBox conteudo1ComboBox;
        private System.Windows.Forms.Label tamanhoLabel;
        private System.Windows.Forms.Label inicioLabel;
        private System.Windows.Forms.Label conteudoLabel;
        private System.Windows.Forms.ComboBox tamanho4ComboBox;
        private System.Windows.Forms.ComboBox inicio4ComboBox;
        private System.Windows.Forms.ComboBox conteudo4ComboBox;
        private System.Windows.Forms.ComboBox inicio3ComboBox;
        private System.Windows.Forms.ComboBox conteudo3ComboBox;
        private System.Windows.Forms.ComboBox inicio2ComboBox;
        private System.Windows.Forms.ComboBox conteudo2ComboBox;
        private System.Windows.Forms.ComboBox tamanho3ComboBox;
        private System.Windows.Forms.ComboBox tamanho2ComboBox;
        private System.Windows.Forms.ComboBox tamanho1ComboBox;
        private System.Windows.Forms.Button incluirlayoutButton;
        private System.Windows.Forms.Button excluirlayoutButton;
        private System.Windows.Forms.Button alterarlayoutButton;
        private System.Windows.Forms.Label statuslayoutLabel;
    }
}