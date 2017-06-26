using System;
using System.Windows.Forms;
using ConversorFolhaDePonto.Modelo;
using ConversorFolhaDePonto.BLL;

namespace ConversorFolhaDePonto.UI
{
    public partial class consultafuncionarioForm : Form
    {
        public consultafuncionarioForm()
        {
            InitializeComponent();
        }

        private void FuncionariomanutencaoForm_Load(object sender, EventArgs e)
        {
            codigoempresaComboBox.DataSource = DataBaseBLL.CarregarEmpresasComboBox();
            nomeempresaTextBox.Text = codigoempresaComboBox.SelectedValue.ToString();
           //consultafuncionarioGridView.DataSource = DataBaseBLL.CarregarFuncionarioGrid(codigoempresaComboBox.SelectedText);
        }

        private void CodigoempresaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           nomeempresaTextBox.Text = codigoempresaComboBox.SelectedValue.ToString();
           Empresa empresaSelecionada = (Empresa)codigoempresaComboBox.SelectedItem;
           consultafuncionarioGridView.DataSource = DataBaseBLL.CarregarFuncionarioGrid(empresaSelecionada.Id);
            if (string.IsNullOrEmpty(codigoempresaComboBox.Text))
            {
                detalhesfuncionarioButton.Enabled = false;
                incluirfuncionarioButton.Enabled = false;
            }
            else
            {
                detalhesfuncionarioButton.Enabled = true;
                incluirfuncionarioButton.Enabled = true;
            }
        }   

        private void DetalhesfuncionarioButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (consultafuncionarioGridView.SelectedRows.Count == 0) throw new Exception("Selecione um funcionário.");
                cadastrarfuncionarioForm objForm = new cadastrarfuncionarioForm(consultafuncionarioGridView.SelectedRows[0].Cells, codigoempresaComboBox, nomeempresaTextBox, ref consultafuncionarioGridView);
                objForm.Show();
            }
            catch (Exception ex)
            {
                MensagemErro(ex);
            }
        }

        private void incluirfuncionarioButton_Click(object sender, EventArgs e)
        {
            try
            {
                cadastrarfuncionarioForm objForm = new cadastrarfuncionarioForm(codigoempresaComboBox, nomeempresaTextBox, ref consultafuncionarioGridView);
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
