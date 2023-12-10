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
using Tyuiu.ShaukerovaAN.Sprint6.Task7.V26.Lib;
namespace Tyuiu.ShaukerovaAN.Sprint6.Task7.V26
{
    public partial class FormMain_SAN : Form
    {
        public FormMain_SAN()
        {
            InitializeComponent();
            openFileDialogOpen_SAN.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_SAN.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();


        private void buttonOpen_SAN_MouseEnter(object sender, EventArgs e)
        {
            toolTipOpen_SAN.ToolTipTitle = "Открыть файл";
        }

        private void buttonDoIt_SAN_MouseEnter(object sender, EventArgs e)
        {
            toolTipDoIt_SAN.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_SAN_MouseEnter(object sender, EventArgs e)
        {
            toolTipSave_SAN.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_SAN_MouseEnter(object sender, EventArgs e)
        {
            toolTipHelp_SAN.ToolTipTitle = "Справка";
        }
       

        private void FormMain_SAN_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_SAN.ColumnCount = 50;
            dataGridViewOutPut_SAN.ColumnCount = 50;

            dataGridViewInPut_SAN.RowCount = 50;
            dataGridViewOutPut_SAN.RowCount = 50;
        }
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void buttonOpen_SAN_Click(object sender, EventArgs e)
        {
            openFileDialogOpen_SAN.ShowDialog();
            openFilePath = openFileDialogOpen_SAN.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_SAN.ColumnCount = columns;
            dataGridViewInPut_SAN.RowCount = rows;
            dataGridViewOutPut_SAN.RowCount = rows;
            dataGridViewOutPut_SAN.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_SAN.Columns[i].Width = 25;
                dataGridViewOutPut_SAN.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_SAN.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDoIt_SAN.Enabled = true;
        }

        private void buttonDoIt_SAN_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_SAN.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_SAN.Enabled = true;

        }

        private void buttonSave_SAN_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SAN.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_SAN.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SAN.ShowDialog();

            string path = saveFileDialogMatrix_SAN.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_SAN.RowCount;
            int columns = dataGridViewOutPut_SAN.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_SAN.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_SAN.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void buttonHelp_SAN_Click_1(object sender, EventArgs e)
        {
            FormAbout_SAN formAbout = new FormAbout_SAN();
            formAbout.ShowDialog();
        }
    }
}
