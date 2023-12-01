using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LyaginVA.Sprint6.Task3.V26.Lib;

namespace Tyuiu.LyaginVA.Sprint6.Task3.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int [,] mtrx = new int[5, 5] { { 16, 19, 17, 2, 8 },
                                       { -17, 8, -17, -8, 1 },
                                       { -7, 17, -2, 1, -3 },
                                       { -12, 0, -17, 15, 6 },
                                       { 17, -6, -17, 18, -19 } };
        

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_LVA.ColumnCount = columns;
            dataGridViewMatrix_LVA.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_LVA.Columns[i].Width = 30;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++ )
                {
                    dataGridViewMatrix_LVA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
                
                
            }

        }

        private void buttonReference_LVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУБ-23-2 Лягин Владимир Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResult_LVA_Click(object sender, EventArgs e)
        {
            
            int[,] resultMatrix = ds.Calculate(mtrx);

            
            dataGridViewMatrixResult_LVA.Rows.Clear();
            dataGridViewMatrixResult_LVA.Columns.Clear();

            
            int rows = resultMatrix.GetUpperBound(0) + 1;
            int columns = resultMatrix.Length / rows;

            
            dataGridViewMatrixResult_LVA.ColumnCount = columns;
            dataGridViewMatrixResult_LVA.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrixResult_LVA.Columns[i].Width = 30;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrixResult_LVA.Rows[i].Cells[j].Value = resultMatrix[i, j].ToString();
                }
            }
        }
    }
}
