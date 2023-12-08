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
using Tyuiu.LyaginVA.Sprint6.Task7.V15.Lib;

namespace Tyuiu.LyaginVA.Sprint6.Task7.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_LVA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialogMatrix_LVA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        static string openFile;
        static int rows;
        static int columns;
        DataService ds = new DataService();
        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

            private void buttonOpenFile_LVA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_LVA.ShowDialog();
            openFile = openFileDialogTask_LVA.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFile);

            dataGridViewInMatrix_LVA.RowCount = rows;
            dataGridViewInMatrix_LVA.ColumnCount = columns;
            dataGridViewOutMatrix_LVA.RowCount = rows;
            dataGridViewOutMatrix_LVA.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInMatrix_LVA.Columns[i].Width = 50;
                dataGridViewOutMatrix_LVA.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInMatrix_LVA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFile);
            buttonDone_LVA.Enabled = true;

        }

        private void buttonOpenFile_LVA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_LVA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_LVA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_LVA.ToolTipTitle = "Выполнить";

        }

        private void buttonSavefile_LVA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_LVA.ToolTipTitle = "Сохранить файл";
        }

        private void buttonHelp_LVA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_LVA.ToolTipTitle = "Справка";
        }

        private void buttonHelp_LVA_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }

        private void buttonSavefile_LVA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_LVA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_LVA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_LVA.ShowDialog();

            string path = saveFileDialogMatrix_LVA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix_LVA.RowCount;
            int columns = dataGridViewOutMatrix_LVA.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewInMatrix_LVA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewInMatrix_LVA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInMatrix_LVA.RowCount = 50;
            dataGridViewOutMatrix_LVA.RowCount = 50;

            dataGridViewInMatrix_LVA.ColumnCount = 50;
            dataGridViewOutMatrix_LVA.ColumnCount = 50;

            panelInputData_LVA.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInMatrix_LVA.Columns[i].Width = 25;
                dataGridViewOutMatrix_LVA.Columns[i].Width = 25;
            }
        }

        private void buttonDone_LVA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFile);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutMatrix_LVA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSavefile_LVA.Enabled = true;
        }
    }
}
