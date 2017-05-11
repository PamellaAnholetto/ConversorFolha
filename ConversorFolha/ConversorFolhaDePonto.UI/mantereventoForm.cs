using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ConversorFolhaDePonto.BLL;
using ConversorFolhaDePonto.Modelo;

namespace ConversorFolhaDePonto.UI
{
    public partial class ManutencaoeventoForm : Form
    {
        public ManutencaoeventoForm(ComboBox CodigoEmpresa, TextBox NomeEmpresa)
        {
            InitializeComponent();
            codigoempresaComboBox.DataSource = CodigoEmpresa.DataSource;
            codigoempresaComboBox.SelectedIndex = CodigoEmpresa.SelectedIndex;
            codigoempresaComboBox.Enabled = false;
            nomeempresaTextBox.Text = NomeEmpresa.Text;
        }

        public ManutencaoeventoForm(DataGridViewCellCollection LinhaSelecionada, ComboBox CodigoEmpresa, TextBox NomeEmpresa)
        {
            InitializeComponent();
            codigoempresaComboBox.DataSource = CodigoEmpresa.DataSource;
            codigoempresaComboBox.SelectedIndex = CodigoEmpresa.SelectedIndex;
            codigoempresaComboBox.Enabled = false;
            nomeempresaTextBox.Text = NomeEmpresa.Text;
            eventoexternoTextBox.Text = LinhaSelecionada["externoDataGridViewTextBoxColumn"].Value.ToString();
            eventointernoTextBox.Text = LinhaSelecionada["internoDataGridViewTextBoxColumn"].Value.ToString();
            eventotrensferivelCheckBox.Checked = (bool)LinhaSelecionada["transferivelDataGridViewCheckBoxColumn"].Value;
        }

        private void CadastroeventoForm_Load(object sender, EventArgs e)
        {
            
        }

       private void CodigoempresaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {    
            nomeempresaTextBox.Text = codigoempresaComboBox.SelectedValue.ToString();
            Empresa empresaSelecionada = (Empresa)codigoempresaComboBox.SelectedItem;
            if (string.IsNullOrEmpty(codigoempresaComboBox.Text))
            {
                eventoGroupBox.Enabled = false;               
            }else
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
    }
}
