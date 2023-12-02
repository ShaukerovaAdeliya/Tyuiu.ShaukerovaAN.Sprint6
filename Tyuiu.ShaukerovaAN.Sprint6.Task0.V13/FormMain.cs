using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ShaukerovaAN.Sprint6.Task0.V13.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint6.Task0.V13
{
    public partial class FormMain_SAN : Form
    {
        public FormMain_SAN()
        {
            InitializeComponent();
        }

        private void buttonDone_SAN_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_SAN.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarA_SAN.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBoxVarA_SAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != 1) && (e.KeyChar != ',') && (e.KeyChar == -1))
            {
                e.Handled = true;
            }
        }


        private void buttonHelp_SAN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИСТНб-23-1 Шаукерова Аделия Нуржановна", "Сообщение");
        }

        
    }
}
