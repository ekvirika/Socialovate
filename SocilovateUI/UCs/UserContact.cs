using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocilovateUI
{
    public partial class UserContact : UserControl
    {
        public UserContact()
        {
            InitializeComponent();
        }

        public Image ProfileImage { 
            get { return pictureBox1.Image;  }
            set { pictureBox1.Image = value; }
        }

        public string ContactFullName
        {
            get { return FullName.Text; }
            set {FullName.Text = value; }
        }

        public string ContactEmail
        {
            get { return Email.Text; }
            set { Email.Text = value; }
        }


    }
}
