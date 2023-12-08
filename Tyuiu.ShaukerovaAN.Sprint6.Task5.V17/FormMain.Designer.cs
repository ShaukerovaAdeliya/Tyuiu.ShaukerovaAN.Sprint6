
namespace Tyuiu.ShaukerovaAN.Sprint6.Task5.V17
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_SAN = new System.Windows.Forms.Panel();
            this.panelLeft_SAN = new System.Windows.Forms.Panel();
            this.panelFill_SAN = new System.Windows.Forms.Panel();
            this.groupBoxTask_SAN = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SAN = new System.Windows.Forms.TextBox();
            this.splitterPanel_SAN = new System.Windows.Forms.Splitter();
            this.groupBoxOutput_SAN = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_SAN = new System.Windows.Forms.DataGridView();
            this.chartResult_SAN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDone_SAN = new System.Windows.Forms.Button();
            this.buttonOpen_SAN = new System.Windows.Forms.Button();
            this.buttonHelp_SAN = new System.Windows.Forms.Button();
            this.panelTop_SAN.SuspendLayout();
            this.panelLeft_SAN.SuspendLayout();
            this.panelFill_SAN.SuspendLayout();
            this.groupBoxTask_SAN.SuspendLayout();
            this.groupBoxOutput_SAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SAN)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_SAN
            // 
            this.panelTop_SAN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelTop_SAN.Controls.Add(this.buttonHelp_SAN);
            this.panelTop_SAN.Controls.Add(this.buttonOpen_SAN);
            this.panelTop_SAN.Controls.Add(this.buttonDone_SAN);
            this.panelTop_SAN.Controls.Add(this.groupBoxTask_SAN);
            this.panelTop_SAN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_SAN.Location = new System.Drawing.Point(0, 0);
            this.panelTop_SAN.Name = "panelTop_SAN";
            this.panelTop_SAN.Size = new System.Drawing.Size(957, 156);
            this.panelTop_SAN.TabIndex = 0;
            // 
            // panelLeft_SAN
            // 
            this.panelLeft_SAN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelLeft_SAN.Controls.Add(this.groupBoxOutput_SAN);
            this.panelLeft_SAN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_SAN.Location = new System.Drawing.Point(0, 156);
            this.panelLeft_SAN.Name = "panelLeft_SAN";
            this.panelLeft_SAN.Size = new System.Drawing.Size(301, 443);
            this.panelLeft_SAN.TabIndex = 1;
            // 
            // panelFill_SAN
            // 
            this.panelFill_SAN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelFill_SAN.Controls.Add(this.chartResult_SAN);
            this.panelFill_SAN.Controls.Add(this.splitterPanel_SAN);
            this.panelFill_SAN.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFill_SAN.Location = new System.Drawing.Point(307, 156);
            this.panelFill_SAN.Name = "panelFill_SAN";
            this.panelFill_SAN.Size = new System.Drawing.Size(650, 443);
            this.panelFill_SAN.TabIndex = 2;
            // 
            // groupBoxTask_SAN
            // 
            this.groupBoxTask_SAN.Controls.Add(this.textBoxTask_SAN);
            this.groupBoxTask_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_SAN.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SAN.Name = "groupBoxTask_SAN";
            this.groupBoxTask_SAN.Size = new System.Drawing.Size(532, 138);
            this.groupBoxTask_SAN.TabIndex = 0;
            this.groupBoxTask_SAN.TabStop = false;
            this.groupBoxTask_SAN.Text = "Условие";
            // 
            // textBoxTask_SAN
            // 
            this.textBoxTask_SAN.Location = new System.Drawing.Point(6, 23);
            this.textBoxTask_SAN.Multiline = true;
            this.textBoxTask_SAN.Name = "textBoxTask_SAN";
            this.textBoxTask_SAN.Size = new System.Drawing.Size(520, 109);
            this.textBoxTask_SAN.TabIndex = 0;
            this.textBoxTask_SAN.Text = "Прочитать данные из файла InPutFileTask5V17.txt. Вывести в dataGridView. Вывести " +
    "все отрицательные числа. Построить диаграмму по этим значениям.";
            // 
            // splitterPanel_SAN
            // 
            this.splitterPanel_SAN.Location = new System.Drawing.Point(0, 0);
            this.splitterPanel_SAN.Name = "splitterPanel_SAN";
            this.splitterPanel_SAN.Size = new System.Drawing.Size(3, 443);
            this.splitterPanel_SAN.TabIndex = 0;
            this.splitterPanel_SAN.TabStop = false;
            // 
            // groupBoxOutput_SAN
            // 
            this.groupBoxOutput_SAN.Controls.Add(this.dataGridViewResult_SAN);
            this.groupBoxOutput_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutput_SAN.Location = new System.Drawing.Point(12, 6);
            this.groupBoxOutput_SAN.Name = "groupBoxOutput_SAN";
            this.groupBoxOutput_SAN.Size = new System.Drawing.Size(264, 426);
            this.groupBoxOutput_SAN.TabIndex = 0;
            this.groupBoxOutput_SAN.TabStop = false;
            this.groupBoxOutput_SAN.Text = "Вывод данных:";
            // 
            // dataGridViewResult_SAN
            // 
            this.dataGridViewResult_SAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SAN.Location = new System.Drawing.Point(6, 23);
            this.dataGridViewResult_SAN.Name = "dataGridViewResult_SAN";
            this.dataGridViewResult_SAN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewResult_SAN.Size = new System.Drawing.Size(240, 397);
            this.dataGridViewResult_SAN.TabIndex = 0;
            // 
            // chartResult_SAN
            // 
            this.chartResult_SAN.BackColor = System.Drawing.SystemColors.ButtonFace;
            chartArea2.Name = "ChartArea1";
            this.chartResult_SAN.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartResult_SAN.Legends.Add(legend2);
            this.chartResult_SAN.Location = new System.Drawing.Point(9, 12);
            this.chartResult_SAN.Name = "chartResult_SAN";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartResult_SAN.Series.Add(series2);
            this.chartResult_SAN.Size = new System.Drawing.Size(631, 420);
            this.chartResult_SAN.TabIndex = 1;
            this.chartResult_SAN.Text = "chart1";
            // 
            // buttonDone_SAN
            // 
            this.buttonDone_SAN.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_SAN.Location = new System.Drawing.Point(563, 35);
            this.buttonDone_SAN.Name = "buttonDone_SAN";
            this.buttonDone_SAN.Size = new System.Drawing.Size(112, 90);
            this.buttonDone_SAN.TabIndex = 1;
            this.buttonDone_SAN.Text = "Выполнить";
            this.buttonDone_SAN.UseVisualStyleBackColor = false;
            this.buttonDone_SAN.Click += new System.EventHandler(this.buttonDone_SAN_Click);
            // 
            // buttonOpen_SAN
            // 
            this.buttonOpen_SAN.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpen_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen_SAN.Location = new System.Drawing.Point(694, 35);
            this.buttonOpen_SAN.Name = "buttonOpen_SAN";
            this.buttonOpen_SAN.Size = new System.Drawing.Size(112, 90);
            this.buttonOpen_SAN.TabIndex = 2;
            this.buttonOpen_SAN.Text = "Открыть файл";
            this.buttonOpen_SAN.UseVisualStyleBackColor = false;
            this.buttonOpen_SAN.Click += new System.EventHandler(this.buttonOpen_SAN_Click);
            // 
            // buttonHelp_SAN
            // 
            this.buttonHelp_SAN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonHelp_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_SAN.Location = new System.Drawing.Point(829, 35);
            this.buttonHelp_SAN.Name = "buttonHelp_SAN";
            this.buttonHelp_SAN.Size = new System.Drawing.Size(112, 90);
            this.buttonHelp_SAN.TabIndex = 3;
            this.buttonHelp_SAN.Text = "Справка";
            this.buttonHelp_SAN.UseVisualStyleBackColor = false;
            this.buttonHelp_SAN.Click += new System.EventHandler(this.buttonHelp_SAN_Click);
            // 
            // FormMain_SAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 599);
            this.Controls.Add(this.panelFill_SAN);
            this.Controls.Add(this.panelLeft_SAN);
            this.Controls.Add(this.panelTop_SAN);
            this.Name = "FormMain_SAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 17 | Шаукерова А.Н. ";
            this.panelTop_SAN.ResumeLayout(false);
            this.panelLeft_SAN.ResumeLayout(false);
            this.panelFill_SAN.ResumeLayout(false);
            this.groupBoxTask_SAN.ResumeLayout(false);
            this.groupBoxTask_SAN.PerformLayout();
            this.groupBoxOutput_SAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SAN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_SAN;
        private System.Windows.Forms.GroupBox groupBoxTask_SAN;
        private System.Windows.Forms.Panel panelLeft_SAN;
        private System.Windows.Forms.Panel panelFill_SAN;
        private System.Windows.Forms.TextBox textBoxTask_SAN;
        private System.Windows.Forms.Splitter splitterPanel_SAN;
        private System.Windows.Forms.Button buttonHelp_SAN;
        private System.Windows.Forms.Button buttonOpen_SAN;
        private System.Windows.Forms.Button buttonDone_SAN;
        private System.Windows.Forms.GroupBox groupBoxOutput_SAN;
        private System.Windows.Forms.DataGridView dataGridViewResult_SAN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_SAN;
    }
}

