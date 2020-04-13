using SocialovateDomainDTOs;
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
    public partial class Authorisation : Form
    {
        private readonly ISocialovateService _service;
        public Authorisation()
        {
            _service = SocialovateService.Instance;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            var user = _service.SignInUser(new LoginDTO()
            {
                Email = Email.Text,
                Password = Password.Text
            });

            if (user != null)
            {
                MessageBox.Show("Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Socialovate socialovateView = new Socialovate();
                socialovateView.Show();
            }
            else
            {
                MessageBox.Show("Ooooppsss.. Something went wrong. Try again!");
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            //open another form
            this.Hide();
            Registration registrationForm = new Registration();
            registrationForm.ShowDialog();
        }
    }
}
