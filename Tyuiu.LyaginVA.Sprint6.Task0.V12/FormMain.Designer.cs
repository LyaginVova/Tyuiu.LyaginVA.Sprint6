
namespace Tyuiu.LyaginVA.Sprint6.Task0.V12
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
            this.groupBoxCondition_LVA = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_LVA = new System.Windows.Forms.PictureBox();
            this.textBoxCondition_LVA = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_LVA = new System.Windows.Forms.GroupBox();
            this.textBoxVarA_LVA = new System.Windows.Forms.TextBox();
            this.textBoxVariableA_LVA = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData_LVA = new System.Windows.Forms.GroupBox();
            this.textBoxAnswer_LVA = new System.Windows.Forms.TextBox();
            this.textBoxResult_LVA = new System.Windows.Forms.TextBox();
            this.buttonResult_LVA = new System.Windows.Forms.Button();
            this.buttonHelp_LVA = new System.Windows.Forms.Button();
            this.groupBoxCondition_LVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_LVA)).BeginInit();
            this.groupBoxInputData_LVA.SuspendLayout();
            this.groupBoxOutputData_LVA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_LVA
            // 
            this.groupBoxCondition_LVA.Controls.Add(this.pictureBoxFormula_LVA);
            this.groupBoxCondition_LVA.Controls.Add(this.textBoxCondition_LVA);
            this.groupBoxCondition_LVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_LVA.Location = new System.Drawing.Point(12, 0);
            this.groupBoxCondition_LVA.Name = "groupBoxCondition_LVA";
            this.groupBoxCondition_LVA.Size = new System.Drawing.Size(776, 280);
            this.groupBoxCondition_LVA.TabIndex = 0;
            this.groupBoxCondition_LVA.TabStop = false;
            this.groupBoxCondition_LVA.Text = "Условие";
            // 
            // pictureBoxFormula_LVA
            // 
            this.pictureBoxFormula_LVA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_LVA.Image")));
            this.pictureBoxFormula_LVA.Location = new System.Drawing.Point(626, 22);
            this.pictureBoxFormula_LVA.Name = "pictureBoxFormula_LVA";
            this.pictureBoxFormula_LVA.Size = new System.Drawing.Size(144, 65);
            this.pictureBoxFormula_LVA.TabIndex = 1;
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
            this.textBoxCondition_LVA.Size = new System.Drawing.Size(565, 244);
            this.textBoxCondition_LVA.TabIndex = 0;
            this.textBoxCondition_LVA.TabStop = false;
            this.textBoxCondition_LVA.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInputData_LVA
            // 
            this.groupBoxInputData_LVA.Controls.Add(this.textBoxVarA_LVA);
            this.groupBoxInputData_LVA.Controls.Add(this.textBoxVariableA_LVA);
            this.groupBoxInputData_LVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputData_LVA.Location = new System.Drawing.Point(12, 286);
            this.groupBoxInputData_LVA.Name = "groupBoxInputData_LVA";
            this.groupBoxInputData_LVA.Size = new System.Drawing.Size(273, 130);
            this.groupBoxInputData_LVA.TabIndex = 2;
            this.groupBoxInputData_LVA.TabStop = false;
            this.groupBoxInputData_LVA.Text = "Ввод данных";
            // 
            // textBoxVarA_LVA
            // 
            this.textBoxVarA_LVA.Location = new System.Drawing.Point(6, 41);
            this.textBoxVarA_LVA.Name = "textBoxVarA_LVA";
            this.textBoxVarA_LVA.Size = new System.Drawing.Size(107, 23);
            this.textBoxVarA_LVA.TabIndex = 3;
            this.textBoxVarA_LVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarA_LVA_KeyPress);
            // 
            // textBoxVariableA_LVA
            // 
            this.textBoxVariableA_LVA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxVariableA_LVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVariableA_LVA.Location = new System.Drawing.Point(6, 19);
            this.textBoxVariableA_LVA.Name = "textBoxVariableA_LVA";
            this.textBoxVariableA_LVA.ReadOnly = true;
            this.textBoxVariableA_LVA.Size = new System.Drawing.Size(179, 16);
            this.textBoxVariableA_LVA.TabIndex = 2;
            this.textBoxVariableA_LVA.TabStop = false;
            this.textBoxVariableA_LVA.Text = "Переменная A:";
            // 
            // groupBoxOutputData_LVA
            // 
            this.groupBoxOutputData_LVA.Controls.Add(this.textBoxAnswer_LVA);
            this.groupBoxOutputData_LVA.Controls.Add(this.textBoxResult_LVA);
            this.groupBoxOutputData_LVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutputData_LVA.Location = new System.Drawing.Point(582, 286);
            this.groupBoxOutputData_LVA.Name = "groupBoxOutputData_LVA";
            this.groupBoxOutputData_LVA.Size = new System.Drawing.Size(200, 100);
            this.groupBoxOutputData_LVA.TabIndex = 4;
            this.groupBoxOutputData_LVA.TabStop = false;
            this.groupBoxOutputData_LVA.Text = "Вывод данных";
            // 
            // textBoxAnswer_LVA
            // 
            this.textBoxAnswer_LVA.Location = new System.Drawing.Point(6, 51);
            this.textBoxAnswer_LVA.Name = "textBoxAnswer_LVA";
            this.textBoxAnswer_LVA.Size = new System.Drawing.Size(188, 23);
            this.textBoxAnswer_LVA.TabIndex = 0;
            // 
            // textBoxResult_LVA
            // 
            this.textBoxResult_LVA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult_LVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_LVA.Location = new System.Drawing.Point(7, 22);
            this.textBoxResult_LVA.Name = "textBoxResult_LVA";
            this.textBoxResult_LVA.ReadOnly = true;
            this.textBoxResult_LVA.Size = new System.Drawing.Size(100, 16);
            this.textBoxResult_LVA.TabIndex = 0;
            this.textBoxResult_LVA.TabStop = false;
            this.textBoxResult_LVA.Text = "Результат:";
            // 
            // buttonResult_LVA
            // 
            this.buttonResult_LVA.Location = new System.Drawing.Point(652, 392);
            this.buttonResult_LVA.Name = "buttonResult_LVA";
            this.buttonResult_LVA.Size = new System.Drawing.Size(130, 46);
            this.buttonResult_LVA.TabIndex = 1;
            this.buttonResult_LVA.Text = "Выполнить";
            this.buttonResult_LVA.UseVisualStyleBackColor = true;
            this.buttonResult_LVA.Click += new System.EventHandler(this.buttonResult_LVA_Click);
            // 
            // buttonHelp_LVA
            // 
            this.buttonHelp_LVA.Location = new System.Drawing.Point(582, 392);
            this.buttonHelp_LVA.Name = "buttonHelp_LVA";
            this.buttonHelp_LVA.Size = new System.Drawing.Size(64, 46);
            this.buttonHelp_LVA.TabIndex = 5;
            this.buttonHelp_LVA.Text = "?";
            this.buttonHelp_LVA.UseVisualStyleBackColor = true;
            this.buttonHelp_LVA.Click += new System.EventHandler(this.buttonHelp_LVA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_LVA);
            this.Controls.Add(this.buttonResult_LVA);
            this.Controls.Add(this.groupBoxOutputData_LVA);
            this.Controls.Add(this.groupBoxInputData_LVA);
            this.Controls.Add(this.groupBoxCondition_LVA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 12 | Лягин В.А.";
            this.groupBoxCondition_LVA.ResumeLayout(false);
            this.groupBoxCondition_LVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_LVA)).EndInit();
            this.groupBoxInputData_LVA.ResumeLayout(false);
            this.groupBoxInputData_LVA.PerformLayout();
            this.groupBoxOutputData_LVA.ResumeLayout(false);
            this.groupBoxOutputData_LVA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_LVA;
        private System.Windows.Forms.TextBox textBoxCondition_LVA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_LVA;
        private System.Windows.Forms.GroupBox groupBoxInputData_LVA;
        private System.Windows.Forms.TextBox textBoxVariableA_LVA;
        private System.Windows.Forms.TextBox textBoxVarA_LVA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_LVA;
        private System.Windows.Forms.TextBox textBoxAnswer_LVA;
        private System.Windows.Forms.TextBox textBoxResult_LVA;
        private System.Windows.Forms.Button buttonResult_LVA;
        private System.Windows.Forms.Button buttonHelp_LVA;
    }
}

