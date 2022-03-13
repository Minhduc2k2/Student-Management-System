using Student_Management_System;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class FirstNameForm : Form
    {
        string firstName = "";
        string lastName = "";
        public FirstNameForm()
        {
            InitializeComponent();
        }

        public FirstNameForm(string firstName)
        {
            this.firstName = firstName;
            InitializeComponent();
        }
        public FirstNameForm(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            InitializeComponent();
        }

        Student student = new Student();
        private void FirstNameForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet1.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.myDBDataSet1.student);
            SqlCommand command;
            if (lastName.Equals(""))
                command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM student WHERE fname LIKE N'%" + firstName + "%'");
            else
                command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM student WHERE fname LIKE N'%" + firstName + "%' and lname LIKE N'%" + lastName + "%'");

            DataGridView1.ReadOnly = true;
            //Processing img
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 115;
            DataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet1.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.myDBDataSet1.student);
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM student WHERE fname LIKE N'%" + firstName + "%'");
            DataGridView1.ReadOnly = true;
            //Processing img
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 115;
            DataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }

        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteStudentForm = new UpdateDeleteStudentForm();
            // Thứ tự của các cột: id - fname - lname - bd - gender - phone - address - picture
            updateDeleteStudentForm.TextBoxStudentId.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeleteStudentForm.TextBoxFname.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeleteStudentForm.TextBoxLname.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeleteStudentForm.dateTimePicker1.Value = (DateTime)DataGridView1.CurrentRow.Cells[3].Value;


            if ((DataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() == "Female"))
            {
                updateDeleteStudentForm.RadioButtonFemale.Checked = true;
            }
            else
            {
                updateDeleteStudentForm.RadioButtonMale.Checked = true;
            }
            updateDeleteStudentForm.TextBoxPhone.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDeleteStudentForm.TextBoxAddress.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;
            pic = (byte[])DataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeleteStudentForm.PictureBoxStudentImage.Image = Image.FromStream(picture);
            this.Show();
            updateDeleteStudentForm.Show();

        }
    }
}
