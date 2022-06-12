using Student_Management_System;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LoginForm.Human_Resource
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        MY_DB myDB = new MY_DB();
        public void getImageAndUserName()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * from hr WHERE id = @id", myDB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Globals.GlobalUserId;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0]["fig"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);
                labelUsername.Text = "Welcome back " + table.Rows[0]["uname"].ToString() + "\nID:"+ table.Rows[0]["id"].ToString();
            }

        }

        private void ButtonAddContact_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm();
            addContactForm.ShowDialog();
        }

        private void buttonEditContact_Click(object sender, EventArgs e)
        {
            EditContactForm editContactForm = new EditContactForm();
            editContactForm.ShowDialog();
        }
        bool check_IsExist()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM group_pro WHERE id = @id AND hr_id = @hr_id", myDB.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = textBoxEnterGroupName.Text.Trim();
            command.Parameters.Add("@hr_id", SqlDbType.Int).Value = Globals.GlobalUserId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Name has already exist","Contact Form",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_IsExist())
                    return;
                myDB.openConnection();
                SqlCommand command = new SqlCommand("INSERT INTO group_pro(id,hr_id) " + "VALUES(@id,@hr_id)", myDB.getConnection);
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = textBoxEnterGroupName.Text.Trim();
                command.Parameters.Add("@hr_id", SqlDbType.Int).Value = Globals.GlobalUserId;
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Add Group Success", "Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Add Group Fail", "Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEditGroup_Click(object sender, EventArgs e)
        {
            try
            {
                myDB.openConnection();
                SqlCommand command = new SqlCommand("UPDATE group_pro SET id = @idnew WHERE id = @idold", myDB.getConnection);
                command.Parameters.Add("@idold", SqlDbType.NVarChar).Value = comboBoxSelectedGroup1.SelectedValue.ToString();
                command.Parameters.Add("@idnew", SqlDbType.NVarChar).Value = textBoxEnterNewName.Text.Trim();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Edit Group Success", "Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Edit Group Fail", "Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            getImageAndUserName();
            SqlCommand command = new SqlCommand("SELECT id from group_pro", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBoxSelectedGroup1.DataSource = table;
            comboBoxSelectedGroup1.DisplayMember = "id";
            comboBoxSelectedGroup1.ValueMember = "id";
            comboBoxSelectedGroup2.DataSource = table;
            comboBoxSelectedGroup2.DisplayMember = "id";
            comboBoxSelectedGroup2.ValueMember = "id";

            command = new SqlCommand("SELECT id from contact WHERE hr_id = @hr_id", myDB.getConnection);
            command.Parameters.Add("@hr_id", SqlDbType.Int).Value = Globals.GlobalUserId;
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            comboBoxID.DataSource = table;
            comboBoxID.DisplayMember = "id";
            comboBoxID.ValueMember = "id";
        }

        private void buttonRemoveGroup_Click(object sender, EventArgs e)
        {

            try
            {
                myDB.openConnection();
                SqlCommand command = new SqlCommand("DELETE FROM group_pro WHERE id = @id", myDB.getConnection);
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = comboBoxSelectedGroup2.SelectedValue.ToString();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Delete Group Success", "Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete Group Fail", "Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveContact_Click(object sender, EventArgs e)
        {
            try
            {
                myDB.openConnection();
                SqlCommand command = new SqlCommand("DELETE FROM contact WHERE id = @id", myDB.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = comboBoxID.SelectedValue.ToString();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Delete Contact Success", "Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete Contact Fail", "Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonShowFullList_Click(object sender, EventArgs e)
        {
            FullContact fullContact = new FullContact();
            fullContact.ShowDialog();
        }
    }
}
