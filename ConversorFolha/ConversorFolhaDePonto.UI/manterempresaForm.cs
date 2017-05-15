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
        public manutencaoempresaForm(DataGridViewCellCollection LinhaSelecionada, ComboBox CodigoEmpresa, TextBox NomeEmpresa, ref DataGridView ConsultaempresaGridView)
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
        }

        private void CodigoempresaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomeempresaTextBox.Text = codigoempresaComboBox.SelectedValue.ToString();
            Empresa empresaSelecionada = (Empresa)codigoempresaComboBox.SelectedItem;
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
                    Utilities.ResetarControles(layoutempresaGroupBox);
                    inicioeventoTextBox.Focus();
                    Close();
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

        private void inicioeventoTextBox_Validated(object sender, EventArgs e)
        {
            alterarempresaButton.Enabled = true;
        }

        private void manutencaoempresaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            consultaempresaGridView.DataSource = DataBaseBLL.CarregarEmpresaGrid(codigoempresaComboBox.Text);
        }
    }
}
