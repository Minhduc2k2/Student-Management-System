using Student_Management_System;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LoginForm.Human_Resource
{
    public partial class EditContactForm : Form
    {
        public EditContactForm()
        {
            InitializeComponent();
        }
        MY_DB myDB = new MY_DB();
        Contact contact = new Contact();

        private void EditContactForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id from contact WHERE hr_id = @hr_id", myDB.getConnection);
            command.Parameters.Add("@hr_id", SqlDbType.Int).Value = Globals.GlobalUserId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBoxID.DataSource = table;
            comboBoxID.DisplayMember = "id";
            comboBoxID.ValueMember = "id";

            command = new SqlCommand("SELECT id from group_pro WHERE hr_id = @hr_id", myDB.getConnection); 
            command.Parameters.Add("@hr_id", SqlDbType.Int).Value = Globals.GlobalUserId;
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            comboBoxGroup.DataSource = table;
            comboBoxGroup.DisplayMember = "id";
            comboBoxGroup.ValueMember = "id";
        }

        private void comboBoxID_Leave(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * from contact WHERE id = @id", myDB.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(comboBoxID.SelectedValue.ToString());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                TextBoxFname.Text = table.Rows[0]["fname"].ToString();
                TextBoxLname.Text = table.Rows[0]["lname"].ToString();
                MessageBox.Show(table.Rows[0]["group_id"].ToString());
                comboBoxGroup.SelectedValue = table.Rows[0]["group_id"].ToString();
                TextBoxPhone.Text = table.Rows[0]["phone"].ToString();
                TextBoxEmail.Text = table.Rows[0]["email"].ToString();
                TextBoxAddress.Text = table.Rows[0]["address"].ToString();
                byte[] pic = (byte[])table.Rows[0]["pic"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxContactImage.Image = Image.FromStream(picture);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessBarForm processBarForm = new ProcessBarForm();
                processBarForm.ShowDialog();

                int id = int.Parse(comboBoxID.SelectedValue.ToString());
                string fname = TextBoxFname.Text.Trim();
                string lname = TextBoxLname.Text.Trim();
                string group_id = comboBoxGroup.SelectedValue.ToString();
                string phone = TextBoxPhone.Text.Trim();
                string email = TextBoxEmail.Text.Trim();
                string address = TextBoxAddress.Text.Trim();
                MemoryStream picture = new MemoryStream();
                PictureBoxContactImage.Image.Save(picture, PictureBoxContactImage.Image.RawFormat);
                if (contact.updateContact(id, fname, lname, group_id, phone, email, address, picture))
                {
                    MessageBox.Show("Edit Contact Success", "Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Edit Contact Fail", "Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*gif)|*.jpg;*.png;*gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxContactImage.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
