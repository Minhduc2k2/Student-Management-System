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
            ProcessBarForm processBarForm = new ProcessBarForm();
            processBarForm.ShowDialog();

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
            else if (radioButtonPhone.Checked)
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

        private void ButtonEditStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            int id = Convert.ToInt32(TextBoxStudentId.Text);
            string fname = TextBoxFname.Text;
            string lname = TextBoxLname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = TextBoxPhone.Text;
            string address = TextBoxAddress.Text;
            string gender;
            if (RadioButtonMale.Checked)
                gender = "Male";
            else
                gender = "FeMale";
            MemoryStream picture = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
                MessageBox.Show("The Student age must be beetween 10 and 100", "Invalid Birthday Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (verif())
            {
                try
                {
                    PictureBoxStudentImage.Image.Save(picture, PictureBoxStudentImage.Image.RawFormat);
                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, address, picture))
                    {
                        MessageBox.Show("Student Edited", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ButtonRemoveStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            try
            {
                int id = Convert.ToInt32(TextBoxStudentId.Text);
                //Display a comfirmation message before the delete
                if ((MessageBox.Show("Are You Sure You Want To Delete This Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (student.deleteStudent(id))
                    {
                        MessageBox.Show("Student Deleted", "Deleted Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Clear Fields after delete
                        TextBoxStudentId.Text = "";
                        TextBoxFname.Text = "";
                        TextBoxLname.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        TextBoxPhone.Text = "";
                        TextBoxAddress.Text = "";
                        PictureBoxStudentImage.Image = null;
                        RadioButtonMale.Checked = true;

                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
