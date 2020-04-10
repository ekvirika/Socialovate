using SocialovateDomainModels.Implementation;
using SocialovateDomainServices.Abstraction;
using SocialovateDomainServices.Implementation;
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
    public partial class Registration : Form
    {
        private readonly ISocialovateService _service;

        public Registration()
        {
            _service = SocialovateService.Instance;
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            _service.RegisterNewUser(new Account()
            {
                Username = UsernameInp.Text,
                Password = PasswordInp.Text,
                ImageUrl = ImageUrl.Text,
                User = new User()
                {
                    Name = NameInp.Text,
                    Surname = SurnameInp.Text,
                    Age = Convert.ToInt32(AgeInp.Text),
                    Email = EmailInp.Text
                }
            });

            MessageBox.Show($"User {UsernameInp.Text} {SurnameInp.Text} successfully registered!");

            //open new Dialog
            this.Hide();
            Authorisation mainView = new Authorisation();
            mainView.ShowDialog();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
