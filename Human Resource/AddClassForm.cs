using LoginForm.Human_Resource;
using Student_Management_System;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class AddClassForm : Form
    {
        public AddClassForm()
        {
            InitializeComponent();
        }
        public AddClassForm(string id)
        {
            InitializeComponent();
            TextBoxContactId.Text = id;
        }
        Course course = new Course();
        Score score = new Score();
        MyClass myClass = new MyClass();
        DataTable tableAvailableCourse;
        DataTable tableSelectedCourse;
        MY_DB myDB = new MY_DB();
        private void AddClassForm_Load(object sender, EventArgs e)
        {
            this.tableAvailableCourse = course.getAllCourses();
            listBoxAvailableCourse.DataSource = tableAvailableCourse;
            listBoxAvailableCourse.ValueMember = "id";
            listBoxAvailableCourse.DisplayMember = "label";
            listBoxAvailableCourse.SelectedItem = null;


            SqlCommand command = new SqlCommand("SELECT * FROM temp", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            tableSelectedCourse = new DataTable();
            adapter.Fill(this.tableSelectedCourse);
            listBoxSelectedCourse.DataSource = tableSelectedCourse;
            listBoxSelectedCourse.ValueMember = "label";
            listBoxSelectedCourse.DisplayMember = "label";
            listBoxSelectedCourse.SelectedItem = null;
        }
        public void reload()
        {
            listBoxAvailableCourse.DataSource = tableAvailableCourse;
            listBoxAvailableCourse.ValueMember = "id";
            listBoxAvailableCourse.DisplayMember = "label";
            listBoxAvailableCourse.SelectedItem = null;

            listBoxSelectedCourse.DataSource = tableSelectedCourse;
            listBoxSelectedCourse.ValueMember = "label";
            listBoxSelectedCourse.DisplayMember = "label";
            listBoxSelectedCourse.SelectedItem = null;
        }

        private void ButtonAddCourse_Click(object sender, EventArgs e)
        {
            int index = listBoxAvailableCourse.SelectedIndex;

            DataRow dr = tableAvailableCourse.Rows[index];


            tableSelectedCourse.ImportRow(dr);

            dr.Delete();
            tableAvailableCourse.AcceptChanges();

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < tableSelectedCourse.Rows.Count; i++)
                {
                    int contactId = Int32.Parse(TextBoxContactId.Text.Trim());
                    string courseLabel = tableSelectedCourse.Rows[i]["label"].ToString().Trim();
                    int semester = Int32.Parse(NumericUpDownSemester.Value.ToString());
                    if (!myClass.classExist(courseLabel))
                    {
                        if (myClass.insertClass(courseLabel, contactId))
                        {
                            MessageBox.Show("Class has been inserted", "Add Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong", "Add Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Class has been already set", "Add Class", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Class has been already set", "Class has been already set", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
