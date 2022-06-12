using LoginForm;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class AddHRForm : Form
    {
        public AddHRForm()
        {
            InitializeComponent();
        }
        Email email = new Email();
        string emailRegex = @"^[a-z][a-z0-9_\.]{5,32}@[a-z0-9]{2,}(\.[a-z0-9]{2,4}){1,2}$";
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            //Show Process Bar
            ProcessBarForm processBarForm = new ProcessBarForm();
            processBarForm.ShowDialog();

            Close();
        }

        bool verif()
        {
            if (TextBoxId.Text.Trim() == "" || TextBoxFname.Text.Trim() == "" || TextBoxLname.Text.Trim() == "" || TextBoxPassword.Text.Trim() == "" || TextBoxUserName.Text.Trim() == "" || PictureBoxStudentImage.Image == null || TextBoxEmail.Text.Trim() == "")
                return false;
            else
                return true;
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
        bool existUsername()
        {
            MY_DB db = new MY_DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM hr WHERE uname = @uname", db.getConnection);

            command.Parameters.Add("@uname ", SqlDbType.NVarChar).Value = TextBoxUserName.Text;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        bool existID()
        {
            MY_DB db = new MY_DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM hr WHERE id = @id", db.getConnection);

            command.Parameters.Add("@id ", SqlDbType.Int).Value = int.Parse(TextBoxId.Text);

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        private void ButtonAddStudent_Click(object sender, EventArgs e)
        {
            if (!verif())
            {
                MessageBox.Show("Empty Field", "Add HumanResourse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(!int.TryParse(TextBoxId.Text.Trim(),out int _))
            {
                MessageBox.Show("ID must be a number", "Add HumanResourse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(!Regex.IsMatch(TextBoxEmail.Text, emailRegex))
            {
                MessageBox.Show("Email is InValid", "Add HumanResourse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                HumanResource humanResource = new HumanResource();
                int id = int.Parse(TextBoxId.Text.Trim());
                string f_name = TextBoxFname.Text.Trim();
                string l_name = TextBoxLname.Text.Trim();
                string uname = TextBoxUserName.Text.Trim();
                string pwd = TextBoxPassword.Text.Trim();
                MemoryStream picture = new MemoryStream();
                PictureBoxStudentImage.Image.Save(picture, PictureBoxStudentImage.Image.RawFormat);

                if (existUsername())
                {
                    MessageBox.Show("New HumanResourse username already exist", "Add HumanResourse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (existID())
                {
                    MessageBox.Show("New HumanResourse ID already exist", "Add HumanResourse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (humanResource.insertUser(id, f_name, l_name, uname, pwd, picture))
                {
                    email.insertEmail(uname, TextBoxEmail.Text.Trim());
                    MessageBox.Show("New HumanResourse Added", "Add HumanResourse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("New HumanResourse Error", "Add HumanResourse", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add HumanResourse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
