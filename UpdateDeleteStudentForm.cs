using LoginForm;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }






        bool verif()
        {
            if (TextBoxFname.Text.Trim() == "" || TextBoxLname.Text.Trim() == "" || TextBoxAddress.Text.Trim() == "" || TextBoxPhone.Text.Trim() == "" || PictureBoxStudentImage.Image == null)
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



        private void Find_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            if (radioButtonID.Checked)
            {
                int id = int.Parse(TextBoxStudentId.Text);
                SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM student WHERE id = " + id);

                DataTable table = student.getStudents(command);

                if (table.Rows.Count > 0)
                {
                    TextBoxFname.Text = table.Rows[0]["fname"].ToString();
                    TextBoxLname.Text = table.Rows[0]["lname"].ToString();
                    dateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];

                    if (table.Rows[0]["gender"].ToString() == "Female")
                    {
                        RadioButtonFemale.Checked = true;
                    }
                    else
                    {
                        RadioButtonMale.Checked = true;
                    }
                    TextBoxPhone.Text = table.Rows[0]["phone"].ToString();
                    TextBoxAddress.Text = table.Rows[0]["address"].ToString();

                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    PictureBoxStudentImage.Image = Image.FromStream(picture);


                }
                else
                {
                    MessageBox.Show("not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if(radioButtonPhone.Checked)
            {
                int phone = int.Parse(TextBoxPhone.Text);
                SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM student WHERE phone = " + phone);

                DataTable table = student.getStudents(command);

                if (table.Rows.Count > 0)
                {
                    TextBoxFname.Text = table.Rows[0]["fname"].ToString();
                    TextBoxLname.Text = table.Rows[0]["lname"].ToString();
                    dateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];

                    if (table.Rows[0]["gender"].ToString() == "Female")
                    {
                        RadioButtonFemale.Checked = true;
                    }
                    else
                    {
                        RadioButtonMale.Checked = true;
                    }
                    TextBoxPhone.Text = table.Rows[0]["phone"].ToString();
                    TextBoxAddress.Text = table.Rows[0]["address"].ToString();

                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    PictureBoxStudentImage.Image = Image.FromStream(picture);


                }
                else
                {
                    MessageBox.Show("not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (radioButtonFistName.Checked)
            {
                string firstName = TextBoxFname.Text.Trim();
                FirstNameForm firstNameForm = new FirstNameForm(firstName);
                firstNameForm.Show();
            }
            else
            {
                string firstName = TextBoxFname.Text.Trim();
                string lastName = TextBoxLname.Text.Trim();
                FirstNameForm firstNameForm = new FirstNameForm(firstName, lastName);
                firstNameForm.Show();

            }
        }
    }
}
