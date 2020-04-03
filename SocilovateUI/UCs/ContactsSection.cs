using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocilovateUI.UCs
{
    public partial class ContactsSection : UserControl
    {
        private static ContactsSection _instance;
        public static ContactsSection Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ContactsSection();
                return _instance;
            }
        }
        public ContactsSection()
        {
            InitializeComponent();
        }
    }
}
