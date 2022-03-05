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
    public partial class Form1 : Form
    {
        public Form1()
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
                MessageBox.Show("Ok, next time will we go to Main Menu of App", "Announcement" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Invalid UserName Or PassWord", "Login Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
