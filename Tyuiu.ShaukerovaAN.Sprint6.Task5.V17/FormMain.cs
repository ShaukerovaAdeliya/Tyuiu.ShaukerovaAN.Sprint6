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

using Tyuiu.ShaukerovaAN.Sprint6.Task5.V17.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint6.Task5.V17
{
    public partial class FormMain_SAN : Form
    {
        public FormMain_SAN()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\shauk\source\repos\Tyuiu.ShaukerovaAN.Sprint6\Tyuiu.ShaukerovaAN.Sprint6.Task5.V17\bin\Debug\InPutFileTask5V17.txt";

        private void buttonDone_SAN_Click(object sender, EventArgs e)
        {
            dataGridViewResult_SAN.ColumnCount = 2;
            dataGridViewResult_SAN.Columns[0].Width = 30;
            dataGridViewResult_SAN.Columns[1].Width = 50;
            this.chartResult_SAN.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_SAN.ChartAreas[0].AxisY.Title = "Ось Y";
            chartResult_SAN.Series[0].Points.Clear();
            double[] numMass = new double[ds.len];
            numMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewResult_SAN.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartResult_SAN.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void buttonOpen_SAN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_SAN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИСТНб-23-1 Шаукерова Аделия Нуржановна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
