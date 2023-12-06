using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LyaginVA.Sprint6.Task5.V2.Lib;

namespace Tyuiu.LyaginVA.Sprint6.Task5.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\vova\source\repos\Tyuiu.LyaginVA.Sprint6\Tyuiu.LyaginVA.Sprint6.Task5.V2\bin\Debug\InPutFileTask5V2.txt";

        private void buttonResult_LVA_Click(object sender, EventArgs e)
        {
            dataGridViewResult_LVA.ColumnCount = 2;
            dataGridViewResult_LVA.Columns[0].Width = 20;
            dataGridViewResult_LVA.Columns[1].Width = 50;
            this.chartFunction_LVA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_LVA.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction_LVA.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for(int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_LVA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_LVA.Series[0].Points.AddXY(i, numsMass[i]);
            }


        }



        private void buttonReference_LVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУБ-23-2 Лягин Владимир Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpenFile_LVA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
