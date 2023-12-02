
namespace Tyuiu.ShaukerovaAN.Sprint6.Task0.V13
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
            this.groupBoxTask_SAN = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_SAN = new System.Windows.Forms.PictureBox();
            this.textBoxTask_SAN = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_SAN = new System.Windows.Forms.GroupBox();
            this.labelVarX_SAN = new System.Windows.Forms.Label();
            this.textBoxVarA_SAN = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData_SAN = new System.Windows.Forms.GroupBox();
            this.labelResult_SAN = new System.Windows.Forms.Label();
            this.textBoxResult_SAN = new System.Windows.Forms.TextBox();
            this.buttonHelp_SAN = new System.Windows.Forms.Button();
            this.buttonDone_SAN = new System.Windows.Forms.Button();
            this.groupBoxTask_SAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SAN)).BeginInit();
            this.groupBoxInputData_SAN.SuspendLayout();
            this.groupBoxOutputData_SAN.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SAN
            // 
            this.groupBoxTask_SAN.Controls.Add(this.pictureBoxFormula_SAN);
            this.groupBoxTask_SAN.Controls.Add(this.textBoxTask_SAN);
            this.groupBoxTask_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_SAN.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SAN.Name = "groupBoxTask_SAN";
            this.groupBoxTask_SAN.Size = new System.Drawing.Size(779, 248);
            this.groupBoxTask_SAN.TabIndex = 0;
            this.groupBoxTask_SAN.TabStop = false;
            this.groupBoxTask_SAN.Text = "Условие";
            // 
            // pictureBoxFormula_SAN
            // 
            this.pictureBoxFormula_SAN.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_SAN.Image")));
            this.pictureBoxFormula_SAN.Location = new System.Drawing.Point(609, 35);
            this.pictureBoxFormula_SAN.Name = "pictureBoxFormula_SAN";
            this.pictureBoxFormula_SAN.Size = new System.Drawing.Size(129, 79);
            this.pictureBoxFormula_SAN.TabIndex = 1;
            this.pictureBoxFormula_SAN.TabStop = false;
            // 
            // textBoxTask_SAN
            // 
            this.textBoxTask_SAN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTask_SAN.Location = new System.Drawing.Point(6, 35);
            this.textBoxTask_SAN.Multiline = true;
            this.textBoxTask_SAN.Name = "textBoxTask_SAN";
            this.textBoxTask_SAN.Size = new System.Drawing.Size(568, 186);
            this.textBoxTask_SAN.TabIndex = 0;
            this.textBoxTask_SAN.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInputData_SAN
            // 
            this.groupBoxInputData_SAN.Controls.Add(this.textBoxVarA_SAN);
            this.groupBoxInputData_SAN.Controls.Add(this.labelVarX_SAN);
            this.groupBoxInputData_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputData_SAN.Location = new System.Drawing.Point(12, 290);
            this.groupBoxInputData_SAN.Name = "groupBoxInputData_SAN";
            this.groupBoxInputData_SAN.Size = new System.Drawing.Size(395, 100);
            this.groupBoxInputData_SAN.TabIndex = 1;
            this.groupBoxInputData_SAN.TabStop = false;
            this.groupBoxInputData_SAN.Text = "Ввод данных";
            // 
            // labelVarX_SAN
            // 
            this.labelVarX_SAN.Location = new System.Drawing.Point(6, 34);
            this.labelVarX_SAN.Name = "labelVarX_SAN";
            this.labelVarX_SAN.Size = new System.Drawing.Size(120, 23);
            this.labelVarX_SAN.TabIndex = 3;
            this.labelVarX_SAN.Text = "Переменная X:";
            // 
            // textBoxVarA_SAN
            // 
            this.textBoxVarA_SAN.Location = new System.Drawing.Point(6, 62);
            this.textBoxVarA_SAN.Name = "textBoxVarA_SAN";
            this.textBoxVarA_SAN.Size = new System.Drawing.Size(183, 24);
            this.textBoxVarA_SAN.TabIndex = 1;
            // 
            // groupBoxOutputData_SAN
            // 
            this.groupBoxOutputData_SAN.Controls.Add(this.labelResult_SAN);
            this.groupBoxOutputData_SAN.Controls.Add(this.textBoxResult_SAN);
            this.groupBoxOutputData_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutputData_SAN.Location = new System.Drawing.Point(426, 290);
            this.groupBoxOutputData_SAN.Name = "groupBoxOutputData_SAN";
            this.groupBoxOutputData_SAN.Size = new System.Drawing.Size(365, 100);
            this.groupBoxOutputData_SAN.TabIndex = 2;
            this.groupBoxOutputData_SAN.TabStop = false;
            this.groupBoxOutputData_SAN.Text = "Вывод данных";
            // 
            // labelResult_SAN
            // 
            this.labelResult_SAN.AutoSize = true;
            this.labelResult_SAN.Location = new System.Drawing.Point(6, 41);
            this.labelResult_SAN.Name = "labelResult_SAN";
            this.labelResult_SAN.Size = new System.Drawing.Size(84, 18);
            this.labelResult_SAN.TabIndex = 1;
            this.labelResult_SAN.Text = "Результат:";
            // 
            // textBoxResult_SAN
            // 
            this.textBoxResult_SAN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxResult_SAN.Location = new System.Drawing.Point(6, 62);
            this.textBoxResult_SAN.Name = "textBoxResult_SAN";
            this.textBoxResult_SAN.Size = new System.Drawing.Size(300, 24);
            this.textBoxResult_SAN.TabIndex = 0;
            // 
            // buttonHelp_SAN
            // 
            this.buttonHelp_SAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_SAN.Location = new System.Drawing.Point(594, 396);
            this.buttonHelp_SAN.Name = "buttonHelp_SAN";
            this.buttonHelp_SAN.Size = new System.Drawing.Size(42, 43);
            this.buttonHelp_SAN.TabIndex = 3;
            this.buttonHelp_SAN.Text = "?";
            this.buttonHelp_SAN.UseVisualStyleBackColor = true;
            this.buttonHelp_SAN.Click += new System.EventHandler(this.buttonHelp_SAN_Click);
            // 
            // buttonDone_SAN
            // 
            this.buttonDone_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_SAN.Location = new System.Drawing.Point(665, 396);
            this.buttonDone_SAN.Name = "buttonDone_SAN";
            this.buttonDone_SAN.Size = new System.Drawing.Size(109, 43);
            this.buttonDone_SAN.TabIndex = 4;
            this.buttonDone_SAN.Text = "Выполнить";
            this.buttonDone_SAN.UseVisualStyleBackColor = true;
            this.buttonDone_SAN.Click += new System.EventHandler(this.buttonDone_SAN_Click);
            // 
            // FormMain_SAN
            // 
            this.ClientSize = new System.Drawing.Size(803, 451);
            this.Controls.Add(this.groupBoxInputData_SAN);
            this.Controls.Add(this.buttonDone_SAN);
            this.Controls.Add(this.buttonHelp_SAN);
            this.Controls.Add(this.groupBoxOutputData_SAN);
            this.Controls.Add(this.groupBoxTask_SAN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_SAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 13 | Шаукерова А.Н.";
            this.groupBoxTask_SAN.ResumeLayout(false);
            this.groupBoxTask_SAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SAN)).EndInit();
            this.groupBoxInputData_SAN.ResumeLayout(false);
            this.groupBoxInputData_SAN.PerformLayout();
            this.groupBoxOutputData_SAN.ResumeLayout(false);
            this.groupBoxOutputData_SAN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SAN;
        private System.Windows.Forms.PictureBox pictureBoxFormula_SAN;
        private System.Windows.Forms.TextBox textBoxTask_SAN;
        private System.Windows.Forms.GroupBox groupBoxInputData_SAN;
        private System.Windows.Forms.TextBox textBoxVarA_SAN;
        private System.Windows.Forms.GroupBox groupBoxOutputData_SAN;
        private System.Windows.Forms.TextBox textBoxResult_SAN;
        private System.Windows.Forms.Label labelVarX_SAN;
        private System.Windows.Forms.Label labelResult_SAN;
        private System.Windows.Forms.Button buttonHelp_SAN;
        private System.Windows.Forms.Button buttonDone_SAN;
    }
}

