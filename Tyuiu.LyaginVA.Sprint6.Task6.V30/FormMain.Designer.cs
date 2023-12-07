
namespace Tyuiu.LyaginVA.Sprint6.Task6.V30
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelInfo_LVA = new System.Windows.Forms.Panel();
            this.buttonHelp_LVA = new System.Windows.Forms.Button();
            this.buttonDone_LVA = new System.Windows.Forms.Button();
            this.buttonOpenFile_LVA = new System.Windows.Forms.Button();
            this.panelCondition_LVA = new System.Windows.Forms.Panel();
            this.groupBoxCondition_LVA = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_LVA = new System.Windows.Forms.TextBox();
            this.panelInputData_LVA = new System.Windows.Forms.Panel();
            this.groupBoxInputData_LVA = new System.Windows.Forms.GroupBox();
            this.textBoxLoadData_LVA = new System.Windows.Forms.TextBox();
            this.panelOutputData_LVA = new System.Windows.Forms.Panel();
            this.groupBoxOutputData_LVA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_LVA = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_LVA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipTask_LVA = new System.Windows.Forms.ToolTip(this.components);
            this.panelInfo_LVA.SuspendLayout();
            this.panelCondition_LVA.SuspendLayout();
            this.groupBoxCondition_LVA.SuspendLayout();
            this.panelInputData_LVA.SuspendLayout();
            this.groupBoxInputData_LVA.SuspendLayout();
            this.panelOutputData_LVA.SuspendLayout();
            this.groupBoxOutputData_LVA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo_LVA
            // 
            this.panelInfo_LVA.Controls.Add(this.buttonHelp_LVA);
            this.panelInfo_LVA.Controls.Add(this.buttonDone_LVA);
            this.panelInfo_LVA.Controls.Add(this.buttonOpenFile_LVA);
            this.panelInfo_LVA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo_LVA.Location = new System.Drawing.Point(0, 0);
            this.panelInfo_LVA.Name = "panelInfo_LVA";
            this.panelInfo_LVA.Size = new System.Drawing.Size(800, 68);
            this.panelInfo_LVA.TabIndex = 0;
            // 
            // buttonHelp_LVA
            // 
            this.buttonHelp_LVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_LVA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_LVA.Image")));
            this.buttonHelp_LVA.Location = new System.Drawing.Point(712, 3);
            this.buttonHelp_LVA.Name = "buttonHelp_LVA";
            this.buttonHelp_LVA.Size = new System.Drawing.Size(85, 62);
            this.buttonHelp_LVA.TabIndex = 1;
            this.toolTipTask_LVA.SetToolTip(this.buttonHelp_LVA, "Сведение о программе");
            this.buttonHelp_LVA.UseVisualStyleBackColor = true;
            this.buttonHelp_LVA.Click += new System.EventHandler(this.buttonHelp_LVA_Click);
            // 
            // buttonDone_LVA
            // 
            this.buttonDone_LVA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_LVA.Image")));
            this.buttonDone_LVA.Location = new System.Drawing.Point(105, 3);
            this.buttonDone_LVA.Name = "buttonDone_LVA";
            this.buttonDone_LVA.Size = new System.Drawing.Size(89, 62);
            this.buttonDone_LVA.TabIndex = 0;
            this.toolTipTask_LVA.SetToolTip(this.buttonDone_LVA, "Выводите четвертое слово каждой строки \r\n");
            this.buttonDone_LVA.UseVisualStyleBackColor = true;
            this.buttonDone_LVA.Click += new System.EventHandler(this.buttonDone_LVA_Click);
            // 
            // buttonOpenFile_LVA
            // 
            this.buttonOpenFile_LVA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_LVA.Image")));
            this.buttonOpenFile_LVA.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_LVA.Name = "buttonOpenFile_LVA";
            this.buttonOpenFile_LVA.Size = new System.Drawing.Size(96, 62);
            this.buttonOpenFile_LVA.TabIndex = 0;
            this.toolTipTask_LVA.SetToolTip(this.buttonOpenFile_LVA, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_LVA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_LVA.Click += new System.EventHandler(this.buttonOpenFile_LVA_Click);
            // 
            // panelCondition_LVA
            // 
            this.panelCondition_LVA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCondition_LVA.Controls.Add(this.groupBoxCondition_LVA);
            this.panelCondition_LVA.Location = new System.Drawing.Point(0, 74);
            this.panelCondition_LVA.Name = "panelCondition_LVA";
            this.panelCondition_LVA.Size = new System.Drawing.Size(800, 80);
            this.panelCondition_LVA.TabIndex = 1;
            // 
            // groupBoxCondition_LVA
            // 
            this.groupBoxCondition_LVA.Controls.Add(this.textBoxCondition_LVA);
            this.groupBoxCondition_LVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCondition_LVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_LVA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCondition_LVA.Name = "groupBoxCondition_LVA";
            this.groupBoxCondition_LVA.Size = new System.Drawing.Size(800, 80);
            this.groupBoxCondition_LVA.TabIndex = 0;
            this.groupBoxCondition_LVA.TabStop = false;
            this.groupBoxCondition_LVA.Text = "Условие:";
            // 
            // textBoxCondition_LVA
            // 
            this.textBoxCondition_LVA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCondition_LVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_LVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCondition_LVA.Location = new System.Drawing.Point(3, 19);
            this.textBoxCondition_LVA.Multiline = true;
            this.textBoxCondition_LVA.Name = "textBoxCondition_LVA";
            this.textBoxCondition_LVA.ReadOnly = true;
            this.textBoxCondition_LVA.Size = new System.Drawing.Size(794, 58);
            this.textBoxCondition_LVA.TabIndex = 0;
            this.textBoxCondition_LVA.TabStop = false;
            this.textBoxCondition_LVA.Text = resources.GetString("textBoxCondition_LVA.Text");
            // 
            // panelInputData_LVA
            // 
            this.panelInputData_LVA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelInputData_LVA.Controls.Add(this.groupBoxInputData_LVA);
            this.panelInputData_LVA.Location = new System.Drawing.Point(0, 157);
            this.panelInputData_LVA.Name = "panelInputData_LVA";
            this.panelInputData_LVA.Size = new System.Drawing.Size(401, 361);
            this.panelInputData_LVA.TabIndex = 2;
            // 
            // groupBoxInputData_LVA
            // 
            this.groupBoxInputData_LVA.Controls.Add(this.textBoxLoadData_LVA);
            this.groupBoxInputData_LVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInputData_LVA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInputData_LVA.Name = "groupBoxInputData_LVA";
            this.groupBoxInputData_LVA.Size = new System.Drawing.Size(401, 361);
            this.groupBoxInputData_LVA.TabIndex = 0;
            this.groupBoxInputData_LVA.TabStop = false;
            this.groupBoxInputData_LVA.Text = "Ввод:";
            // 
            // textBoxLoadData_LVA
            // 
            this.textBoxLoadData_LVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLoadData_LVA.Location = new System.Drawing.Point(3, 16);
            this.textBoxLoadData_LVA.Multiline = true;
            this.textBoxLoadData_LVA.Name = "textBoxLoadData_LVA";
            this.textBoxLoadData_LVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLoadData_LVA.Size = new System.Drawing.Size(395, 342);
            this.textBoxLoadData_LVA.TabIndex = 0;
            // 
            // panelOutputData_LVA
            // 
            this.panelOutputData_LVA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOutputData_LVA.Controls.Add(this.groupBoxOutputData_LVA);
            this.panelOutputData_LVA.Controls.Add(this.splitter1);
            this.panelOutputData_LVA.Location = new System.Drawing.Point(398, 157);
            this.panelOutputData_LVA.Name = "panelOutputData_LVA";
            this.panelOutputData_LVA.Size = new System.Drawing.Size(402, 361);
            this.panelOutputData_LVA.TabIndex = 3;
            // 
            // groupBoxOutputData_LVA
            // 
            this.groupBoxOutputData_LVA.Controls.Add(this.textBoxResult_LVA);
            this.groupBoxOutputData_LVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputData_LVA.Location = new System.Drawing.Point(3, 0);
            this.groupBoxOutputData_LVA.Name = "groupBoxOutputData_LVA";
            this.groupBoxOutputData_LVA.Size = new System.Drawing.Size(399, 361);
            this.groupBoxOutputData_LVA.TabIndex = 1;
            this.groupBoxOutputData_LVA.TabStop = false;
            this.groupBoxOutputData_LVA.Text = "Вывод:";
            // 
            // textBoxResult_LVA
            // 
            this.textBoxResult_LVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_LVA.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_LVA.Multiline = true;
            this.textBoxResult_LVA.Name = "textBoxResult_LVA";
            this.textBoxResult_LVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_LVA.Size = new System.Drawing.Size(393, 342);
            this.textBoxResult_LVA.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 361);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // openFileDialogTask_LVA
            // 
            this.openFileDialogTask_LVA.FileName = "openFileDialogTask_LVA";
            // 
            // toolTipTask_LVA
            // 
            this.toolTipTask_LVA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipTask_LVA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.panelOutputData_LVA);
            this.Controls.Add(this.panelInputData_LVA);
            this.Controls.Add(this.panelCondition_LVA);
            this.Controls.Add(this.panelInfo_LVA);
            this.MinimumSize = new System.Drawing.Size(816, 557);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 30 | Лягин В.А.";
            this.panelInfo_LVA.ResumeLayout(false);
            this.panelCondition_LVA.ResumeLayout(false);
            this.groupBoxCondition_LVA.ResumeLayout(false);
            this.groupBoxCondition_LVA.PerformLayout();
            this.panelInputData_LVA.ResumeLayout(false);
            this.groupBoxInputData_LVA.ResumeLayout(false);
            this.groupBoxInputData_LVA.PerformLayout();
            this.panelOutputData_LVA.ResumeLayout(false);
            this.groupBoxOutputData_LVA.ResumeLayout(false);
            this.groupBoxOutputData_LVA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo_LVA;
        private System.Windows.Forms.Panel panelCondition_LVA;
        private System.Windows.Forms.GroupBox groupBoxCondition_LVA;
        private System.Windows.Forms.Panel panelInputData_LVA;
        private System.Windows.Forms.Panel panelOutputData_LVA;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox textBoxCondition_LVA;
        private System.Windows.Forms.Button buttonHelp_LVA;
        private System.Windows.Forms.ToolTip toolTipTask_LVA;
        private System.Windows.Forms.Button buttonDone_LVA;
        private System.Windows.Forms.Button buttonOpenFile_LVA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_LVA;
        private System.Windows.Forms.GroupBox groupBoxInputData_LVA;
        private System.Windows.Forms.TextBox textBoxLoadData_LVA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_LVA;
        private System.Windows.Forms.TextBox textBoxResult_LVA;
    }
}

