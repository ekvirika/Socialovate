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
    public partial class UserProfile : UserControl
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            //get User
            var user = LoginHelperService.GetCurrentUser();

            //
/*            Username.Text = user.Username;
            Email.Text = user.User.Email;
            Age.Text = user.User.Age.ToString();
            Fullname.Text = $"{user.User.Name} {user.User.Surname}";
            ProfilePicture.Load(user.ImageUrl);*/
        }
    }
}
