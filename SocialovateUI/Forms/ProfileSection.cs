﻿using SocialovateDomainServices.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialovateUI.Forms
{
    public partial class ProfileSection : Form
    {
        public ProfileSection()
        {
            InitializeComponent();
        }

        private void ProfileSec_Load(object sender, EventArgs e)
        {
            //get User
            var user = LoginHelperService.GetCurrentUser();

            // add texts to fields
            //ProfilePic.Load(user.ImageUrl);
            ProfilePic.ImageLocation = user.ImageUrl;
            Nameuser.Text = $"{user.User.Name} {user.User.Surname}";
            Username.Text = user.Username;
            Email.Text = user.User.Email;
            Age.Text = $"{user.User.Age.ToString()} Years Old";
        }
    }
}
