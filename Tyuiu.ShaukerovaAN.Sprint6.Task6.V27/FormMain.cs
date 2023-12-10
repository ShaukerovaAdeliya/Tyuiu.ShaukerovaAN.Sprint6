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
using Tyuiu.ShaukerovaAN.Sprint6.Task6.V27.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint6.Task6.V27
{
    public partial class FormMain_SAN : Form
    {
        public FormMain_SAN()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_SAN_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SAN.ShowDialog();
            openFilePath = openFileDialogTask_SAN.FileName;
            textBoxln_SAN.Text = File.ReadAllText(openFilePath);
            groupBoxOut_SAN.Text = groupBoxOut_SAN.Text + " " + openFileDialogTask_SAN.FileName;
            buttonDoIt_SAN.Enabled = true;
        }

        private void buttonDoIt_SAN_Click(object sender, EventArgs e)
        {

            textBoxOut_SAN.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_SAN_Click(object sender, EventArgs e)
        {
            FormAbout_SAN formAbout = new FormAbout_SAN();
            formAbout.ShowDialog();
        }
    }
}
