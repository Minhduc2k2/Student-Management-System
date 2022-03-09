using LoginForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }




        private void ButtonCancel_Click(object sender, EventArgs e)
        {
           Close();   
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
            if((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void ButtonAddStudent_Click(object sender, EventArgs e)
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
            else if(verif())
            {
                PictureBoxStudentImage.Image.Save(picture, PictureBoxStudentImage.Image.RawFormat);
                if (student.insertStudent(id, fname, lname, bdate, gender, phone, address, picture))
                {
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


    }
}
