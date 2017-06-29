using System; 
using System.Windows.Forms;
using ConversorFolhaDePonto.BLL;
using ConversorFolhaDePonto.Modelo;

namespace ConversorFolhaDePonto.UI
{
    public partial class ConsultarempresaForm : Form
    {
        public ConsultarempresaForm()
        {
            InitializeComponent();
        }

        private void EmpresamanutencaoForm_Load(object sender, EventArgs e)
        {
            codigoempresaComboBox.DataSource = DataBaseBLL.CarregarEmpresasComboBox();
            nomeempresaTextBox.Text = codigoempresaComboBox.SelectedValue.ToString();
            //consultaempresaGridView.DataSource = DataBaseBLL.CarregarEmpresaGrid(codigoempresaComboBox.SelectedText);
        }

        private void CodigoempresaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomeempresaTextBox.Text = codigoempresaComboBox.SelectedValue.ToString();
            Empresa empresaSelecionada = (Empresa)codigoempresaComboBox.SelectedItem;
            consultaempresaGridView.DataSource = DataBaseBLL.CarregarEmpresaGrid(empresaSelecionada.Id);
            if(string.IsNullOrEmpty(codigoempresaComboBox.Text))
            {
                detalhesempresaButton.Enabled = false;                
            }
            else
            {
                detalhesempresaButton.Enabled = true;                
            }
        }

        private void DetalhesempresaButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (consultaempresaGridView.SelectedRows.Count == 0) throw new Exception("Selecione uma empresa.");
                manutencaoempresaForm objForm = new manutencaoempresaForm(consultaempresaGridView.SelectedRows[0].Cells, codigoempresaComboBox, nomeempresaTextBox, ref consultaempresaGridView, ref codigoempresaComboBox);
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
