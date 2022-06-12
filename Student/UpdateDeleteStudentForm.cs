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
    public partial class UpdateDeleteStudentForm : Form
    {
        //Regex
        //VIETNAM Phone number
        string phoneRegex = @"^(84|0[2|3|5|7|8|9])+([0-9]{8})\b$";

        //Email
        //địa chỉ email phải bắt đầu bằng 1 ký tự
        //địa chỉ email là tập hợp của các ký tự a-z, 0 - 9 và có thể có các ký tự như dấu chấm, dấu gạch dưới
        //độ dài tối thiểu của email là 5, độ dài tối đa là 32
        //tên miền của email có thể là tên miền cấp 1 or tên miền cấp 2
        //string emailRegex = @"^[a-z][a-z0-9_\.]{5,32}@[a-z0-9]{2,}(\.[a-z0-9]{2,4}){1,2}$";

        //Name
        //Chữ cái đầu tiên phải viết hoa
        string nameRegex = @"^[A-ZÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ][a-zàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđ]*(?:[ ][A-ZÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ][a-zàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđ]*)*$";

        string idRegex = @"^[0-9]*$";

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
            //Show Progress Bar
            ProcessBarForm processBarForm = new ProcessBarForm();
            processBarForm.ShowDialog();

            Student student = new Student();

            if (comboBox1.Text == "ID")
            {
                int id = int.Parse(TextBoxStudentId.Text.Trim());
                SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM student WHERE id = " + id);

                DataTable table = student.getStudents(command);

                if (table.Rows.Count > 0)
                {
                    TextBoxFname.Text = table.Rows[0]["fname"].ToString().Trim();
                    TextBoxLname.Text = table.Rows[0]["lname"].ToString().Trim();
                    dateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];

                    if (table.Rows[0]["gender"].ToString() == "Female")
                    {
                        RadioButtonFemale.Checked = true;
                    }
                    else
                    {
                        RadioButtonMale.Checked = true;
                    }
                    TextBoxPhone.Text = table.Rows[0]["phone"].ToString().Trim();
                    TextBoxAddress.Text = table.Rows[0]["address"].ToString().Trim();

                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    PictureBoxStudentImage.Image = Image.FromStream(picture);
                }
                else
                {
                    MessageBox.Show("Not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (comboBox1.Text == "Phone")
            {
                int phone = int.Parse(TextBoxPhone.Text.Trim());
                SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM student WHERE phone = " + phone);

                DataTable table = student.getStudents(command);

                if (table.Rows.Count > 0)
                {
                    TextBoxFname.Text = table.Rows[0]["fname"].ToString().Trim();
                    TextBoxLname.Text = table.Rows[0]["lname"].ToString().Trim();
                    dateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];

                    if (table.Rows[0]["gender"].ToString() == "Female")
                    {
                        RadioButtonFemale.Checked = true;
                    }
                    else
                    {
                        RadioButtonMale.Checked = true;
                    }
                    TextBoxPhone.Text = table.Rows[0]["phone"].ToString().Trim();
                    TextBoxAddress.Text = table.Rows[0]["address"].ToString().Trim();

                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    PictureBoxStudentImage.Image = Image.FromStream(picture);
                }
                else
                {
                    MessageBox.Show("Not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (comboBox1.Text == "FirstName")
            {
                string firstName = TextBoxFname.Text.Trim();
                FirstNameForm firstNameForm = new FirstNameForm(firstName);
                firstNameForm.Show();
            }
            else if (comboBox1.Text == "Name")
            {
                string firstName = TextBoxFname.Text.Trim().Trim();
                string lastName = TextBoxLname.Text.Trim().Trim();
                FirstNameForm firstNameForm = new FirstNameForm(firstName, lastName);
                firstNameForm.Show();
            }
            else
            {
                MessageBox.Show("Choose value, please!", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool checkRegex()
        {
            int flag = 0;
            if (TextBoxStudentId.Text == "" || !Regex.IsMatch(TextBoxStudentId.Text, idRegex))
            {
                textBoxNotiStudentID.Text = "ID is invalid";
                flag = 1;
            }
            if (!Regex.IsMatch(TextBoxFname.Text, nameRegex))
            {
                textBoxNotiFName.Text = "First Name is invalid";
                flag = 1;
            }
            if (!Regex.IsMatch(TextBoxLname.Text, nameRegex))
            {
                textBoxNotiLName.Text = "Last Name is invalid";
                flag = 1;
            }
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                textBoxNotiBirthday.Text = "The Student age must be beetween 10 and 100";
            }
            if (!Regex.IsMatch(TextBoxPhone.Text, phoneRegex))
            {
                textBoxNotiPhone.Text = "Phone Number is invalid";
                flag = 1;
            }
            if (TextBoxAddress.Text.Equals(""))
            {
                textBoxNotiAddress.Text = "Address is empty";
                flag = 1;
            }
            if (PictureBoxStudentImage.Image == null)
            {
                MessageBox.Show("Image is not valid", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            if (flag == 0)
                return true;
            return false;
        }
        private void ButtonEditStudent_Click(object sender, EventArgs e)
        {

            try
            {
                if (checkRegex())
                {
                    Student student = new Student();
                    int id = Convert.ToInt32(TextBoxStudentId.Text.Trim());
                    string fname = TextBoxFname.Text.Trim();
                    string lname = TextBoxLname.Text.Trim();
                    DateTime bdate = dateTimePicker1.Value;
                    string phone = TextBoxPhone.Text.Trim();
                    string address = TextBoxAddress.Text.Trim();
                    string gender;
                    if (RadioButtonMale.Checked)
                        gender = "Male";
                    else
                        gender = "FeMale";
                    MemoryStream picture = new MemoryStream();
                    int born_year = dateTimePicker1.Value.Year;
                    int this_year = DateTime.Now.Year;

                    PictureBoxStudentImage.Image.Save(picture, PictureBoxStudentImage.Image.RawFormat);
                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, address, picture))
                    {
                        MessageBox.Show("Student Edited", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void TextBoxFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxNotiFName.Text = "";
        }

        private void TextBoxLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxNotiLName.Text = "";
        }
        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxNotiBirthday.Text = "";
        }

        private void TextBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxNotiPhone.Text = "";
        }

        private void TextBoxStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxNotiStudentID.Text = "";
        }

        private void TextBoxAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxNotiAddress.Text = "";
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
                        textBoxNotiStudentID.Text = "";
                        textBoxNotiFName.Text = "";
                        textBoxNotiLName.Text = "";
                        textBoxNotiBirthday.Text = "";
                        textBoxNotiPhone.Text = "";
                        textBoxNotiAddress.Text = "";
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonAddCourse_Click_1(object sender, EventArgs e)
        {
            AddSemesterForm addSemesterForm = new AddSemesterForm(TextBoxStudentId.Text);
            addSemesterForm.Show(this);
        }
    }
}
