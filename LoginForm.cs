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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username = @User AND password = @Pass", db.getConnection);

            command.Parameters.Add("@User ", SqlDbType.VarChar).Value = TextBoxUserName.Text;
            command.Parameters.Add("@Pass ", SqlDbType.VarChar).Value = TextBoxPassword.Text;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                //MessageBox.Show("Ok, next time will we go to Main Menu of App", "Announcement" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Invalid UserName Or PassWord", "Login Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void TextBoxUserName_Enter(object sender, EventArgs e)
        {
            if (TextBoxUserName.Text == "UserName")
            {
                TextBoxUserName.Text = "";
            }
        }

        private void TextBoxUserName_Leave(object sender, EventArgs e)
        {
            if (TextBoxUserName.Text == "")
            {
                TextBoxUserName.Text = "UserName";
            }
        }

        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == "Password")
            {
                TextBoxPassword.Text = "";
                TextBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == "")
            {
                TextBoxPassword.Text = "Password";
                TextBoxPassword.UseSystemPasswordChar = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}
