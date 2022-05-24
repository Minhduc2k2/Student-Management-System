using Student_Management_System;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LoginForm.Human_Resource
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }
        MY_DB myDB = new MY_DB();
        Contact contact = new Contact();
        private void ButtonAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessBarForm processBarForm = new ProcessBarForm();
                processBarForm.ShowDialog();

                int id = int.Parse(TextBoxId.Text);
                string fname = TextBoxFname.Text.Trim();
                string lname = TextBoxLname.Text.Trim();
                string group_id = comboBox1.SelectedValue.ToString();
                string phone = TextBoxPhone.Text.Trim();
                string email = TextBoxEmail.Text.Trim();
                string address = TextBoxAddress.Text.Trim();
                MemoryStream picture = new MemoryStream();
                PictureBoxStudentImage.Image.Save(picture, PictureBoxStudentImage.Image.RawFormat);
                if (contact.insertContact(id, fname, lname, group_id, phone, email, address, picture))
                {
                    MessageBox.Show("Add Contact Success", "Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Add Contact Fail", "Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id from group_pro WHERE hr_id = @hr_id", myDB.getConnection);
            command.Parameters.Add("@hr_id", SqlDbType.Int).Value = Globals.GlobalUserId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "id";
            comboBox1.ValueMember = "id";
        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*gif)|*.jpg;*.png;*gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
