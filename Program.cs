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

            //Application.Run(new LoginForm());
            //Application.Run(new AddStudentForm());
            LoginForm loginForm = new LoginForm();
            if(loginForm.ShowDialog() == DialogResult.Yes)
            {
                Application.Run(new RegisterForm());
            }
            if(loginForm.ShowDialog() == DialogResult.OK)
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
