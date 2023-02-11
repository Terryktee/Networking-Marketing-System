using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Management_System
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
            // Application.Run(new Form());
            // Application.Run(new Network_Management_System.Member.frm_logout());
            Application.Run(new Network_Management_System.Parent.frm_login());
            // Application.Run(new Network_Management_System.Parent.frmsignup());
            //Application.Run(new Network_Management_System.Member.frm_memberstartup());
        }
    }
}
