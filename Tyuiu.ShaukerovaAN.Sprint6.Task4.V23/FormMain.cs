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

using Tyuiu.ShaukerovaAN.Sprint6.Task4.V23.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint6.Task4.V23
{
    public partial class FormMain_SAN : Form
    {
        public FormMain_SAN()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

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

                //this.chartFunction.Titles.Add("График функции f(x)=4 - 2X+(2+Cos(x)/ 2x-2)")

                this.chartResult_SAN.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_SAN.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutput_SAN.Text = "";

                chartResult_SAN.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartResult_SAN.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxOutput_SAN.AppendText(valueArray[i] + Environment.NewLine);
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
            MessageBox.Show("Таск 4 выполнил студент группы ИСТНб-23-1 Шаукерова Аделия Нуржановна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_SAN_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V23.txt";
                File.WriteAllText(path, textBoxOutput_SAN.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранён успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
