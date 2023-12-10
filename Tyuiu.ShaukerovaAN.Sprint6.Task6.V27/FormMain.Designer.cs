
namespace Tyuiu.ShaukerovaAN.Sprint6.Task6.V27
{
    partial class FormMain_SAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SAN));
            this.panelTop_SAN = new System.Windows.Forms.Panel();
            this.buttonHelp_SAN = new System.Windows.Forms.Button();
            this.buttonDoIt_SAN = new System.Windows.Forms.Button();
            this.buttonOpenFile_SAN = new System.Windows.Forms.Button();
            this.groupBoxTask_SAN = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SAN = new System.Windows.Forms.TextBox();
            this.panelLeft_SAN = new System.Windows.Forms.Panel();
            this.splitterL = new System.Windows.Forms.Splitter();
            this.groupBoxln_SAN = new System.Windows.Forms.GroupBox();
            this.textBoxln_SAN = new System.Windows.Forms.TextBox();
            this.splitterPanel_SAN = new System.Windows.Forms.Splitter();
            this.panelRight_SAN = new System.Windows.Forms.Panel();
            this.groupBoxOut_SAN = new System.Windows.Forms.GroupBox();
            this.textBoxOut_SAN = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_SAN = new System.Windows.Forms.OpenFileDialog();
            this.toolTipOpenFile_SAN = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogHelp_SAN = new System.Windows.Forms.OpenFileDialog();
            this.toolTipHelp_SAN = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogDoIt_SAN = new System.Windows.Forms.OpenFileDialog();
            this.toolTipDoIt_SAN = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_SAN.SuspendLayout();
            this.groupBoxTask_SAN.SuspendLayout();
            this.panelLeft_SAN.SuspendLayout();
            this.groupBoxln_SAN.SuspendLayout();
            this.panelRight_SAN.SuspendLayout();
            this.groupBoxOut_SAN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_SAN
            // 
            this.panelTop_SAN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTop_SAN.Controls.Add(this.buttonHelp_SAN);
            this.panelTop_SAN.Controls.Add(this.buttonDoIt_SAN);
            this.panelTop_SAN.Controls.Add(this.buttonOpenFile_SAN);
            this.panelTop_SAN.Controls.Add(this.groupBoxTask_SAN);
            this.panelTop_SAN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_SAN.Location = new System.Drawing.Point(0, 0);
            this.panelTop_SAN.Name = "panelTop_SAN";
            this.panelTop_SAN.Size = new System.Drawing.Size(973, 195);
            this.panelTop_SAN.TabIndex = 0;
            // 
            // buttonHelp_SAN
            // 
            this.buttonHelp_SAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SAN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHelp_SAN.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SAN.Image")));
            this.buttonHelp_SAN.Location = new System.Drawing.Point(859, 12);
            this.buttonHelp_SAN.Name = "buttonHelp_SAN";
            this.buttonHelp_SAN.Size = new System.Drawing.Size(102, 71);
            this.buttonHelp_SAN.TabIndex = 3;
            this.toolTipOpenFile_SAN.SetToolTip(this.buttonHelp_SAN, "Сведение о программе\r\n");
            this.buttonHelp_SAN.UseVisualStyleBackColor = false;
            this.buttonHelp_SAN.Click += new System.EventHandler(this.buttonHelp_SAN_Click);
            // 
            // buttonDoIt_SAN
            // 
            this.buttonDoIt_SAN.Image = ((System.Drawing.Image)(resources.GetObject("buttonDoIt_SAN.Image")));
            this.buttonDoIt_SAN.Location = new System.Drawing.Point(142, 12);
            this.buttonDoIt_SAN.Name = "buttonDoIt_SAN";
            this.buttonDoIt_SAN.Size = new System.Drawing.Size(102, 71);
            this.buttonDoIt_SAN.TabIndex = 2;
            this.toolTipDoIt_SAN.SetToolTip(this.buttonDoIt_SAN, "Производит поиск в файле вхождений символов \"H\" и выводит");
            this.buttonDoIt_SAN.UseVisualStyleBackColor = true;
            this.buttonDoIt_SAN.Click += new System.EventHandler(this.buttonDoIt_SAN_Click);
            // 
            // buttonOpenFile_SAN
            // 
            this.buttonOpenFile_SAN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOpenFile_SAN.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SAN.Image")));
            this.buttonOpenFile_SAN.Location = new System.Drawing.Point(18, 12);
            this.buttonOpenFile_SAN.Name = "buttonOpenFile_SAN";
            this.buttonOpenFile_SAN.Size = new System.Drawing.Size(102, 71);
            this.buttonOpenFile_SAN.TabIndex = 1;
            this.toolTipOpenFile_SAN.SetToolTip(this.buttonOpenFile_SAN, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonOpenFile_SAN.UseVisualStyleBackColor = false;
            this.buttonOpenFile_SAN.Click += new System.EventHandler(this.buttonOpenFile_SAN_Click);
            // 
            // groupBoxTask_SAN
            // 
            this.groupBoxTask_SAN.Controls.Add(this.textBoxTask_SAN);
            this.groupBoxTask_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_SAN.Location = new System.Drawing.Point(12, 89);
            this.groupBoxTask_SAN.Name = "groupBoxTask_SAN";
            this.groupBoxTask_SAN.Size = new System.Drawing.Size(958, 100);
            this.groupBoxTask_SAN.TabIndex = 0;
            this.groupBoxTask_SAN.TabStop = false;
            this.groupBoxTask_SAN.Text = "Условие";
            // 
            // textBoxTask_SAN
            // 
            this.textBoxTask_SAN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTask_SAN.Location = new System.Drawing.Point(6, 23);
            this.textBoxTask_SAN.Multiline = true;
            this.textBoxTask_SAN.Name = "textBoxTask_SAN";
            this.textBoxTask_SAN.Size = new System.Drawing.Size(943, 71);
            this.textBoxTask_SAN.TabIndex = 0;
            this.textBoxTask_SAN.Text = resources.GetString("textBoxTask_SAN.Text");
            // 
            // panelLeft_SAN
            // 
            this.panelLeft_SAN.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelLeft_SAN.Controls.Add(this.splitterL);
            this.panelLeft_SAN.Controls.Add(this.groupBoxln_SAN);
            this.panelLeft_SAN.Controls.Add(this.splitterPanel_SAN);
            this.panelLeft_SAN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_SAN.Location = new System.Drawing.Point(0, 195);
            this.panelLeft_SAN.Name = "panelLeft_SAN";
            this.panelLeft_SAN.Size = new System.Drawing.Size(479, 357);
            this.panelLeft_SAN.TabIndex = 1;
            // 
            // splitterL
            // 
            this.splitterL.Location = new System.Drawing.Point(3, 0);
            this.splitterL.Name = "splitterL";
            this.splitterL.Size = new System.Drawing.Size(3, 357);
            this.splitterL.TabIndex = 2;
            this.splitterL.TabStop = false;
            // 
            // groupBoxln_SAN
            // 
            this.groupBoxln_SAN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxln_SAN.Controls.Add(this.textBoxln_SAN);
            this.groupBoxln_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxln_SAN.Location = new System.Drawing.Point(12, 17);
            this.groupBoxln_SAN.Name = "groupBoxln_SAN";
            this.groupBoxln_SAN.Size = new System.Drawing.Size(454, 328);
            this.groupBoxln_SAN.TabIndex = 1;
            this.groupBoxln_SAN.TabStop = false;
            this.groupBoxln_SAN.Text = "Ввод:";
            // 
            // textBoxln_SAN
            // 
            this.textBoxln_SAN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxln_SAN.Location = new System.Drawing.Point(6, 23);
            this.textBoxln_SAN.Multiline = true;
            this.textBoxln_SAN.Name = "textBoxln_SAN";
            this.textBoxln_SAN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxln_SAN.Size = new System.Drawing.Size(442, 299);
            this.textBoxln_SAN.TabIndex = 0;
            // 
            // splitterPanel_SAN
            // 
            this.splitterPanel_SAN.Location = new System.Drawing.Point(0, 0);
            this.splitterPanel_SAN.Name = "splitterPanel_SAN";
            this.splitterPanel_SAN.Size = new System.Drawing.Size(3, 357);
            this.splitterPanel_SAN.TabIndex = 0;
            this.splitterPanel_SAN.TabStop = false;
            // 
            // panelRight_SAN
            // 
            this.panelRight_SAN.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelRight_SAN.Controls.Add(this.groupBoxOut_SAN);
            this.panelRight_SAN.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight_SAN.Location = new System.Drawing.Point(485, 195);
            this.panelRight_SAN.Name = "panelRight_SAN";
            this.panelRight_SAN.Size = new System.Drawing.Size(488, 357);
            this.panelRight_SAN.TabIndex = 2;
            // 
            // groupBoxOut_SAN
            // 
            this.groupBoxOut_SAN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOut_SAN.Controls.Add(this.textBoxOut_SAN);
            this.groupBoxOut_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOut_SAN.Location = new System.Drawing.Point(14, 17);
            this.groupBoxOut_SAN.Name = "groupBoxOut_SAN";
            this.groupBoxOut_SAN.Size = new System.Drawing.Size(462, 328);
            this.groupBoxOut_SAN.TabIndex = 0;
            this.groupBoxOut_SAN.TabStop = false;
            this.groupBoxOut_SAN.Text = "Вывод:";
            // 
            // textBoxOut_SAN
            // 
            this.textBoxOut_SAN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOut_SAN.Location = new System.Drawing.Point(6, 23);
            this.textBoxOut_SAN.Multiline = true;
            this.textBoxOut_SAN.Name = "textBoxOut_SAN";
            this.textBoxOut_SAN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_SAN.Size = new System.Drawing.Size(441, 299);
            this.textBoxOut_SAN.TabIndex = 0;
            // 
            // openFileDialogTask_SAN
            // 
            this.openFileDialogTask_SAN.FileName = "openFileDialog1";
            // 
            // toolTipOpenFile_SAN
            // 
            this.toolTipOpenFile_SAN.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipOpenFile_SAN.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogHelp_SAN
            // 
            this.openFileDialogHelp_SAN.FileName = "openFileDialog1";
            // 
            // toolTipHelp_SAN
            // 
            this.toolTipHelp_SAN.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipHelp_SAN.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogDoIt_SAN
            // 
            this.openFileDialogDoIt_SAN.FileName = "openFileDialog1";
            // 
            // toolTipDoIt_SAN
            // 
            this.toolTipDoIt_SAN.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipDoIt_SAN.ToolTipTitle = "Подсказка";
            // 
            // FormMain_SAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 552);
            this.Controls.Add(this.panelRight_SAN);
            this.Controls.Add(this.panelLeft_SAN);
            this.Controls.Add(this.panelTop_SAN);
            this.Name = "FormMain_SAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 27 | Шаукерова А.Н.";
            this.panelTop_SAN.ResumeLayout(false);
            this.groupBoxTask_SAN.ResumeLayout(false);
            this.groupBoxTask_SAN.PerformLayout();
            this.panelLeft_SAN.ResumeLayout(false);
            this.groupBoxln_SAN.ResumeLayout(false);
            this.groupBoxln_SAN.PerformLayout();
            this.panelRight_SAN.ResumeLayout(false);
            this.groupBoxOut_SAN.ResumeLayout(false);
            this.groupBoxOut_SAN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_SAN;
        private System.Windows.Forms.Button buttonHelp_SAN;
        private System.Windows.Forms.Button buttonDoIt_SAN;
        private System.Windows.Forms.Button buttonOpenFile_SAN;
        private System.Windows.Forms.GroupBox groupBoxTask_SAN;
        private System.Windows.Forms.TextBox textBoxTask_SAN;
        private System.Windows.Forms.Panel panelLeft_SAN;
        private System.Windows.Forms.GroupBox groupBoxln_SAN;
        private System.Windows.Forms.TextBox textBoxln_SAN;
        private System.Windows.Forms.Splitter splitterPanel_SAN;
        private System.Windows.Forms.Panel panelRight_SAN;
        private System.Windows.Forms.GroupBox groupBoxOut_SAN;
        private System.Windows.Forms.TextBox textBoxOut_SAN;
        private System.Windows.Forms.Splitter splitterL;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SAN;
        private System.Windows.Forms.ToolTip toolTipOpenFile_SAN;
        private System.Windows.Forms.OpenFileDialog openFileDialogHelp_SAN;
        private System.Windows.Forms.ToolTip toolTipHelp_SAN;
        private System.Windows.Forms.ToolTip toolTipDoIt_SAN;
        private System.Windows.Forms.OpenFileDialog openFileDialogDoIt_SAN;
    }
}

