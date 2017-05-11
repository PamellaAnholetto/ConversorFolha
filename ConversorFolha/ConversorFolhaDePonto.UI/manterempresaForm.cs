using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConversorFolhaDePonto.BLL;
using ConversorFolhaDePonto.Modelo;

namespace ConversorFolhaDePonto.UI
{
    public partial class ManutencaoempresaForm : Form
    {
        public ManutencaoempresaForm(DataGridViewCellCollection LinhaSelecionada, ComboBox CodigoEmpresa, TextBox NomeEmpresa)
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
            tamanhohorasTextBox.Text= LinhaSelecionada["tamanhoHorasDataGridViewTextBoxColumn"].Value.ToString();
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
    }
}
