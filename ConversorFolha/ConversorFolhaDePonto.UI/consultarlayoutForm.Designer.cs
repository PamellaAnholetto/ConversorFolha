namespace ConversorFolhaDePonto.UI
{
    partial class consultarlayoutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultarlayoutForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.consultalayoutGroupBox = new System.Windows.Forms.GroupBox();
            this.detalheslayoutButton = new System.Windows.Forms.Button();
            this.nomelayoutComboBox = new System.Windows.Forms.ComboBox();
            this.layoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultalayoutGridView = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioHorasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoHorasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomelayoutLabel = new System.Windows.Forms.Label();
            this.consultalayoutGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultalayoutGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // consultalayoutGroupBox
            // 
            this.consultalayoutGroupBox.Controls.Add(this.detalheslayoutButton);
            this.consultalayoutGroupBox.Controls.Add(this.nomelayoutComboBox);
            this.consultalayoutGroupBox.Controls.Add(this.consultalayoutGridView);
            this.consultalayoutGroupBox.Controls.Add(this.nomelayoutLabel);
            this.consultalayoutGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultalayoutGroupBox.Location = new System.Drawing.Point(12, 12);
            this.consultalayoutGroupBox.Name = "consultalayoutGroupBox";
            this.consultalayoutGroupBox.Size = new System.Drawing.Size(869, 457);
            this.consultalayoutGroupBox.TabIndex = 13;
            this.consultalayoutGroupBox.TabStop = false;
            // 
            // detalheslayoutButton
            // 
            this.detalheslayoutButton.BackColor = System.Drawing.Color.Transparent;
            this.detalheslayoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.detalheslayoutButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalheslayoutButton.ForeColor = System.Drawing.Color.Black;
            this.detalheslayoutButton.Image = ((System.Drawing.Image)(resources.GetObject("detalheslayoutButton.Image")));
            this.detalheslayoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detalheslayoutButton.Location = new System.Drawing.Point(774, 424);
            this.detalheslayoutButton.Name = "detalheslayoutButton";
            this.detalheslayoutButton.Size = new System.Drawing.Size(85, 26);
            this.detalheslayoutButton.TabIndex = 24;
            this.detalheslayoutButton.Text = "Detalhes";
            this.detalheslayoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.detalheslayoutButton.UseVisualStyleBackColor = false;
            this.detalheslayoutButton.Click += new System.EventHandler(this.DetalheslayoutButton_Click);
            // 
            // nomelayoutComboBox
            // 
            this.nomelayoutComboBox.DataSource = this.layoutBindingSource;
            this.nomelayoutComboBox.DisplayMember = "Nome";
            this.nomelayoutComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nomelayoutComboBox.FormattingEnabled = true;
            this.nomelayoutComboBox.Location = new System.Drawing.Point(9, 38);
            this.nomelayoutComboBox.Name = "nomelayoutComboBox";
            this.nomelayoutComboBox.Size = new System.Drawing.Size(252, 25);
            this.nomelayoutComboBox.TabIndex = 14;
            this.nomelayoutComboBox.ValueMember = "Nome";
            this.nomelayoutComboBox.SelectedIndexChanged += new System.EventHandler(this.NomelayoutComboBox_SelectedIndexChanged);
            // 
            // layoutBindingSource
            // 
            this.layoutBindingSource.DataSource = typeof(ConversorFolhaDePonto.Modelo.Layout);
            // 
            // consultalayoutGridView
            // 
            this.consultalayoutGridView.AllowUserToAddRows = false;
            this.consultalayoutGridView.AllowUserToDeleteRows = false;
            this.consultalayoutGridView.AllowUserToResizeColumns = false;
            this.consultalayoutGridView.AllowUserToResizeRows = false;
            this.consultalayoutGridView.AutoGenerateColumns = false;
            this.consultalayoutGridView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.consultalayoutGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.consultalayoutGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.consultalayoutGridView.ColumnHeadersHeight = 60;
            this.consultalayoutGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.consultalayoutGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.inicioEmpresaDataGridViewTextBoxColumn,
            this.tamanhoEmpresaDataGridViewTextBoxColumn,
            this.inicioFuncionarioDataGridViewTextBoxColumn,
            this.tamanhoFuncionarioDataGridViewTextBoxColumn,
            this.inicioEventoDataGridViewTextBoxColumn,
            this.tamanhoEventoDataGridViewTextBoxColumn,
            this.inicioHorasDataGridViewTextBoxColumn,
            this.tamanhoHorasDataGridViewTextBoxColumn});
            this.consultalayoutGridView.DataSource = this.layoutBindingSource;
            this.consultalayoutGridView.Location = new System.Drawing.Point(9, 69);
            this.consultalayoutGridView.Name = "consultalayoutGridView";
            this.consultalayoutGridView.ReadOnly = true;
            this.consultalayoutGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.consultalayoutGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.consultalayoutGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consultalayoutGridView.Size = new System.Drawing.Size(850, 350);
            this.consultalayoutGridView.TabIndex = 4;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // inicioEmpresaDataGridViewTextBoxColumn
            // 
            this.inicioEmpresaDataGridViewTextBoxColumn.DataPropertyName = "InicioEmpresa";
            this.inicioEmpresaDataGridViewTextBoxColumn.HeaderText = "Início Empresa";
            this.inicioEmpresaDataGridViewTextBoxColumn.Name = "inicioEmpresaDataGridViewTextBoxColumn";
            this.inicioEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.inicioEmpresaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.inicioEmpresaDataGridViewTextBoxColumn.Width = 70;
            // 
            // tamanhoEmpresaDataGridViewTextBoxColumn
            // 
            this.tamanhoEmpresaDataGridViewTextBoxColumn.DataPropertyName = "TamanhoEmpresa";
            this.tamanhoEmpresaDataGridViewTextBoxColumn.HeaderText = "Tamanho Empresa";
            this.tamanhoEmpresaDataGridViewTextBoxColumn.Name = "tamanhoEmpresaDataGridViewTextBoxColumn";
            this.tamanhoEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tamanhoEmpresaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tamanhoEmpresaDataGridViewTextBoxColumn.Width = 80;
            // 
            // inicioFuncionarioDataGridViewTextBoxColumn
            // 
            this.inicioFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "InicioFuncionario";
            this.inicioFuncionarioDataGridViewTextBoxColumn.HeaderText = "Inicio Funcionário";
            this.inicioFuncionarioDataGridViewTextBoxColumn.Name = "inicioFuncionarioDataGridViewTextBoxColumn";
            this.inicioFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.inicioFuncionarioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.inicioFuncionarioDataGridViewTextBoxColumn.Width = 80;
            // 
            // tamanhoFuncionarioDataGridViewTextBoxColumn
            // 
            this.tamanhoFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "TamanhoFuncionario";
            this.tamanhoFuncionarioDataGridViewTextBoxColumn.HeaderText = "Tamanho Funcionário";
            this.tamanhoFuncionarioDataGridViewTextBoxColumn.Name = "tamanhoFuncionarioDataGridViewTextBoxColumn";
            this.tamanhoFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.tamanhoFuncionarioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tamanhoFuncionarioDataGridViewTextBoxColumn.Width = 80;
            // 
            // inicioEventoDataGridViewTextBoxColumn
            // 
            this.inicioEventoDataGridViewTextBoxColumn.DataPropertyName = "InicioEvento";
            this.inicioEventoDataGridViewTextBoxColumn.HeaderText = "Início Evento";
            this.inicioEventoDataGridViewTextBoxColumn.Name = "inicioEventoDataGridViewTextBoxColumn";
            this.inicioEventoDataGridViewTextBoxColumn.ReadOnly = true;
            this.inicioEventoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.inicioEventoDataGridViewTextBoxColumn.Width = 70;
            // 
            // tamanhoEventoDataGridViewTextBoxColumn
            // 
            this.tamanhoEventoDataGridViewTextBoxColumn.DataPropertyName = "TamanhoEvento";
            this.tamanhoEventoDataGridViewTextBoxColumn.HeaderText = "Tamanho Evento";
            this.tamanhoEventoDataGridViewTextBoxColumn.Name = "tamanhoEventoDataGridViewTextBoxColumn";
            this.tamanhoEventoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tamanhoEventoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tamanhoEventoDataGridViewTextBoxColumn.Width = 80;
            // 
            // inicioHorasDataGridViewTextBoxColumn
            // 
            this.inicioHorasDataGridViewTextBoxColumn.DataPropertyName = "InicioHoras";
            this.inicioHorasDataGridViewTextBoxColumn.HeaderText = "Início Horas";
            this.inicioHorasDataGridViewTextBoxColumn.Name = "inicioHorasDataGridViewTextBoxColumn";
            this.inicioHorasDataGridViewTextBoxColumn.ReadOnly = true;
            this.inicioHorasDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.inicioHorasDataGridViewTextBoxColumn.Width = 60;
            // 
            // tamanhoHorasDataGridViewTextBoxColumn
            // 
            this.tamanhoHorasDataGridViewTextBoxColumn.DataPropertyName = "TamanhoHoras";
            this.tamanhoHorasDataGridViewTextBoxColumn.HeaderText = "Tamanho Horas";
            this.tamanhoHorasDataGridViewTextBoxColumn.Name = "tamanhoHorasDataGridViewTextBoxColumn";
            this.tamanhoHorasDataGridViewTextBoxColumn.ReadOnly = true;
            this.tamanhoHorasDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tamanhoHorasDataGridViewTextBoxColumn.Width = 70;
            // 
            // nomelayoutLabel
            // 
            this.nomelayoutLabel.AutoSize = true;
            this.nomelayoutLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomelayoutLabel.Location = new System.Drawing.Point(6, 18);
            this.nomelayoutLabel.Name = "nomelayoutLabel";
            this.nomelayoutLabel.Size = new System.Drawing.Size(87, 17);
            this.nomelayoutLabel.TabIndex = 9;
            this.nomelayoutLabel.Text = "Nome Layout";
            // 
            // consultarlayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 475);
            this.Controls.Add(this.consultalayoutGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "consultarlayoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Layout";
            this.Load += new System.EventHandler(this.LayoutmanutencaoForm_Load);
            this.consultalayoutGroupBox.ResumeLayout(false);
            this.consultalayoutGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultalayoutGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox consultalayoutGroupBox;
        private System.Windows.Forms.ComboBox nomelayoutComboBox;
        private System.Windows.Forms.DataGridView consultalayoutGridView;
        private System.Windows.Forms.Label nomelayoutLabel;
        private System.Windows.Forms.BindingSource layoutBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioEventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoEventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioHorasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoHorasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button detalheslayoutButton;
    }
}