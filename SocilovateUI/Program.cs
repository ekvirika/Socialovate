using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocilovateUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new Authorisation());
        }
    }
}


// lightpink rgb(244,162,168)
// !slategray rgb(119,139,138)
// dimgray rgb(92,114,101)
// dakgrey rgb(140,156,182)

// !indianred rgb(213,92,84)
// !slategray rgb(119,139,138)
