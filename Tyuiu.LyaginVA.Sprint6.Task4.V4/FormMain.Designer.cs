
namespace Tyuiu.LyaginVA.Sprint6.Task4.V4
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxCondition_LVA = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_LVA = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxInputData_LVA = new System.Windows.Forms.GroupBox();
            this.textBoxVarB_LVA = new System.Windows.Forms.TextBox();
            this.textBoxEnd_LVA = new System.Windows.Forms.TextBox();
            this.textBoxVarA_LVA = new System.Windows.Forms.TextBox();
            this.textBoxStart_LVA = new System.Windows.Forms.TextBox();
            this.buttonResult_LVA = new System.Windows.Forms.Button();
            this.buttonReference_LVA = new System.Windows.Forms.Button();
            this.groupBoxOutputData_LVA = new System.Windows.Forms.GroupBox();
            this.textBoxAnswer_LVA = new System.Windows.Forms.TextBox();
            this.buttonSave_LVA = new System.Windows.Forms.Button();
            this.panelOutputData_LVA = new System.Windows.Forms.Panel();
            this.chartFunction_LVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelCondition_LVA = new System.Windows.Forms.Panel();
            this.panelFuncation_LVA = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxCondition_LVA.SuspendLayout();
            this.groupBoxInputData_LVA.SuspendLayout();
            this.groupBoxOutputData_LVA.SuspendLayout();
            this.panelOutputData_LVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_LVA)).BeginInit();
            this.panelCondition_LVA.SuspendLayout();
            this.panelFuncation_LVA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_LVA
            // 
            this.groupBoxCondition_LVA.Controls.Add(this.textBoxCondition_LVA);
            this.groupBoxCondition_LVA.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCondition_LVA.Name = "groupBoxCondition_LVA";
            this.groupBoxCondition_LVA.Size = new System.Drawing.Size(418, 69);
            this.groupBoxCondition_LVA.TabIndex = 0;
            this.groupBoxCondition_LVA.TabStop = false;
            this.groupBoxCondition_LVA.Text = "Условие";
            // 
            // textBoxCondition_LVA
            // 
            this.textBoxCondition_LVA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCondition_LVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_LVA.Location = new System.Drawing.Point(6, 16);
            this.textBoxCondition_LVA.Multiline = true;
            this.textBoxCondition_LVA.Name = "textBoxCondition_LVA";
            this.textBoxCondition_LVA.ReadOnly = true;
            this.textBoxCondition_LVA.Size = new System.Drawing.Size(405, 47);
            this.textBoxCondition_LVA.TabIndex = 0;
            this.textBoxCondition_LVA.TabStop = false;
            this.textBoxCondition_LVA.Text = "Протабулировать функцию на заданном диапозоне от -5 до 5.\r\nРезультат вывести в te" +
    "xtBox, построить график функции и сохранить в файл\r\nOutPutFileTask4V4.txt по наж" +
    "атию кнопки.";
            // 
            // groupBoxInputData_LVA
            // 
            this.groupBoxInputData_LVA.Controls.Add(this.textBoxVarB_LVA);
            this.groupBoxInputData_LVA.Controls.Add(this.textBoxEnd_LVA);
            this.groupBoxInputData_LVA.Controls.Add(this.textBoxVarA_LVA);
            this.groupBoxInputData_LVA.Controls.Add(this.textBoxStart_LVA);
            this.groupBoxInputData_LVA.Location = new System.Drawing.Point(427, 3);
            this.groupBoxInputData_LVA.Name = "groupBoxInputData_LVA";
            this.groupBoxInputData_LVA.Size = new System.Drawing.Size(279, 69);
            this.groupBoxInputData_LVA.TabIndex = 1;
            this.groupBoxInputData_LVA.TabStop = false;
            this.groupBoxInputData_LVA.Text = "Ввод данных";
            // 
            // textBoxVarB_LVA
            // 
            this.textBoxVarB_LVA.Location = new System.Drawing.Point(144, 35);
            this.textBoxVarB_LVA.Name = "textBoxVarB_LVA";
            this.textBoxVarB_LVA.Size = new System.Drawing.Size(129, 20);
            this.textBoxVarB_LVA.TabIndex = 0;
            // 
            // textBoxEnd_LVA
            // 
            this.textBoxEnd_LVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEnd_LVA.Location = new System.Drawing.Point(144, 16);
            this.textBoxEnd_LVA.Name = "textBoxEnd_LVA";
            this.textBoxEnd_LVA.ReadOnly = true;
            this.textBoxEnd_LVA.Size = new System.Drawing.Size(100, 13);
            this.textBoxEnd_LVA.TabIndex = 0;
            this.textBoxEnd_LVA.TabStop = false;
            this.textBoxEnd_LVA.Text = "Конец шага:";
            // 
            // textBoxVarA_LVA
            // 
            this.textBoxVarA_LVA.Location = new System.Drawing.Point(6, 35);
            this.textBoxVarA_LVA.Name = "textBoxVarA_LVA";
            this.textBoxVarA_LVA.Size = new System.Drawing.Size(132, 20);
            this.textBoxVarA_LVA.TabIndex = 0;
            // 
            // textBoxStart_LVA
            // 
            this.textBoxStart_LVA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxStart_LVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStart_LVA.Location = new System.Drawing.Point(6, 16);
            this.textBoxStart_LVA.Name = "textBoxStart_LVA";
            this.textBoxStart_LVA.ReadOnly = true;
            this.textBoxStart_LVA.Size = new System.Drawing.Size(100, 13);
            this.textBoxStart_LVA.TabIndex = 0;
            this.textBoxStart_LVA.TabStop = false;
            this.textBoxStart_LVA.Text = "Старт шага:";
            // 
            // buttonResult_LVA
            // 
            this.buttonResult_LVA.BackColor = System.Drawing.Color.Green;
            this.buttonResult_LVA.Location = new System.Drawing.Point(712, 3);
            this.buttonResult_LVA.Name = "buttonResult_LVA";
            this.buttonResult_LVA.Size = new System.Drawing.Size(98, 69);
            this.buttonResult_LVA.TabIndex = 1;
            this.buttonResult_LVA.Text = "Выполнить";
            this.buttonResult_LVA.UseVisualStyleBackColor = false;
            this.buttonResult_LVA.Click += new System.EventHandler(this.buttonResult_LVA_Click);
            // 
            // buttonReference_LVA
            // 
            this.buttonReference_LVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReference_LVA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonReference_LVA.Location = new System.Drawing.Point(930, 3);
            this.buttonReference_LVA.Name = "buttonReference_LVA";
            this.buttonReference_LVA.Size = new System.Drawing.Size(102, 69);
            this.buttonReference_LVA.TabIndex = 1;
            this.buttonReference_LVA.Text = "Справка";
            this.buttonReference_LVA.UseVisualStyleBackColor = false;
            this.buttonReference_LVA.Click += new System.EventHandler(this.buttonReference_LVA_Click);
            // 
            // groupBoxOutputData_LVA
            // 
            this.groupBoxOutputData_LVA.Controls.Add(this.textBoxAnswer_LVA);
            this.groupBoxOutputData_LVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputData_LVA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutputData_LVA.Name = "groupBoxOutputData_LVA";
            this.groupBoxOutputData_LVA.Size = new System.Drawing.Size(259, 561);
            this.groupBoxOutputData_LVA.TabIndex = 2;
            this.groupBoxOutputData_LVA.TabStop = false;
            this.groupBoxOutputData_LVA.Text = "Вывод :";
            // 
            // textBoxAnswer_LVA
            // 
            this.textBoxAnswer_LVA.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAnswer_LVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAnswer_LVA.Location = new System.Drawing.Point(3, 16);
            this.textBoxAnswer_LVA.Multiline = true;
            this.textBoxAnswer_LVA.Name = "textBoxAnswer_LVA";
            this.textBoxAnswer_LVA.ReadOnly = true;
            this.textBoxAnswer_LVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAnswer_LVA.Size = new System.Drawing.Size(253, 542);
            this.textBoxAnswer_LVA.TabIndex = 1;
            this.textBoxAnswer_LVA.TabStop = false;
            // 
            // buttonSave_LVA
            // 
            this.buttonSave_LVA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave_LVA.Location = new System.Drawing.Point(816, 3);
            this.buttonSave_LVA.Name = "buttonSave_LVA";
            this.buttonSave_LVA.Size = new System.Drawing.Size(102, 69);
            this.buttonSave_LVA.TabIndex = 1;
            this.buttonSave_LVA.Text = "Сохранить";
            this.buttonSave_LVA.UseVisualStyleBackColor = false;
            this.buttonSave_LVA.Click += new System.EventHandler(this.buttonSave_LVA_Click);
            // 
            // panelOutputData_LVA
            // 
            this.panelOutputData_LVA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOutputData_LVA.Controls.Add(this.groupBoxOutputData_LVA);
            this.panelOutputData_LVA.Location = new System.Drawing.Point(0, 78);
            this.panelOutputData_LVA.Name = "panelOutputData_LVA";
            this.panelOutputData_LVA.Size = new System.Drawing.Size(259, 561);
            this.panelOutputData_LVA.TabIndex = 2;
            // 
            // chartFunction_LVA
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFunction_LVA.ChartAreas.Add(chartArea4);
            this.chartFunction_LVA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chartFunction_LVA.Legends.Add(legend4);
            this.chartFunction_LVA.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_LVA.Name = "chartFunction_LVA";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "SeriesFunction";
            this.chartFunction_LVA.Series.Add(series4);
            this.chartFunction_LVA.Size = new System.Drawing.Size(779, 561);
            this.chartFunction_LVA.TabIndex = 2;
            this.chartFunction_LVA.Text = "chartFunction_LVA";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            title4.Name = "TitleFunction_LVA";
            title4.Text = "График функции";
            this.chartFunction_LVA.Titles.Add(title4);
            // 
            // panelCondition_LVA
            // 
            this.panelCondition_LVA.Controls.Add(this.groupBoxCondition_LVA);
            this.panelCondition_LVA.Controls.Add(this.groupBoxInputData_LVA);
            this.panelCondition_LVA.Controls.Add(this.buttonResult_LVA);
            this.panelCondition_LVA.Controls.Add(this.buttonReference_LVA);
            this.panelCondition_LVA.Controls.Add(this.buttonSave_LVA);
            this.panelCondition_LVA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondition_LVA.Location = new System.Drawing.Point(0, 0);
            this.panelCondition_LVA.Name = "panelCondition_LVA";
            this.panelCondition_LVA.Size = new System.Drawing.Size(1044, 78);
            this.panelCondition_LVA.TabIndex = 3;
            // 
            // panelFuncation_LVA
            // 
            this.panelFuncation_LVA.Controls.Add(this.splitter1);
            this.panelFuncation_LVA.Controls.Add(this.chartFunction_LVA);
            this.panelFuncation_LVA.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFuncation_LVA.Location = new System.Drawing.Point(265, 78);
            this.panelFuncation_LVA.Name = "panelFuncation_LVA";
            this.panelFuncation_LVA.Size = new System.Drawing.Size(779, 561);
            this.panelFuncation_LVA.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 561);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 639);
            this.Controls.Add(this.panelFuncation_LVA);
            this.Controls.Add(this.panelCondition_LVA);
            this.Controls.Add(this.panelOutputData_LVA);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1060, 678);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 4 | Лягин В.А.";
            this.groupBoxCondition_LVA.ResumeLayout(false);
            this.groupBoxCondition_LVA.PerformLayout();
            this.groupBoxInputData_LVA.ResumeLayout(false);
            this.groupBoxInputData_LVA.PerformLayout();
            this.groupBoxOutputData_LVA.ResumeLayout(false);
            this.groupBoxOutputData_LVA.PerformLayout();
            this.panelOutputData_LVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_LVA)).EndInit();
            this.panelCondition_LVA.ResumeLayout(false);
            this.panelFuncation_LVA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_LVA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxCondition_LVA;
        private System.Windows.Forms.GroupBox groupBoxInputData_LVA;
        private System.Windows.Forms.TextBox textBoxVarB_LVA;
        private System.Windows.Forms.TextBox textBoxEnd_LVA;
        private System.Windows.Forms.TextBox textBoxVarA_LVA;
        private System.Windows.Forms.TextBox textBoxStart_LVA;
        private System.Windows.Forms.Button buttonResult_LVA;
        private System.Windows.Forms.Button buttonReference_LVA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_LVA;
        private System.Windows.Forms.TextBox textBoxAnswer_LVA;
        private System.Windows.Forms.Button buttonSave_LVA;
        private System.Windows.Forms.Panel panelOutputData_LVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_LVA;
        private System.Windows.Forms.Panel panelCondition_LVA;
        private System.Windows.Forms.Panel panelFuncation_LVA;
        private System.Windows.Forms.Splitter splitter1;
    }
}

