using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ConversorFolhaDePonto.BLL;
using ConversorFolhaDePonto.Modelo;

namespace ConversorFolhaDePonto.UI
{
    public partial class manutencaoempresaForm : Form
    {
        private DataGridView consultaempresaGridView;
        private ComboBox empresaComboBox;
        public manutencaoempresaForm(DataGridViewCellCollection LinhaSelecionada, ComboBox CodigoEmpresa, TextBox NomeEmpresa, ref DataGridView ConsultaempresaGridView, ref ComboBox CodigoEmpresaComboBox)
        {
            InitializeComponent();
            codigoempresaComboBox.DataSource = CodigoEmpresa.DataSource;
            codigoempresaComboBox.SelectedIndex = CodigoEmpresa.SelectedIndex;
            codigoempresaComboBox.Enabled = false;
            nomeempresaTextBox.Text = NomeEmpresa.Text;
            inicioeventoTextBox.Text = LinhaSelecionada["inicioEventoDataGridViewTextBoxColumn"].Value.ToString();
            tamanhoeventoTextBox.Text = LinhaSelecionada["tamanhoEventoDataGridViewTextBoxColumn"].Value.ToString();
            iniciofuncionarioTextBox.Text = LinhaSelecionada["inicioFuncionarioDataGridViewTextBoxColumn"].Value.ToString();
            tamanhofuncionarioTextBox.Text = LinhaSelecionada["tamanhoFuncionarioDataGridViewTextBoxColumn"].Value.ToString();
            iniciohorasTextBox.Text = LinhaSelecionada["inicioHorasDataGridViewTextBoxColumn"].Value.ToString();
            tamanhohorasTextBox.Text = LinhaSelecionada["tamanhoHorasDataGridViewTextBoxColumn"].Value.ToString();
            consultaempresaGridView = ConsultaempresaGridView;
            empresaComboBox = CodigoEmpresaComboBox;
        }

        private void CodigoempresaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (string.IsNullOrEmpty(codigoempresaComboBox.Text))
            {
                layoutempresaGroupBox.Enabled = false;
            }
            else
            {
                layoutempresaGroupBox.Enabled = true;
            }
        }

        private void AlterarempresaButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja alterar a empresa?", ParametroInfo.SistemaVersao, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    statusempresaLabel.Text = "Processando...";
                    statusempresaLabel.Visible = true;
                    List<ErrosTela> ErrosTela = new List<ErrosTela>();
                    Utilities.ValidarTextBoxes(layoutempresaGroupBox, ref ErrosTela);
                    if (ErrosTela.Count() > 0)
                    {
                        string strCamposInvalidos = Utilities.CriarMensagemErro(layoutempresaGroupBox, ErrosTela);
                        statusempresaLabel.Text = "Não foi possível alterar...";
                        MessageBox.Show("Preencher Campo(s):" + Environment.NewLine + strCamposInvalidos, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DataBaseBLL.AlterarEmpresa(
                            new Empresa()
                            {
                                Id = codigoempresaComboBox.Text,
                                Nome = nomeempresaTextBox.Text,
                                InicioEvento = int.Parse(inicioeventoTextBox.Text),
                                TamanhoEvento = int.Parse(tamanhoeventoTextBox.Text),
                                InicioFuncionario = int.Parse(iniciofuncionarioTextBox.Text),
                                TamanhoFuncionario = int.Parse(tamanhofuncionarioTextBox.Text),
                                InicioHoras = int.Parse(iniciohorasTextBox.Text),
                                TamanhoHoras = int.Parse(tamanhohorasTextBox.Text)
                            }
                        );
                        statusempresaLabel.Text = "Empresa alterada com sucesso.";
                        MessageBox.Show("Empresa alterada com sucesso!", ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Utilities.ResetarControles(layoutempresaGroupBox);
                        inicioeventoTextBox.Focus();
                        Close();
                    }
                }
            }

            catch (Exception ex)
            {
                if (ex.Message == "23505")
                {
                    MessageBox.Show("Empresa já cadastrado.", ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    statusempresaLabel.Text = "Não foi possível alterar...";
                }
                else
                {
                    MessageBox.Show(ex.Message, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    statusempresaLabel.Text = "Não foi possível alterar...";
                }
            }
        }

        private void InicioeventoTextBox_Validated(object sender, EventArgs e)
        {
            alterarempresaButton.Enabled = true;
        }

        private void ManutencaoempresaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            empresaComboBox.DataSource = DataBaseBLL.CarregarEmpresasComboBox();
            consultaempresaGridView.DataSource = DataBaseBLL.CarregarEmpresaGrid(codigoempresaComboBox.Text);
        }

        private void ExcluirempresaButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir a empresa?", ParametroInfo.SistemaVersao, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataBaseBLL.ExcluirEmpresa(new Empresa() { Id = codigoempresaComboBox.Text });

                    statusempresaLabel.Text = "Processando...";
                    statusempresaLabel.Visible = true;
                    List<ErrosTela> ErrosTela = new List<ErrosTela>();
                    Utilities.ValidarTextBoxes(layoutempresaGroupBox, ref ErrosTela);
                    if (ErrosTela.Count() > 0)
                    {
                        string strCamposInvalidos = Utilities.CriarMensagemErro(layoutempresaGroupBox, ErrosTela);
                        statusempresaLabel.Text = "Não foi possível excluir...";
                        MessageBox.Show("Preencher Campo(s):" + Environment.NewLine + strCamposInvalidos, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        statusempresaLabel.Text = "Empresa excluída com sucesso.";
                        MessageBox.Show("Empresa excluída com sucesso!", ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Utilities.ResetarControles(layoutempresaGroupBox);
                        inicioeventoTextBox.Focus();
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
