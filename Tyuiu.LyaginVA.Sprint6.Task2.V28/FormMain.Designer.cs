
namespace Tyuiu.LyaginVA.Sprint6.Task2.V28
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_LVA = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_LVA = new System.Windows.Forms.PictureBox();
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
            this.chartFunction_LVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_LVA = new System.Windows.Forms.DataGridView();
            this.ColumnVarX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFunction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxResult_LVA = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxCondition_LVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_LVA)).BeginInit();
            this.groupBoxInputData_LVA.SuspendLayout();
            this.groupBoxOutputData_LVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_LVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_LVA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_LVA
            // 
            this.groupBoxCondition_LVA.Controls.Add(this.pictureBoxFormula_LVA);
            this.groupBoxCondition_LVA.Controls.Add(this.textBoxCondition_LVA);
            this.groupBoxCondition_LVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_LVA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_LVA.Name = "groupBoxCondition_LVA";
            this.groupBoxCondition_LVA.Size = new System.Drawing.Size(521, 313);
            this.groupBoxCondition_LVA.TabIndex = 0;
            this.groupBoxCondition_LVA.TabStop = false;
            this.groupBoxCondition_LVA.Text = "Условие";
            // 
            // pictureBoxFormula_LVA
            // 
            this.pictureBoxFormula_LVA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_LVA.Image")));
            this.pictureBoxFormula_LVA.Location = new System.Drawing.Point(180, 54);
            this.pictureBoxFormula_LVA.Name = "pictureBoxFormula_LVA";
            this.pictureBoxFormula_LVA.Size = new System.Drawing.Size(341, 42);
            this.pictureBoxFormula_LVA.TabIndex = 4;
            this.pictureBoxFormula_LVA.TabStop = false;
            // 
            // textBoxCondition_LVA
            // 
            this.textBoxCondition_LVA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCondition_LVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_LVA.Location = new System.Drawing.Point(6, 19);
            this.textBoxCondition_LVA.Multiline = true;
            this.textBoxCondition_LVA.Name = "textBoxCondition_LVA";
            this.textBoxCondition_LVA.ReadOnly = true;
            this.textBoxCondition_LVA.Size = new System.Drawing.Size(438, 250);
            this.textBoxCondition_LVA.TabIndex = 0;
            this.textBoxCondition_LVA.TabStop = false;
            this.textBoxCondition_LVA.Text = "Протабулировать функцию по формуле на заданном диапозоне.\r\nРезультат вывести в Da" +
    "taGridView и построить график функции.";
            // 
            // groupBoxInputData_LVA
            // 
            this.groupBoxInputData_LVA.Controls.Add(this.textBoxVarB_LVA);
            this.groupBoxInputData_LVA.Controls.Add(this.textBoxEnd_LVA);
            this.groupBoxInputData_LVA.Controls.Add(this.textBoxVarA_LVA);
            this.groupBoxInputData_LVA.Controls.Add(this.textBoxStart_LVA);
            this.groupBoxInputData_LVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputData_LVA.Location = new System.Drawing.Point(12, 331);
            this.groupBoxInputData_LVA.Name = "groupBoxInputData_LVA";
            this.groupBoxInputData_LVA.Size = new System.Drawing.Size(307, 100);
            this.groupBoxInputData_LVA.TabIndex = 1;
            this.groupBoxInputData_LVA.TabStop = false;
            this.groupBoxInputData_LVA.Text = "Ввод данных";
            // 
            // textBoxVarB_LVA
            // 
            this.textBoxVarB_LVA.Location = new System.Drawing.Point(153, 51);
            this.textBoxVarB_LVA.Name = "textBoxVarB_LVA";
            this.textBoxVarB_LVA.Size = new System.Drawing.Size(148, 23);
            this.textBoxVarB_LVA.TabIndex = 0;
            // 
            // textBoxEnd_LVA
            // 
            this.textBoxEnd_LVA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxEnd_LVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEnd_LVA.Location = new System.Drawing.Point(153, 22);
            this.textBoxEnd_LVA.Name = "textBoxEnd_LVA";
            this.textBoxEnd_LVA.ReadOnly = true;
            this.textBoxEnd_LVA.Size = new System.Drawing.Size(100, 16);
            this.textBoxEnd_LVA.TabIndex = 0;
            this.textBoxEnd_LVA.TabStop = false;
            this.textBoxEnd_LVA.Text = "Конец шага:";
            // 
            // textBoxVarA_LVA
            // 
            this.textBoxVarA_LVA.Location = new System.Drawing.Point(6, 51);
            this.textBoxVarA_LVA.Name = "textBoxVarA_LVA";
            this.textBoxVarA_LVA.Size = new System.Drawing.Size(127, 23);
            this.textBoxVarA_LVA.TabIndex = 0;
            // 
            // textBoxStart_LVA
            // 
            this.textBoxStart_LVA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxStart_LVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStart_LVA.Location = new System.Drawing.Point(6, 22);
            this.textBoxStart_LVA.Name = "textBoxStart_LVA";
            this.textBoxStart_LVA.ReadOnly = true;
            this.textBoxStart_LVA.Size = new System.Drawing.Size(100, 16);
            this.textBoxStart_LVA.TabIndex = 0;
            this.textBoxStart_LVA.TabStop = false;
            this.textBoxStart_LVA.Text = "Старт шага:";
            // 
            // buttonResult_LVA
            // 
            this.buttonResult_LVA.BackColor = System.Drawing.Color.Green;
            this.buttonResult_LVA.Location = new System.Drawing.Point(420, 346);
            this.buttonResult_LVA.Name = "buttonResult_LVA";
            this.buttonResult_LVA.Size = new System.Drawing.Size(113, 85);
            this.buttonResult_LVA.TabIndex = 1;
            this.buttonResult_LVA.Text = "Выполнить";
            this.buttonResult_LVA.UseVisualStyleBackColor = false;
            this.buttonResult_LVA.Click += new System.EventHandler(this.buttonResult_LVA_Click);
            this.buttonResult_LVA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonResult_LVA_MouseDown);
            this.buttonResult_LVA.MouseEnter += new System.EventHandler(this.buttonResult_LVA_MouseEnter);
            this.buttonResult_LVA.MouseLeave += new System.EventHandler(this.buttonResult_LVA_MouseLeave);
            // 
            // buttonReference_LVA
            // 
            this.buttonReference_LVA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonReference_LVA.Location = new System.Drawing.Point(339, 346);
            this.buttonReference_LVA.Name = "buttonReference_LVA";
            this.buttonReference_LVA.Size = new System.Drawing.Size(75, 85);
            this.buttonReference_LVA.TabIndex = 2;
            this.buttonReference_LVA.Text = "Справка";
            this.buttonReference_LVA.UseVisualStyleBackColor = false;
            this.buttonReference_LVA.Click += new System.EventHandler(this.buttonReference_LVA_Click);
            // 
            // groupBoxOutputData_LVA
            // 
            this.groupBoxOutputData_LVA.Controls.Add(this.chartFunction_LVA);
            this.groupBoxOutputData_LVA.Controls.Add(this.dataGridViewFunction_LVA);
            this.groupBoxOutputData_LVA.Controls.Add(this.textBoxResult_LVA);
            this.groupBoxOutputData_LVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutputData_LVA.Location = new System.Drawing.Point(539, 12);
            this.groupBoxOutputData_LVA.Name = "groupBoxOutputData_LVA";
            this.groupBoxOutputData_LVA.Size = new System.Drawing.Size(575, 426);
            this.groupBoxOutputData_LVA.TabIndex = 3;
            this.groupBoxOutputData_LVA.TabStop = false;
            this.groupBoxOutputData_LVA.Text = "Вывод данных";
            // 
            // chartFunction_LVA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_LVA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_LVA.Legends.Add(legend1);
            this.chartFunction_LVA.Location = new System.Drawing.Point(138, 41);
            this.chartFunction_LVA.Name = "chartFunction_LVA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_LVA.Series.Add(series1);
            this.chartFunction_LVA.Size = new System.Drawing.Size(556, 378);
            this.chartFunction_LVA.TabIndex = 6;
            this.chartFunction_LVA.Text = "chartFunction_LVA";
            // 
            // dataGridViewFunction_LVA
            // 
            this.dataGridViewFunction_LVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_LVA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnVarX,
            this.ColumnFunction});
            this.dataGridViewFunction_LVA.Location = new System.Drawing.Point(6, 41);
            this.dataGridViewFunction_LVA.Name = "dataGridViewFunction_LVA";
            this.dataGridViewFunction_LVA.RowHeadersVisible = false;
            this.dataGridViewFunction_LVA.Size = new System.Drawing.Size(126, 378);
            this.dataGridViewFunction_LVA.TabIndex = 5;
            // 
            // ColumnVarX
            // 
            this.ColumnVarX.HeaderText = "X";
            this.ColumnVarX.Name = "ColumnVarX";
            this.ColumnVarX.Width = 50;
            // 
            // ColumnFunction
            // 
            this.ColumnFunction.HeaderText = "F(X)";
            this.ColumnFunction.Name = "ColumnFunction";
            this.ColumnFunction.Width = 50;
            // 
            // textBoxResult_LVA
            // 
            this.textBoxResult_LVA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult_LVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_LVA.Location = new System.Drawing.Point(6, 19);
            this.textBoxResult_LVA.Name = "textBoxResult_LVA";
            this.textBoxResult_LVA.ReadOnly = true;
            this.textBoxResult_LVA.Size = new System.Drawing.Size(100, 16);
            this.textBoxResult_LVA.TabIndex = 0;
            this.textBoxResult_LVA.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 450);
            this.Controls.Add(this.groupBoxOutputData_LVA);
            this.Controls.Add(this.buttonReference_LVA);
            this.Controls.Add(this.buttonResult_LVA);
            this.Controls.Add(this.groupBoxInputData_LVA);
            this.Controls.Add(this.groupBoxCondition_LVA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 28 | Лягин В.А.";
            this.groupBoxCondition_LVA.ResumeLayout(false);
            this.groupBoxCondition_LVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_LVA)).EndInit();
            this.groupBoxInputData_LVA.ResumeLayout(false);
            this.groupBoxInputData_LVA.PerformLayout();
            this.groupBoxOutputData_LVA.ResumeLayout(false);
            this.groupBoxOutputData_LVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_LVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_LVA)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxResult_LVA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_LVA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_LVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_LVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVarX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFunction;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

