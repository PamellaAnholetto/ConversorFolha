using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ConversorFolhaDePonto.BLL;
using ConversorFolhaDePonto.Modelo;

namespace ConversorFolhaDePonto.UI
{
    public partial class cadastrargeralForm : Form
    {
        public cadastrargeralForm()
        {
            InitializeComponent();
        }

        private void IncluirempresaButton_Click(object sender, EventArgs e)
        {
            try
            {
                statusempresaLabel.Text = "Processando...";
                statusempresaLabel.Visible = true;
                List<ErrosTela> ErrosTela = new List<ErrosTela>();
                Utilities.ValidarTextBoxes(empresaGroupBox, ref ErrosTela);
                if (ErrosTela.Count() > 0)
                {
                    string strCamposInvalidos = Utilities.CriarMensagemErro(eventoGroupBox, ErrosTela);
                    statusempresaLabel.Text = "Não foi possível incluir...";
                    MessageBox.Show("Preencher Campo(s):" + Environment.NewLine + strCamposInvalidos, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DataBaseBLL.GravarEmpresa(
                                        new Empresa()
                                        {
                                            Id = codigoempresaMaskedTextBox.Text,
                                            Nome = nomeempresaTextBox.Text,
                                            InicioEvento = int.Parse(inicioeventoTextBox.Text),
                                            TamanhoEvento = int.Parse(tamanhoeventoTextBox.Text),
                                            InicioFuncionario = int.Parse(iniciofuncionarioTextBox.Text),
                                            TamanhoFuncionario = int.Parse(tamanhofuncionarioTextBox.Text),
                                            InicioHoras = int.Parse(iniciohorasTextBox.Text),
                                            TamanhoHoras = int.Parse(tamanhohorasTextBox.Text)
                                        }
                    );
                    statusempresaLabel.Text = "Empresa incluída com sucesso.";
                    //Habilitar e Desabilitar 
                    eventoGroupBox.Enabled = true;
                    funcionarioGroupBox.Enabled = true;
                    novaempresaButton.Enabled = true;
                    empresaGroupBox.Enabled = false;
                    eventoexternoTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "23505")
                {
                    MessageBox.Show("Empresa já cadastrada.", ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    statusempresaLabel.Text = "Não foi possível incluir...";
                }
                else
                {
                    MessageBox.Show(ex.Message, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    statusempresaLabel.Text = "Não foi possível incluir...";
                }

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
                            IdEmpresa = codigoempresaMaskedTextBox.Text,
                            NomeEmpresa = nomeempresaTextBox.Text,
                            Externo = eventoexternoTextBox.Text,
                            Interno = enventointernoTextBox.Text,
                            Transferivel = eventotrensferivelCheckBox.Checked
                        }
                    );
                    statuseventoLabel.Text = "Evento incluído com sucesso.";
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

        private void IncluirfuncionarioButton_Click(object sender, EventArgs e)
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
                                            IdEmpresa = codigoempresaMaskedTextBox.Text,
                                            NomeEmpresa = nomeempresaTextBox.Text,
                                            Externo = funcionarioexternoTextBox.Text,
                                            Interno = funcionariointernoTextBox.Text
                                        }
                    );
                    statusfuncionarioLabel.Text = "Funcionário incluído com sucesso.";
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
        }

        private void NovaempresaButton_Click(object sender, EventArgs e)
        {
            try
            {
                eventoGroupBox.Enabled = false;
                funcionarioGroupBox.Enabled = false;
                empresaGroupBox.Enabled = true;
                Utilities.ResetarControles(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      
            }
        }

        private void CadastrogeralForm_Load(object sender, EventArgs e)
        {
            BindEventoKeyPress(this);
        }

        public void BindEventoKeyPress(Control ObjControle)
        {
            foreach (Control controle in ObjControle.Controls)
            {
                if (controle is GroupBox) BindEventoKeyPress(controle);
                if (controle is TextBox && controle != nomeempresaTextBox) ((TextBox)(controle)).KeyPress += FormTextBoxes_KeyPress;
            }
        }

        private void FormTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckDigit(e);
        }

        private void CheckDigit(KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b') if ((!char.IsDigit(e.KeyChar)) || (char.IsControl(e.KeyChar))) e.Handled = true;
        }
    }
}