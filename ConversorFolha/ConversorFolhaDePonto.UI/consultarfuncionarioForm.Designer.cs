namespace ConversorFolhaDePonto.UI
{
    partial class consultafuncionarioForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultafuncionarioForm));
            this.consultafuncionarioGridView = new System.Windows.Forms.DataGridView();
            this.idEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.externoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultafuncionarioGroupBox = new System.Windows.Forms.GroupBox();
            this.detalhesfuncionarioButton = new System.Windows.Forms.Button();
            this.incluirfuncionarioButton = new System.Windows.Forms.Button();
            this.codigoempresaComboBox = new System.Windows.Forms.ComboBox();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeempresaLabel = new System.Windows.Forms.Label();
            this.nomeempresaTextBox = new System.Windows.Forms.TextBox();
            this.codigoempresaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultafuncionarioGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.consultafuncionarioGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // consultafuncionarioGridView
            // 
            this.consultafuncionarioGridView.AllowUserToAddRows = false;
            this.consultafuncionarioGridView.AllowUserToDeleteRows = false;
            this.consultafuncionarioGridView.AllowUserToResizeColumns = false;
            this.consultafuncionarioGridView.AllowUserToResizeRows = false;
            this.consultafuncionarioGridView.AutoGenerateColumns = false;
            this.consultafuncionarioGridView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.consultafuncionarioGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.consultafuncionarioGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.consultafuncionarioGridView.ColumnHeadersHeight = 60;
            this.consultafuncionarioGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.consultafuncionarioGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpresaDataGridViewTextBoxColumn,
            this.nomeEmpresaDataGridViewTextBoxColumn,
            this.externoDataGridViewTextBoxColumn,
            this.internoDataGridViewTextBoxColumn});
            this.consultafuncionarioGridView.DataSource = this.funcionarioBindingSource;
            this.consultafuncionarioGridView.Location = new System.Drawing.Point(9, 69);
            this.consultafuncionarioGridView.Name = "consultafuncionarioGridView";
            this.consultafuncionarioGridView.ReadOnly = true;
            this.consultafuncionarioGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.consultafuncionarioGridView.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.consultafuncionarioGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consultafuncionarioGridView.Size = new System.Drawing.Size(481, 350);
            this.consultafuncionarioGridView.TabIndex = 4;
            // 
            // idEmpresaDataGridViewTextBoxColumn
            // 
            this.idEmpresaDataGridViewTextBoxColumn.DataPropertyName = "IdEmpresa";
            this.idEmpresaDataGridViewTextBoxColumn.HeaderText = "Código Empresa";
            this.idEmpresaDataGridViewTextBoxColumn.Name = "idEmpresaDataGridViewTextBoxColumn";
            this.idEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEmpresaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idEmpresaDataGridViewTextBoxColumn.Width = 80;
            // 
            // nomeEmpresaDataGridViewTextBoxColumn
            // 
            this.nomeEmpresaDataGridViewTextBoxColumn.DataPropertyName = "NomeEmpresa";
            this.nomeEmpresaDataGridViewTextBoxColumn.HeaderText = "Nome Empresa";
            this.nomeEmpresaDataGridViewTextBoxColumn.Name = "nomeEmpresaDataGridViewTextBoxColumn";
            this.nomeEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeEmpresaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nomeEmpresaDataGridViewTextBoxColumn.Width = 200;
            // 
            // externoDataGridViewTextBoxColumn
            // 
            this.externoDataGridViewTextBoxColumn.DataPropertyName = "Externo";
            this.externoDataGridViewTextBoxColumn.HeaderText = "Externo";
            this.externoDataGridViewTextBoxColumn.Name = "externoDataGridViewTextBoxColumn";
            this.externoDataGridViewTextBoxColumn.ReadOnly = true;
            this.externoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.externoDataGridViewTextBoxColumn.Width = 70;
            // 
            // internoDataGridViewTextBoxColumn
            // 
            this.internoDataGridViewTextBoxColumn.DataPropertyName = "Interno";
            this.internoDataGridViewTextBoxColumn.HeaderText = "Interno";
            this.internoDataGridViewTextBoxColumn.Name = "internoDataGridViewTextBoxColumn";
            this.internoDataGridViewTextBoxColumn.ReadOnly = true;
            this.internoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.internoDataGridViewTextBoxColumn.Width = 70;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataSource = typeof(ConversorFolhaDePonto.Modelo.Funcionario);
            // 
            // consultafuncionarioGroupBox
            // 
            this.consultafuncionarioGroupBox.Controls.Add(this.detalhesfuncionarioButton);
            this.consultafuncionarioGroupBox.Controls.Add(this.incluirfuncionarioButton);
            this.consultafuncionarioGroupBox.Controls.Add(this.codigoempresaComboBox);
            this.consultafuncionarioGroupBox.Controls.Add(this.consultafuncionarioGridView);
            this.consultafuncionarioGroupBox.Controls.Add(this.nomeempresaLabel);
            this.consultafuncionarioGroupBox.Controls.Add(this.nomeempresaTextBox);
            this.consultafuncionarioGroupBox.Controls.Add(this.codigoempresaLabel);
            this.consultafuncionarioGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultafuncionarioGroupBox.Location = new System.Drawing.Point(12, 12);
            this.consultafuncionarioGroupBox.Name = "consultafuncionarioGroupBox";
            this.consultafuncionarioGroupBox.Size = new System.Drawing.Size(498, 457);
            this.consultafuncionarioGroupBox.TabIndex = 12;
            this.consultafuncionarioGroupBox.TabStop = false;
            // 
            // detalhesfuncionarioButton
            // 
            this.detalhesfuncionarioButton.BackColor = System.Drawing.Color.Transparent;
            this.detalhesfuncionarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.detalhesfuncionarioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalhesfuncionarioButton.ForeColor = System.Drawing.Color.Black;
            this.detalhesfuncionarioButton.Image = ((System.Drawing.Image)(resources.GetObject("detalhesfuncionarioButton.Image")));
            this.detalhesfuncionarioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detalhesfuncionarioButton.Location = new System.Drawing.Point(405, 424);
            this.detalhesfuncionarioButton.Name = "detalhesfuncionarioButton";
            this.detalhesfuncionarioButton.Size = new System.Drawing.Size(85, 26);
            this.detalhesfuncionarioButton.TabIndex = 23;
            this.detalhesfuncionarioButton.Text = "Detalhes";
            this.detalhesfuncionarioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.detalhesfuncionarioButton.UseVisualStyleBackColor = false;
            this.detalhesfuncionarioButton.Click += new System.EventHandler(this.DetalhesfuncionarioButton_Click);
            // 
            // incluirfuncionarioButton
            // 
            this.incluirfuncionarioButton.BackColor = System.Drawing.Color.Transparent;
            this.incluirfuncionarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.incluirfuncionarioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incluirfuncionarioButton.ForeColor = System.Drawing.Color.Black;
            this.incluirfuncionarioButton.Image = ((System.Drawing.Image)(resources.GetObject("incluirfuncionarioButton.Image")));
            this.incluirfuncionarioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incluirfuncionarioButton.Location = new System.Drawing.Point(329, 424);
            this.incluirfuncionarioButton.Name = "incluirfuncionarioButton";
            this.incluirfuncionarioButton.Size = new System.Drawing.Size(69, 26);
            this.incluirfuncionarioButton.TabIndex = 22;
            this.incluirfuncionarioButton.Text = "Incluir";
            this.incluirfuncionarioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.incluirfuncionarioButton.UseVisualStyleBackColor = false;
            this.incluirfuncionarioButton.Click += new System.EventHandler(this.incluirfuncionarioButton_Click);
            // 
            // codigoempresaComboBox
            // 
            this.codigoempresaComboBox.DataSource = this.empresaBindingSource;
            this.codigoempresaComboBox.DisplayMember = "Id";
            this.codigoempresaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codigoempresaComboBox.FormattingEnabled = true;
            this.codigoempresaComboBox.Location = new System.Drawing.Point(9, 38);
            this.codigoempresaComboBox.Name = "codigoempresaComboBox";
            this.codigoempresaComboBox.Size = new System.Drawing.Size(70, 25);
            this.codigoempresaComboBox.TabIndex = 14;
            this.codigoempresaComboBox.ValueMember = "Nome";
            this.codigoempresaComboBox.SelectedIndexChanged += new System.EventHandler(this.CodigoempresaComboBox_SelectedIndexChanged);
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataSource = typeof(ConversorFolhaDePonto.Modelo.Empresa);
            // 
            // nomeempresaLabel
            // 
            this.nomeempresaLabel.AutoSize = true;
            this.nomeempresaLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeempresaLabel.Location = new System.Drawing.Point(126, 18);
            this.nomeempresaLabel.Name = "nomeempresaLabel";
            this.nomeempresaLabel.Size = new System.Drawing.Size(97, 17);
            this.nomeempresaLabel.TabIndex = 9;
            this.nomeempresaLabel.Text = "Nome Empresa";
            // 
            // nomeempresaTextBox
            // 
            this.nomeempresaTextBox.AccessibleName = "Nome da Empresa";
            this.nomeempresaTextBox.Enabled = false;
            this.nomeempresaTextBox.Location = new System.Drawing.Point(129, 41);
            this.nomeempresaTextBox.Name = "nomeempresaTextBox";
            this.nomeempresaTextBox.Size = new System.Drawing.Size(269, 22);
            this.nomeempresaTextBox.TabIndex = 10;
            // 
            // codigoempresaLabel
            // 
            this.codigoempresaLabel.AutoSize = true;
            this.codigoempresaLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoempresaLabel.Location = new System.Drawing.Point(6, 18);
            this.codigoempresaLabel.Name = "codigoempresaLabel";
            this.codigoempresaLabel.Size = new System.Drawing.Size(105, 17);
            this.codigoempresaLabel.TabIndex = 1;
            this.codigoempresaLabel.Text = "Código Empresa";
            // 
            // ConsultafuncionarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 477);
            this.Controls.Add(this.consultafuncionarioGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultafuncionarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Funcionário";
            this.Load += new System.EventHandler(this.FuncionariomanutencaoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultafuncionarioGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.consultafuncionarioGroupBox.ResumeLayout(false);
            this.consultafuncionarioGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView consultafuncionarioGridView;
        private System.Windows.Forms.GroupBox consultafuncionarioGroupBox;
        private System.Windows.Forms.ComboBox codigoempresaComboBox;
        private System.Windows.Forms.Label nomeempresaLabel;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private System.Windows.Forms.TextBox nomeempresaTextBox;
        private System.Windows.Forms.Label codigoempresaLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn externoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button detalhesfuncionarioButton;
        private System.Windows.Forms.Button incluirfuncionarioButton;
    }
}