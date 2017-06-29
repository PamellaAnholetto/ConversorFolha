using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ConversorFolhaDePonto.Modelo;

namespace ConversorFolhaDePonto.UI
{
    public class Utilities
    {
        public static void ResetarControles(Control Controle)
        {
            foreach (Control control in Controle.Controls)
            {
                if (control is GroupBox) ResetarControles(control);
                if (control is TextBox) ((TextBox)(control)).Clear();
                if (control is ComboBox) if (((ComboBox)(control)).Items.Count > 0) ((ComboBox)(control)).SelectedIndex = 0;
                if (control is CheckBox) ((CheckBox)(control)).Checked = false;
                if (control is ListBox) ((ListBox)(control)).ClearSelected();
                if (control is MaskedTextBox) ((MaskedTextBox)(control)).Clear();
            }
        }

        public static void ValidarTextBoxes(Control GroupBox, ref List<ErrosTela> ErrosTela)
        {
            foreach (Control control in GroupBox.Controls)
            {
                if (control is GroupBox) ValidarTextBoxes(control, ref ErrosTela);
                if (control is TextBox || control is MaskedTextBox || control is ComboBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        ErrosTela.Add(new ErrosTela()
                        {
                            CampoInvalido = "- " + control.AccessibleName + Environment.NewLine
                        });
                    }
                }
            }
        }

        public static string CriarMensagemErro(Control GroupBox, List<ErrosTela> ErrosTela)
        {
            string strCamposInvalidos = string.Empty;
            foreach (var erro in ErrosTela)
            {
                strCamposInvalidos += erro.CampoInvalido;
            }
            return strCamposInvalidos;
        }

        public static List<string> CarregarItensPosicao()
        {
            List<string> Itens = new List<string>() { string.Empty };
            for (int i = 1; i <= 60; i++)
            {
                Itens.Add(i.ToString());
            }
            return Itens;
        }

        public static List<string> CarregarItensConteudo()
        {
            return new List<string>() { string.Empty, "Código Empresa", "Código Funcionário", "Código Evento", "Horas" };
        }
    }
}
