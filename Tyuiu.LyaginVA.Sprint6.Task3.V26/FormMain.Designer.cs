
namespace Tyuiu.LyaginVA.Sprint6.Task3.V26
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
            this.groupBoxCondition_LVA = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_LVA = new System.Windows.Forms.DataGridView();
            this.textBoxCondition_LVA = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData_LVA = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrixResult_LVA = new System.Windows.Forms.DataGridView();
            this.textBoxResult_LVA = new System.Windows.Forms.TextBox();
            this.buttonResult_LVA = new System.Windows.Forms.Button();
            this.buttonReference_LVA = new System.Windows.Forms.Button();
            this.groupBoxCondition_LVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_LVA)).BeginInit();
            this.groupBoxOutputData_LVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_LVA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_LVA
            // 
            this.groupBoxCondition_LVA.Controls.Add(this.dataGridViewMatrix_LVA);
            this.groupBoxCondition_LVA.Controls.Add(this.textBoxCondition_LVA);
            this.groupBoxCondition_LVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_LVA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_LVA.Name = "groupBoxCondition_LVA";
            this.groupBoxCondition_LVA.Size = new System.Drawing.Size(568, 426);
            this.groupBoxCondition_LVA.TabIndex = 0;
            this.groupBoxCondition_LVA.TabStop = false;
            this.groupBoxCondition_LVA.Text = "Условие";
            // 
            // dataGridViewMatrix_LVA
            // 
            this.dataGridViewMatrix_LVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_LVA.Location = new System.Drawing.Point(261, 22);
            this.dataGridViewMatrix_LVA.Name = "dataGridViewMatrix_LVA";
            this.dataGridViewMatrix_LVA.ReadOnly = true;
            this.dataGridViewMatrix_LVA.RowHeadersVisible = false;
            this.dataGridViewMatrix_LVA.Size = new System.Drawing.Size(301, 322);
            this.dataGridViewMatrix_LVA.TabIndex = 4;
            this.dataGridViewMatrix_LVA.TabStop = false;
            // 
            // textBoxCondition_LVA
            // 
            this.textBoxCondition_LVA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCondition_LVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_LVA.Location = new System.Drawing.Point(6, 22);
            this.textBoxCondition_LVA.Multiline = true;
            this.textBoxCondition_LVA.Name = "textBoxCondition_LVA";
            this.textBoxCondition_LVA.ReadOnly = true;
            this.textBoxCondition_LVA.Size = new System.Drawing.Size(269, 195);
            this.textBoxCondition_LVA.TabIndex = 0;
            this.textBoxCondition_LVA.TabStop = false;
            this.textBoxCondition_LVA.Text = "Дана матрица 5 на 5\r\n16  19  17   2   8\r\n -17   8 -17  -8   1\r\n  -7  17  -2   1  " +
    "-3\r\n -12   0 -17  15   6\r\n  17  -6 -17  18 -19\r\nЗаменить четные значения в треть" +
    "ей строке на 0";
            // 
            // groupBoxOutputData_LVA
            // 
            this.groupBoxOutputData_LVA.Controls.Add(this.dataGridViewMatrixResult_LVA);
            this.groupBoxOutputData_LVA.Controls.Add(this.textBoxResult_LVA);
            this.groupBoxOutputData_LVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutputData_LVA.Location = new System.Drawing.Point(588, 12);
            this.groupBoxOutputData_LVA.Name = "groupBoxOutputData_LVA";
            this.groupBoxOutputData_LVA.Size = new System.Drawing.Size(315, 374);
            this.groupBoxOutputData_LVA.TabIndex = 1;
            this.groupBoxOutputData_LVA.TabStop = false;
            this.groupBoxOutputData_LVA.Text = "Вывод данных";
            // 
            // dataGridViewMatrixResult_LVA
            // 
            this.dataGridViewMatrixResult_LVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixResult_LVA.Location = new System.Drawing.Point(6, 44);
            this.dataGridViewMatrixResult_LVA.Name = "dataGridViewMatrixResult_LVA";
            this.dataGridViewMatrixResult_LVA.ReadOnly = true;
            this.dataGridViewMatrixResult_LVA.RowHeadersVisible = false;
            this.dataGridViewMatrixResult_LVA.Size = new System.Drawing.Size(301, 322);
            this.dataGridViewMatrixResult_LVA.TabIndex = 4;
            this.dataGridViewMatrixResult_LVA.TabStop = false;
            // 
            // textBoxResult_LVA
            // 
            this.textBoxResult_LVA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult_LVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_LVA.Location = new System.Drawing.Point(6, 22);
            this.textBoxResult_LVA.Name = "textBoxResult_LVA";
            this.textBoxResult_LVA.ReadOnly = true;
            this.textBoxResult_LVA.Size = new System.Drawing.Size(109, 16);
            this.textBoxResult_LVA.TabIndex = 0;
            this.textBoxResult_LVA.TabStop = false;
            this.textBoxResult_LVA.Text = "Результат:";
            // 
            // buttonResult_LVA
            // 
            this.buttonResult_LVA.Location = new System.Drawing.Point(685, 392);
            this.buttonResult_LVA.Name = "buttonResult_LVA";
            this.buttonResult_LVA.Size = new System.Drawing.Size(131, 46);
            this.buttonResult_LVA.TabIndex = 2;
            this.buttonResult_LVA.Text = "Выполнить";
            this.buttonResult_LVA.UseVisualStyleBackColor = true;
            this.buttonResult_LVA.Click += new System.EventHandler(this.buttonResult_LVA_Click);
            // 
            // buttonReference_LVA
            // 
            this.buttonReference_LVA.Location = new System.Drawing.Point(594, 392);
            this.buttonReference_LVA.Name = "buttonReference_LVA";
            this.buttonReference_LVA.Size = new System.Drawing.Size(73, 43);
            this.buttonReference_LVA.TabIndex = 3;
            this.buttonReference_LVA.Text = "?";
            this.buttonReference_LVA.UseVisualStyleBackColor = true;
            this.buttonReference_LVA.Click += new System.EventHandler(this.buttonReference_LVA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.buttonReference_LVA);
            this.Controls.Add(this.buttonResult_LVA);
            this.Controls.Add(this.groupBoxOutputData_LVA);
            this.Controls.Add(this.groupBoxCondition_LVA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 26 | Лягин В.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_LVA.ResumeLayout(false);
            this.groupBoxCondition_LVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_LVA)).EndInit();
            this.groupBoxOutputData_LVA.ResumeLayout(false);
            this.groupBoxOutputData_LVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_LVA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_LVA;
        private System.Windows.Forms.TextBox textBoxCondition_LVA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_LVA;
        private System.Windows.Forms.TextBox textBoxResult_LVA;
        private System.Windows.Forms.Button buttonResult_LVA;
        private System.Windows.Forms.Button buttonReference_LVA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_LVA;
        private System.Windows.Forms.DataGridView dataGridViewMatrixResult_LVA;
    }
}

