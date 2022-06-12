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
            //this.studentTableAdapter.Fill(this.myDBDataSet1.student);

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
            DataGridView1.Columns[0].HeaderText = "ID";
            DataGridView1.Columns[1].HeaderText = "First Name";
            DataGridView1.Columns[2].HeaderText = "Last Name";
            DataGridView1.Columns[3].HeaderText = "Birth Day";
            DataGridView1.Columns[4].HeaderText = "Gender";
            DataGridView1.Columns[5].HeaderText = "Phone";
            DataGridView1.Columns[6].HeaderText = "Address";
            DataGridView1.Columns[7].HeaderText = "Picture";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet1.student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.myDBDataSet1.student);
            
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
            DataGridView1.Columns[0].HeaderText = "ID";
            DataGridView1.Columns[1].HeaderText = "First Name";
            DataGridView1.Columns[2].HeaderText = "Last Name";
            DataGridView1.Columns[3].HeaderText = "Birth Day";
            DataGridView1.Columns[4].HeaderText = "Gender";
            DataGridView1.Columns[5].HeaderText = "Phone";
            DataGridView1.Columns[6].HeaderText = "Address";
            DataGridView1.Columns[7].HeaderText = "Avatar";
        }

    }
}
