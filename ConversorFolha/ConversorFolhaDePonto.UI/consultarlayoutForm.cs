using System;
using System.Windows.Forms;
using ConversorFolhaDePonto.Modelo;
using ConversorFolhaDePonto.BLL;

namespace ConversorFolhaDePonto.UI
{
    public partial class consultarlayoutForm : Form
    {
        public consultarlayoutForm()
        {
            InitializeComponent();
        }

         private void LayoutmanutencaoForm_Load(object sender, EventArgs e)
        {
            nomelayoutComboBox.DataSource = DataBaseBLL.CarregarLayoutComboBox();
        }

        private void NomelayoutComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {            
            Layout layoutSelecionado = (Layout)nomelayoutComboBox.SelectedItem;
            consultalayoutGridView.DataSource = DataBaseBLL.CarregarLayoutGrid(layoutSelecionado.Nome);
            if (string.IsNullOrEmpty(nomelayoutComboBox.Text))
            {
                detalheslayoutButton.Enabled = false;
            }
            else
            {
                detalheslayoutButton.Enabled = true;
            }
        }
        
        private void DetalheslayoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (consultalayoutGridView.SelectedRows.Count == 0) throw new Exception("Selecione um layout.");
                cadastrarlayoutForm objForm = new cadastrarlayoutForm(consultalayoutGridView.SelectedRows[0].Cells, ref nomelayoutComboBox, ref consultalayoutGridView);
                objForm.Show();
            }
            catch (Exception ex)
            {
                MensagemErro(ex);
            }
        }

        public void MensagemErro(Exception ex)
        {
            MessageBox.Show(ex.Message, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
