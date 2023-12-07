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
using Tyuiu.LyaginVA.Sprint6.Task6.V30.Lib;

namespace Tyuiu.LyaginVA.Sprint6.Task6.V30
{
    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            InitializeComponent();
            buttonDone_LVA.Enabled = false;
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_LVA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_LVA.ShowDialog();
            openFilePath = openFileDialogTask_LVA.FileName;
            textBoxLoadData_LVA.Text = File.ReadAllText(openFilePath);
            groupBoxInputData_LVA.Text = groupBoxInputData_LVA.Text + " " + openFileDialogTask_LVA.FileName;
            buttonDone_LVA.Enabled = true;
            
        }

        private void buttonDone_LVA_Click(object sender, EventArgs e)
        {
            textBoxResult_LVA.Text = ds.CollectTextFromFile(openFilePath);
            
        }

        private void buttonHelp_LVA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();

        }
    }
}
