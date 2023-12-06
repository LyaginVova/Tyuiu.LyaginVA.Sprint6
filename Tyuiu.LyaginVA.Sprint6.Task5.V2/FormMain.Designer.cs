
namespace Tyuiu.LyaginVA.Sprint6.Task5.V2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelCondition_LVA = new System.Windows.Forms.Panel();
            this.buttonReference_LVA = new System.Windows.Forms.Button();
            this.buttonOpenFile_LVA = new System.Windows.Forms.Button();
            this.buttonResult_LVA = new System.Windows.Forms.Button();
            this.groupBoxCondition_LVA = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_LVA = new System.Windows.Forms.TextBox();
            this.panelChar_LVA = new System.Windows.Forms.Panel();
            this.splitterOut_LVA = new System.Windows.Forms.Splitter();
            this.chartFunction_LVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelOutPutData_LVA = new System.Windows.Forms.Panel();
            this.groupBoxOutputData_LVA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_LVA = new System.Windows.Forms.DataGridView();
            this.panelCondition_LVA.SuspendLayout();
            this.groupBoxCondition_LVA.SuspendLayout();
            this.panelChar_LVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_LVA)).BeginInit();
            this.panelOutPutData_LVA.SuspendLayout();
            this.groupBoxOutputData_LVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_LVA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCondition_LVA
            // 
            this.panelCondition_LVA.Controls.Add(this.buttonReference_LVA);
            this.panelCondition_LVA.Controls.Add(this.buttonOpenFile_LVA);
            this.panelCondition_LVA.Controls.Add(this.buttonResult_LVA);
            this.panelCondition_LVA.Controls.Add(this.groupBoxCondition_LVA);
            this.panelCondition_LVA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondition_LVA.Location = new System.Drawing.Point(0, 0);
            this.panelCondition_LVA.Name = "panelCondition_LVA";
            this.panelCondition_LVA.Size = new System.Drawing.Size(864, 100);
            this.panelCondition_LVA.TabIndex = 0;
            // 
            // buttonReference_LVA
            // 
            this.buttonReference_LVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReference_LVA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonReference_LVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReference_LVA.Location = new System.Drawing.Point(751, 12);
            this.buttonReference_LVA.Name = "buttonReference_LVA";
            this.buttonReference_LVA.Size = new System.Drawing.Size(101, 76);
            this.buttonReference_LVA.TabIndex = 2;
            this.buttonReference_LVA.Text = "Справка";
            this.buttonReference_LVA.UseVisualStyleBackColor = false;
            this.buttonReference_LVA.Click += new System.EventHandler(this.buttonReference_LVA_Click);
            // 
            // buttonOpenFile_LVA
            // 
            this.buttonOpenFile_LVA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpenFile_LVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile_LVA.Location = new System.Drawing.Point(632, 12);
            this.buttonOpenFile_LVA.Name = "buttonOpenFile_LVA";
            this.buttonOpenFile_LVA.Size = new System.Drawing.Size(113, 76);
            this.buttonOpenFile_LVA.TabIndex = 2;
            this.buttonOpenFile_LVA.Text = "Открыть \r\nфайл\r\n";
            this.buttonOpenFile_LVA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_LVA.Click += new System.EventHandler(this.buttonOpenFile_LVA_Click);
            // 
            // buttonResult_LVA
            // 
            this.buttonResult_LVA.BackColor = System.Drawing.Color.Green;
            this.buttonResult_LVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult_LVA.Location = new System.Drawing.Point(516, 12);
            this.buttonResult_LVA.Name = "buttonResult_LVA";
            this.buttonResult_LVA.Size = new System.Drawing.Size(110, 76);
            this.buttonResult_LVA.TabIndex = 2;
            this.buttonResult_LVA.Text = "Выполнить";
            this.buttonResult_LVA.UseVisualStyleBackColor = false;
            this.buttonResult_LVA.Click += new System.EventHandler(this.buttonResult_LVA_Click);
            // 
            // groupBoxCondition_LVA
            // 
            this.groupBoxCondition_LVA.Controls.Add(this.textBoxCondition_LVA);
            this.groupBoxCondition_LVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_LVA.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCondition_LVA.Name = "groupBoxCondition_LVA";
            this.groupBoxCondition_LVA.Size = new System.Drawing.Size(507, 91);
            this.groupBoxCondition_LVA.TabIndex = 1;
            this.groupBoxCondition_LVA.TabStop = false;
            this.groupBoxCondition_LVA.Text = "Условие";
            // 
            // textBoxCondition_LVA
            // 
            this.textBoxCondition_LVA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCondition_LVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_LVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCondition_LVA.Location = new System.Drawing.Point(10, 20);
            this.textBoxCondition_LVA.Multiline = true;
            this.textBoxCondition_LVA.Name = "textBoxCondition_LVA";
            this.textBoxCondition_LVA.ReadOnly = true;
            this.textBoxCondition_LVA.Size = new System.Drawing.Size(454, 65);
            this.textBoxCondition_LVA.TabIndex = 0;
            this.textBoxCondition_LVA.TabStop = false;
            this.textBoxCondition_LVA.Text = "Прочитать данные из файла InPutFileTask5V2.txt. Вывести в dataGridView\r\nотрицател" +
    "ьные числа и построить диаграмму по этим значениям.";
            // 
            // panelChar_LVA
            // 
            this.panelChar_LVA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChar_LVA.Controls.Add(this.splitterOut_LVA);
            this.panelChar_LVA.Controls.Add(this.chartFunction_LVA);
            this.panelChar_LVA.Location = new System.Drawing.Point(203, 100);
            this.panelChar_LVA.Name = "panelChar_LVA";
            this.panelChar_LVA.Size = new System.Drawing.Size(661, 350);
            this.panelChar_LVA.TabIndex = 0;
            // 
            // splitterOut_LVA
            // 
            this.splitterOut_LVA.Location = new System.Drawing.Point(0, 0);
            this.splitterOut_LVA.Name = "splitterOut_LVA";
            this.splitterOut_LVA.Size = new System.Drawing.Size(3, 350);
            this.splitterOut_LVA.TabIndex = 1;
            this.splitterOut_LVA.TabStop = false;
            // 
            // chartFunction_LVA
            // 
            this.chartFunction_LVA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartFunction_LVA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_LVA.Legends.Add(legend2);
            this.chartFunction_LVA.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_LVA.Name = "chartFunction_LVA";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_LVA.Series.Add(series2);
            this.chartFunction_LVA.Size = new System.Drawing.Size(774, 350);
            this.chartFunction_LVA.TabIndex = 0;
            this.chartFunction_LVA.Text = "chartFunction_LVA";
            // 
            // panelOutPutData_LVA
            // 
            this.panelOutPutData_LVA.Controls.Add(this.groupBoxOutputData_LVA);
            this.panelOutPutData_LVA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutPutData_LVA.Location = new System.Drawing.Point(0, 100);
            this.panelOutPutData_LVA.Name = "panelOutPutData_LVA";
            this.panelOutPutData_LVA.Size = new System.Drawing.Size(200, 350);
            this.panelOutPutData_LVA.TabIndex = 1;
            // 
            // groupBoxOutputData_LVA
            // 
            this.groupBoxOutputData_LVA.Controls.Add(this.dataGridViewResult_LVA);
            this.groupBoxOutputData_LVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputData_LVA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutputData_LVA.Name = "groupBoxOutputData_LVA";
            this.groupBoxOutputData_LVA.Size = new System.Drawing.Size(200, 350);
            this.groupBoxOutputData_LVA.TabIndex = 0;
            this.groupBoxOutputData_LVA.TabStop = false;
            this.groupBoxOutputData_LVA.Text = "Вывод данных:";
            // 
            // dataGridViewResult_LVA
            // 
            this.dataGridViewResult_LVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_LVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_LVA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_LVA.Name = "dataGridViewResult_LVA";
            this.dataGridViewResult_LVA.ReadOnly = true;
            this.dataGridViewResult_LVA.RowHeadersVisible = false;
            this.dataGridViewResult_LVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewResult_LVA.Size = new System.Drawing.Size(194, 331);
            this.dataGridViewResult_LVA.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.panelOutPutData_LVA);
            this.Controls.Add(this.panelChar_LVA);
            this.Controls.Add(this.panelCondition_LVA);
            this.MinimumSize = new System.Drawing.Size(880, 489);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 2 | Лягин В.А.";
            this.panelCondition_LVA.ResumeLayout(false);
            this.groupBoxCondition_LVA.ResumeLayout(false);
            this.groupBoxCondition_LVA.PerformLayout();
            this.panelChar_LVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_LVA)).EndInit();
            this.panelOutPutData_LVA.ResumeLayout(false);
            this.groupBoxOutputData_LVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_LVA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCondition_LVA;
        private System.Windows.Forms.Panel panelChar_LVA;
        private System.Windows.Forms.GroupBox groupBoxCondition_LVA;
        private System.Windows.Forms.Button buttonReference_LVA;
        private System.Windows.Forms.Button buttonOpenFile_LVA;
        private System.Windows.Forms.Button buttonResult_LVA;
        private System.Windows.Forms.TextBox textBoxCondition_LVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_LVA;
        private System.Windows.Forms.Splitter splitterOut_LVA;
        private System.Windows.Forms.Panel panelOutPutData_LVA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_LVA;
        private System.Windows.Forms.DataGridView dataGridViewResult_LVA;
    }
}

