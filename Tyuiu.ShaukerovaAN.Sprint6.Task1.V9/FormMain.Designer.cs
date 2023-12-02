
namespace Tyuiu.ShaukerovaAN.Sprint6.Task1.V9
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
            this.groupBoxCondition_SAN = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_SAN = new System.Windows.Forms.PictureBox();
            this.textBoxTask_SAN = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_SAN = new System.Windows.Forms.GroupBox();
            this.labelEnd_SAN = new System.Windows.Forms.Label();
            this.labelStart_SAN = new System.Windows.Forms.Label();
            this.textBoxStop_SAN = new System.Windows.Forms.TextBox();
            this.textBoxStart_SAN = new System.Windows.Forms.TextBox();
            this.groupBoxOutputdata_SAN = new System.Windows.Forms.GroupBox();
            this.labelResult_SAN = new System.Windows.Forms.Label();
            this.textBoxResult_SAN = new System.Windows.Forms.TextBox();
            this.buttonSpravka_SAN = new System.Windows.Forms.Button();
            this.buttonDone_SAN = new System.Windows.Forms.Button();
            this.groupBoxCondition_SAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SAN)).BeginInit();
            this.groupBoxInputData_SAN.SuspendLayout();
            this.groupBoxOutputdata_SAN.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_SAN
            // 
            this.groupBoxCondition_SAN.Controls.Add(this.pictureBoxFormula_SAN);
            this.groupBoxCondition_SAN.Controls.Add(this.textBoxTask_SAN);
            this.groupBoxCondition_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_SAN.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_SAN.Name = "groupBoxCondition_SAN";
            this.groupBoxCondition_SAN.Size = new System.Drawing.Size(600, 303);
            this.groupBoxCondition_SAN.TabIndex = 0;
            this.groupBoxCondition_SAN.TabStop = false;
            this.groupBoxCondition_SAN.Text = "Условие";
            // 
            // pictureBoxFormula_SAN
            // 
            this.pictureBoxFormula_SAN.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_SAN.Image")));
            this.pictureBoxFormula_SAN.Location = new System.Drawing.Point(6, 75);
            this.pictureBoxFormula_SAN.Name = "pictureBoxFormula_SAN";
            this.pictureBoxFormula_SAN.Size = new System.Drawing.Size(577, 89);
            this.pictureBoxFormula_SAN.TabIndex = 1;
            this.pictureBoxFormula_SAN.TabStop = false;
            // 
            // textBoxTask_SAN
            // 
            this.textBoxTask_SAN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTask_SAN.Location = new System.Drawing.Point(6, 34);
            this.textBoxTask_SAN.Multiline = true;
            this.textBoxTask_SAN.Name = "textBoxTask_SAN";
            this.textBoxTask_SAN.Size = new System.Drawing.Size(588, 257);
            this.textBoxTask_SAN.TabIndex = 0;
            this.textBoxTask_SAN.Text = "Протабулировать функцию в заданном диапазоне.\r\nРезультат вывести в виде таблицы";
            // 
            // groupBoxInputData_SAN
            // 
            this.groupBoxInputData_SAN.Controls.Add(this.labelEnd_SAN);
            this.groupBoxInputData_SAN.Controls.Add(this.labelStart_SAN);
            this.groupBoxInputData_SAN.Controls.Add(this.textBoxStop_SAN);
            this.groupBoxInputData_SAN.Controls.Add(this.textBoxStart_SAN);
            this.groupBoxInputData_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputData_SAN.Location = new System.Drawing.Point(18, 321);
            this.groupBoxInputData_SAN.Name = "groupBoxInputData_SAN";
            this.groupBoxInputData_SAN.Size = new System.Drawing.Size(338, 100);
            this.groupBoxInputData_SAN.TabIndex = 1;
            this.groupBoxInputData_SAN.TabStop = false;
            this.groupBoxInputData_SAN.Text = "Ввод данных";
            // 
            // labelEnd_SAN
            // 
            this.labelEnd_SAN.AutoSize = true;
            this.labelEnd_SAN.Location = new System.Drawing.Point(174, 49);
            this.labelEnd_SAN.Name = "labelEnd_SAN";
            this.labelEnd_SAN.Size = new System.Drawing.Size(92, 18);
            this.labelEnd_SAN.TabIndex = 5;
            this.labelEnd_SAN.Text = "Конец шага:";
            // 
            // labelStart_SAN
            // 
            this.labelStart_SAN.AutoSize = true;
            this.labelStart_SAN.Location = new System.Drawing.Point(6, 49);
            this.labelStart_SAN.Name = "labelStart_SAN";
            this.labelStart_SAN.Size = new System.Drawing.Size(90, 18);
            this.labelStart_SAN.TabIndex = 3;
            this.labelStart_SAN.Text = "Старт шага:";
            // 
            // textBoxStop_SAN
            // 
            this.textBoxStop_SAN.Location = new System.Drawing.Point(177, 70);
            this.textBoxStop_SAN.Name = "textBoxStop_SAN";
            this.textBoxStop_SAN.Size = new System.Drawing.Size(145, 24);
            this.textBoxStop_SAN.TabIndex = 1;
            // 
            // textBoxStart_SAN
            // 
            this.textBoxStart_SAN.Location = new System.Drawing.Point(6, 70);
            this.textBoxStart_SAN.Name = "textBoxStart_SAN";
            this.textBoxStart_SAN.Size = new System.Drawing.Size(145, 24);
            this.textBoxStart_SAN.TabIndex = 0;
            // 
            // groupBoxOutputdata_SAN
            // 
            this.groupBoxOutputdata_SAN.Controls.Add(this.labelResult_SAN);
            this.groupBoxOutputdata_SAN.Controls.Add(this.textBoxResult_SAN);
            this.groupBoxOutputdata_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutputdata_SAN.Location = new System.Drawing.Point(618, 21);
            this.groupBoxOutputdata_SAN.Name = "groupBoxOutputdata_SAN";
            this.groupBoxOutputdata_SAN.Size = new System.Drawing.Size(424, 394);
            this.groupBoxOutputdata_SAN.TabIndex = 4;
            this.groupBoxOutputdata_SAN.TabStop = false;
            this.groupBoxOutputdata_SAN.Text = "Вывод данных";
            // 
            // labelResult_SAN
            // 
            this.labelResult_SAN.AutoSize = true;
            this.labelResult_SAN.Location = new System.Drawing.Point(6, 27);
            this.labelResult_SAN.Name = "labelResult_SAN";
            this.labelResult_SAN.Size = new System.Drawing.Size(84, 18);
            this.labelResult_SAN.TabIndex = 1;
            this.labelResult_SAN.Text = "Результат:";
            // 
            // textBoxResult_SAN
            // 
            this.textBoxResult_SAN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxResult_SAN.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_SAN.Location = new System.Drawing.Point(9, 48);
            this.textBoxResult_SAN.Multiline = true;
            this.textBoxResult_SAN.Name = "textBoxResult_SAN";
            this.textBoxResult_SAN.ReadOnly = true;
            this.textBoxResult_SAN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SAN.Size = new System.Drawing.Size(409, 340);
            this.textBoxResult_SAN.TabIndex = 0;
            // 
            // buttonSpravka_SAN
            // 
            this.buttonSpravka_SAN.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSpravka_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSpravka_SAN.Location = new System.Drawing.Point(379, 346);
            this.buttonSpravka_SAN.Name = "buttonSpravka_SAN";
            this.buttonSpravka_SAN.Size = new System.Drawing.Size(75, 69);
            this.buttonSpravka_SAN.TabIndex = 6;
            this.buttonSpravka_SAN.Text = "Справка";
            this.buttonSpravka_SAN.UseVisualStyleBackColor = false;
            this.buttonSpravka_SAN.Click += new System.EventHandler(this.buttonSpravka_SAN_Click);
            // 
            // buttonDone_SAN
            // 
            this.buttonDone_SAN.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_SAN.Location = new System.Drawing.Point(460, 346);
            this.buttonDone_SAN.Name = "buttonDone_SAN";
            this.buttonDone_SAN.Size = new System.Drawing.Size(135, 69);
            this.buttonDone_SAN.TabIndex = 7;
            this.buttonDone_SAN.Text = "Выполнить";
            this.buttonDone_SAN.UseVisualStyleBackColor = false;
            this.buttonDone_SAN.Click += new System.EventHandler(this.buttonDone_SAN_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 536);
            this.Controls.Add(this.buttonDone_SAN);
            this.Controls.Add(this.buttonSpravka_SAN);
            this.Controls.Add(this.groupBoxOutputdata_SAN);
            this.Controls.Add(this.groupBoxInputData_SAN);
            this.Controls.Add(this.groupBoxCondition_SAN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 9 | Шаукерова А.Н.";
            this.groupBoxCondition_SAN.ResumeLayout(false);
            this.groupBoxCondition_SAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SAN)).EndInit();
            this.groupBoxInputData_SAN.ResumeLayout(false);
            this.groupBoxInputData_SAN.PerformLayout();
            this.groupBoxOutputdata_SAN.ResumeLayout(false);
            this.groupBoxOutputdata_SAN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_SAN;
        private System.Windows.Forms.TextBox textBoxTask_SAN;
        private System.Windows.Forms.GroupBox groupBoxInputData_SAN;
        private System.Windows.Forms.Label labelStart_SAN;
        private System.Windows.Forms.TextBox textBoxStop_SAN;
        private System.Windows.Forms.TextBox textBoxStart_SAN;
        private System.Windows.Forms.Label labelEnd_SAN;
        private System.Windows.Forms.PictureBox pictureBoxFormula_SAN;
        private System.Windows.Forms.GroupBox groupBoxOutputdata_SAN;
        private System.Windows.Forms.Label labelResult_SAN;
        private System.Windows.Forms.TextBox textBoxResult_SAN;
        private System.Windows.Forms.Button buttonSpravka_SAN;
        private System.Windows.Forms.Button buttonDone_SAN;
    }
}

