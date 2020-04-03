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
    public partial class MessagesSection : UserControl
    {
        private static MessagesSection _instance;
        public static MessagesSection Instance { 
            get
            {
                if (_instance == null)
                    _instance = new MessagesSection();
                return _instance;
            } 
        }
        public MessagesSection()
        {
            InitializeComponent();
        }
    }
}
