namespace SocialovateUI.Forms
{
    partial class ContactsSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsSection));
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.TextBox();
            this.SearchNew = new System.Windows.Forms.Button();
            this.SearchExisting = new System.Windows.Forms.Button();
            this.ShowMyContacts = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddUser)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(114)))), ((int)(((byte)(101)))));
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(12, 82);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(492, 334);
            this.DataGrid.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Search.Location = new System.Drawing.Point(12, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(206, 26);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search by Username...";
            this.Search.Enter += new System.EventHandler(this.Search_Enter);
            // 
            // SearchNew
            // 
            this.SearchNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.SearchNew.FlatAppearance.BorderSize = 0;
            this.SearchNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchNew.Font = new System.Drawing.Font("SF Pro Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchNew.ForeColor = System.Drawing.Color.White;
            this.SearchNew.Location = new System.Drawing.Point(153, 44);
            this.SearchNew.Name = "SearchNew";
            this.SearchNew.Size = new System.Drawing.Size(141, 32);
            this.SearchNew.TabIndex = 8;
            this.SearchNew.Text = "Search for new Contacts";
            this.SearchNew.UseVisualStyleBackColor = false;
            this.SearchNew.Click += new System.EventHandler(this.SearchNew_Click);
            // 
            // SearchExisting
            // 
            this.SearchExisting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.SearchExisting.FlatAppearance.BorderSize = 0;
            this.SearchExisting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchExisting.Font = new System.Drawing.Font("SF Pro Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchExisting.ForeColor = System.Drawing.Color.White;
            this.SearchExisting.Location = new System.Drawing.Point(12, 44);
            this.SearchExisting.Name = "SearchExisting";
            this.SearchExisting.Size = new System.Drawing.Size(135, 32);
            this.SearchExisting.TabIndex = 8;
            this.SearchExisting.Text = "Search in my Contacts";
            this.SearchExisting.UseVisualStyleBackColor = false;
            this.SearchExisting.Click += new System.EventHandler(this.SearchExisting_Click);
            // 
            // ShowMyContacts
            // 
            this.ShowMyContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
            this.ShowMyContacts.FlatAppearance.BorderSize = 0;
            this.ShowMyContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowMyContacts.Font = new System.Drawing.Font("SF Pro Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowMyContacts.ForeColor = System.Drawing.Color.White;
            this.ShowMyContacts.Location = new System.Drawing.Point(300, 44);
            this.ShowMyContacts.Name = "ShowMyContacts";
            this.ShowMyContacts.Size = new System.Drawing.Size(141, 32);
            this.ShowMyContacts.TabIndex = 8;
            this.ShowMyContacts.Text = "ShowMyContacts";
            this.ShowMyContacts.UseVisualStyleBackColor = false;
            this.ShowMyContacts.Click += new System.EventHandler(this.ShowMyContacts_Click);
            // 
            // AddUser
            // 
            this.AddUser.Image = ((System.Drawing.Image)(resources.GetObject("AddUser.Image")));
            this.AddUser.Location = new System.Drawing.Point(447, 50);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(25, 26);
            this.AddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddUser.TabIndex = 9;
            this.AddUser.TabStop = false;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // ContactsSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(608, 428);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.SearchExisting);
            this.Controls.Add(this.ShowMyContacts);
            this.Controls.Add(this.SearchNew);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.DataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContactsSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.ContactsSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button SearchNew;
        private System.Windows.Forms.Button SearchExisting;
        private System.Windows.Forms.Button ShowMyContacts;
        private System.Windows.Forms.PictureBox AddUser;
    }
}