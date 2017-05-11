﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ConversorFolhaDePonto.BLL;
using ConversorFolhaDePonto.Modelo;
using System.Drawing;

namespace ConversorFolhaDePonto.UI
{
    public partial class CadastrarlayoutForm : Form
    {
        private DataGridViewCellCollection linhaSelecionada;
        public CadastrarlayoutForm()
        {
            InitializeComponent();
            excluirlayoutButton.Visible = false;
            alterarlayoutButton.Visible = false;
        }

        public CadastrarlayoutForm(DataGridViewCellCollection LinhaSelecionada, ComboBox NomeLayout)
        {
            InitializeComponent();
            incluirlayoutButton.Visible = false;
            alterarlayoutButton.Location = new Point(186, 188);
            excluirlayoutButton.Location = new Point(261, 188);
            nomelayoutTextBox.Text = NomeLayout.Text;
            linhaSelecionada = LinhaSelecionada;
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
                    case "3"://Tamanho
                        controle.Items.AddRange(Utilities.CarregarItensPosicao().ToArray<string>());
                        controle.SelectedIndexChanged += TamanhoComboBoxes_SelectedIndexChanged;
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

