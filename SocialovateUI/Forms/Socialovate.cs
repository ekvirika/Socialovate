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
    public partial class Socialovate : Form
    {
        private readonly ISocialovateService _service = default;
        public Socialovate()
        {
            _service = SocialovateService.Instance;
            InitializeComponent();
        }

        private void OnMouseEnterProfileSec(object sender, EventArgs e)
        {
            Profile.BackColor = Color.FromKnownColor(KnownColor.Black);
            SidePanel.Height = this.Height;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            ProfileSection profileSection = new ProfileSection();
            profileSection.TopLevel = false;
            MainSection.Controls.Add(profileSection);
            profileSection.Dock = DockStyle.Fill;
            profileSection.BringToFront();
            profileSection.Show();
        }

        private void ContactsSec_Click(object sender, EventArgs e)
        {
            ContactsSection contactsSection = new ContactsSection();
            contactsSection.TopLevel = false;
            MainSection.Controls.Add(contactsSection);
            contactsSection.Dock = DockStyle.Fill;
            contactsSection.BringToFront();
            contactsSection.Show();
        }
    }
}
