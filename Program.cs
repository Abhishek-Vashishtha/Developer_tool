using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Developer_Tools
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
            FormLogin login_form = new FormLogin();
            Form1 form1 = new Form1();

            if (Environment.UserName == "15861" && Environment.UserDomainName == "GENUSDOMAIN")
            {
                Form1.login_success = true;
            }
            else
            {
                Application.Run(login_form);
            }

            if (Form1.login_success == true)
            {
                Application.Run(form1);
            }
        }
    }
}
