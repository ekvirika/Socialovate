namespace SocilovateUI.UCs
{
    partial class ProfileSection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Username = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(253, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 243);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("SF Compact Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(343, 320);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(51, 19);
            this.Username.TabIndex = 2;
            this.Username.Text = "label2";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("SF Compact Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(343, 354);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(51, 19);
            this.Age.TabIndex = 2;
            this.Age.Text = "label2";
            this.Age.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("SF Compact Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(343, 389);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(51, 19);
            this.Email.TabIndex = 2;
            this.Email.Text = "label2";
            this.Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProfileSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("SF Compact Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ProfileSection";
            this.Size = new System.Drawing.Size(802, 577);
            this.Load += new System.EventHandler(this.ProfileSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label Email;
    }
}
