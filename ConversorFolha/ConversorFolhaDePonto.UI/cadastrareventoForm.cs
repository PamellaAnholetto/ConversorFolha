using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ConversorFolhaDePonto.BLL;
using ConversorFolhaDePonto.Modelo;


namespace ConversorFolhaDePonto.UI
{
    public partial class cadastrareventoForm : Form
    {
        public DataGridViewCellCollection linhaSelecionada;
        private DataGridView consultaeventoGridView;
        public cadastrareventoForm(ComboBox CodigoEmpresa, TextBox NomeEmpresa, ref DataGridView ConsultaeventoGridView)
        {
            InitializeComponent();
            codigoempresaComboBox.DataSource = CodigoEmpresa.DataSource;
            codigoempresaComboBox.SelectedIndex = CodigoEmpresa.SelectedIndex;
            codigoempresaComboBox.Enabled = false;
            excluireventoButton.Visible = false;
            alterareventoButton.Visible = false;
            nomeempresaTextBox.Text = NomeEmpresa.Text;
            consultaeventoGridView = ConsultaeventoGridView;
        }

        public cadastrareventoForm(DataGridViewCellCollection LinhaSelecionada, ComboBox CodigoEmpresa, TextBox NomeEmpresa, ref DataGridView ConsultaeventoGridView)
        {
            InitializeComponent();
            codigoempresaComboBox.DataSource = CodigoEmpresa.DataSource;
            codigoempresaComboBox.SelectedIndex = CodigoEmpresa.SelectedIndex;
            codigoempresaComboBox.Enabled = false;
            incluireventoButton.Visible = false;
            alterareventoButton.Location = new Point(240, 104);
            excluireventoButton.Location = new Point(240, 134);
            nomeempresaTextBox.Text = NomeEmpresa.Text;
            eventoexternoTextBox.Text = LinhaSelecionada["externoDataGridViewTextBoxColumn"].Value.ToString();
            eventointernoTextBox.Text = LinhaSelecionada["internoDataGridViewTextBoxColumn"].Value.ToString();
            eventotrensferivelCheckBox.Checked = (bool)LinhaSelecionada["transferivelDataGridViewCheckBoxColumn"].Value;
            linhaSelecionada = LinhaSelecionada;
            consultaeventoGridView = ConsultaeventoGridView;
        }

        private void CodigoempresaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomeempresaTextBox.Text = codigoempresaComboBox.SelectedValue.ToString();
            Empresa empresaSelecionada = (Empresa)codigoempresaComboBox.SelectedItem;
            if (string.IsNullOrEmpty(codigoempresaComboBox.Text))
            {
                eventoGroupBox.Enabled = false;
            }
            else
            {
                eventoGroupBox.Enabled = true;
            }
        }

        private void IncluireventoButton_Click(object sender, EventArgs e)
        {
            try
            {
                statuseventoLabel.Text = "Processando...";
                statuseventoLabel.Visible = true;
                List<ErrosTela> ErrosTela = new List<ErrosTela>();
                Utilities.ValidarTextBoxes(eventoGroupBox, ref ErrosTela);
                if (ErrosTela.Count() > 0)
                {
                    string strCamposInvalidos = Utilities.CriarMensagemErro(eventoGroupBox, ErrosTela);
                    statuseventoLabel.Text = "Não foi possível incluir...";
                    MessageBox.Show("Preencher Campo(s):" + Environment.NewLine + strCamposInvalidos, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DataBaseBLL.GravarEvento(
                        new Evento()
                        {
                            IdEmpresa = codigoempresaComboBox.Text,
                            NomeEmpresa = nomeempresaTextBox.Text,
                            Externo = eventoexternoTextBox.Text,
                            Interno = eventointernoTextBox.Text,
                            Transferivel = eventotrensferivelCheckBox.Checked,
                        }
                    );
                    statuseventoLabel.Text = "Evento incluido com sucesso.";
                    Utilities.ResetarControles(eventoGroupBox);
                    eventoexternoTextBox.Focus();
                    Close();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "23505")
                {
                    MessageBox.Show("Evento já cadastrado.", ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    statuseventoLabel.Text = "Não foi possível incluir...";
                }
                else
                {
                    MessageBox.Show(ex.Message, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    statuseventoLabel.Text = "Não foi possível incluir...";
                }
            }
        }

        private void AlterareventoButton_Click(object sender, EventArgs e)
        {
            try
            {
                statuseventoLabel.Text = "Processando...";
                statuseventoLabel.Visible = true;
                List<ErrosTela> ErrosTela = new List<ErrosTela>();
                Utilities.ValidarTextBoxes(eventoGroupBox, ref ErrosTela);
                if (ErrosTela.Count() > 0)
                {
                    string strCamposInvalidos = Utilities.CriarMensagemErro(eventoGroupBox, ErrosTela);
                    statuseventoLabel.Text = "Não foi possível alterar...";
                    MessageBox.Show("Preencher Campo(s):" + Environment.NewLine + strCamposInvalidos, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DataBaseBLL.AlterarEvento(
                        new Evento()
                        {
                            IdEmpresa = codigoempresaComboBox.Text,
                            NomeEmpresa = nomeempresaTextBox.Text,
                            Externo = eventoexternoTextBox.Text,
                            Interno = eventointernoTextBox.Text,
                            Transferivel = eventotrensferivelCheckBox.Checked,

                        }, linhaSelecionada["externoDataGridViewTextBoxColumn"].Value.ToString()
                    );
                    statuseventoLabel.Text = "Evento alterado com sucesso.";
                    Utilities.ResetarControles(eventoGroupBox);
                    eventoexternoTextBox.Focus();
                    Close();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "23505")
                {
                    MessageBox.Show("Evento já cadastrado.", ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    statuseventoLabel.Text = "Não foi possível alterar...";
                }
                else
                {
                    MessageBox.Show(ex.Message, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    statuseventoLabel.Text = "Não foi possível alterar...";
                }
            }
        }

        private void EventoexternoTextBox_Validated(object sender, EventArgs e)
        {
            alterareventoButton.Enabled = true;
        }

        private void CadastrareventoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            consultaeventoGridView.DataSource = DataBaseBLL.CarregarEventoGrid(codigoempresaComboBox.Text);
        }

        private void ExcluireventoButton_Click(object sender, EventArgs e)
        {
            DataBaseBLL.ExcluirFuncionario(new Funcionario() { IdEmpresa = codigoempresaComboBox.Text ,  Externo = eventoexternoTextBox.Text});

        }
    }
}