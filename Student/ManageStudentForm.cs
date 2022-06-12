using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class ManageStudentForm : Form
    {
        public ManageStudentForm()
        {
            InitializeComponent();
        }
        Student student = new Student();
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
        public void fillGrid(SqlCommand command)
        {
            DataGridView1.ReadOnly = true;
            //Processing img
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 115;
            DataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;

            labelTotalStudent.Text = ("Total Student: " + DataGridView1.Rows.Count);
        }
        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet1.student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.myDBDataSet1.student);

            SqlCommand command = new SqlCommand("Select * from student");
            fillGrid(command);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet1.student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.myDBDataSet1.student);

            SqlCommand command = new SqlCommand("Select * from student");
            fillGrid(command);
        }

        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //UpdateDeleteStudentForm updateDeleteStudentForm = new UpdateDeleteStudentForm();
            // Thứ tự của các cột: id - fname - lname - bd - gender - phone - address - picture
            TextBoxStudentId.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            TextBoxFname.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBoxLname.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = (DateTime)DataGridView1.CurrentRow.Cells[3].Value;


            if ((DataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() == "Female"))
            {
                RadioButtonFemale.Checked = true;
            }
            else
            {
                RadioButtonMale.Checked = true;
            }
            TextBoxPhone.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            TextBoxAddress.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;
            pic = (byte[])DataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            PictureBoxStudentImage.Image = Image.FromStream(picture);

        }
        bool verif()
        {
            if (TextBoxStudentId.Text.Trim() == "" || TextBoxFname.Text.Trim() == "" || TextBoxLname.Text.Trim() == "" || TextBoxAddress.Text.Trim() == "" || TextBoxPhone.Text.Trim() == "" || PictureBoxStudentImage.Image == null)
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
                MessageBox.Show("Image is not valid", "Manage Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            if (flag == 0)
                return true;
            return false;
        }
        private void ButtonAddStudent_Click(object sender, EventArgs e)
        {
            //Show Process Bar
            ProcessBarForm processBarForm = new ProcessBarForm();
            processBarForm.ShowDialog();
            try
            {
                if (checkRegex())
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

                    PictureBoxStudentImage.Image.Save(picture, PictureBoxStudentImage.Image.RawFormat);
                    if (student.insertStudent(id, fname, lname, bdate, gender, phone, address, picture))
                    {
                        MessageBox.Show("New Student Added", "Manage Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error", "Manage Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Manage Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ButtonEditStudent_Click(object sender, EventArgs e)
        {

            try
            {
                if (checkRegex())
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

                    PictureBoxStudentImage.Image.Save(picture, PictureBoxStudentImage.Image.RawFormat);
                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, address, picture))
                    {
                        MessageBox.Show("Student Edited", "Manage Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error", "Manage Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Manage Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        textBoxNotiStudentID.Text = "";
                        textBoxNotiFName.Text = "";
                        textBoxNotiLName.Text = "";
                        textBoxNotiBirthday.Text = "";
                        textBoxNotiPhone.Text = "";
                        textBoxNotiAddress.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
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
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from student where CONCAT(fname, lname, address) LIKE N'%" + textBoxFind.Text + "%'");
            fillGrid(command);
        }

        private void ButtonDownloadImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + TextBoxStudentId.Text);
            if ((PictureBoxStudentImage.Image == null))
            {
                MessageBox.Show("No image in the picturebox");
            }
            else if (svf.ShowDialog() == DialogResult.OK)
            {
                PictureBoxStudentImage.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }

        }
    }
}
