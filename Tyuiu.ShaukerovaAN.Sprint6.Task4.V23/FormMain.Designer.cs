
namespace Tyuiu.ShaukerovaAN.Sprint6.Task4.V23
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_SAN = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SAN = new System.Windows.Forms.TextBox();
            this.groupBoxInput_SAN = new System.Windows.Forms.GroupBox();
            this.textBoxStop_SAN = new System.Windows.Forms.TextBox();
            this.textBoxStart_SAN = new System.Windows.Forms.TextBox();
            this.labelStop_SAN = new System.Windows.Forms.Label();
            this.labelStart_SAN = new System.Windows.Forms.Label();
            this.groupBoxOutput_SAN = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_SAN = new System.Windows.Forms.TextBox();
            this.buttonDone_SAN = new System.Windows.Forms.Button();
            this.buttonSave_SAN = new System.Windows.Forms.Button();
            this.buttonHelp_SAN = new System.Windows.Forms.Button();
            this.panelTop_SAN = new System.Windows.Forms.Panel();
            this.panelLeft_SAN = new System.Windows.Forms.Panel();
            this.splitterFill_SAN = new System.Windows.Forms.Splitter();
            this.splitterLeft_SAN = new System.Windows.Forms.Splitter();
            this.panelFill_SAN = new System.Windows.Forms.Panel();
            this.chartResult_SAN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_SAN.SuspendLayout();
            this.groupBoxInput_SAN.SuspendLayout();
            this.groupBoxOutput_SAN.SuspendLayout();
            this.panelLeft_SAN.SuspendLayout();
            this.panelFill_SAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SAN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SAN
            // 
            this.groupBoxTask_SAN.Controls.Add(this.textBoxTask_SAN);
            this.groupBoxTask_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_SAN.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SAN.Name = "groupBoxTask_SAN";
            this.groupBoxTask_SAN.Size = new System.Drawing.Size(475, 99);
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
            this.textBoxTask_SAN.Size = new System.Drawing.Size(463, 70);
            this.textBoxTask_SAN.TabIndex = 0;
            this.textBoxTask_SAN.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в te" +
    "xtBox. Построить график функции и сохранить в файл OutPutFileTask4V23.txt по наж" +
    "атию кнопки.";
            // 
            // groupBoxInput_SAN
            // 
            this.groupBoxInput_SAN.Controls.Add(this.textBoxStop_SAN);
            this.groupBoxInput_SAN.Controls.Add(this.textBoxStart_SAN);
            this.groupBoxInput_SAN.Controls.Add(this.labelStop_SAN);
            this.groupBoxInput_SAN.Controls.Add(this.labelStart_SAN);
            this.groupBoxInput_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInput_SAN.Location = new System.Drawing.Point(493, 12);
            this.groupBoxInput_SAN.Name = "groupBoxInput_SAN";
            this.groupBoxInput_SAN.Size = new System.Drawing.Size(231, 99);
            this.groupBoxInput_SAN.TabIndex = 1;
            this.groupBoxInput_SAN.TabStop = false;
            this.groupBoxInput_SAN.Text = "Ввод данных";
            // 
            // textBoxStop_SAN
            // 
            this.textBoxStop_SAN.Location = new System.Drawing.Point(126, 59);
            this.textBoxStop_SAN.Name = "textBoxStop_SAN";
            this.textBoxStop_SAN.Size = new System.Drawing.Size(89, 24);
            this.textBoxStop_SAN.TabIndex = 3;
            // 
            // textBoxStart_SAN
            // 
            this.textBoxStart_SAN.Location = new System.Drawing.Point(6, 59);
            this.textBoxStart_SAN.Name = "textBoxStart_SAN";
            this.textBoxStart_SAN.Size = new System.Drawing.Size(100, 24);
            this.textBoxStart_SAN.TabIndex = 2;
            // 
            // labelStop_SAN
            // 
            this.labelStop_SAN.AutoSize = true;
            this.labelStop_SAN.Location = new System.Drawing.Point(123, 33);
            this.labelStop_SAN.Name = "labelStop_SAN";
            this.labelStop_SAN.Size = new System.Drawing.Size(92, 18);
            this.labelStop_SAN.TabIndex = 1;
            this.labelStop_SAN.Text = "Конец шага:";
            // 
            // labelStart_SAN
            // 
            this.labelStart_SAN.Location = new System.Drawing.Point(6, 33);
            this.labelStart_SAN.Name = "labelStart_SAN";
            this.labelStart_SAN.Size = new System.Drawing.Size(100, 23);
            this.labelStart_SAN.TabIndex = 4;
            this.labelStart_SAN.Text = "Старт шага:";
            // 
            // groupBoxOutput_SAN
            // 
            this.groupBoxOutput_SAN.Controls.Add(this.textBoxOutput_SAN);
            this.groupBoxOutput_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutput_SAN.Location = new System.Drawing.Point(12, 117);
            this.groupBoxOutput_SAN.Name = "groupBoxOutput_SAN";
            this.groupBoxOutput_SAN.Size = new System.Drawing.Size(340, 455);
            this.groupBoxOutput_SAN.TabIndex = 2;
            this.groupBoxOutput_SAN.TabStop = false;
            this.groupBoxOutput_SAN.Text = "Вывод";
            // 
            // textBoxOutput_SAN
            // 
            this.textBoxOutput_SAN.Location = new System.Drawing.Point(6, 23);
            this.textBoxOutput_SAN.Multiline = true;
            this.textBoxOutput_SAN.Name = "textBoxOutput_SAN";
            this.textBoxOutput_SAN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_SAN.Size = new System.Drawing.Size(314, 426);
            this.textBoxOutput_SAN.TabIndex = 0;
            // 
            // buttonDone_SAN
            // 
            this.buttonDone_SAN.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_SAN.Location = new System.Drawing.Point(744, 12);
            this.buttonDone_SAN.Name = "buttonDone_SAN";
            this.buttonDone_SAN.Size = new System.Drawing.Size(102, 93);
            this.buttonDone_SAN.TabIndex = 4;
            this.buttonDone_SAN.Text = "Выполнить";
            this.buttonDone_SAN.UseVisualStyleBackColor = false;
            this.buttonDone_SAN.Click += new System.EventHandler(this.buttonDone_SAN_Click);
            // 
            // buttonSave_SAN
            // 
            this.buttonSave_SAN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSave_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave_SAN.Location = new System.Drawing.Point(852, 12);
            this.buttonSave_SAN.Name = "buttonSave_SAN";
            this.buttonSave_SAN.Size = new System.Drawing.Size(106, 93);
            this.buttonSave_SAN.TabIndex = 5;
            this.buttonSave_SAN.Text = "Сохранить";
            this.buttonSave_SAN.UseVisualStyleBackColor = false;
            this.buttonSave_SAN.Click += new System.EventHandler(this.buttonSave_SAN_Click);
            this.buttonSave_SAN.MouseLeave += new System.EventHandler(this.buttonDone_SAN_Click);
            // 
            // buttonHelp_SAN
            // 
            this.buttonHelp_SAN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_SAN.Location = new System.Drawing.Point(964, 12);
            this.buttonHelp_SAN.Name = "buttonHelp_SAN";
            this.buttonHelp_SAN.Size = new System.Drawing.Size(102, 93);
            this.buttonHelp_SAN.TabIndex = 6;
            this.buttonHelp_SAN.Text = "Справка";
            this.buttonHelp_SAN.UseVisualStyleBackColor = false;
            this.buttonHelp_SAN.Click += new System.EventHandler(this.buttonHelp_SAN_Click);
            // 
            // panelTop_SAN
            // 
            this.panelTop_SAN.Location = new System.Drawing.Point(0, 0);
            this.panelTop_SAN.Name = "panelTop_SAN";
            this.panelTop_SAN.Size = new System.Drawing.Size(200, 100);
            this.panelTop_SAN.TabIndex = 6;
            // 
            // panelLeft_SAN
            // 
            this.panelLeft_SAN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelLeft_SAN.Controls.Add(this.splitterFill_SAN);
            this.panelLeft_SAN.Controls.Add(this.splitterLeft_SAN);
            this.panelLeft_SAN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_SAN.Location = new System.Drawing.Point(0, 0);
            this.panelLeft_SAN.Name = "panelLeft_SAN";
            this.panelLeft_SAN.Size = new System.Drawing.Size(373, 597);
            this.panelLeft_SAN.TabIndex = 1;
            // 
            // splitterFill_SAN
            // 
            this.splitterFill_SAN.Location = new System.Drawing.Point(3, 0);
            this.splitterFill_SAN.Name = "splitterFill_SAN";
            this.splitterFill_SAN.Size = new System.Drawing.Size(3, 597);
            this.splitterFill_SAN.TabIndex = 0;
            this.splitterFill_SAN.TabStop = false;
            // 
            // splitterLeft_SAN
            // 
            this.splitterLeft_SAN.Location = new System.Drawing.Point(0, 0);
            this.splitterLeft_SAN.Name = "splitterLeft_SAN";
            this.splitterLeft_SAN.Size = new System.Drawing.Size(3, 597);
            this.splitterLeft_SAN.TabIndex = 0;
            this.splitterLeft_SAN.TabStop = false;
            // 
            // panelFill_SAN
            // 
            this.panelFill_SAN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelFill_SAN.Controls.Add(this.chartResult_SAN);
            this.panelFill_SAN.Controls.Add(this.buttonSave_SAN);
            this.panelFill_SAN.Controls.Add(this.buttonHelp_SAN);
            this.panelFill_SAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_SAN.Location = new System.Drawing.Point(0, 0);
            this.panelFill_SAN.Name = "panelFill_SAN";
            this.panelFill_SAN.Size = new System.Drawing.Size(1078, 597);
            this.panelFill_SAN.TabIndex = 7;
            // 
            // chartResult_SAN
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_SAN.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResult_SAN.Legends.Add(legend1);
            this.chartResult_SAN.Location = new System.Drawing.Point(392, 117);
            this.chartResult_SAN.Name = "chartResult_SAN";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_SAN.Series.Add(series1);
            this.chartResult_SAN.Size = new System.Drawing.Size(674, 468);
            this.chartResult_SAN.TabIndex = 7;
            this.chartResult_SAN.Text = "chart1";
            // 
            // FormMain_SAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 597);
            this.Controls.Add(this.buttonDone_SAN);
            this.Controls.Add(this.groupBoxOutput_SAN);
            this.Controls.Add(this.groupBoxInput_SAN);
            this.Controls.Add(this.groupBoxTask_SAN);
            this.Controls.Add(this.panelTop_SAN);
            this.Controls.Add(this.panelLeft_SAN);
            this.Controls.Add(this.panelFill_SAN);
            this.MinimumSize = new System.Drawing.Size(1094, 636);
            this.Name = "FormMain_SAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 23 |  Шаукерова А.Н.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTask_SAN.ResumeLayout(false);
            this.groupBoxTask_SAN.PerformLayout();
            this.groupBoxInput_SAN.ResumeLayout(false);
            this.groupBoxInput_SAN.PerformLayout();
            this.groupBoxOutput_SAN.ResumeLayout(false);
            this.groupBoxOutput_SAN.PerformLayout();
            this.panelLeft_SAN.ResumeLayout(false);
            this.panelFill_SAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SAN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SAN;
        private System.Windows.Forms.TextBox textBoxTask_SAN;
        private System.Windows.Forms.GroupBox groupBoxInput_SAN;
        private System.Windows.Forms.TextBox textBoxStop_SAN;
        private System.Windows.Forms.TextBox textBoxStart_SAN;
        private System.Windows.Forms.Label labelStop_SAN;
        private System.Windows.Forms.Label labelStart_SAN;
        private System.Windows.Forms.GroupBox groupBoxOutput_SAN;
        private System.Windows.Forms.TextBox textBoxOutput_SAN;
        private System.Windows.Forms.Button buttonDone_SAN;
        private System.Windows.Forms.Button buttonSave_SAN;
        private System.Windows.Forms.Button buttonHelp_SAN;
        private System.Windows.Forms.Panel panelTop_SAN;
        private System.Windows.Forms.Panel panelLeft_SAN;
        private System.Windows.Forms.Splitter splitterFill_SAN;
        private System.Windows.Forms.Splitter splitterLeft_SAN;
        private System.Windows.Forms.Panel panelFill_SAN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_SAN;
    }
}

