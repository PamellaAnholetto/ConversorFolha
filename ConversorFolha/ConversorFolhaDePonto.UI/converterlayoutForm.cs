using System;
using System.Windows.Forms;
using ConversorFolhaDePonto.Modelo;
using ConversorFolhaDePonto.BLL;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace ConversorFolhaDePonto.UI
{
    public partial class converterlayoutForm : Form
    {

        public converterlayoutForm()
        {
            InitializeComponent();
        }

        private void lerdiretorioButton_Click(object sender, EventArgs e)
        {
            lerOpenFileDialog.ShowDialog();
            lerdiretorioTextBox.Text = lerOpenFileDialog.FileName;
        }

        private void diretoriogravarButton_Click(object sender, EventArgs e)
        {
            gravarFolderBrowserDialog.ShowDialog();
            diretoriogravarTextBox.Text = gravarFolderBrowserDialog.SelectedPath + "\\" +
                nomeempresaTextBox.Text + " " + DateTime.Now.Date.ToString().Substring(2, 8).Replace("/", string.Empty) + ".txt";
        }

        private void gerarpontoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(codigoempresaComboBox.Text))
                    throw new Exception("Favor informar a empresa.");
                if (string.IsNullOrEmpty(nomelayoutComboBox.Text))
                    throw new Exception("Favor informar o Layout.");
                if (string.IsNullOrEmpty(lerdiretorioTextBox.Text))
                    throw new Exception("Favor informar o caminho de leitura.");
                if (string.IsNullOrEmpty(diretoriogravarTextBox.Text))
                    throw new Exception("Favor informar o caminho de gravação.");
                string[] aArquivoOriginal = File.ReadAllLines(lerdiretorioTextBox.Text, Encoding.Default);
                if (aArquivoOriginal.Length == 0)
                    throw new Exception("Arquivo em branco.");
                Empresa objEmpresa = DataBaseBLL.BuscarEmpresaPorId(codigoempresaComboBox.Text);
                Layout objLayout = DataBaseBLL.BuscarLayoutPorNome(nomelayoutComboBox.Text);

                ConversorBLL.ConverterArquivo(aArquivoOriginal, objEmpresa, objLayout, diretoriogravarTextBox.Text);
                MessageBox.Show("Arquivo gerado com sucesso!", ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ParametroInfo.SistemaVersao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void conversorForm_Load(object sender, EventArgs e)
        {
            codigoempresaComboBox.DataSource = DataBaseBLL.CarregarEmpresasComboBox();
            nomeempresaTextBox.Text = codigoempresaComboBox.SelectedValue.ToString();
            nomelayoutComboBox.DataSource = DataBaseBLL.CarregarLayoutComboBox();
        }

        private void codigoempresaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomeempresaTextBox.Text = codigoempresaComboBox.SelectedValue.ToString();
            lerdiretorioTextBox.Clear();
            lerOpenFileDialog.FileName = null;
            diretoriogravarTextBox.Clear();
            gravarFolderBrowserDialog.SelectedPath = null;
        }
    }
}