using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SocialovateDomainServices.Implementation;

namespace SocilovateUI.UCs
{
    public partial class ProfileSection : UserControl
    {
        private static ProfileSection _instance;
        public static ProfileSection Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProfileSection();
                return _instance;
            }
        }

        public ProfileSection()
        {
            InitializeComponent();
        }

        private void ProfileSection_Load(object sender, EventArgs e)
        {
            //get User
            var user = LoginHelperService.GetCurrentUser();

            // add texts into fields
            Username.Text = user.Username;
            Email.Text = user.User.Email;
            Age.Text = user.User.Age.ToString();
        }
    }
}
