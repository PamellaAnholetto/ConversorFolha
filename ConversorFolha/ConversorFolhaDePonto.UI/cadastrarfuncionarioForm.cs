using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ConversorFolhaDePonto.Modelo;
using ConversorFolhaDePonto.BLL;

namespace ConversorFolhaDePonto.UI
{
    public partial class cadastrarfuncionarioForm : Form
    {
        public DataGridViewCellCollection linhaSelecionada;
        private DataGridView consultafuncionarioGridView;
        public cadastrarfuncionarioForm(ComboBox CodigoEmpresa, TextBox NomeEmpresa, ref DataGridView ConsultafuncionarioGridView)
        {
            InitializeComponent();
            codigoempresaComboBox.DataSource = CodigoEmpresa.DataSource;
            codigoempresaComboBox.SelectedIndex = CodigoEmpresa.SelectedIndex;
            codigoempresaComboBox.Enabled = false;
            excluirfuncionarioButton.Visible = false;
            alterarfuncionarioButton.Visible = false;
            nomeempresaTextBox.Text = NomeEmpresa.Text;
            consultafuncionarioGridView = ConsultafuncionarioGridView;
        }

        public cadastrarfuncionarioForm(DataGridViewCellCollection LinhaSelecionada, ComboBox CodigoEmpresa, TextBox NomeEmpresa, ref DataGridView ConsultafuncionarioGridView)
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
            linhaSelecionada = LinhaSelecionada;
            consultafuncionarioGridView = ConsultafuncionarioGridView;
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

        private void IncluirfuncionarioButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja incluir esse funcionário?", ParametroInfo.SistemaVersao, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                        MessageBox.Show("Funcionário incluido com sucesso!", ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Utilities.ResetarControles(funcionarioGroupBox);
                        funcionarioexternoTextBox.Focus();
                        Close();
                    }
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
        }

        private void AlterarfuncionarioButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja alterar esse funcionário?", ParametroInfo.SistemaVersao, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    statusfuncionarioLabel.Text = "Processando...";
                    statusfuncionarioLabel.Visible = true;
                    List<ErrosTela> ErrosTela = new List<ErrosTela>();
                    Utilities.ValidarTextBoxes(funcionarioGroupBox, ref ErrosTela);
                    if (ErrosTela.Count() > 0)
                    {
                        string strCamposInvalidos = Utilities.CriarMensagemErro(funcionarioGroupBox, ErrosTela);
                        statusfuncionarioLabel.Text = "Não foi possível alterar...";
                        MessageBox.Show("Preencher Campo(s):" + Environment.NewLine + strCamposInvalidos, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DataBaseBLL.AlterarFuncionario(
                                   new Funcionario()
                                   {
                                       IdEmpresa = codigoempresaComboBox.Text,
                                       NomeEmpresa = nomeempresaTextBox.Text,
                                       Externo = funcionarioexternoTextBox.Text,
                                       Interno = funcionariointernoTextBox.Text,

                                   }, linhaSelecionada["externoDataGridViewTextBoxColumn"].Value.ToString()
                        );
                        statusfuncionarioLabel.Text = "Funcionário alterado com sucesso.";
                        MessageBox.Show("Funcionário alterado com sucesso!", ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Utilities.ResetarControles(funcionarioGroupBox);
                        funcionarioexternoTextBox.Focus();
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "23505")
                {
                    MessageBox.Show("Funcionário já cadastrado.", ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    statusfuncionarioLabel.Text = "Não foi possível alterar...";
                }
                else
                {
                    MessageBox.Show(ex.Message, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    statusfuncionarioLabel.Text = "Não foi possível alterar...";
                }
            }
        }

        private void FuncionarioexternoTextBox_TextChanged(object sender, EventArgs e)
        {
            funcionarioexternoTextBox.TextChanged += FuncionarioAlterado;
        }

        private void FuncionariointernoTextBox_TextChanged(object sender, EventArgs e)
        {
            funcionariointernoTextBox.TextChanged += FuncionarioAlterado;
        }

        private void FuncionarioAlterado(object sender, EventArgs e)
        {
            alterarfuncionarioButton.Enabled = true;
        }

        private void CadastrarfuncionarioForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            consultafuncionarioGridView.DataSource = DataBaseBLL.CarregarFuncionarioGrid(codigoempresaComboBox.Text);
        }

        private void ExcluirfuncionarioButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir esse funcionário?", ParametroInfo.SistemaVersao, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataBaseBLL.ExcluirFuncionario(new Funcionario() { IdEmpresa = codigoempresaComboBox.Text, Externo = funcionarioexternoTextBox.Text });

                    statusfuncionarioLabel.Text = "Processando...";
                    statusfuncionarioLabel.Visible = true;
                    List<ErrosTela> ErrosTela = new List<ErrosTela>();
                    Utilities.ValidarTextBoxes(funcionarioGroupBox, ref ErrosTela);
                    if (ErrosTela.Count() > 0)
                    {
                        string strCamposInvalidos = Utilities.CriarMensagemErro(funcionarioGroupBox, ErrosTela);
                        statusfuncionarioLabel.Text = "Não foi possível excluir...";
                        MessageBox.Show("Preencher Campo(s):" + Environment.NewLine + strCamposInvalidos, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        statusfuncionarioLabel.Text = "Funcionário excluído com sucesso.";
                        MessageBox.Show("Funcionário excluído com sucesso!", ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Utilities.ResetarControles(funcionarioGroupBox);
                        funcionarioexternoTextBox.Focus();
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}