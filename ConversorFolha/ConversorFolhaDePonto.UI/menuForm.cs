using System;
using System.Windows.Forms;
using System.IO;

namespace ConversorFolhaDePonto.UI
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }
        private void conversaoStripMenuItem_Click(object sender, EventArgs e)
        {
            converterlayoutForm objForm = new converterlayoutForm();
            objForm.Show();
        }

        private void empresaStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarempresaForm objForm = new ConsultarempresaForm();
            objForm.Show();
        }

        private void eventoStripMenuItem_Click(object sender, EventArgs e)
        {
           consultaeventoForm objForm = new consultaeventoForm();
            objForm.Show();
        }

        private void funcionarioStripMenuItem_Click(object sender, EventArgs e)
        {
            consultafuncionarioForm objForm = new consultafuncionarioForm();
            objForm.Show();
        }

        private void novaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrargeralForm objForm = new cadastrargeralForm();
            objForm.Show();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\Manual_ConversorPonto_OFICIAL.pdf");
        }

        private void layoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrarlayoutForm objForm = new cadastrarlayoutForm();
            objForm.Show();
        }

        private void layoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           consultarlayoutForm objForm = new consultarlayoutForm();
            objForm.Show();
        }
    }
}