namespace ConversorFolhaDePonto.UI
{
    partial class cadastrargeralForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrargeralForm));
            this.nomeempresaLabel = new System.Windows.Forms.Label();
            this.incluirempresaButton = new System.Windows.Forms.Button();
            this.codigoempresaLabel = new System.Windows.Forms.Label();
            this.nomeempresaTextBox = new System.Windows.Forms.TextBox();
            this.empresaGroupBox = new System.Windows.Forms.GroupBox();
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
            this.codigoempresaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.eventoGroupBox = new System.Windows.Forms.GroupBox();
            this.eventotrensferivelCheckBox = new System.Windows.Forms.CheckBox();
            this.statuseventoLabel = new System.Windows.Forms.Label();
            this.incluireventoButton = new System.Windows.Forms.Button();
            this.enventointernoTextBox = new System.Windows.Forms.TextBox();
            this.eventoexternoLabel = new System.Windows.Forms.Label();
            this.eventoexternoTextBox = new System.Windows.Forms.TextBox();
            this.eventointernoLabel = new System.Windows.Forms.Label();
            this.funcionarioGroupBox = new System.Windows.Forms.GroupBox();
            this.statusfuncionarioLabel = new System.Windows.Forms.Label();
            this.incluirfuncionarioButton = new System.Windows.Forms.Button();
            this.funcionariointernoTextBox = new System.Windows.Forms.TextBox();
            this.funcionarioexternoLabel = new System.Windows.Forms.Label();
            this.funcionarioexternoTextBox = new System.Windows.Forms.TextBox();
            this.funcionariointernoLabel = new System.Windows.Forms.Label();
            this.novaempresaButton = new System.Windows.Forms.Button();
            this.empresaGroupBox.SuspendLayout();
            this.layoutempresaGroupBox.SuspendLayout();
            this.posicaofuncionarioGroupBox.SuspendLayout();
            this.posicaoeventoGroupBox.SuspendLayout();
            this.posicaohorasGroupBox.SuspendLayout();
            this.eventoGroupBox.SuspendLayout();
            this.funcionarioGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            // incluirempresaButton
            // 
            this.incluirempresaButton.BackColor = System.Drawing.Color.Transparent;
            this.incluirempresaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.incluirempresaButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incluirempresaButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.incluirempresaButton.Image = ((System.Drawing.Image)(resources.GetObject("incluirempresaButton.Image")));
            this.incluirempresaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incluirempresaButton.Location = new System.Drawing.Point(398, 105);
            this.incluirempresaButton.Name = "incluirempresaButton";
            this.incluirempresaButton.Size = new System.Drawing.Size(72, 26);
            this.incluirempresaButton.TabIndex = 4;
            this.incluirempresaButton.Text = "Incluir";
            this.incluirempresaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.incluirempresaButton.UseVisualStyleBackColor = false;
            this.incluirempresaButton.Click += new System.EventHandler(this.IncluirempresaButton_Click);
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
            // nomeempresaTextBox
            // 
            this.nomeempresaTextBox.AccessibleName = "Nome Empresa";
            this.nomeempresaTextBox.Location = new System.Drawing.Point(169, 39);
            this.nomeempresaTextBox.MaxLength = 200;
            this.nomeempresaTextBox.Name = "nomeempresaTextBox";
            this.nomeempresaTextBox.Size = new System.Drawing.Size(335, 22);
            this.nomeempresaTextBox.TabIndex = 3;
            // 
            // empresaGroupBox
            // 
            this.empresaGroupBox.Controls.Add(this.layoutempresaGroupBox);
            this.empresaGroupBox.Controls.Add(this.codigoempresaMaskedTextBox);
            this.empresaGroupBox.Controls.Add(this.nomeempresaTextBox);
            this.empresaGroupBox.Controls.Add(this.codigoempresaLabel);
            this.empresaGroupBox.Controls.Add(this.nomeempresaLabel);
            this.empresaGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresaGroupBox.Location = new System.Drawing.Point(11, 12);
            this.empresaGroupBox.Name = "empresaGroupBox";
            this.empresaGroupBox.Size = new System.Drawing.Size(517, 214);
            this.empresaGroupBox.TabIndex = 0;
            this.empresaGroupBox.TabStop = false;
            this.empresaGroupBox.Text = "Empresa";
            // 
            // layoutempresaGroupBox
            // 
            this.layoutempresaGroupBox.Controls.Add(this.posicaofuncionarioGroupBox);
            this.layoutempresaGroupBox.Controls.Add(this.posicaoeventoGroupBox);
            this.layoutempresaGroupBox.Controls.Add(this.statusempresaLabel);
            this.layoutempresaGroupBox.Controls.Add(this.posicaohorasGroupBox);
            this.layoutempresaGroupBox.Controls.Add(this.incluirempresaButton);
            this.layoutempresaGroupBox.Location = new System.Drawing.Point(15, 67);
            this.layoutempresaGroupBox.Name = "layoutempresaGroupBox";
            this.layoutempresaGroupBox.Size = new System.Drawing.Size(489, 138);
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
            this.posicaofuncionarioGroupBox.Location = new System.Drawing.Point(329, 21);
            this.posicaofuncionarioGroupBox.Name = "posicaofuncionarioGroupBox";
            this.posicaofuncionarioGroupBox.Size = new System.Drawing.Size(141, 77);
            this.posicaofuncionarioGroupBox.TabIndex = 2;
            this.posicaofuncionarioGroupBox.TabStop = false;
            this.posicaofuncionarioGroupBox.Text = "Funcionário";
            // 
            // tamanhofuncionarioTextBox
            // 
            this.tamanhofuncionarioTextBox.AccessibleName = "Tamanho Funcionário";
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
            this.iniciofuncionarioTextBox.AccessibleName = "Inicio Funcionário";
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
            this.posicaoeventoGroupBox.Location = new System.Drawing.Point(20, 21);
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
            this.inicioeventoTextBox.AccessibleName = "Inicio Evento";
            this.inicioeventoTextBox.Location = new System.Drawing.Point(76, 16);
            this.inicioeventoTextBox.MaxLength = 4;
            this.inicioeventoTextBox.Name = "inicioeventoTextBox";
            this.inicioeventoTextBox.Size = new System.Drawing.Size(47, 22);
            this.inicioeventoTextBox.TabIndex = 1;
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
            this.statusempresaLabel.Location = new System.Drawing.Point(19, 114);
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
            this.posicaohorasGroupBox.Location = new System.Drawing.Point(174, 21);
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
            this.tamanhohorasTextBox.AccessibleName = "Tamanho Horas";
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
            // codigoempresaMaskedTextBox
            // 
            this.codigoempresaMaskedTextBox.AccessibleDescription = "";
            this.codigoempresaMaskedTextBox.AccessibleName = "Código Empresa";
            this.codigoempresaMaskedTextBox.Location = new System.Drawing.Point(15, 39);
            this.codigoempresaMaskedTextBox.Mask = "00,0000";
            this.codigoempresaMaskedTextBox.Name = "codigoempresaMaskedTextBox";
            this.codigoempresaMaskedTextBox.Size = new System.Drawing.Size(52, 22);
            this.codigoempresaMaskedTextBox.TabIndex = 1;
            this.codigoempresaMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // eventoGroupBox
            // 
            this.eventoGroupBox.Controls.Add(this.eventotrensferivelCheckBox);
            this.eventoGroupBox.Controls.Add(this.statuseventoLabel);
            this.eventoGroupBox.Controls.Add(this.incluireventoButton);
            this.eventoGroupBox.Controls.Add(this.enventointernoTextBox);
            this.eventoGroupBox.Controls.Add(this.eventoexternoLabel);
            this.eventoGroupBox.Controls.Add(this.eventoexternoTextBox);
            this.eventoGroupBox.Controls.Add(this.eventointernoLabel);
            this.eventoGroupBox.Enabled = false;
            this.eventoGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventoGroupBox.Location = new System.Drawing.Point(10, 232);
            this.eventoGroupBox.Name = "eventoGroupBox";
            this.eventoGroupBox.Size = new System.Drawing.Size(209, 125);
            this.eventoGroupBox.TabIndex = 1;
            this.eventoGroupBox.TabStop = false;
            this.eventoGroupBox.Text = "Evento";
            // 
            // eventotrensferivelCheckBox
            // 
            this.eventotrensferivelCheckBox.AutoSize = true;
            this.eventotrensferivelCheckBox.Location = new System.Drawing.Point(9, 78);
            this.eventotrensferivelCheckBox.Name = "eventotrensferivelCheckBox";
            this.eventotrensferivelCheckBox.Size = new System.Drawing.Size(94, 21);
            this.eventotrensferivelCheckBox.TabIndex = 4;
            this.eventotrensferivelCheckBox.Text = "Transferível";
            this.eventotrensferivelCheckBox.UseVisualStyleBackColor = true;
            // 
            // statuseventoLabel
            // 
            this.statuseventoLabel.AutoSize = true;
            this.statuseventoLabel.Location = new System.Drawing.Point(6, 102);
            this.statuseventoLabel.Name = "statuseventoLabel";
            this.statuseventoLabel.Size = new System.Drawing.Size(45, 17);
            this.statuseventoLabel.TabIndex = 6;
            this.statuseventoLabel.Text = "Status";
            this.statuseventoLabel.Visible = false;
            // 
            // incluireventoButton
            // 
            this.incluireventoButton.BackColor = System.Drawing.Color.Transparent;
            this.incluireventoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.incluireventoButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incluireventoButton.Image = ((System.Drawing.Image)(resources.GetObject("incluireventoButton.Image")));
            this.incluireventoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incluireventoButton.Location = new System.Drawing.Point(128, 20);
            this.incluireventoButton.Name = "incluireventoButton";
            this.incluireventoButton.Size = new System.Drawing.Size(72, 26);
            this.incluireventoButton.TabIndex = 5;
            this.incluireventoButton.Text = "Incluir";
            this.incluireventoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.incluireventoButton.UseVisualStyleBackColor = false;
            this.incluireventoButton.Click += new System.EventHandler(this.IncluireventoButton_Click);
            // 
            // enventointernoTextBox
            // 
            this.enventointernoTextBox.AccessibleName = "Evento Interno";
            this.enventointernoTextBox.Location = new System.Drawing.Point(68, 50);
            this.enventointernoTextBox.MaxLength = 4;
            this.enventointernoTextBox.Name = "enventointernoTextBox";
            this.enventointernoTextBox.Size = new System.Drawing.Size(49, 22);
            this.enventointernoTextBox.TabIndex = 3;
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
            this.eventoexternoTextBox.Location = new System.Drawing.Point(68, 22);
            this.eventoexternoTextBox.MaxLength = 3;
            this.eventoexternoTextBox.Name = "eventoexternoTextBox";
            this.eventoexternoTextBox.Size = new System.Drawing.Size(49, 22);
            this.eventoexternoTextBox.TabIndex = 1;
            // 
            // eventointernoLabel
            // 
            this.eventointernoLabel.AutoSize = true;
            this.eventointernoLabel.Location = new System.Drawing.Point(6, 53);
            this.eventointernoLabel.Name = "eventointernoLabel";
            this.eventointernoLabel.Size = new System.Drawing.Size(50, 17);
            this.eventointernoLabel.TabIndex = 2;
            this.eventointernoLabel.Text = "Interno";
            // 
            // funcionarioGroupBox
            // 
            this.funcionarioGroupBox.Controls.Add(this.statusfuncionarioLabel);
            this.funcionarioGroupBox.Controls.Add(this.incluirfuncionarioButton);
            this.funcionarioGroupBox.Controls.Add(this.funcionariointernoTextBox);
            this.funcionarioGroupBox.Controls.Add(this.funcionarioexternoLabel);
            this.funcionarioGroupBox.Controls.Add(this.funcionarioexternoTextBox);
            this.funcionarioGroupBox.Controls.Add(this.funcionariointernoLabel);
            this.funcionarioGroupBox.Enabled = false;
            this.funcionarioGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionarioGroupBox.Location = new System.Drawing.Point(226, 232);
            this.funcionarioGroupBox.Name = "funcionarioGroupBox";
            this.funcionarioGroupBox.Size = new System.Drawing.Size(207, 125);
            this.funcionarioGroupBox.TabIndex = 2;
            this.funcionarioGroupBox.TabStop = false;
            this.funcionarioGroupBox.Text = "Funcionário";
            // 
            // statusfuncionarioLabel
            // 
            this.statusfuncionarioLabel.AutoSize = true;
            this.statusfuncionarioLabel.Location = new System.Drawing.Point(6, 102);
            this.statusfuncionarioLabel.Name = "statusfuncionarioLabel";
            this.statusfuncionarioLabel.Size = new System.Drawing.Size(45, 17);
            this.statusfuncionarioLabel.TabIndex = 5;
            this.statusfuncionarioLabel.Text = "Status";
            this.statusfuncionarioLabel.Visible = false;
            // 
            // incluirfuncionarioButton
            // 
            this.incluirfuncionarioButton.BackColor = System.Drawing.Color.Transparent;
            this.incluirfuncionarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.incluirfuncionarioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incluirfuncionarioButton.Image = ((System.Drawing.Image)(resources.GetObject("incluirfuncionarioButton.Image")));
            this.incluirfuncionarioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incluirfuncionarioButton.Location = new System.Drawing.Point(124, 20);
            this.incluirfuncionarioButton.Name = "incluirfuncionarioButton";
            this.incluirfuncionarioButton.Size = new System.Drawing.Size(72, 26);
            this.incluirfuncionarioButton.TabIndex = 4;
            this.incluirfuncionarioButton.Text = "Incluir";
            this.incluirfuncionarioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.incluirfuncionarioButton.UseVisualStyleBackColor = false;
            this.incluirfuncionarioButton.Click += new System.EventHandler(this.IncluirfuncionarioButton_Click);
            // 
            // funcionariointernoTextBox
            // 
            this.funcionariointernoTextBox.AccessibleName = "Funcionário Interno";
            this.funcionariointernoTextBox.Location = new System.Drawing.Point(64, 52);
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
            this.funcionarioexternoTextBox.AccessibleName = "Funcionário Externo";
            this.funcionarioexternoTextBox.Location = new System.Drawing.Point(64, 22);
            this.funcionarioexternoTextBox.MaxLength = 6;
            this.funcionarioexternoTextBox.Name = "funcionarioexternoTextBox";
            this.funcionarioexternoTextBox.Size = new System.Drawing.Size(49, 22);
            this.funcionarioexternoTextBox.TabIndex = 1;
            // 
            // funcionariointernoLabel
            // 
            this.funcionariointernoLabel.AutoSize = true;
            this.funcionariointernoLabel.Location = new System.Drawing.Point(6, 53);
            this.funcionariointernoLabel.Name = "funcionariointernoLabel";
            this.funcionariointernoLabel.Size = new System.Drawing.Size(50, 17);
            this.funcionariointernoLabel.TabIndex = 2;
            this.funcionariointernoLabel.Text = "Interno";
            // 
            // novaempresaButton
            // 
            this.novaempresaButton.BackColor = System.Drawing.Color.Transparent;
            this.novaempresaButton.Enabled = false;
            this.novaempresaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.novaempresaButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novaempresaButton.Image = ((System.Drawing.Image)(resources.GetObject("novaempresaButton.Image")));
            this.novaempresaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.novaempresaButton.Location = new System.Drawing.Point(446, 274);
            this.novaempresaButton.Name = "novaempresaButton";
            this.novaempresaButton.Size = new System.Drawing.Size(78, 40);
            this.novaempresaButton.TabIndex = 3;
            this.novaempresaButton.Text = "Nova Empresa";
            this.novaempresaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.novaempresaButton.UseVisualStyleBackColor = false;
            this.novaempresaButton.Click += new System.EventHandler(this.NovaempresaButton_Click);
            // 
            // cadastrargeralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(536, 360);
            this.Controls.Add(this.empresaGroupBox);
            this.Controls.Add(this.eventoGroupBox);
            this.Controls.Add(this.funcionarioGroupBox);
            this.Controls.Add(this.novaempresaButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cadastrargeralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Geral";
            this.Load += new System.EventHandler(this.CadastrogeralForm_Load);
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
            this.eventoGroupBox.ResumeLayout(false);
            this.eventoGroupBox.PerformLayout();
            this.funcionarioGroupBox.ResumeLayout(false);
            this.funcionarioGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nomeempresaLabel;
        private System.Windows.Forms.Button incluirempresaButton;
        private System.Windows.Forms.Label codigoempresaLabel;
        private System.Windows.Forms.TextBox nomeempresaTextBox;
        private System.Windows.Forms.GroupBox empresaGroupBox;
        private System.Windows.Forms.GroupBox funcionarioGroupBox;
        private System.Windows.Forms.Label funcionariointernoLabel;
        private System.Windows.Forms.TextBox funcionarioexternoTextBox;
        private System.Windows.Forms.Label funcionarioexternoLabel;
        private System.Windows.Forms.GroupBox eventoGroupBox;
        private System.Windows.Forms.TextBox enventointernoTextBox;
        private System.Windows.Forms.Label eventointernoLabel;
        private System.Windows.Forms.TextBox eventoexternoTextBox;
        private System.Windows.Forms.Label eventoexternoLabel;
        private System.Windows.Forms.Button novaempresaButton;
        private System.Windows.Forms.TextBox funcionariointernoTextBox;
        private System.Windows.Forms.Button incluireventoButton;
        private System.Windows.Forms.Button incluirfuncionarioButton;
        private System.Windows.Forms.MaskedTextBox codigoempresaMaskedTextBox;
        private System.Windows.Forms.Label statusempresaLabel;
        private System.Windows.Forms.Label statuseventoLabel;
        private System.Windows.Forms.CheckBox eventotrensferivelCheckBox;
        private System.Windows.Forms.Label statusfuncionarioLabel;
        private System.Windows.Forms.GroupBox layoutempresaGroupBox;
        private System.Windows.Forms.GroupBox posicaoeventoGroupBox;
        private System.Windows.Forms.TextBox tamanhoeventoTextBox;
        private System.Windows.Forms.TextBox inicioeventoTextBox;
        private System.Windows.Forms.Label tamanhoeventoLabel;
        private System.Windows.Forms.Label inicioeventoLabel;
        private System.Windows.Forms.GroupBox posicaofuncionarioGroupBox;
        private System.Windows.Forms.TextBox tamanhofuncionarioTextBox;
        private System.Windows.Forms.TextBox iniciofuncionarioTextBox;
        private System.Windows.Forms.Label tamanhofuncionarioLabel;
        private System.Windows.Forms.Label iniciofuncionarioLabel;
        private System.Windows.Forms.GroupBox posicaohorasGroupBox;
        private System.Windows.Forms.TextBox tamanhohorasTextBox;
        private System.Windows.Forms.TextBox iniciohorasTextBox;
        private System.Windows.Forms.Label tamanhovaloreventoLabel;
        private System.Windows.Forms.Label iniciohorasLabel;
    }
}