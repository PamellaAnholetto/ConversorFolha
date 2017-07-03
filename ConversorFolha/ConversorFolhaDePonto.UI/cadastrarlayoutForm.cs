using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ConversorFolhaDePonto.BLL;
using ConversorFolhaDePonto.Modelo;

namespace ConversorFolhaDePonto.UI
{
    public partial class cadastrarlayoutForm : Form
    {
        private DataGridViewCellCollection linhaSelecionada;
        private DataGridView consultaLayoutGridView;
        private ComboBox nomelayoutComboBox;

        public cadastrarlayoutForm()
        {
            InitializeComponent();
            excluirlayoutButton.Visible = false;
            alterarlayoutButton.Visible = false;
        }

        public cadastrarlayoutForm(DataGridViewCellCollection LinhaSelecionada, ref ComboBox NomeLayout, ref DataGridView ConsultaLayoutGridView)
        {
            InitializeComponent();
            incluirlayoutButton.Visible = false;
            alterarlayoutButton.Location = new Point(186, 198);
            excluirlayoutButton.Location = new Point(261, 198);
            nomelayoutTextBox.Text = NomeLayout.Text;
            linhaSelecionada = LinhaSelecionada;
            consultaLayoutGridView = ConsultaLayoutGridView;
            nomelayoutComboBox = NomeLayout;
        }

        private static IEnumerable<ComboBox> ConteudoComboBoxes;
        private static IEnumerable<ComboBox> InicioComboBoxes;
        private static IEnumerable<ComboBox> TamanhoComboBoxes;

        private void CadastrolayoutForm_Load(object sender, EventArgs e)
        {
            foreach (var controle in conteudoGroupBox.Controls.OfType<ComboBox>())
            {
                switch (controle.AccessibleName)
                {
                    case "1"://Conteúdo
                        controle.Items.AddRange(Utilities.CarregarItensConteudo().ToArray<string>());
                        break;
                    case "2"://Início
                        controle.Items.AddRange(Utilities.CarregarItensPosicao().ToArray<string>());
                        break;
                    case "3"://Tamanho
                        controle.Items.AddRange(Utilities.CarregarItensPosicao().ToArray<string>());
                        break;
                    default:
                        break;
                }
            }
            ConteudoComboBoxes = from combobox in conteudoGroupBox.Controls.OfType<ComboBox>()
                                 where combobox.AccessibleName == "1"
                                 orderby combobox.TabIndex
                                 select combobox;
            InicioComboBoxes = from combobox in conteudoGroupBox.Controls.OfType<ComboBox>()
                               where combobox.AccessibleName == "2"
                               orderby combobox.TabIndex
                               select combobox;
            TamanhoComboBoxes = from combobox in conteudoGroupBox.Controls.OfType<ComboBox>()
                                where combobox.AccessibleName == "3"
                                orderby combobox.TabIndex
                                select combobox;

            //pega item escolhido na tela anterior.
            if (linhaSelecionada != null)
            {
                Dictionary<string, object> ordem = new Dictionary<string, object>()
                {
                    { "Empresa", linhaSelecionada["inicioEmpresaDataGridViewTextBoxColumn"].Value },
                    { "Evento", linhaSelecionada["inicioEventoDataGridViewTextBoxColumn"].Value },
                    { "Funcionario", linhaSelecionada["inicioFuncionarioDataGridViewTextBoxColumn"].Value },
                    { "Horas", linhaSelecionada["inicioHorasDataGridViewTextBoxColumn"].Value }

                }.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);

                for (int i = 0; i < InicioComboBoxes.Count(); i++)
                {
                    if (ordem.Keys.ElementAt(i) == "Empresa")
                    {
                        InicioComboBoxes.ElementAt(i).SelectedIndex = (int)ordem["Empresa"];
                        ConteudoComboBoxes.ElementAt(i).SelectedIndex = 1;
                        TamanhoComboBoxes.ElementAt(i).SelectedIndex = (int)linhaSelecionada["tamanhoEmpresaDataGridViewTextBoxColumn"].Value;
                    }
                    else
                    if (ordem.Keys.ElementAt(i) == "Funcionario")
                    {
                        InicioComboBoxes.ElementAt(i).SelectedIndex = (int)ordem["Funcionario"];
                        ConteudoComboBoxes.ElementAt(i).SelectedIndex = 2;
                        TamanhoComboBoxes.ElementAt(i).SelectedIndex = (int)linhaSelecionada["tamanhoFuncionarioDataGridViewTextBoxColumn"].Value;
                    }
                    else
                    if (ordem.Keys.ElementAt(i) == "Evento")
                    {
                        InicioComboBoxes.ElementAt(i).SelectedIndex = (int)ordem["Evento"];
                        ConteudoComboBoxes.ElementAt(i).SelectedIndex = 3;
                        TamanhoComboBoxes.ElementAt(i).SelectedIndex = (int)linhaSelecionada["tamanhoEventoDataGridViewTextBoxColumn"].Value;
                    }
                    else
                    if (ordem.Keys.ElementAt(i) == "Horas")
                    {
                        InicioComboBoxes.ElementAt(i).SelectedIndex = (int)ordem["Horas"];
                        ConteudoComboBoxes.ElementAt(i).SelectedIndex = 4;
                        TamanhoComboBoxes.ElementAt(i).SelectedIndex = (int)linhaSelecionada["tamanhoHorasDataGridViewTextBoxColumn"].Value;
                    }
                }
            }
            CarregarValidacoes();
        }

