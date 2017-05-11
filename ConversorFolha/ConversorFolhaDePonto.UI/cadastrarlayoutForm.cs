using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ConversorFolhaDePonto.BLL;
using ConversorFolhaDePonto.Modelo;

namespace ConversorFolhaDePonto.UI
{
    public partial class CadastrarlayoutForm : Form
    {
        public CadastrarlayoutForm()
        {
            InitializeComponent();
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
                        controle.SelectedIndexChanged += Conteudo_SelectedIndexChanged;
                        break;
                    case "2"://Início
                        controle.Items.AddRange(Utilities.CarregarItensPosicao().ToArray<string>());
                        controle.SelectedIndexChanged += Inicio_SelectedIndexChanged;
                        break;
                    case "3"://Tamamnho
                        controle.Items.AddRange(Utilities.CarregarItensPosicao().ToArray<string>());
                        controle.SelectedIndexChanged += TamanhoComboBoxes_SelectedIndexChanged;
                        //controle.TextChanged += TamanhoComboBoxes_TextChanged;
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
        }

        private void Inicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox newsender = (ComboBox)sender;
            if (newsender.SelectedIndex != 0)
                TamanhoComboBoxes.ElementAt(int.Parse(newsender.AccessibleDescription)).Enabled = true;
            else
                TamanhoComboBoxes.ElementAt(int.Parse(newsender.AccessibleDescription)).Enabled = false;
        }

        private void Conteudo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox newsender = (ComboBox)sender;
            if (newsender.SelectedIndex != 0)
                InicioComboBoxes.ElementAt(int.Parse(newsender.AccessibleDescription)).Enabled = true;
            else
                InicioComboBoxes.ElementAt(int.Parse(newsender.AccessibleDescription)).Enabled = false;
        }

        //private void TamanhoComboBoxes_TextChanged(object sender, EventArgs e)
        //{
        //    ValidarTela(ref ConteudoComboBoxes, ref InicioComboBoxes, ref TamanhoComboBoxes);
        //}

        private void TamanhoComboBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarTela(ref ConteudoComboBoxes, ref InicioComboBoxes, ref TamanhoComboBoxes);
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
    }
}

