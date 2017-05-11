namespace ConversorFolhaDePonto.UI
{
    partial class menuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuForm));
            this.menuMenuStrip = new System.Windows.Forms.MenuStrip();
            this.cadastroStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaempresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversaoStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutencaoStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMenuStrip
            // 
            this.menuMenuStrip.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroStripMenuItem,
            this.conversaoStripMenuItem,
            this.manutencaoStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuMenuStrip.Name = "menuMenuStrip";
            this.menuMenuStrip.Size = new System.Drawing.Size(905, 25);
            this.menuMenuStrip.TabIndex = 0;
            this.menuMenuStrip.Text = "Cadastro";
            // 
            // cadastroStripMenuItem
            // 
            this.cadastroStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layoutToolStripMenuItem,
            this.novaempresaToolStripMenuItem});
            this.cadastroStripMenuItem.Name = "cadastroStripMenuItem";
            this.cadastroStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.cadastroStripMenuItem.Text = "Cadastro";
            // 
            // layoutToolStripMenuItem
            // 
            this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
            this.layoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.layoutToolStripMenuItem.Text = "Layout";
            this.layoutToolStripMenuItem.ToolTipText = "Cadastro completo do layout";
            this.layoutToolStripMenuItem.Click += new System.EventHandler(this.layoutToolStripMenuItem_Click);
            // 
            // novaempresaToolStripMenuItem
            // 
            this.novaempresaToolStripMenuItem.Name = "novaempresaToolStripMenuItem";
            this.novaempresaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.novaempresaToolStripMenuItem.Text = "Geral";
            this.novaempresaToolStripMenuItem.ToolTipText = "Cadastro completo das empresas";
            this.novaempresaToolStripMenuItem.Click += new System.EventHandler(this.novaEmpresaToolStripMenuItem_Click);
            // 
            // conversaoStripMenuItem
            // 
            this.conversaoStripMenuItem.Name = "conversaoStripMenuItem";
            this.conversaoStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.conversaoStripMenuItem.Text = "Conversão";
            this.conversaoStripMenuItem.ToolTipText = "Realiza a conversão do arquivo da folha de ponto.";
            this.conversaoStripMenuItem.Click += new System.EventHandler(this.conversaoStripMenuItem_Click);
            // 
            // manutencaoStripMenuItem
            // 
            this.manutencaoStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layoutToolStripMenuItem1,
            this.eventosStripMenuItem,
            this.empresasStripMenuItem,
            this.funcionariosStripMenuItem});
            this.manutencaoStripMenuItem.Name = "manutencaoStripMenuItem";
            this.manutencaoStripMenuItem.Size = new System.Drawing.Size(97, 21);
            this.manutencaoStripMenuItem.Text = "Manutenção";
            // 
            // layoutToolStripMenuItem1
            // 
            this.layoutToolStripMenuItem1.Name = "layoutToolStripMenuItem1";
            this.layoutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.layoutToolStripMenuItem1.Text = "Layout";
            this.layoutToolStripMenuItem1.ToolTipText = "Consulta dos layouts cadastrados";
            this.layoutToolStripMenuItem1.Click += new System.EventHandler(this.layoutToolStripMenuItem1_Click);
            // 
            // eventosStripMenuItem
            // 
            this.eventosStripMenuItem.Name = "eventosStripMenuItem";
            this.eventosStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eventosStripMenuItem.Text = "Eventos";
            this.eventosStripMenuItem.ToolTipText = "Consulta dos eventos cadastrados";
            this.eventosStripMenuItem.Click += new System.EventHandler(this.eventoStripMenuItem_Click);
            // 
            // empresasStripMenuItem
            // 
            this.empresasStripMenuItem.Name = "empresasStripMenuItem";
            this.empresasStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.empresasStripMenuItem.Text = "Empresas";
            this.empresasStripMenuItem.ToolTipText = "Consulta das empresas cadastradas";
            this.empresasStripMenuItem.Click += new System.EventHandler(this.empresaStripMenuItem_Click);
            // 
            // funcionariosStripMenuItem
            // 
            this.funcionariosStripMenuItem.Name = "funcionariosStripMenuItem";
            this.funcionariosStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.funcionariosStripMenuItem.Text = "Funcionários";
            this.funcionariosStripMenuItem.ToolTipText = "Consulta dos funcionários cadastrados";
            this.funcionariosStripMenuItem.Click += new System.EventHandler(this.funcionarioStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(905, 614);
            this.Controls.Add(this.menuMenuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "menuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Ponto";
            this.menuMenuStrip.ResumeLayout(false);
            this.menuMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem conversaoStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutencaoStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaempresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layoutToolStripMenuItem1;
    }
}