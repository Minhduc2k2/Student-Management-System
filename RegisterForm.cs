﻿using RegisterForm;
using System;
using System.Data;
using System.Data.SqlClient;
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
            //Tạo đối tượng user
            User user = new User();
            string username = TextBoxUserName.Text;
            string password = TextBoxPassword.Text;
            string repassword = TextBoxRePassword.Text;

            if (verif() == 1)
            {
                //Gọi hàm insertUser
                if (user.insertUser(username, password))
                {
                    MessageBox.Show("New User Added", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (verif() == 2)
            {
                //MessageBox.Show("Password and Re-Password is not equal", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxNotiRePassword.Text = "Password and Re-Password is not equal";
            }
            else if (verif() == 3)
            {
                //MessageBox.Show("UserName already exists", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxNotiUserName.Text = "UserName already exists";
            }
            else
            {
                //MessageBox.Show("Empty Fields", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (TextBoxUserName.Text.Trim() == "")
                    textBoxNotiUserName.Text = "UserName must be filled";
                if (TextBoxPassword.Text.Trim() == "")
                    textBoxNotiPassword.Text = "Password must be filled";
                if (TextBoxRePassword.Text.Trim() == "")
                    textBoxNotiRePassword.Text = "Re-Password must be filled";
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
            if (TextBoxUserName.Text.Trim() == "" || TextBoxPassword.Text.Trim() == "" || TextBoxRePassword.Text.Trim() == "")
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

        private void TextBoxUserName_Leave(object sender, EventArgs e)
        {
            if (existUsername())
                //MessageBox.Show("UserName already exists", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxNotiUserName.Text = "UserName already exists";

        }

        private void TextBoxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxNotiUserName.Text = "";
        }

        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxNotiPassword.Text = "";
        }

        private void TextBoxRePassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxNotiRePassword.Text = "";
        }
    }
}
