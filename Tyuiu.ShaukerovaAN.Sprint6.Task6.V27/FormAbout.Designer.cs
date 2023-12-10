
namespace Tyuiu.ShaukerovaAN.Sprint6.Task6.V27
{
    partial class FormAbout_SAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_SAN));
            this.buttonDone_SAN = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_SAN = new System.Windows.Forms.PictureBox();
            this.labelInfo_SAN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SAN)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_SAN
            // 
            this.buttonDone_SAN.Location = new System.Drawing.Point(392, 156);
            this.buttonDone_SAN.Name = "buttonDone_SAN";
            this.buttonDone_SAN.Size = new System.Drawing.Size(146, 39);
            this.buttonDone_SAN.TabIndex = 0;
            this.buttonDone_SAN.Text = "OK";
            this.buttonDone_SAN.UseVisualStyleBackColor = true;
            this.buttonDone_SAN.Click += new System.EventHandler(this.buttonDone_SAN_Click);
            // 
            // pictureBoxAvatar_SAN
            // 
            this.pictureBoxAvatar_SAN.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_SAN.Image")));
            this.pictureBoxAvatar_SAN.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_SAN.Name = "pictureBoxAvatar_SAN";
            this.pictureBoxAvatar_SAN.Size = new System.Drawing.Size(137, 183);
            this.pictureBoxAvatar_SAN.TabIndex = 1;
            this.pictureBoxAvatar_SAN.TabStop = false;
            // 
            // labelInfo_SAN
            // 
            this.labelInfo_SAN.AutoSize = true;
            this.labelInfo_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_SAN.Location = new System.Drawing.Point(169, 9);
            this.labelInfo_SAN.Name = "labelInfo_SAN";
            this.labelInfo_SAN.Size = new System.Drawing.Size(359, 144);
            this.labelInfo_SAN.TabIndex = 2;
            this.labelInfo_SAN.Text = resources.GetString("labelInfo_SAN.Text");
            // 
            // FormAbout_SAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 217);
            this.Controls.Add(this.labelInfo_SAN);
            this.Controls.Add(this.pictureBoxAvatar_SAN);
            this.Controls.Add(this.buttonDone_SAN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_SAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SAN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_SAN;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_SAN;
        private System.Windows.Forms.Label labelInfo_SAN;
    }
}