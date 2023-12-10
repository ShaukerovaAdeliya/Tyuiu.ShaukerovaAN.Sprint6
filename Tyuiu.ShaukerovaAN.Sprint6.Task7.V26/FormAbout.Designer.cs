
namespace Tyuiu.ShaukerovaAN.Sprint6.Task7.V26
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
            this.pictureBoxAvatar_SAN = new System.Windows.Forms.PictureBox();
            this.labelInfo_SAN = new System.Windows.Forms.Label();
            this.buttonOK_SAN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SAN)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_SAN
            // 
            this.pictureBoxAvatar_SAN.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_SAN.Image")));
            this.pictureBoxAvatar_SAN.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_SAN.Name = "pictureBoxAvatar_SAN";
            this.pictureBoxAvatar_SAN.Size = new System.Drawing.Size(142, 186);
            this.pictureBoxAvatar_SAN.TabIndex = 0;
            this.pictureBoxAvatar_SAN.TabStop = false;
            // 
            // labelInfo_SAN
            // 
            this.labelInfo_SAN.AutoSize = true;
            this.labelInfo_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_SAN.Location = new System.Drawing.Point(160, 12);
            this.labelInfo_SAN.Name = "labelInfo_SAN";
            this.labelInfo_SAN.Size = new System.Drawing.Size(389, 162);
            this.labelInfo_SAN.TabIndex = 1;
            this.labelInfo_SAN.Text = resources.GetString("labelInfo_SAN.Text");
            // 
            // buttonOK_SAN
            // 
            this.buttonOK_SAN.Location = new System.Drawing.Point(393, 209);
            this.buttonOK_SAN.Name = "buttonOK_SAN";
            this.buttonOK_SAN.Size = new System.Drawing.Size(129, 37);
            this.buttonOK_SAN.TabIndex = 2;
            this.buttonOK_SAN.Text = "OK";
            this.buttonOK_SAN.UseVisualStyleBackColor = true;
            this.buttonOK_SAN.Click += new System.EventHandler(this.buttonOK_SAN_Click);
            // 
            // FormAbout_SAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 258);
            this.Controls.Add(this.buttonOK_SAN);
            this.Controls.Add(this.labelInfo_SAN);
            this.Controls.Add(this.pictureBoxAvatar_SAN);
            this.Name = "FormAbout_SAN";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SAN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_SAN;
        private System.Windows.Forms.Label labelInfo_SAN;
        private System.Windows.Forms.Button buttonOK_SAN;
    }
}