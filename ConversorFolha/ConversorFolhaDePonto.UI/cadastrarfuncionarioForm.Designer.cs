namespace ConversorFolhaDePonto.UI
{
    partial class CadastrarfuncionarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarfuncionarioForm));
            this.cadastrofuncionarioGroupBox = new System.Windows.Forms.GroupBox();
            this.incluirfuncionarioButton = new System.Windows.Forms.Button();
            this.codigoempresaLabel = new System.Windows.Forms.Label();
            this.funcionarioGroupBox = new System.Windows.Forms.GroupBox();
            this.statusfuncionarioLabel = new System.Windows.Forms.Label();
            this.funcionariointernoTextBox = new System.Windows.Forms.TextBox();
            this.funcionarioexternoLabel = new System.Windows.Forms.Label();
            this.funcionarioexternoTextBox = new System.Windows.Forms.TextBox();
            this.funcionariointernoLabel = new System.Windows.Forms.Label();
            this.codigoempresaComboBox = new System.Windows.Forms.ComboBox();
            this.nomeempresaLabel = new System.Windows.Forms.Label();
            this.nomeempresaTextBox = new System.Windows.Forms.TextBox();
            this.cadastrofuncionarioGroupBox.SuspendLayout();
            this.funcionarioGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastrofuncionarioGroupBox
            // 
            resources.ApplyResources(this.cadastrofuncionarioGroupBox, "cadastrofuncionarioGroupBox");
            this.cadastrofuncionarioGroupBox.Controls.Add(this.incluirfuncionarioButton);
            this.cadastrofuncionarioGroupBox.Controls.Add(this.codigoempresaLabel);
            this.cadastrofuncionarioGroupBox.Controls.Add(this.funcionarioGroupBox);
            this.cadastrofuncionarioGroupBox.Controls.Add(this.codigoempresaComboBox);
            this.cadastrofuncionarioGroupBox.Controls.Add(this.nomeempresaLabel);
            this.cadastrofuncionarioGroupBox.Controls.Add(this.nomeempresaTextBox);
            this.cadastrofuncionarioGroupBox.Name = "cadastrofuncionarioGroupBox";
            this.cadastrofuncionarioGroupBox.TabStop = false;
            // 
            // incluirfuncionarioButton
            // 
            resources.ApplyResources(this.incluirfuncionarioButton, "incluirfuncionarioButton");
            this.incluirfuncionarioButton.BackColor = System.Drawing.Color.Transparent;
            this.incluirfuncionarioButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.incluirfuncionarioButton.Name = "incluirfuncionarioButton";
            this.incluirfuncionarioButton.UseVisualStyleBackColor = false;
            // 
            // codigoempresaLabel
            // 
            resources.ApplyResources(this.codigoempresaLabel, "codigoempresaLabel");
            this.codigoempresaLabel.Name = "codigoempresaLabel";
            // 
            // funcionarioGroupBox
            // 
            resources.ApplyResources(this.funcionarioGroupBox, "funcionarioGroupBox");
            this.funcionarioGroupBox.Controls.Add(this.statusfuncionarioLabel);
            this.funcionarioGroupBox.Controls.Add(this.funcionariointernoTextBox);
            this.funcionarioGroupBox.Controls.Add(this.funcionarioexternoLabel);
            this.funcionarioGroupBox.Controls.Add(this.funcionarioexternoTextBox);
            this.funcionarioGroupBox.Controls.Add(this.funcionariointernoLabel);
            this.funcionarioGroupBox.Name = "funcionarioGroupBox";
            this.funcionarioGroupBox.TabStop = false;
            // 
            // statusfuncionarioLabel
            // 
            resources.ApplyResources(this.statusfuncionarioLabel, "statusfuncionarioLabel");
            this.statusfuncionarioLabel.Name = "statusfuncionarioLabel";
            // 
            // funcionariointernoTextBox
            // 
            resources.ApplyResources(this.funcionariointernoTextBox, "funcionariointernoTextBox");
            this.funcionariointernoTextBox.Name = "funcionariointernoTextBox";
            // 
            // funcionarioexternoLabel
            // 
            resources.ApplyResources(this.funcionarioexternoLabel, "funcionarioexternoLabel");
            this.funcionarioexternoLabel.Name = "funcionarioexternoLabel";
            // 
            // funcionarioexternoTextBox
            // 
            resources.ApplyResources(this.funcionarioexternoTextBox, "funcionarioexternoTextBox");
            this.funcionarioexternoTextBox.Name = "funcionarioexternoTextBox";
            // 
            // funcionariointernoLabel
            // 
            resources.ApplyResources(this.funcionariointernoLabel, "funcionariointernoLabel");
            this.funcionariointernoLabel.Name = "funcionariointernoLabel";
            // 
            // codigoempresaComboBox
            // 
            resources.ApplyResources(this.codigoempresaComboBox, "codigoempresaComboBox");
            this.codigoempresaComboBox.DisplayMember = "Id";
            this.codigoempresaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codigoempresaComboBox.FormattingEnabled = true;
            this.codigoempresaComboBox.Name = "codigoempresaComboBox";
            this.codigoempresaComboBox.ValueMember = "Nome";
            this.codigoempresaComboBox.SelectedIndexChanged += new System.EventHandler(this.CodigoempresaComboBox_SelectedIndexChanged);
            // 
            // nomeempresaLabel
            // 
            resources.ApplyResources(this.nomeempresaLabel, "nomeempresaLabel");
            this.nomeempresaLabel.Name = "nomeempresaLabel";
            // 
            // nomeempresaTextBox
            // 
            resources.ApplyResources(this.nomeempresaTextBox, "nomeempresaTextBox");
            this.nomeempresaTextBox.Name = "nomeempresaTextBox";
            // 
            // CadastrarfuncionarioForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cadastrofuncionarioGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CadastrarfuncionarioForm";
            this.cadastrofuncionarioGroupBox.ResumeLayout(false);
            this.cadastrofuncionarioGroupBox.PerformLayout();
            this.funcionarioGroupBox.ResumeLayout(false);
            this.funcionarioGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cadastrofuncionarioGroupBox;
        private System.Windows.Forms.Label codigoempresaLabel;
        private System.Windows.Forms.GroupBox funcionarioGroupBox;
        private System.Windows.Forms.Label statusfuncionarioLabel;
        private System.Windows.Forms.TextBox funcionariointernoTextBox;
        private System.Windows.Forms.Label funcionarioexternoLabel;
        private System.Windows.Forms.TextBox funcionarioexternoTextBox;
        private System.Windows.Forms.Label funcionariointernoLabel;
        private System.Windows.Forms.ComboBox codigoempresaComboBox;
        private System.Windows.Forms.Label nomeempresaLabel;
        private System.Windows.Forms.TextBox nomeempresaTextBox;
        private System.Windows.Forms.Button incluirfuncionarioButton;
    }
}