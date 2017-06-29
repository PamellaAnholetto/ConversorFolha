using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ConversorFolhaDePonto.UI
{
    public partial class manualForm : Form
    {
        public manualForm()
        {
            InitializeComponent();
            webBrowser.Navigate(string.Format(@"file://{0}\Manual_ConversorPonto_OFICIAL.pdf", Application.StartupPath));    
        }
    }
}
