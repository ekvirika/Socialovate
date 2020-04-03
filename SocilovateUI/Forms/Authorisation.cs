using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SocialovateDomainDTOs;
using SocialovateDomainModels.Abstraction;
using SocialovateDomainServices;
using SocialovateDomainServices.Abstraction;
using SocialovateDomainServices.Implementation;

namespace SocilovateUI
{
    public partial class Authorisation : Form
    {
        private readonly ISocialovateService _service;
        public Authorisation()
        {
            _service = SocialovateService.Instance;
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            //open another form
            this.Hide();
            Registration registrationForm = new Registration();
            registrationForm.ShowDialog();
        }



        private void SingInBtn_Click(object sender, EventArgs e)
        {
            // TODO add ?authentication Logic here

            var user = _service.SignInUser(new LoginDTO()
            {
                Email = email.Text,
                Password = password.Text
            });

            if (user != null)
            {
                MessageBox.Show("Success");
                this.Hide();
                Socialovate socialovateView = new Socialovate();
                socialovateView.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ooooppsss.. Something went wrong. Try again!");
            }

            //open another form
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
