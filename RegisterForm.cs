using RegisterForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            User user = new User();
            string username = TextBoxUserName.Text;
            string password = TextBoxPassword.Text;
            string repassword = TextBoxRePassword.Text;

            if(verif() == 1)
            {
                if(user.insertUser(username, password))
                {
                    MessageBox.Show("New User Added", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Error", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(verif() == 2)
            {
                MessageBox.Show("Password and Re-Password is not equal", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if(verif() == 3)
            {
                MessageBox.Show("UserName already exists", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //Check if UserName already exists
        bool existUsername()
        {
            MY_DB db = new MY_DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username = @User", db.getConnection);

            command.Parameters.Add("@User ", SqlDbType.VarChar).Value = TextBoxUserName.Text;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        int verif()
        {
            //Check if Empty Fields
            if (TextBoxUserName.Text.Trim() == "" || TextBoxPassword.Text.Trim() == "" ||TextBoxRePassword.Text.Trim() == "")
                return 0;
            //Check if Password and Re-Password is not equal
            if (!TextBoxPassword.Text.Equals(TextBoxRePassword.Text))
                return 2;
            //Check if UserName already exists
            if (existUsername())
                return 3;
            //Success
            else
                return 1;
        }    
    }
}
