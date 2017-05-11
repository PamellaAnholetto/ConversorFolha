namespace ConversorFolhaDePonto.UI
{
    partial class ConsultarempresaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarempresaForm));
            this.consultaempresaGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioHorasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoHorasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaempresaGroupBox = new System.Windows.Forms.GroupBox();
            this.detalhesempresaButton = new System.Windows.Forms.Button();
            this.codigoempresaComboBox = new System.Windows.Forms.ComboBox();
            this.nomeempresaLabel = new System.Windows.Forms.Label();
            this.nomeempresaTextBox = new System.Windows.Forms.TextBox();
            this.codigoempresaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultaempresaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            this.consultaempresaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // consultaempresaGridView
            // 
            this.consultaempresaGridView.AllowUserToAddRows = false;
            this.consultaempresaGridView.AllowUserToDeleteRows = false;
            this.consultaempresaGridView.AllowUserToResizeColumns = false;
            this.consultaempresaGridView.AllowUserToResizeRows = false;
            this.consultaempresaGridView.AutoGenerateColumns = false;
            this.consultaempresaGridView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.consultaempresaGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.consultaempresaGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.consultaempresaGridView.ColumnHeadersHeight = 60;
            this.consultaempresaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.consultaempresaGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.inicioEventoDataGridViewTextBoxColumn,
            this.tamanhoEventoDataGridViewTextBoxColumn,
            this.inicioFuncionarioDataGridViewTextBoxColumn,
            this.tamanhoFuncionarioDataGridViewTextBoxColumn,
            this.inicioHorasDataGridViewTextBoxColumn,
            this.tamanhoHorasDataGridViewTextBoxColumn});
            this.consultaempresaGridView.DataSource = this.empresaBindingSource;
            this.consultaempresaGridView.Location = new System.Drawing.Point(9, 67);
            this.consultaempresaGridView.Name = "consultaempresaGridView";
            this.consultaempresaGridView.ReadOnly = true;
            this.consultaempresaGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.consultaempresaGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.consultaempresaGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consultaempresaGridView.Size = new System.Drawing.Size(789, 315);
            this.consultaempresaGridView.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Código Empresa";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 80;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome Empresa";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // inicioEventoDataGridViewTextBoxColumn
            // 
            this.inicioEventoDataGridViewTextBoxColumn.DataPropertyName = "InicioEvento";
            this.inicioEventoDataGridViewTextBoxColumn.HeaderText = "Início Evento";
            this.inicioEventoDataGridViewTextBoxColumn.Name = "inicioEventoDataGridViewTextBoxColumn";
            this.inicioEventoDataGridViewTextBoxColumn.ReadOnly = true;
            this.inicioEventoDataGridViewTextBoxColumn.Width = 65;
            // 
            // tamanhoEventoDataGridViewTextBoxColumn
            // 
            this.tamanhoEventoDataGridViewTextBoxColumn.DataPropertyName = "TamanhoEvento";
            this.tamanhoEventoDataGridViewTextBoxColumn.HeaderText = "Tamanho Evento";
            this.tamanhoEventoDataGridViewTextBoxColumn.Name = "tamanhoEventoDataGridViewTextBoxColumn";
            this.tamanhoEventoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tamanhoEventoDataGridViewTextBoxColumn.Width = 80;
            // 
            // inicioFuncionarioDataGridViewTextBoxColumn
            // 
            this.inicioFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "InicioFuncionario";
            this.inicioFuncionarioDataGridViewTextBoxColumn.HeaderText = "Início Funcionário";
            this.inicioFuncionarioDataGridViewTextBoxColumn.Name = "inicioFuncionarioDataGridViewTextBoxColumn";
            this.inicioFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.inicioFuncionarioDataGridViewTextBoxColumn.Width = 80;
            // 
            // tamanhoFuncionarioDataGridViewTextBoxColumn
            // 
            this.tamanhoFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "TamanhoFuncionario";
            this.tamanhoFuncionarioDataGridViewTextBoxColumn.HeaderText = "Tamanho Funcionário";
            this.tamanhoFuncionarioDataGridViewTextBoxColumn.Name = "tamanhoFuncionarioDataGridViewTextBoxColumn";
            this.tamanhoFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.tamanhoFuncionarioDataGridViewTextBoxColumn.Width = 80;
            // 
            // inicioHorasDataGridViewTextBoxColumn
            // 
            this.inicioHorasDataGridViewTextBoxColumn.DataPropertyName = "InicioHoras";
            this.inicioHorasDataGridViewTextBoxColumn.HeaderText = "Início Horas";
            this.inicioHorasDataGridViewTextBoxColumn.Name = "inicioHorasDataGridViewTextBoxColumn";
            this.inicioHorasDataGridViewTextBoxColumn.ReadOnly = true;
            this.inicioHorasDataGridViewTextBoxColumn.Width = 60;
            // 
            // tamanhoHorasDataGridViewTextBoxColumn
            // 
            this.tamanhoHorasDataGridViewTextBoxColumn.DataPropertyName = "TamanhoHoras";
            this.tamanhoHorasDataGridViewTextBoxColumn.HeaderText = "Tamanho Horas";
            this.tamanhoHorasDataGridViewTextBoxColumn.Name = "tamanhoHorasDataGridViewTextBoxColumn";
            this.tamanhoHorasDataGridViewTextBoxColumn.ReadOnly = true;
            this.tamanhoHorasDataGridViewTextBoxColumn.Width = 80;
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataSource = typeof(ConversorFolhaDePonto.Modelo.Empresa);
            // 
            // consultaempresaGroupBox
            // 
            this.consultaempresaGroupBox.Controls.Add(this.detalhesempresaButton);
            this.consultaempresaGroupBox.Controls.Add(this.codigoempresaComboBox);
            this.consultaempresaGroupBox.Controls.Add(this.consultaempresaGridView);
            this.consultaempresaGroupBox.Controls.Add(this.nomeempresaLabel);
            this.consultaempresaGroupBox.Controls.Add(this.nomeempresaTextBox);
            this.consultaempresaGroupBox.Controls.Add(this.codigoempresaLabel);
            this.consultaempresaGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaempresaGroupBox.Location = new System.Drawing.Point(12, 12);
            this.consultaempresaGroupBox.Name = "consultaempresaGroupBox";
            this.consultaempresaGroupBox.Size = new System.Drawing.Size(808, 421);
            this.consultaempresaGroupBox.TabIndex = 18;
            this.consultaempresaGroupBox.TabStop = false;
            // 
            // detalhesempresaButton
            // 
            this.detalhesempresaButton.BackColor = System.Drawing.Color.Transparent;
            this.detalhesempresaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.detalhesempresaButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalhesempresaButton.ForeColor = System.Drawing.Color.Black;
            this.detalhesempresaButton.Image = ((System.Drawing.Image)(resources.GetObject("detalhesempresaButton.Image")));
            this.detalhesempresaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detalhesempresaButton.Location = new System.Drawing.Point(713, 388);
            this.detalhesempresaButton.Name = "detalhesempresaButton";
            this.detalhesempresaButton.Size = new System.Drawing.Size(85, 26);
            this.detalhesempresaButton.TabIndex = 22;
            this.detalhesempresaButton.Text = "Detalhes";
            this.detalhesempresaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.detalhesempresaButton.UseVisualStyleBackColor = false;
            this.detalhesempresaButton.Click += new System.EventHandler(this.DetalhesempresaButton_Click);
            // 
            // codigoempresaComboBox
            // 
            this.codigoempresaComboBox.DataSource = this.empresaBindingSource;
            this.codigoempresaComboBox.DisplayMember = "Id";
            this.codigoempresaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codigoempresaComboBox.FormattingEnabled = true;
            this.codigoempresaComboBox.Location = new System.Drawing.Point(9, 36);
            this.codigoempresaComboBox.Name = "codigoempresaComboBox";
            this.codigoempresaComboBox.Size = new System.Drawing.Size(71, 25);
            this.codigoempresaComboBox.TabIndex = 14;
            this.codigoempresaComboBox.ValueMember = "Nome";
            this.codigoempresaComboBox.SelectedIndexChanged += new System.EventHandler(this.CodigoempresaComboBox_SelectedIndexChanged);
            // 
            // nomeempresaLabel
            // 
            this.nomeempresaLabel.AutoSize = true;
            this.nomeempresaLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeempresaLabel.Location = new System.Drawing.Point(126, 19);
            this.nomeempresaLabel.Name = "nomeempresaLabel";
            this.nomeempresaLabel.Size = new System.Drawing.Size(97, 17);
            this.nomeempresaLabel.TabIndex = 9;
            this.nomeempresaLabel.Text = "Nome Empresa";
            // 
            // nomeempresaTextBox
            // 
            this.nomeempresaTextBox.AccessibleName = "Nome da Empresa";
            this.nomeempresaTextBox.Enabled = false;
            this.nomeempresaTextBox.Location = new System.Drawing.Point(129, 39);
            this.nomeempresaTextBox.Name = "nomeempresaTextBox";
            this.nomeempresaTextBox.Size = new System.Drawing.Size(280, 22);
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
            // ConsultarempresaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 442);
            this.Controls.Add(this.consultaempresaGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultarempresaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Empresa";
            this.Load += new System.EventHandler(this.EmpresamanutencaoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultaempresaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            this.consultaempresaGroupBox.ResumeLayout(false);
            this.consultaempresaGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView consultaempresaGridView;
        private System.Windows.Forms.GroupBox consultaempresaGroupBox;
        private System.Windows.Forms.ComboBox codigoempresaComboBox;
        private System.Windows.Forms.Label nomeempresaLabel;
        private System.Windows.Forms.TextBox nomeempresaTextBox;
        private System.Windows.Forms.Label codigoempresaLabel;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private System.Windows.Forms.Button detalhesempresaButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioEventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoEventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioHorasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoHorasDataGridViewTextBoxColumn;
    }
}