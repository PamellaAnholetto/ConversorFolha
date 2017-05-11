namespace ConversorFolhaDePonto.UI
{
    partial class ManutencaofuncionarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManutencaofuncionarioForm));
            this.funcionarioGroupBox = new System.Windows.Forms.GroupBox();
            this.statusfuncionarioLabel = new System.Windows.Forms.Label();
            this.funcionariointernoTextBox = new System.Windows.Forms.TextBox();
            this.funcionarioexternoLabel = new System.Windows.Forms.Label();
            this.funcionarioexternoTextBox = new System.Windows.Forms.TextBox();
            this.funcionariointernoLabel = new System.Windows.Forms.Label();
            this.codigoempresaComboBox = new System.Windows.Forms.ComboBox();
            this.codigoempresaLabel = new System.Windows.Forms.Label();
            this.nomeempresaLabel = new System.Windows.Forms.Label();
            this.cadastrofuncionarioGroupBox = new System.Windows.Forms.GroupBox();
            this.excluirfuncionarioButton = new System.Windows.Forms.Button();
            this.alterarfuncionarioButton = new System.Windows.Forms.Button();
            this.nomeempresaTextBox = new System.Windows.Forms.TextBox();
            this.funcionarioGroupBox.SuspendLayout();
            this.cadastrofuncionarioGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // funcionarioGroupBox
            // 
            this.funcionarioGroupBox.Controls.Add(this.statusfuncionarioLabel);
            this.funcionarioGroupBox.Controls.Add(this.funcionariointernoTextBox);
            this.funcionarioGroupBox.Controls.Add(this.funcionarioexternoLabel);
            this.funcionarioGroupBox.Controls.Add(this.funcionarioexternoTextBox);
            this.funcionarioGroupBox.Controls.Add(this.funcionariointernoLabel);
            this.funcionarioGroupBox.Enabled = false;
            this.funcionarioGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionarioGroupBox.Location = new System.Drawing.Point(9, 67);
            this.funcionarioGroupBox.Name = "funcionarioGroupBox";
            this.funcionarioGroupBox.Size = new System.Drawing.Size(228, 80);
            this.funcionarioGroupBox.TabIndex = 9;
            this.funcionarioGroupBox.TabStop = false;
            this.funcionarioGroupBox.Text = "Funcionário";
            // 
            // statusfuncionarioLabel
            // 
            this.statusfuncionarioLabel.AutoSize = true;
            this.statusfuncionarioLabel.Location = new System.Drawing.Point(6, 57);
            this.statusfuncionarioLabel.Name = "statusfuncionarioLabel";
            this.statusfuncionarioLabel.Size = new System.Drawing.Size(45, 17);
            this.statusfuncionarioLabel.TabIndex = 5;
            this.statusfuncionarioLabel.Text = "Status";
            this.statusfuncionarioLabel.Visible = false;
            // 
            // funcionariointernoTextBox
            // 
            this.funcionariointernoTextBox.AccessibleName = "Funcionario BuddyWin";
            this.funcionariointernoTextBox.Location = new System.Drawing.Point(173, 21);
            this.funcionariointernoTextBox.MaxLength = 6;
            this.funcionariointernoTextBox.Name = "funcionariointernoTextBox";
            this.funcionariointernoTextBox.Size = new System.Drawing.Size(49, 22);
            this.funcionariointernoTextBox.TabIndex = 3;
            // 
            // funcionarioexternoLabel
            // 
            this.funcionarioexternoLabel.AutoSize = true;
            this.funcionarioexternoLabel.Location = new System.Drawing.Point(6, 22);
            this.funcionarioexternoLabel.Name = "funcionarioexternoLabel";
            this.funcionarioexternoLabel.Size = new System.Drawing.Size(52, 17);
            this.funcionarioexternoLabel.TabIndex = 0;
            this.funcionarioexternoLabel.Text = "Externo";
            // 
            // funcionarioexternoTextBox
            // 
            this.funcionarioexternoTextBox.AccessibleName = "Funcionario Externo";
            this.funcionarioexternoTextBox.Location = new System.Drawing.Point(64, 21);
            this.funcionarioexternoTextBox.MaxLength = 6;
            this.funcionarioexternoTextBox.Name = "funcionarioexternoTextBox";
            this.funcionarioexternoTextBox.Size = new System.Drawing.Size(49, 22);
            this.funcionarioexternoTextBox.TabIndex = 1;
            // 
            // funcionariointernoLabel
            // 
            this.funcionariointernoLabel.AutoSize = true;
            this.funcionariointernoLabel.Location = new System.Drawing.Point(119, 22);
            this.funcionariointernoLabel.Name = "funcionariointernoLabel";
            this.funcionariointernoLabel.Size = new System.Drawing.Size(50, 17);
            this.funcionariointernoLabel.TabIndex = 2;
            this.funcionariointernoLabel.Text = "Interno";
            // 
            // codigoempresaComboBox
            // 
            this.codigoempresaComboBox.DisplayMember = "Id";
            this.codigoempresaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codigoempresaComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoempresaComboBox.FormattingEnabled = true;
            this.codigoempresaComboBox.Location = new System.Drawing.Point(9, 39);
            this.codigoempresaComboBox.Name = "codigoempresaComboBox";
            this.codigoempresaComboBox.Size = new System.Drawing.Size(68, 25);
            this.codigoempresaComboBox.TabIndex = 19;
            this.codigoempresaComboBox.ValueMember = "Nome";
            this.codigoempresaComboBox.SelectedIndexChanged += new System.EventHandler(this.CodigoempresaComboBox_SelectedIndexChanged);
            // 
            // codigoempresaLabel
            // 
            this.codigoempresaLabel.AutoSize = true;
            this.codigoempresaLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoempresaLabel.Location = new System.Drawing.Point(6, 19);
            this.codigoempresaLabel.Name = "codigoempresaLabel";
            this.codigoempresaLabel.Size = new System.Drawing.Size(105, 17);
            this.codigoempresaLabel.TabIndex = 16;
            this.codigoempresaLabel.Text = "Código Empresa";
            // 
            // nomeempresaLabel
            // 
            this.nomeempresaLabel.AutoSize = true;
            this.nomeempresaLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeempresaLabel.Location = new System.Drawing.Point(122, 19);
            this.nomeempresaLabel.Name = "nomeempresaLabel";
            this.nomeempresaLabel.Size = new System.Drawing.Size(97, 17);
            this.nomeempresaLabel.TabIndex = 17;
            this.nomeempresaLabel.Text = "Nome Empresa";
            // 
            // cadastrofuncionarioGroupBox
            // 
            this.cadastrofuncionarioGroupBox.Controls.Add(this.excluirfuncionarioButton);
            this.cadastrofuncionarioGroupBox.Controls.Add(this.alterarfuncionarioButton);
            this.cadastrofuncionarioGroupBox.Controls.Add(this.codigoempresaLabel);
            this.cadastrofuncionarioGroupBox.Controls.Add(this.funcionarioGroupBox);
            this.cadastrofuncionarioGroupBox.Controls.Add(this.codigoempresaComboBox);
            this.cadastrofuncionarioGroupBox.Controls.Add(this.nomeempresaLabel);
            this.cadastrofuncionarioGroupBox.Controls.Add(this.nomeempresaTextBox);
            this.cadastrofuncionarioGroupBox.Location = new System.Drawing.Point(12, 12);
            this.cadastrofuncionarioGroupBox.Name = "cadastrofuncionarioGroupBox";
            this.cadastrofuncionarioGroupBox.Size = new System.Drawing.Size(397, 155);
            this.cadastrofuncionarioGroupBox.TabIndex = 20;
            this.cadastrofuncionarioGroupBox.TabStop = false;
            // 
            // excluirfuncionarioButton
            // 
            this.excluirfuncionarioButton.BackColor = System.Drawing.Color.Transparent;
            this.excluirfuncionarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.excluirfuncionarioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirfuncionarioButton.ForeColor = System.Drawing.Color.Black;
            this.excluirfuncionarioButton.Image = ((System.Drawing.Image)(resources.GetObject("excluirfuncionarioButton.Image")));
            this.excluirfuncionarioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excluirfuncionarioButton.Location = new System.Drawing.Point(322, 121);
            this.excluirfuncionarioButton.Name = "excluirfuncionarioButton";
            this.excluirfuncionarioButton.Size = new System.Drawing.Size(69, 26);
            this.excluirfuncionarioButton.TabIndex = 24;
            this.excluirfuncionarioButton.Text = "Excluir";
            this.excluirfuncionarioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.excluirfuncionarioButton.UseVisualStyleBackColor = false;
            // 
            // alterarfuncionarioButton
            // 
            this.alterarfuncionarioButton.BackColor = System.Drawing.Color.Transparent;
            this.alterarfuncionarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alterarfuncionarioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarfuncionarioButton.ForeColor = System.Drawing.Color.Black;
            this.alterarfuncionarioButton.Image = ((System.Drawing.Image)(resources.GetObject("alterarfuncionarioButton.Image")));
            this.alterarfuncionarioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alterarfuncionarioButton.Location = new System.Drawing.Point(243, 121);
            this.alterarfuncionarioButton.Name = "alterarfuncionarioButton";
            this.alterarfuncionarioButton.Size = new System.Drawing.Size(73, 26);
            this.alterarfuncionarioButton.TabIndex = 23;
            this.alterarfuncionarioButton.Text = "Alterar";
            this.alterarfuncionarioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.alterarfuncionarioButton.UseVisualStyleBackColor = false;
            // 
            // nomeempresaTextBox
            // 
            this.nomeempresaTextBox.AccessibleName = "Nome da Empresa";
            this.nomeempresaTextBox.Enabled = false;
            this.nomeempresaTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeempresaTextBox.Location = new System.Drawing.Point(125, 39);
            this.nomeempresaTextBox.MaxLength = 200;
            this.nomeempresaTextBox.Name = "nomeempresaTextBox";
            this.nomeempresaTextBox.Size = new System.Drawing.Size(266, 22);
            this.nomeempresaTextBox.TabIndex = 18;
            // 
            // ManutencaofuncionarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 173);
            this.Controls.Add(this.cadastrofuncionarioGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManutencaofuncionarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção Funcionário";
            this.funcionarioGroupBox.ResumeLayout(false);
            this.funcionarioGroupBox.PerformLayout();
            this.cadastrofuncionarioGroupBox.ResumeLayout(false);
            this.cadastrofuncionarioGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox funcionarioGroupBox;
        private System.Windows.Forms.Label statusfuncionarioLabel;
        private System.Windows.Forms.TextBox funcionariointernoTextBox;
        private System.Windows.Forms.Label funcionarioexternoLabel;
        private System.Windows.Forms.TextBox funcionarioexternoTextBox;
        private System.Windows.Forms.Label funcionariointernoLabel;
        private System.Windows.Forms.ComboBox codigoempresaComboBox;
        private System.Windows.Forms.Label codigoempresaLabel;
        private System.Windows.Forms.Label nomeempresaLabel;
        private System.Windows.Forms.GroupBox cadastrofuncionarioGroupBox;
        private System.Windows.Forms.TextBox nomeempresaTextBox;
        private System.Windows.Forms.Button excluirfuncionarioButton;
        private System.Windows.Forms.Button alterarfuncionarioButton;
    }
}