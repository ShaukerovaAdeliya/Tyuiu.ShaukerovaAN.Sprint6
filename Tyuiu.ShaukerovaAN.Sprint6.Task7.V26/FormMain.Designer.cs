
namespace Tyuiu.ShaukerovaAN.Sprint6.Task7.V26
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
            this.buttonSave_SAN = new System.Windows.Forms.Button();
            this.buttonDoIt_SAN = new System.Windows.Forms.Button();
            this.buttonOpen_SAN = new System.Windows.Forms.Button();
            this.groupBoxTask_SAN = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SAN = new System.Windows.Forms.TextBox();
            this.openFileDialogOpen_SAN = new System.Windows.Forms.OpenFileDialog();
            this.toolTipOpen_SAN = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogDoIt_SAN = new System.Windows.Forms.OpenFileDialog();
            this.toolTipDoIt_SAN = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogSave_SAN = new System.Windows.Forms.OpenFileDialog();
            this.toolTipSave_SAN = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipHelp_SAN = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogHelp_SAN = new System.Windows.Forms.OpenFileDialog();
            this.splitterPanel_SAN = new System.Windows.Forms.Splitter();
            this.panelLeft_SAN = new System.Windows.Forms.Panel();
            this.groupBoxInput_SAN = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitterRight_SAN = new System.Windows.Forms.Splitter();
            this.panelRight_SAN = new System.Windows.Forms.Panel();
            this.groupBoxOutput_SAN = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_SAN = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutPut_SAN = new System.Windows.Forms.DataGridView();
            this.saveFileDialogMatrix_SAN = new System.Windows.Forms.SaveFileDialog();
            this.panelTop_SAN.SuspendLayout();
            this.groupBoxTask_SAN.SuspendLayout();
            this.panelLeft_SAN.SuspendLayout();
            this.groupBoxInput_SAN.SuspendLayout();
            this.panelRight_SAN.SuspendLayout();
            this.groupBoxOutput_SAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_SAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SAN)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_SAN
            // 
            this.panelTop_SAN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelTop_SAN.Controls.Add(this.buttonHelp_SAN);
            this.panelTop_SAN.Controls.Add(this.buttonSave_SAN);
            this.panelTop_SAN.Controls.Add(this.buttonDoIt_SAN);
            this.panelTop_SAN.Controls.Add(this.buttonOpen_SAN);
            this.panelTop_SAN.Controls.Add(this.groupBoxTask_SAN);
            this.panelTop_SAN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_SAN.Location = new System.Drawing.Point(0, 0);
            this.panelTop_SAN.Name = "panelTop_SAN";
            this.panelTop_SAN.Size = new System.Drawing.Size(1027, 183);
            this.panelTop_SAN.TabIndex = 0;
            // 
            // buttonHelp_SAN
            // 
            this.buttonHelp_SAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SAN.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SAN.Image")));
            this.buttonHelp_SAN.Location = new System.Drawing.Point(926, 12);
            this.buttonHelp_SAN.Name = "buttonHelp_SAN";
            this.buttonHelp_SAN.Size = new System.Drawing.Size(74, 71);
            this.buttonHelp_SAN.TabIndex = 4;
            this.buttonHelp_SAN.UseVisualStyleBackColor = true;
            this.buttonHelp_SAN.Click += new System.EventHandler(this.buttonHelp_SAN_MouseEnter);
            this.buttonHelp_SAN.MouseEnter += new System.EventHandler(this.buttonHelp_SAN_Click_1);
            // 
            // buttonSave_SAN
            // 
            this.buttonSave_SAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_SAN.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_SAN.Image")));
            this.buttonSave_SAN.Location = new System.Drawing.Point(192, 5);
            this.buttonSave_SAN.Name = "buttonSave_SAN";
            this.buttonSave_SAN.Size = new System.Drawing.Size(74, 71);
            this.buttonSave_SAN.TabIndex = 3;
            this.buttonSave_SAN.UseVisualStyleBackColor = true;
            this.buttonSave_SAN.Click += new System.EventHandler(this.buttonSave_SAN_MouseEnter);
            this.buttonSave_SAN.MouseEnter += new System.EventHandler(this.buttonSave_SAN_Click);
            // 
            // buttonDoIt_SAN
            // 
            this.buttonDoIt_SAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDoIt_SAN.Image = ((System.Drawing.Image)(resources.GetObject("buttonDoIt_SAN.Image")));
            this.buttonDoIt_SAN.Location = new System.Drawing.Point(102, 5);
            this.buttonDoIt_SAN.Name = "buttonDoIt_SAN";
            this.buttonDoIt_SAN.Size = new System.Drawing.Size(74, 71);
            this.buttonDoIt_SAN.TabIndex = 2;
            this.toolTipDoIt_SAN.SetToolTip(this.buttonDoIt_SAN, "Выполнить обработку данных\r\n");
            this.buttonDoIt_SAN.UseVisualStyleBackColor = true;
            this.buttonDoIt_SAN.Click += new System.EventHandler(this.buttonDoIt_SAN_MouseEnter);
            this.buttonDoIt_SAN.MouseEnter += new System.EventHandler(this.buttonDoIt_SAN_Click);
            // 
            // buttonOpen_SAN
            // 
            this.buttonOpen_SAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen_SAN.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_SAN.Image")));
            this.buttonOpen_SAN.Location = new System.Drawing.Point(12, 5);
            this.buttonOpen_SAN.Name = "buttonOpen_SAN";
            this.buttonOpen_SAN.Size = new System.Drawing.Size(74, 71);
            this.buttonOpen_SAN.TabIndex = 1;
            this.toolTipOpen_SAN.SetToolTip(this.buttonOpen_SAN, "Открыть файл для обработки данных в формате CSV\r\n");
            this.buttonOpen_SAN.UseVisualStyleBackColor = true;
            this.buttonOpen_SAN.Click += new System.EventHandler(this.buttonOpen_SAN_MouseEnter);
            this.buttonOpen_SAN.MouseEnter += new System.EventHandler(this.buttonOpen_SAN_Click);
            // 
            // groupBoxTask_SAN
            // 
            this.groupBoxTask_SAN.Controls.Add(this.textBoxTask_SAN);
            this.groupBoxTask_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_SAN.Location = new System.Drawing.Point(3, 82);
            this.groupBoxTask_SAN.Name = "groupBoxTask_SAN";
            this.groupBoxTask_SAN.Size = new System.Drawing.Size(1021, 95);
            this.groupBoxTask_SAN.TabIndex = 0;
            this.groupBoxTask_SAN.TabStop = false;
            this.groupBoxTask_SAN.Text = "Условие";
            // 
            // textBoxTask_SAN
            // 
            this.textBoxTask_SAN.Location = new System.Drawing.Point(9, 23);
            this.textBoxTask_SAN.Multiline = true;
            this.textBoxTask_SAN.Name = "textBoxTask_SAN";
            this.textBoxTask_SAN.Size = new System.Drawing.Size(1006, 66);
            this.textBoxTask_SAN.TabIndex = 0;
            this.textBoxTask_SAN.Text = resources.GetString("textBoxTask_SAN.Text");
            // 
            // openFileDialogOpen_SAN
            // 
            this.openFileDialogOpen_SAN.FileName = "openFileDialog1";
            // 
            // toolTipOpen_SAN
            // 
            this.toolTipOpen_SAN.IsBalloon = true;
            this.toolTipOpen_SAN.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipOpen_SAN.ToolTipTitle = "Открыть файл";
            // 
            // openFileDialogDoIt_SAN
            // 
            this.openFileDialogDoIt_SAN.FileName = "openFileDialog1";
            // 
            // toolTipDoIt_SAN
            // 
            this.toolTipDoIt_SAN.IsBalloon = true;
            this.toolTipDoIt_SAN.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipDoIt_SAN.ToolTipTitle = "Выполнить";
            // 
            // openFileDialogSave_SAN
            // 
            this.openFileDialogSave_SAN.FileName = "openFileDialog1";
            this.openFileDialogSave_SAN.Title = "Сохранить обработанные данные в файл в формате CSV";
            // 
            // toolTipSave_SAN
            // 
            this.toolTipSave_SAN.IsBalloon = true;
            this.toolTipSave_SAN.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipSave_SAN.ToolTipTitle = "Сохранить в файл";
            // 
            // toolTipHelp_SAN
            // 
            this.toolTipHelp_SAN.IsBalloon = true;
            this.toolTipHelp_SAN.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipHelp_SAN.ToolTipTitle = "Справка";
            // 
            // openFileDialogHelp_SAN
            // 
            this.openFileDialogHelp_SAN.FileName = "openFileDialog1";
            this.openFileDialogHelp_SAN.Title = "Сведение о программе";
            // 
            // splitterPanel_SAN
            // 
            this.splitterPanel_SAN.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterPanel_SAN.Location = new System.Drawing.Point(1024, 183);
            this.splitterPanel_SAN.Name = "splitterPanel_SAN";
            this.splitterPanel_SAN.Size = new System.Drawing.Size(3, 441);
            this.splitterPanel_SAN.TabIndex = 2;
            this.splitterPanel_SAN.TabStop = false;
            // 
            // panelLeft_SAN
            // 
            this.panelLeft_SAN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelLeft_SAN.Controls.Add(this.groupBoxInput_SAN);
            this.panelLeft_SAN.Controls.Add(this.splitter1);
            this.panelLeft_SAN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_SAN.Location = new System.Drawing.Point(0, 183);
            this.panelLeft_SAN.Name = "panelLeft_SAN";
            this.panelLeft_SAN.Size = new System.Drawing.Size(608, 441);
            this.panelLeft_SAN.TabIndex = 3;
            // 
            // groupBoxInput_SAN
            // 
            this.groupBoxInput_SAN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInput_SAN.Controls.Add(this.dataGridViewInPut_SAN);
            this.groupBoxInput_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInput_SAN.Location = new System.Drawing.Point(12, 19);
            this.groupBoxInput_SAN.Name = "groupBoxInput_SAN";
            this.groupBoxInput_SAN.Size = new System.Drawing.Size(567, 326);
            this.groupBoxInput_SAN.TabIndex = 1;
            this.groupBoxInput_SAN.TabStop = false;
            this.groupBoxInput_SAN.Text = "Ввод:";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(605, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 441);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitterRight_SAN
            // 
            this.splitterRight_SAN.Location = new System.Drawing.Point(608, 183);
            this.splitterRight_SAN.Name = "splitterRight_SAN";
            this.splitterRight_SAN.Size = new System.Drawing.Size(10, 441);
            this.splitterRight_SAN.TabIndex = 4;
            this.splitterRight_SAN.TabStop = false;
            // 
            // panelRight_SAN
            // 
            this.panelRight_SAN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelRight_SAN.Controls.Add(this.groupBoxOutput_SAN);
            this.panelRight_SAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_SAN.Location = new System.Drawing.Point(618, 183);
            this.panelRight_SAN.Name = "panelRight_SAN";
            this.panelRight_SAN.Size = new System.Drawing.Size(406, 441);
            this.panelRight_SAN.TabIndex = 5;
            // 
            // groupBoxOutput_SAN
            // 
            this.groupBoxOutput_SAN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutput_SAN.Controls.Add(this.dataGridViewOutPut_SAN);
            this.groupBoxOutput_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutput_SAN.Location = new System.Drawing.Point(7, 19);
            this.groupBoxOutput_SAN.Name = "groupBoxOutput_SAN";
            this.groupBoxOutput_SAN.Size = new System.Drawing.Size(375, 326);
            this.groupBoxOutput_SAN.TabIndex = 0;
            this.groupBoxOutput_SAN.TabStop = false;
            this.groupBoxOutput_SAN.Text = "Вывод:";
            // 
            // dataGridViewInPut_SAN
            // 
            this.dataGridViewInPut_SAN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInPut_SAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_SAN.Location = new System.Drawing.Point(6, 23);
            this.dataGridViewInPut_SAN.Name = "dataGridViewInPut_SAN";
            this.dataGridViewInPut_SAN.Size = new System.Drawing.Size(555, 297);
            this.dataGridViewInPut_SAN.TabIndex = 0;
            // 
            // dataGridViewOutPut_SAN
            // 
            this.dataGridViewOutPut_SAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_SAN.Location = new System.Drawing.Point(6, 23);
            this.dataGridViewOutPut_SAN.Name = "dataGridViewOutPut_SAN";
            this.dataGridViewOutPut_SAN.Size = new System.Drawing.Size(730, 297);
            this.dataGridViewOutPut_SAN.TabIndex = 0;
            // 
            // FormMain_SAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 624);
            this.Controls.Add(this.panelRight_SAN);
            this.Controls.Add(this.splitterRight_SAN);
            this.Controls.Add(this.panelLeft_SAN);
            this.Controls.Add(this.splitterPanel_SAN);
            this.Controls.Add(this.panelTop_SAN);
            this.Name = "FormMain_SAN";
            this.Text = "Спринт 6 | Таск 7 | Вариант 26 | Шаукерова А.Н.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_SAN_Load);
            this.panelTop_SAN.ResumeLayout(false);
            this.groupBoxTask_SAN.ResumeLayout(false);
            this.groupBoxTask_SAN.PerformLayout();
            this.panelLeft_SAN.ResumeLayout(false);
            this.groupBoxInput_SAN.ResumeLayout(false);
            this.panelRight_SAN.ResumeLayout(false);
            this.groupBoxOutput_SAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_SAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SAN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_SAN;
        private System.Windows.Forms.Button buttonHelp_SAN;
        private System.Windows.Forms.Button buttonSave_SAN;
        private System.Windows.Forms.Button buttonDoIt_SAN;
        private System.Windows.Forms.ToolTip toolTipDoIt_SAN;
        private System.Windows.Forms.Button buttonOpen_SAN;
        private System.Windows.Forms.ToolTip toolTipOpen_SAN;
        private System.Windows.Forms.GroupBox groupBoxTask_SAN;
        private System.Windows.Forms.TextBox textBoxTask_SAN;
        private System.Windows.Forms.OpenFileDialog openFileDialogOpen_SAN;
        private System.Windows.Forms.OpenFileDialog openFileDialogDoIt_SAN;
        private System.Windows.Forms.OpenFileDialog openFileDialogSave_SAN;
        private System.Windows.Forms.ToolTip toolTipSave_SAN;
        private System.Windows.Forms.ToolTip toolTipHelp_SAN;
        private System.Windows.Forms.OpenFileDialog openFileDialogHelp_SAN;
        private System.Windows.Forms.Splitter splitterPanel_SAN;
        private System.Windows.Forms.Panel panelLeft_SAN;
        private System.Windows.Forms.Splitter splitterRight_SAN;
        private System.Windows.Forms.Panel panelRight_SAN;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBoxInput_SAN;
        private System.Windows.Forms.GroupBox groupBoxOutput_SAN;
        private System.Windows.Forms.DataGridView dataGridViewInPut_SAN;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_SAN;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_SAN;
    }
}

