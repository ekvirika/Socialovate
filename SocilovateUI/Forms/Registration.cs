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

namespace SocilovateUI
{
    public partial class Registration : Form
    {
        private readonly ISocialovateService _service;

        public Registration()
        {
            _service = SocialovateService.Instance;
            InitializeComponent();
        }

        private void SubmitForm_Click(object sender, EventArgs e)
        {
            //register user
            _service.RegisterNewUser(new Account()
            {
                Username = Nickname.Text,
                Password = Password.Text,
                User = new User()
                {
                    Name = UserName.Text,
                    Surname = Surname.Text,
                    Age = Convert.ToInt32(Age.Text),
                    Image = ImageUrl.Text,
                    Email = Email.Text
                }
            });

            MessageBox.Show($"User {UserName.Text} {Surname.Text} successfully registered!");

            //open new Dialog
            this.Hide();
            Authorisation mainView = new Authorisation();
            mainView.ShowDialog();


        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