        private void CarregarValidacoes()
        {
            conteudo1ComboBox.SelectedIndexChanged += Conteudo_SelectedIndexChanged;
            conteudo2ComboBox.SelectedIndexChanged += Conteudo_SelectedIndexChanged;
            conteudo3ComboBox.SelectedIndexChanged += Conteudo_SelectedIndexChanged;
            conteudo4ComboBox.SelectedIndexChanged += Conteudo_SelectedIndexChanged;

            inicio1ComboBox.SelectedIndexChanged += Inicio_SelectedIndexChanged;
            inicio2ComboBox.SelectedIndexChanged += Inicio_SelectedIndexChanged;
            inicio3ComboBox.SelectedIndexChanged += Inicio_SelectedIndexChanged;
            inicio4ComboBox.SelectedIndexChanged += Inicio_SelectedIndexChanged;

            tamanho1ComboBox.SelectedIndexChanged += TamanhoComboBoxes_SelectedIndexChanged;
            tamanho2ComboBox.SelectedIndexChanged += TamanhoComboBoxes_SelectedIndexChanged;
            tamanho3ComboBox.SelectedIndexChanged += TamanhoComboBoxes_SelectedIndexChanged;
            tamanho4ComboBox.SelectedIndexChanged += TamanhoComboBoxes_SelectedIndexChanged;
        }

