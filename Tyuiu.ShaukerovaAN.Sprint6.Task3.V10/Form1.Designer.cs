
namespace Tyuiu.ShaukerovaAN.Sprint6.Task3.V10
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
            this.groupBoxTask_SAN = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_SAN = new System.Windows.Forms.DataGridView();
            this.textBoxTask_SAN = new System.Windows.Forms.TextBox();
            this.buttonDone_SAN = new System.Windows.Forms.Button();
            this.buttonHelp_SAN = new System.Windows.Forms.Button();
            this.groupBoxOutput_SAN = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_SAN = new System.Windows.Forms.DataGridView();
            this.labelResult_SAN = new System.Windows.Forms.Label();
            this.groupBoxTask_SAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SAN)).BeginInit();
            this.groupBoxOutput_SAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SAN
            // 
            this.groupBoxTask_SAN.Controls.Add(this.dataGridViewMatrix_SAN);
            this.groupBoxTask_SAN.Controls.Add(this.textBoxTask_SAN);
            this.groupBoxTask_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_SAN.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SAN.Name = "groupBoxTask_SAN";
            this.groupBoxTask_SAN.Size = new System.Drawing.Size(738, 395);
            this.groupBoxTask_SAN.TabIndex = 0;
            this.groupBoxTask_SAN.TabStop = false;
            this.groupBoxTask_SAN.Text = "Условие";
            // 
            // dataGridViewMatrix_SAN
            // 
            this.dataGridViewMatrix_SAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_SAN.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_SAN.Location = new System.Drawing.Point(414, 34);
            this.dataGridViewMatrix_SAN.Name = "dataGridViewMatrix_SAN";
            this.dataGridViewMatrix_SAN.RowHeadersVisible = false;
            this.dataGridViewMatrix_SAN.Size = new System.Drawing.Size(304, 339);
            this.dataGridViewMatrix_SAN.TabIndex = 1;
            // 
            // textBoxTask_SAN
            // 
            this.textBoxTask_SAN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTask_SAN.Location = new System.Drawing.Point(6, 34);
            this.textBoxTask_SAN.Multiline = true;
            this.textBoxTask_SAN.Name = "textBoxTask_SAN";
            this.textBoxTask_SAN.Size = new System.Drawing.Size(402, 230);
            this.textBoxTask_SAN.TabIndex = 0;
            this.textBoxTask_SAN.Text = "Дана матрица 5 на 5 \r\n-17   6 -19   6 -13\r\n\r\n-19   3  12 -11  19\r\n\r\n-20  11   9  " +
    "19 -19\r\n\r\n-20  10  -9  17   9\r\n\r\n-4   9  -8  13  -8\r\nЗаменить четные значения в " +
    "пятой строке на 0";
            // 
            // buttonDone_SAN
            // 
            this.buttonDone_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_SAN.Location = new System.Drawing.Point(993, 356);
            this.buttonDone_SAN.Name = "buttonDone_SAN";
            this.buttonDone_SAN.Size = new System.Drawing.Size(143, 51);
            this.buttonDone_SAN.TabIndex = 1;
            this.buttonDone_SAN.Text = "Выполнить";
            this.buttonDone_SAN.UseVisualStyleBackColor = true;
            this.buttonDone_SAN.Click += new System.EventHandler(this.buttonDone_SAN_Click);
            // 
            // buttonHelp_SAN
            // 
            this.buttonHelp_SAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_SAN.Location = new System.Drawing.Point(888, 356);
            this.buttonHelp_SAN.Name = "buttonHelp_SAN";
            this.buttonHelp_SAN.Size = new System.Drawing.Size(67, 51);
            this.buttonHelp_SAN.TabIndex = 2;
            this.buttonHelp_SAN.Text = "?";
            this.buttonHelp_SAN.UseVisualStyleBackColor = true;
            this.buttonHelp_SAN.Click += new System.EventHandler(this.buttonHelp_SAN_Click);
            // 
            // groupBoxOutput_SAN
            // 
            this.groupBoxOutput_SAN.Controls.Add(this.dataGridViewResult_SAN);
            this.groupBoxOutput_SAN.Controls.Add(this.labelResult_SAN);
            this.groupBoxOutput_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutput_SAN.Location = new System.Drawing.Point(768, 12);
            this.groupBoxOutput_SAN.Name = "groupBoxOutput_SAN";
            this.groupBoxOutput_SAN.Size = new System.Drawing.Size(368, 338);
            this.groupBoxOutput_SAN.TabIndex = 3;
            this.groupBoxOutput_SAN.TabStop = false;
            this.groupBoxOutput_SAN.Text = "Вывод данных";
            // 
            // dataGridViewResult_SAN
            // 
            this.dataGridViewResult_SAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SAN.Location = new System.Drawing.Point(18, 58);
            this.dataGridViewResult_SAN.Name = "dataGridViewResult_SAN";
            this.dataGridViewResult_SAN.Size = new System.Drawing.Size(319, 264);
            this.dataGridViewResult_SAN.TabIndex = 1;
            // 
            // labelResult_SAN
            // 
            this.labelResult_SAN.AutoSize = true;
            this.labelResult_SAN.Location = new System.Drawing.Point(15, 34);
            this.labelResult_SAN.Name = "labelResult_SAN";
            this.labelResult_SAN.Size = new System.Drawing.Size(84, 18);
            this.labelResult_SAN.TabIndex = 0;
            this.labelResult_SAN.Text = "Результат:";
            // 
            // FormMain_SAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 445);
            this.Controls.Add(this.groupBoxOutput_SAN);
            this.Controls.Add(this.buttonHelp_SAN);
            this.Controls.Add(this.buttonDone_SAN);
            this.Controls.Add(this.groupBoxTask_SAN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_SAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 10 | Шаукерова А.Н.";
            this.Load += new System.EventHandler(this.FormMain_Load_SAN);
            this.groupBoxTask_SAN.ResumeLayout(false);
            this.groupBoxTask_SAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SAN)).EndInit();
            this.groupBoxOutput_SAN.ResumeLayout(false);
            this.groupBoxOutput_SAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SAN;
        private System.Windows.Forms.TextBox textBoxTask_SAN;
        private System.Windows.Forms.Button buttonDone_SAN;
        private System.Windows.Forms.Button buttonHelp_SAN;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_SAN;
        private System.Windows.Forms.GroupBox groupBoxOutput_SAN;
        private System.Windows.Forms.DataGridView dataGridViewResult_SAN;
        private System.Windows.Forms.Label labelResult_SAN;
    }
}

