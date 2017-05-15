using System;
using System.Windows.Forms;
using ConversorFolhaDePonto.Modelo;
using ConversorFolhaDePonto.BLL;

namespace ConversorFolhaDePonto.UI
{
    public partial class consultaeventoForm : Form
    {
        public consultaeventoForm ()
        {
            InitializeComponent();
        }

        private void EventomanutencaoForm_Load(object sender, EventArgs e)
        {
            codigoempresaComboBox.DataSource = DataBaseBLL.CarregarEmpresasComboBox();
            nomeempresaTextBox.Text = codigoempresaComboBox.SelectedValue.ToString();
            //consultaeventoGridView.DataSource = DataBaseBLL.CarregarEventoGrid(codigoempresaComboBox.SelectedText);
        }

        private void CodigoempresaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomeempresaTextBox.Text = codigoempresaComboBox.SelectedValue.ToString();
            Empresa empresaSelecionada = (Empresa)codigoempresaComboBox.SelectedItem;
            consultaeventoGridView.DataSource = DataBaseBLL.CarregarEventoGrid(empresaSelecionada.Id);
            if (string.IsNullOrEmpty(codigoempresaComboBox.Text))
            {
                detalheseventoButton.Enabled = false;
                incluireventoButton.Enabled = false;
            }
            else
            {
                detalheseventoButton.Enabled = true;
                incluireventoButton.Enabled = true;
            }
        }

        private void DetalheseventoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (consultaeventoGridView.SelectedRows.Count == 0) throw new Exception("Selecione uma empresa.");
                cadastrareventoForm objForm = new cadastrareventoForm(consultaeventoGridView.SelectedRows[0].Cells, codigoempresaComboBox, nomeempresaTextBox, ref consultaeventoGridView);
                objForm.Show();
            }
            catch (Exception ex)
            {
                MensagemErro(ex);
            }
        }       

        private void IncluireventoButton_Click(object sender, EventArgs e)
        {
            try
            {
                cadastrareventoForm objForm = new cadastrareventoForm(codigoempresaComboBox, nomeempresaTextBox, ref consultaeventoGridView);
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
