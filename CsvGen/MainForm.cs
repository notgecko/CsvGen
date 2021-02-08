using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
namespace CsvGen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog {Title = "Save csv file as:", AddExtension = true, CheckFileExists = false, DefaultExt = "csv", Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"};
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtOutPath.Text = saveFileDialog.FileName;
            }
        }
    }
}