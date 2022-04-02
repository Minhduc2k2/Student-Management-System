using LoginForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
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

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            //if (loginForm.DialogResult ==  DialogResult.Yes)
            //{
            //    Application.Run(new RegisterForm());
            //    loginForm.ShowDialog();
            //}
            if (loginForm.DialogResult == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
            else
            {
                Application.Exit();
            }

        }
    }
}
