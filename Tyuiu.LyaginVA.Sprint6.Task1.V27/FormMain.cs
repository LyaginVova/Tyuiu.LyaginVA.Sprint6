using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LyaginVA.Sprint6.Task1.V27.Lib;

namespace Tyuiu.LyaginVA.Sprint6.Task1.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonResult_LVA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVarA_LVA.Text);
                int stopStep = Convert.ToInt32(textBoxVarB_LVA.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxAnswer_LVA.Text = "";
                textBoxAnswer_LVA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxAnswer_LVA.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxAnswer_LVA.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len -1; i++)
                {
                    strLine =String.Format("|{0,5:d}     | {1, 5:f2}    |", startStep, valueArray[i]);
                    textBoxAnswer_LVA.AppendText(strLine + Environment.NewLine);
                    startStep++;

                }

                textBoxAnswer_LVA.AppendText("+----------+----------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonReference_LVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУБ-23-2 Лягин Владимир Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