        private void Inicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox newsender = (ComboBox)sender;
            if (newsender.SelectedIndex != 0)
                TamanhoComboBoxes.ElementAt(int.Parse(newsender.AccessibleDescription)).Enabled = true;
            else
                TamanhoComboBoxes.ElementAt(int.Parse(newsender.AccessibleDescription)).Enabled = false;
            alterarlayoutButton.Enabled = true;
        }

        private void Conteudo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox newsender = (ComboBox)sender;
            if (newsender.SelectedIndex != 0)
                InicioComboBoxes.ElementAt(int.Parse(newsender.AccessibleDescription)).Enabled = true;
            else
                InicioComboBoxes.ElementAt(int.Parse(newsender.AccessibleDescription)).Enabled = false;
            alterarlayoutButton.Enabled = true;
        }

        private void TamanhoComboBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarTela(ref ConteudoComboBoxes, ref InicioComboBoxes, ref TamanhoComboBoxes);
            alterarlayoutButton.Enabled = true;
        }

        public void VerificarLayoutVazio(Layout ObjLayout)
        {
            List<string> CamposVazio = new List<string>();
            if (ObjLayout.InicioEmpresa == 0) CamposVazio.Add("- Início Empresa" + Environment.NewLine);
            if (ObjLayout.TamanhoEmpresa == 0) CamposVazio.Add("- Tamanho Empresa" + Environment.NewLine);
            if (ObjLayout.InicioEvento == 0) CamposVazio.Add("- Início Evento" + Environment.NewLine);
            if (ObjLayout.TamanhoEvento == 0) CamposVazio.Add("- Tamanho Evento" + Environment.NewLine);
            if (ObjLayout.InicioFuncionario == 0) CamposVazio.Add("- Início Funcionario" + Environment.NewLine);
            if (ObjLayout.TamanhoFuncionario == 0) CamposVazio.Add("- Tamanho Funcionario" + Environment.NewLine);
            if (ObjLayout.InicioHoras == 0) CamposVazio.Add("- Início Horas" + Environment.NewLine);
            if (ObjLayout.TamanhoHoras == 0) CamposVazio.Add("- Tamanho Horas" + Environment.NewLine);
            if (CamposVazio.Count > 0)
            {
                string Mensagem = string.Empty;
                foreach (var erro in CamposVazio)
                {
                    Mensagem += erro;
                }
                throw new Exception("Favor informar:" + Environment.NewLine + Mensagem);
            }
        }

        private void IncluirlayoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nomelayoutTextBox.Text))
                    throw new Exception("Favor preencher o nome do layout.");
                Layout ObjLayout = new Layout() { Nome = nomelayoutTextBox.Text };
                for (int i = 0; i < ConteudoComboBoxes.Count(); i++)
                {
                    switch (ConteudoComboBoxes.ElementAt(i).SelectedIndex)
                    {
                        case 1://Código Empresa
                            if (!string.IsNullOrEmpty(InicioComboBoxes.ElementAt(i).Text))
                                ObjLayout.InicioEmpresa = int.Parse(InicioComboBoxes.ElementAt(i).Text);
                            if (!string.IsNullOrEmpty(TamanhoComboBoxes.ElementAt(i).Text))
                                ObjLayout.TamanhoEmpresa = int.Parse(TamanhoComboBoxes.ElementAt(i).Text);
                            break;
                        case 2://Código Funcionário
                            if (!string.IsNullOrEmpty(InicioComboBoxes.ElementAt(i).Text))
                                ObjLayout.InicioFuncionario = int.Parse(InicioComboBoxes.ElementAt(i).Text);
                            if (!string.IsNullOrEmpty(TamanhoComboBoxes.ElementAt(i).Text))
                                ObjLayout.TamanhoFuncionario = int.Parse(TamanhoComboBoxes.ElementAt(i).Text);
                            break;
                        case 3://Código Evento
                            if (!string.IsNullOrEmpty(InicioComboBoxes.ElementAt(i).Text))
                                ObjLayout.InicioEvento = int.Parse(InicioComboBoxes.ElementAt(i).Text);
                            if (!string.IsNullOrEmpty(TamanhoComboBoxes.ElementAt(i).Text))
                                ObjLayout.TamanhoEvento = int.Parse(TamanhoComboBoxes.ElementAt(i).Text);
                            break;
                        case 4://Horas
                            if (!string.IsNullOrEmpty(InicioComboBoxes.ElementAt(i).Text))
                                ObjLayout.InicioHoras = int.Parse(InicioComboBoxes.ElementAt(i).Text);
                            if (!string.IsNullOrEmpty(TamanhoComboBoxes.ElementAt(i).Text))
                                ObjLayout.TamanhoHoras = int.Parse(TamanhoComboBoxes.ElementAt(i).Text);
                            break;
                    }
                }
                VerificarLayoutVazio(ObjLayout);
                DataBaseBLL.GravarLayout(ObjLayout);
                MessageBox.Show("Layout cadastrado com sucesso!", ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Utilities.ResetarControles(cadastrolayoutGroupBox);
            }
            catch (Exception ex)
            {
                if (ex.Message == "23505")
                {
                    MessageBox.Show("Layout já cadastrado.", ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(ex.Message, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void ValidarTela(ref IEnumerable<ComboBox> ConteudoComboBoxes,
            ref IEnumerable<ComboBox> InicioComboBoxes, ref IEnumerable<ComboBox> TamanhoComboBoxes)
        {
            try
            {
                for (int i = 0; i < ConteudoComboBoxes.Count(); i++)
                {
                    if (ConteudoComboBoxes.ElementAt(i).SelectedIndex != -1 &&
                        ConteudoComboBoxes.ElementAt(i).SelectedIndex != 5 &&
                        ConteudoComboBoxes.ElementAt(i).SelectedIndex != 0)
                    {
                        for (int j = 0; j < ConteudoComboBoxes.Count(); j++)
                        {
                            if (ConteudoComboBoxes.ElementAt(i).Name != ConteudoComboBoxes.ElementAt(j).Name &&
                                ConteudoComboBoxes.ElementAt(j).SelectedIndex != -1 &&
                                ConteudoComboBoxes.ElementAt(j).SelectedIndex != 0 &&
                                ConteudoComboBoxes.ElementAt(i).SelectedItem == ConteudoComboBoxes.ElementAt(j).SelectedItem)
                            {
                                ConteudoComboBoxes.ElementAt(j).SelectedIndex = 0;
                                InicioComboBoxes.ElementAt(j).SelectedIndex = 0;
                                TamanhoComboBoxes.ElementAt(j).SelectedIndex = 0;
                                throw new Exception("Conteúdo já selecionado anteriormente.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AlterarlayoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja alterar o layout? ", ParametroInfo.SistemaVersao, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    statuslayoutLabel.Text = "Processando...";
                    statuslayoutLabel.Visible = true;
                    List<ErrosTela> ErrosTela = new List<ErrosTela>();
                    Utilities.ValidarTextBoxes(conteudoGroupBox, ref ErrosTela);
                    if (ErrosTela.Count() > 0)
                    {
                        string strCamposInvalidos = Utilities.CriarMensagemErro(conteudoGroupBox, ErrosTela);
                        statuslayoutLabel.Text = "Não foi possível alterar...";
                        MessageBox.Show("Preencher Campo(s):" + Environment.NewLine + strCamposInvalidos, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(nomelayoutTextBox.Text))
                            throw new Exception("Favor preencher o nome do layout.");
                        Layout ObjLayout = new Layout() { Nome = nomelayoutTextBox.Text };
                        for (int i = 0; i < ConteudoComboBoxes.Count(); i++)
                        {
                            switch (ConteudoComboBoxes.ElementAt(i).SelectedIndex)
                            {
                                case 1://Código Empresa
                                    if (!string.IsNullOrEmpty(InicioComboBoxes.ElementAt(i).Text))
                                        ObjLayout.InicioEmpresa = int.Parse(InicioComboBoxes.ElementAt(i).Text);
                                    if (!string.IsNullOrEmpty(TamanhoComboBoxes.ElementAt(i).Text))
                                        ObjLayout.TamanhoEmpresa = int.Parse(TamanhoComboBoxes.ElementAt(i).Text);
                                    break;
                                case 2://Código Funcionário
                                    if (!string.IsNullOrEmpty(InicioComboBoxes.ElementAt(i).Text))
                                        ObjLayout.InicioFuncionario = int.Parse(InicioComboBoxes.ElementAt(i).Text);
                                    if (!string.IsNullOrEmpty(TamanhoComboBoxes.ElementAt(i).Text))
                                        ObjLayout.TamanhoFuncionario = int.Parse(TamanhoComboBoxes.ElementAt(i).Text);
                                    break;
                                case 3://Código Evento
                                    if (!string.IsNullOrEmpty(InicioComboBoxes.ElementAt(i).Text))
                                        ObjLayout.InicioEvento = int.Parse(InicioComboBoxes.ElementAt(i).Text);
                                    if (!string.IsNullOrEmpty(TamanhoComboBoxes.ElementAt(i).Text))
                                        ObjLayout.TamanhoEvento = int.Parse(TamanhoComboBoxes.ElementAt(i).Text);
                                    break;
                                case 4://Horas
                                    if (!string.IsNullOrEmpty(InicioComboBoxes.ElementAt(i).Text))
                                        ObjLayout.InicioHoras = int.Parse(InicioComboBoxes.ElementAt(i).Text);
                                    if (!string.IsNullOrEmpty(TamanhoComboBoxes.ElementAt(i).Text))
                                        ObjLayout.TamanhoHoras = int.Parse(TamanhoComboBoxes.ElementAt(i).Text);
                                    break;
                            }
                        }
                        statuslayoutLabel.Text = "Layout alterado com sucesso.";
                        DataBaseBLL.AlterarLayout(ObjLayout, linhaSelecionada["nomeDataGridViewTextBoxColumn"].Value.ToString());
                        MessageBox.Show("Layout alterado com sucesso!", ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        VerificarLayoutVazio(ObjLayout);
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "23505")
                {
                    MessageBox.Show("Layout já cadastrado.", ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(ex.Message, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void CadastrarlayoutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (consultaLayoutGridView != null)
                consultaLayoutGridView.DataSource = DataBaseBLL.CarregarLayoutGrid(nomelayoutTextBox.Text);
            if (nomelayoutComboBox != null)
                nomelayoutComboBox.DataSource = DataBaseBLL.CarregarLayoutComboBox();

        }

        private void ExcluirlayoutButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Deseja excluir o layout?", ParametroInfo.SistemaVersao, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataBaseBLL.ExcluirLayout(new Layout() { Nome = nomelayoutTextBox.Text });

                    statuslayoutLabel.Text = "Processando...";
                    statuslayoutLabel.Visible = true;
                    List<ErrosTela> ErrosTela = new List<ErrosTela>();
                    Utilities.ValidarTextBoxes(conteudoGroupBox, ref ErrosTela);
                    if (ErrosTela.Count() > 0)
                    {
                        string strCamposInvalidos = Utilities.CriarMensagemErro(conteudoGroupBox, ErrosTela);
                        statuslayoutLabel.Text = "Não foi possível alterar...";
                        MessageBox.Show("Preencher Campo(s):" + Environment.NewLine + strCamposInvalidos, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        statuslayoutLabel.Text = "Layout excluído com sucesso.";
                        MessageBox.Show("Layout excluído com sucesso!", ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Utilities.ResetarControles(conteudoGroupBox);
                        nomelayoutTextBox.Focus();
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void nomelayoutTextBox_TextChanged(object sender, EventArgs e)
        {
            nomelayoutTextBox.TextChanged += LayoutAlterado;
        }

        private void LayoutAlterado(object sender, EventArgs e)
        {
            alterarlayoutButton.Enabled = true;
        }
    }
}