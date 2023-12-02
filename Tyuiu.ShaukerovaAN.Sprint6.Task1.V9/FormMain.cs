using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ShaukerovaAN.Sprint6.Task1.V9.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint6.Task1.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_SAN_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_SAN.Text);
                int stopStep = Convert.ToInt32(textBoxStop_SAN.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_SAN.Text = "";
                textBoxResult_SAN.AppendText("+----------+------------+" + Environment.NewLine);
                textBoxResult_SAN.AppendText("|    X     |     f(x)   |" + Environment.NewLine);
                textBoxResult_SAN.AppendText("+----------+------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1,7:f2}    |", startStep, valueArray[i]);
                    textBoxResult_SAN.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_SAN.AppendText("+--------------------------+--------------------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void buttonSpravka_SAN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИСТНб-23-1 Шаукерова Аделия Нуржановн", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
