using SocialovateDomainDTOs;
using SocialovateDomainModels.Abstraction;
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
    public partial class ContactsSection : Form
    {
        private readonly IContactService _contactService;
        private readonly List<ContactDTO> _userContacts;
        public readonly IAccount _currentUser;

        public ContactsSection()
        {
            InitializeComponent();

            _currentUser = LoginHelperService.GetCurrentUser();
            _contactService = new ContactService()
            {
                AddContactDel = SocialovateService.Instance.AddUserContact,
                GetAllContactsDel = SocialovateService.Instance.GetAllUserContacts,
                FilterContactsByUsernameDel = SocialovateService.Instance.SearchUserContactByUsername,
                SearchInAllAcountsDel = SocialovateService.Instance.SearchForContactInDB

            };

            _userContacts = _contactService.GetUserContacts(_currentUser);
        }

        private void ContactsSection_Load(object sender, EventArgs e)
        {

            ShowUserContacts();
        }

        private void Search_Enter(object sender, EventArgs e)
        {
            if (Search.Text == "Search by Username...")
            {
                Search.Text = "";
                Search.ForeColor = Color.FromArgb(0, 213, 92, 84);
            }
        }

        private void SearchNew_Click(object sender, EventArgs e)
        {
            var contact = _contactService.SearchInAllAccounts(Search.Text);
            List<ContactDTO> cons = new List<ContactDTO>() { contact };
            //DataGrid.Rows.Add(contact.Name, contact.Surname, contact.Email, contact.Username);
            DataGrid.DataSource = cons;

            //int rowId = DataGrid.Rows.Add();

            //// Grab the new row!
            //DataGridViewRow row = DataGrid.Rows[rowId];

            //// Add the data
            //row.Cells["Column1"].Value = contact.Name;
            //row.Cells["Column2"].Value = contact.Surname;
        }

        private void ShowUserContacts()
        {
            DataGrid.DataSource = _userContacts;
        }

        private void SearchExisting_Click(object sender, EventArgs e)
        {
            var contacts = _contactService.FilterByUsername(Search.Text);
            DataGrid.DataSource = contacts;
        }

        private void ShowMyContacts_Click(object sender, EventArgs e)
        {
            ShowUserContacts();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            _contactService.AddUserContact(_currentUser, DataGrid.Rows.Cast<ContactDTO>().First());
        }
    }
}
