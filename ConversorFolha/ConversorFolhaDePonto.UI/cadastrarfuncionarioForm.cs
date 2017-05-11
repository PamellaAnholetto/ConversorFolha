using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConversorFolhaDePonto.Modelo;
using ConversorFolhaDePonto.BLL;

namespace ConversorFolhaDePonto.UI
{
    public partial class CadastrarfuncionarioForm : Form
    {
        public CadastrarfuncionarioForm(ComboBox CodigoEmpresa, TextBox NomeEmpresa)
        {
            InitializeComponent();
            codigoempresaComboBox.DataSource = CodigoEmpresa.DataSource;
            codigoempresaComboBox.SelectedIndex = CodigoEmpresa.SelectedIndex;
            codigoempresaComboBox.Enabled = false;
            excluirfuncionarioButton.Visible = false;
            alterarfuncionarioButton.Visible = false;
            nomeempresaTextBox.Text = NomeEmpresa.Text;
        }

        public CadastrarfuncionarioForm(DataGridViewCellCollection LinhaSelecionada, ComboBox CodigoEmpresa, TextBox NomeEmpresa)
        {
            InitializeComponent();
            codigoempresaComboBox.DataSource = CodigoEmpresa.DataSource;
            codigoempresaComboBox.SelectedIndex = CodigoEmpresa.SelectedIndex;
            codigoempresaComboBox.Enabled = false;
            incluirfuncionarioButton.Visible = false;
            alterarfuncionarioButton.Location = new Point(243, 97);
            excluirfuncionarioButton.Location = new Point(243, 126);
            nomeempresaTextBox.Text = NomeEmpresa.Text;
            funcionarioexternoTextBox.Text = LinhaSelecionada["externoDataGridViewTextBoxColumn"].Value.ToString();
            funcionariointernoTextBox.Text = LinhaSelecionada["internoDataGridViewTextBoxColumn"].Value.ToString();

        }

        private void CodigoempresaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomeempresaTextBox.Text = codigoempresaComboBox.SelectedValue.ToString();
            Empresa empresaSelecionada = (Empresa)codigoempresaComboBox.SelectedItem;
            if (string.IsNullOrEmpty(codigoempresaComboBox.Text))
            {
                funcionarioGroupBox.Enabled = false;
            }
            else
            {
                funcionarioGroupBox.Enabled = true;
            }
        }
    }
}

/*private void IncluirfuncionarioButton_Click(object sender, EventArgs e)
{
    try
    {
        statusfuncionarioLabel.Text = "Processando...";
        statusfuncionarioLabel.Visible = true;
        List<ErrosTela> ErrosTela = new List<ErrosTela>();
        Utilities.ValidarTextBoxes(funcionarioGroupBox, ref ErrosTela);
        if (ErrosTela.Count() > 0)
        {
            string strCamposInvalidos = Utilities.CriarMensagemErro(funcionarioGroupBox, ErrosTela);
            statusfuncionarioLabel.Text = "Não foi possível incluir...";
            MessageBox.Show("Preencher Campo(s):" + Environment.NewLine + strCamposInvalidos, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
            DataBaseBLL.GravarFuncionario(
                                new Funcionario()
                                {
                                    IdEmpresa = codigoempresaComboBox.Text,
                                    NomeEmpresa = nomeempresaTextBox.Text,
                                    Externo = funcionarioexternoTextBox.Text,
                                    Interno = funcionariointernoTextBox.Text,
                                }
            );
            statusfuncionarioLabel.Text = "Funcionário incluido com sucesso.";
            Utilities.ResetarControles(funcionarioGroupBox);
            funcionarioexternoTextBox.Focus();
        }
    }
    catch (Exception ex)
    {
        if (ex.Message == "23505")
        {
            MessageBox.Show("Funcionário já cadastrado.", ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            statusfuncionarioLabel.Text = "Não foi possível incluir...";
        }
        else
        {
            MessageBox.Show(ex.Message, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            statusfuncionarioLabel.Text = "Não foi possível incluir...";
        }
    }
}*/