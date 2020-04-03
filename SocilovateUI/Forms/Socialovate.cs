using SocialovateDomainServices.Abstraction;
using SocialovateDomainServices.Implementation;
using SocilovateUI.UCs;
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
    public partial class Socialovate : Form
    {
        private readonly ISocialovateService _service = default;
        public Socialovate()
        {
            _service = SocialovateService.Instance;
            InitializeComponent();
        }

        private void OnMouseEnterProfile(object sender, EventArgs e)
        {
            Profile.BackColor = Color.FromKnownColor(KnownColor.Black);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Adding Controls
        public void AddUC(UserControl uc)
        {
            if (!Section.Controls.Contains(uc))
            {
                Section.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            else
            {
                uc.BringToFront();
            }
        }
        #endregion

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            _service.SignOutUser();

            this.Hide(); 
        }

        private void Profile_Click_1(object sender, EventArgs e)
        {
            //AddUC(ProfileSection.Instance);
            if (!Section.Controls.Contains(ProfileSection.Instance))
            {
                Section.Controls.Add(ProfileSection.Instance);
                ProfileSection.Instance.Dock = DockStyle.Fill;
                ProfileSection.Instance.BringToFront();
            }
            else
            {
                ProfileSection.Instance.BringToFront();
            }
        }
        private void Contacts_Click_1(object sender, EventArgs e)
        {
            AddUC(ContactsSection.Instance);

        }  
           
        private void Messages_Click(object sender, EventArgs e)
        {
            AddUC(MessagesSection.Instance);
        }

        private void Section_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
