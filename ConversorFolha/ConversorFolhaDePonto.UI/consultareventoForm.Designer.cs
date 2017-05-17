namespace ConversorFolhaDePonto.UI
{
    partial class consultaeventoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultaeventoForm));
            this.consultaeventoGridView = new System.Windows.Forms.DataGridView();
            this.eventoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaeventoGroupBox = new System.Windows.Forms.GroupBox();
            this.incluireventoButton = new System.Windows.Forms.Button();
            this.detalheseventoButton = new System.Windows.Forms.Button();
            this.codigoempresaComboBox = new System.Windows.Forms.ComboBox();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeempresaLabel = new System.Windows.Forms.Label();
            this.nomeempresaTextBox = new System.Windows.Forms.TextBox();
            this.codigoempresaLabel = new System.Windows.Forms.Label();
            this.idEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.externoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transferivelDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.consultaeventoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).BeginInit();
            this.consultaeventoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // consultaeventoGridView
            // 
            this.consultaeventoGridView.AllowUserToAddRows = false;
            this.consultaeventoGridView.AllowUserToDeleteRows = false;
            this.consultaeventoGridView.AllowUserToResizeColumns = false;
            this.consultaeventoGridView.AllowUserToResizeRows = false;
            this.consultaeventoGridView.AutoGenerateColumns = false;
            this.consultaeventoGridView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.consultaeventoGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.consultaeventoGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.consultaeventoGridView.ColumnHeadersHeight = 60;
            this.consultaeventoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.consultaeventoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpresaDataGridViewTextBoxColumn,
            this.nomeEmpresaDataGridViewTextBoxColumn,
            this.externoDataGridViewTextBoxColumn,
            this.internoDataGridViewTextBoxColumn,
            this.transferivelDataGridViewCheckBoxColumn});
            this.consultaeventoGridView.DataSource = this.eventoBindingSource;
            this.consultaeventoGridView.Location = new System.Drawing.Point(9, 69);
            this.consultaeventoGridView.MultiSelect = false;
            this.consultaeventoGridView.Name = "consultaeventoGridView";
            this.consultaeventoGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.consultaeventoGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.consultaeventoGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.consultaeventoGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.consultaeventoGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consultaeventoGridView.Size = new System.Drawing.Size(556, 345);
            this.consultaeventoGridView.TabIndex = 5;
            // 
            // eventoBindingSource
            // 
            this.eventoBindingSource.DataSource = typeof(ConversorFolhaDePonto.Modelo.Evento);
            // 
            // consultaeventoGroupBox
            // 
            this.consultaeventoGroupBox.Controls.Add(this.incluireventoButton);
            this.consultaeventoGroupBox.Controls.Add(this.detalheseventoButton);
            this.consultaeventoGroupBox.Controls.Add(this.codigoempresaComboBox);
            this.consultaeventoGroupBox.Controls.Add(this.consultaeventoGridView);
            this.consultaeventoGroupBox.Controls.Add(this.nomeempresaLabel);
            this.consultaeventoGroupBox.Controls.Add(this.nomeempresaTextBox);
            this.consultaeventoGroupBox.Controls.Add(this.codigoempresaLabel);
            this.consultaeventoGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaeventoGroupBox.Location = new System.Drawing.Point(13, 12);
            this.consultaeventoGroupBox.Name = "consultaeventoGroupBox";
            this.consultaeventoGroupBox.Size = new System.Drawing.Size(574, 452);
            this.consultaeventoGroupBox.TabIndex = 12;
            this.consultaeventoGroupBox.TabStop = false;
            // 
            // incluireventoButton
            // 
            this.incluireventoButton.BackColor = System.Drawing.Color.Transparent;
            this.incluireventoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.incluireventoButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incluireventoButton.ForeColor = System.Drawing.Color.Black;
            this.incluireventoButton.Image = ((System.Drawing.Image)(resources.GetObject("incluireventoButton.Image")));
            this.incluireventoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incluireventoButton.Location = new System.Drawing.Point(405, 420);
            this.incluireventoButton.Name = "incluireventoButton";
            this.incluireventoButton.Size = new System.Drawing.Size(69, 26);
            this.incluireventoButton.TabIndex = 23;
            this.incluireventoButton.Text = "Incluir";
            this.incluireventoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.incluireventoButton.UseVisualStyleBackColor = false;
            this.incluireventoButton.Click += new System.EventHandler(this.IncluireventoButton_Click);
            // 
            // detalheseventoButton
            // 
            this.detalheseventoButton.BackColor = System.Drawing.Color.Transparent;
            this.detalheseventoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.detalheseventoButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalheseventoButton.ForeColor = System.Drawing.Color.Black;
            this.detalheseventoButton.Image = ((System.Drawing.Image)(resources.GetObject("detalheseventoButton.Image")));
            this.detalheseventoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detalheseventoButton.Location = new System.Drawing.Point(480, 420);
            this.detalheseventoButton.Name = "detalheseventoButton";
            this.detalheseventoButton.Size = new System.Drawing.Size(85, 26);
            this.detalheseventoButton.TabIndex = 21;
            this.detalheseventoButton.Text = "Detalhes";
            this.detalheseventoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.detalheseventoButton.UseVisualStyleBackColor = false;
            this.detalheseventoButton.Click += new System.EventHandler(this.DetalheseventoButton_Click);
            // 
            // codigoempresaComboBox
            // 
            this.codigoempresaComboBox.DataSource = this.empresaBindingSource;
            this.codigoempresaComboBox.DisplayMember = "Id";
            this.codigoempresaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codigoempresaComboBox.FormattingEnabled = true;
            this.codigoempresaComboBox.Location = new System.Drawing.Point(9, 38);
            this.codigoempresaComboBox.Name = "codigoempresaComboBox";
            this.codigoempresaComboBox.Size = new System.Drawing.Size(72, 25);
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
            this.nomeempresaTextBox.Size = new System.Drawing.Size(276, 22);
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
            // transferivelDataGridViewCheckBoxColumn
            // 
            this.transferivelDataGridViewCheckBoxColumn.DataPropertyName = "Transferivel";
            this.transferivelDataGridViewCheckBoxColumn.HeaderText = "Transferível";
            this.transferivelDataGridViewCheckBoxColumn.Name = "transferivelDataGridViewCheckBoxColumn";
            this.transferivelDataGridViewCheckBoxColumn.ReadOnly = true;
            this.transferivelDataGridViewCheckBoxColumn.Width = 80;
            // 
            // consultaeventoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 471);
            this.Controls.Add(this.consultaeventoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "consultaeventoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Evento";
            this.Load += new System.EventHandler(this.EventomanutencaoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultaeventoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).EndInit();
            this.consultaeventoGroupBox.ResumeLayout(false);
            this.consultaeventoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView consultaeventoGridView;
        private System.Windows.Forms.GroupBox consultaeventoGroupBox;
        private System.Windows.Forms.ComboBox codigoempresaComboBox;
        private System.Windows.Forms.Label nomeempresaLabel;
        private System.Windows.Forms.TextBox nomeempresaTextBox;
        private System.Windows.Forms.Label codigoempresaLabel;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private System.Windows.Forms.BindingSource eventoBindingSource;
        private System.Windows.Forms.Button detalheseventoButton;
        private System.Windows.Forms.Button incluireventoButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn externoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn transferivelDataGridViewCheckBoxColumn;
    }
}