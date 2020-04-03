namespace SocilovateUI.UCs
{
    partial class UserProfile
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
            this.Username = new System.Windows.Forms.Label();
            this.Fullname = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(339, 316);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(62, 23);
            this.Username.TabIndex = 0;
            this.Username.Text = "label1";
            // 
            // Fullname
            // 
            this.Fullname.AutoSize = true;
            this.Fullname.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fullname.Location = new System.Drawing.Point(339, 356);
            this.Fullname.Name = "Fullname";
            this.Fullname.Size = new System.Drawing.Size(64, 23);
            this.Fullname.TabIndex = 1;
            this.Fullname.Text = "label2";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(339, 394);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(62, 23);
            this.Age.TabIndex = 0;
            this.Age.Text = "label1";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(339, 427);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(62, 23);
            this.Email.TabIndex = 0;
            this.Email.Text = "label1";
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Location = new System.Drawing.Point(255, 81);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(224, 199);
            this.ProfilePicture.TabIndex = 3;
            this.ProfilePicture.TabStop = false;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.Fullname);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Username);
            this.Name = "UserProfile";
            this.Size = new System.Drawing.Size(740, 548);
            this.Load += new System.EventHandler(this.UserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Fullname;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.PictureBox ProfilePicture;
    }
}
