using Student_Management_System;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class AddSemesterForm : Form
    {
        public AddSemesterForm()
        {
            InitializeComponent();
        }
        public AddSemesterForm(string id)
        {
            InitializeComponent();
            TextBoxStudentId.Text = id;
        }
        Course course = new Course();
        Score score = new Score();
        DataTable tableAvailableCourse;
        DataTable tableSelectedCourse;
        MY_DB myDB = new MY_DB();
        private void AddSemesterForm_Load(object sender, EventArgs e)
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
            listBoxSelectedCourse.ValueMember = "id";
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
            listBoxSelectedCourse.ValueMember = "id";
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
                    int studentId = Int32.Parse(TextBoxStudentId.Text.Trim());
                    //string courseId = comboBoxCourse.SelectedValue.ToString();
                    string courseId = tableSelectedCourse.Rows[i]["id"].ToString();
                    int semester = Int32.Parse(NumericUpDownSemester.Value.ToString());
                    MessageBox.Show(courseId);
                    if (!score.studentScoreExit(studentId, courseId))
                    {
                        if (score.insertScore(studentId, courseId, semester))
                        {
                            MessageBox.Show("Score has been inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The score for this course has been already set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
