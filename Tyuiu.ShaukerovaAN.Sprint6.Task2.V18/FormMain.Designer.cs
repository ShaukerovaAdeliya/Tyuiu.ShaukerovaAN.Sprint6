
namespace Tyuiu.ShaukerovaAN.Sprint6.Task2.V18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SAN));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_SAN = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_SAN = new System.Windows.Forms.PictureBox();
            this.textBoxTask_SAN = new System.Windows.Forms.TextBox();
            this.groupBoxInput_SAN = new System.Windows.Forms.GroupBox();
            this.textBoxStop_SAN = new System.Windows.Forms.TextBox();
            this.labelStop_SAN = new System.Windows.Forms.Label();
            this.textBoxStart_SAN = new System.Windows.Forms.TextBox();
            this.labelStart_SAN = new System.Windows.Forms.Label();
            this.buttonHelp_SAN = new System.Windows.Forms.Button();
            this.buttonDone_SAN = new System.Windows.Forms.Button();
            this.groupBoxOutput_SAN = new System.Windows.Forms.GroupBox();
            this.labelResult_SAN = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewResult_SAN = new System.Windows.Forms.DataGridView();
            this.ColumnX_SAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFX_SAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartResult_SAN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_SAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SAN)).BeginInit();
            this.groupBoxInput_SAN.SuspendLayout();
            this.groupBoxOutput_SAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SAN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SAN
            // 
            this.groupBoxTask_SAN.Controls.Add(this.pictureBoxFormula_SAN);
            this.groupBoxTask_SAN.Controls.Add(this.textBoxTask_SAN);
            this.groupBoxTask_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_SAN.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SAN.Name = "groupBoxTask_SAN";
            this.groupBoxTask_SAN.Size = new System.Drawing.Size(554, 256);
            this.groupBoxTask_SAN.TabIndex = 0;
            this.groupBoxTask_SAN.TabStop = false;
            this.groupBoxTask_SAN.Text = "Условие";
            // 
            // pictureBoxFormula_SAN
            // 
            this.pictureBoxFormula_SAN.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_SAN.Image")));
            this.pictureBoxFormula_SAN.Location = new System.Drawing.Point(19, 89);
            this.pictureBoxFormula_SAN.Name = "pictureBoxFormula_SAN";
            this.pictureBoxFormula_SAN.Size = new System.Drawing.Size(338, 50);
            this.pictureBoxFormula_SAN.TabIndex = 1;
            this.pictureBoxFormula_SAN.TabStop = false;
            // 
            // textBoxTask_SAN
            // 
            this.textBoxTask_SAN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTask_SAN.Location = new System.Drawing.Point(6, 23);
            this.textBoxTask_SAN.Multiline = true;
            this.textBoxTask_SAN.Name = "textBoxTask_SAN";
            this.textBoxTask_SAN.Size = new System.Drawing.Size(444, 172);
            this.textBoxTask_SAN.TabIndex = 0;
            this.textBoxTask_SAN.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView " +
    "и построить график функции.";
            // 
            // groupBoxInput_SAN
            // 
            this.groupBoxInput_SAN.Controls.Add(this.textBoxStop_SAN);
            this.groupBoxInput_SAN.Controls.Add(this.labelStop_SAN);
            this.groupBoxInput_SAN.Controls.Add(this.textBoxStart_SAN);
            this.groupBoxInput_SAN.Controls.Add(this.labelStart_SAN);
            this.groupBoxInput_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInput_SAN.Location = new System.Drawing.Point(12, 293);
            this.groupBoxInput_SAN.Name = "groupBoxInput_SAN";
            this.groupBoxInput_SAN.Size = new System.Drawing.Size(312, 116);
            this.groupBoxInput_SAN.TabIndex = 1;
            this.groupBoxInput_SAN.TabStop = false;
            this.groupBoxInput_SAN.Text = "Ввод данных";
            // 
            // textBoxStop_SAN
            // 
            this.textBoxStop_SAN.Location = new System.Drawing.Point(161, 62);
            this.textBoxStop_SAN.Name = "textBoxStop_SAN";
            this.textBoxStop_SAN.Size = new System.Drawing.Size(137, 24);
            this.textBoxStop_SAN.TabIndex = 3;
            // 
            // labelStop_SAN
            // 
            this.labelStop_SAN.AutoSize = true;
            this.labelStop_SAN.Location = new System.Drawing.Point(158, 41);
            this.labelStop_SAN.Name = "labelStop_SAN";
            this.labelStop_SAN.Size = new System.Drawing.Size(92, 18);
            this.labelStop_SAN.TabIndex = 2;
            this.labelStop_SAN.Text = "Конец шага:";
            // 
            // textBoxStart_SAN
            // 
            this.textBoxStart_SAN.Location = new System.Drawing.Point(9, 62);
            this.textBoxStart_SAN.Name = "textBoxStart_SAN";
            this.textBoxStart_SAN.Size = new System.Drawing.Size(137, 24);
            this.textBoxStart_SAN.TabIndex = 1;
            // 
            // labelStart_SAN
            // 
            this.labelStart_SAN.AutoSize = true;
            this.labelStart_SAN.Location = new System.Drawing.Point(6, 41);
            this.labelStart_SAN.Name = "labelStart_SAN";
            this.labelStart_SAN.Size = new System.Drawing.Size(90, 18);
            this.labelStart_SAN.TabIndex = 0;
            this.labelStart_SAN.Text = "Старт шага:";
            // 
            // buttonHelp_SAN
            // 
            this.buttonHelp_SAN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_SAN.Location = new System.Drawing.Point(339, 303);
            this.buttonHelp_SAN.Name = "buttonHelp_SAN";
            this.buttonHelp_SAN.Size = new System.Drawing.Size(75, 83);
            this.buttonHelp_SAN.TabIndex = 2;
            this.buttonHelp_SAN.Text = "Справка";
            this.buttonHelp_SAN.UseVisualStyleBackColor = false;
            this.buttonHelp_SAN.Click += new System.EventHandler(this.buttonHelp_SAN_Click);
            // 
            // buttonDone_SAN
            // 
            this.buttonDone_SAN.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_SAN.Location = new System.Drawing.Point(436, 303);
            this.buttonDone_SAN.Name = "buttonDone_SAN";
            this.buttonDone_SAN.Size = new System.Drawing.Size(130, 83);
            this.buttonDone_SAN.TabIndex = 3;
            this.buttonDone_SAN.Text = "Выполнить";
            this.buttonDone_SAN.UseVisualStyleBackColor = false;
            this.buttonDone_SAN.Click += new System.EventHandler(this.buttonDone_SAN_Click);
            this.buttonDone_SAN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_SAN_MouseDown);
            this.buttonDone_SAN.MouseEnter += new System.EventHandler(this.buttonDone_SAN_MouseEnter_1);
            this.buttonDone_SAN.MouseLeave += new System.EventHandler(this.buttonDone_SAN_MouseLeave_1);
            // 
            // groupBoxOutput_SAN
            // 
            this.groupBoxOutput_SAN.Controls.Add(this.chartResult_SAN);
            this.groupBoxOutput_SAN.Controls.Add(this.dataGridViewResult_SAN);
            this.groupBoxOutput_SAN.Controls.Add(this.labelResult_SAN);
            this.groupBoxOutput_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutput_SAN.Location = new System.Drawing.Point(592, 21);
            this.groupBoxOutput_SAN.Name = "groupBoxOutput_SAN";
            this.groupBoxOutput_SAN.Size = new System.Drawing.Size(518, 388);
            this.groupBoxOutput_SAN.TabIndex = 4;
            this.groupBoxOutput_SAN.TabStop = false;
            this.groupBoxOutput_SAN.Text = "Вывод данных";
            // 
            // labelResult_SAN
            // 
            this.labelResult_SAN.AutoSize = true;
            this.labelResult_SAN.Location = new System.Drawing.Point(15, 30);
            this.labelResult_SAN.Name = "labelResult_SAN";
            this.labelResult_SAN.Size = new System.Drawing.Size(84, 18);
            this.labelResult_SAN.TabIndex = 0;
            this.labelResult_SAN.Text = "Результат:";
            // 
            // X
            // 
            this.X.HeaderText = "Column1";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            // 
            // dataGridViewResult_SAN
            // 
            this.dataGridViewResult_SAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SAN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX_SAN,
            this.ColumnFX_SAN});
            this.dataGridViewResult_SAN.Location = new System.Drawing.Point(18, 51);
            this.dataGridViewResult_SAN.Name = "dataGridViewResult_SAN";
            this.dataGridViewResult_SAN.RowHeadersVisible = false;
            this.dataGridViewResult_SAN.Size = new System.Drawing.Size(121, 314);
            this.dataGridViewResult_SAN.TabIndex = 1;
            // 
            // ColumnX_SAN
            // 
            this.ColumnX_SAN.HeaderText = "X";
            this.ColumnX_SAN.Name = "ColumnX_SAN";
            this.ColumnX_SAN.Width = 50;
            // 
            // ColumnFX_SAN
            // 
            this.ColumnFX_SAN.HeaderText = "F(X)";
            this.ColumnFX_SAN.Name = "ColumnFX_SAN";
            this.ColumnFX_SAN.Width = 50;
            // 
            // chartResult_SAN
            // 
            chartArea8.Name = "ChartArea1";
            this.chartResult_SAN.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartResult_SAN.Legends.Add(legend8);
            this.chartResult_SAN.Location = new System.Drawing.Point(145, 51);
            this.chartResult_SAN.Name = "chartResult_SAN";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.IsVisibleInLegend = false;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartResult_SAN.Series.Add(series8);
            this.chartResult_SAN.Size = new System.Drawing.Size(367, 314);
            this.chartResult_SAN.TabIndex = 2;
            // 
            // FormMain_SAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 450);
            this.Controls.Add(this.groupBoxOutput_SAN);
            this.Controls.Add(this.buttonDone_SAN);
            this.Controls.Add(this.buttonHelp_SAN);
            this.Controls.Add(this.groupBoxInput_SAN);
            this.Controls.Add(this.groupBoxTask_SAN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_SAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 13 | Шаукерова А.Н.";
            this.groupBoxTask_SAN.ResumeLayout(false);
            this.groupBoxTask_SAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SAN)).EndInit();
            this.groupBoxInput_SAN.ResumeLayout(false);
            this.groupBoxInput_SAN.PerformLayout();
            this.groupBoxOutput_SAN.ResumeLayout(false);
            this.groupBoxOutput_SAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SAN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SAN;
        private System.Windows.Forms.TextBox textBoxTask_SAN;
        private System.Windows.Forms.PictureBox pictureBoxFormula_SAN;
        private System.Windows.Forms.GroupBox groupBoxInput_SAN;
        private System.Windows.Forms.TextBox textBoxStop_SAN;
        private System.Windows.Forms.Label labelStop_SAN;
        private System.Windows.Forms.TextBox textBoxStart_SAN;
        private System.Windows.Forms.Label labelStart_SAN;
        private System.Windows.Forms.Button buttonHelp_SAN;
        private System.Windows.Forms.Button buttonDone_SAN;
        private System.Windows.Forms.GroupBox groupBoxOutput_SAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.Label labelResult_SAN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_SAN;
        private System.Windows.Forms.DataGridView dataGridViewResult_SAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_SAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFX_SAN;
    }
}

