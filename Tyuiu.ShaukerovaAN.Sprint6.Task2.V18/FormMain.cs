using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ShaukerovaAN.Sprint6.Task2.V18.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint6.Task2.V18
{
    public partial class FormMain_SAN : Form
    {
        public FormMain_SAN()
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

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartResult_SAN.Titles.Add("График функции 3cos(x)/(4x-0.5)+sinx-5x-2");

                this.chartResult_SAN.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_SAN.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_SAN.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartResult_SAN.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;

                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SAN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИСТНб-23-1 Шаукерова Аделия Нуржановн", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_SAN_MouseEnter_1(object sender, EventArgs e)
        {
            buttonDone_SAN.BackColor = Color.Red;
        }

        private void buttonDone_SAN_MouseLeave_1(object sender, EventArgs e)
        {
            buttonDone_SAN.BackColor = Color.Green;
        }

        private void buttonDone_SAN_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_SAN.BackColor = Color.Blue;
        }
    }
}
