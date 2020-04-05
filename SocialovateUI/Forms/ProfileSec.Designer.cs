namespace SocialovateUI.Forms
{
    partial class ProfileSec
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Nameuser = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(161, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 319);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Nameuser
            // 
            this.Nameuser.AutoSize = true;
            this.Nameuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(138)))));
            this.Nameuser.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nameuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.Nameuser.Location = new System.Drawing.Point(307, 393);
            this.Nameuser.Name = "Nameuser";
            this.Nameuser.Size = new System.Drawing.Size(47, 19);
            this.Nameuser.TabIndex = 1;
            this.Nameuser.Text = "label1";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.Username.Location = new System.Drawing.Point(307, 426);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(47, 19);
            this.Username.TabIndex = 1;
            this.Username.Text = "label1";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.Age.Location = new System.Drawing.Point(307, 485);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(47, 19);
            this.Age.TabIndex = 1;
            this.Age.Text = "label1";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.Email.Location = new System.Drawing.Point(307, 454);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(47, 19);
            this.Email.TabIndex = 1;
            this.Email.Text = "label1";
            // 
            // ProfileSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(675, 555);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Nameuser);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ProfileSec";
            this.Load += new System.EventHandler(this.ProfileSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Nameuser;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label Email;
    }
}