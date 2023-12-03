using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ShaukerovaAN.Sprint6.Task3.V10.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint6.Task3.V10
{
    public partial class FormMain_SAN : Form
    {
        public FormMain_SAN()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        int[,] matrix = new int[5, 5] { { -17, 6, -19, 6, -13 },
                                           { -19, 3, 12, -11, 19 },
                                           { -20, 11, 9, 19, -19 },
                                           { -20, 10, -9, 17, 9 },
                                           { -4, 9, -8, 13, -8 } };


        private void buttonHelp_SAN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСТНб-23-1 Шаукерова Аделия Нуржановна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load_SAN(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMatrix_SAN.ColumnCount = columns;
            dataGridViewMatrix_SAN.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_SAN.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_SAN.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonDone_SAN_Click(object sender, EventArgs e)
        {
            int[,] matrixres = ds.Calculate(matrix);

            int rows = matrixres.GetUpperBound(0) + 1;
            int columns = matrixres.Length / rows;

            dataGridViewResult_SAN.ColumnCount = columns;
            dataGridViewResult_SAN.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_SAN.Columns[i].Width = 50;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_SAN.Rows[i].Cells[j].Value = Convert.ToString(matrixres[i, j]);
                }
            }
        }
    }
}
