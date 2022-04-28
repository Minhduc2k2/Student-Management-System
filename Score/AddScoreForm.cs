using Student_Management_System;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class ScoreForm : Form
    {
        public ScoreForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
        Score score = new Score();
        Student student = new Student();
        private void ScoreForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet1.student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.myDBDataSet1.student);
            comboBoxCourse.DataSource = course.getAllCourses();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";

            SqlCommand command = new SqlCommand("Select id, fname, lname from student");
            DataGridView1.ReadOnly = true;
            //Processing img
            //DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            //DataGridView1.RowTemplate.Height = 115;
            DataGridView1.DataSource = student.getStudents(command);
            //picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            //picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxStudentId.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void ButtonAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = Int32.Parse(TextBoxStudentId.Text.Trim());
                string courseId = comboBoxCourse.SelectedValue.ToString();
                float scoreValue = Int32.Parse(TextBoxScore.Text.Trim());
                string description = TextBoxDescription.Text.Trim();

                if(!score.studentScoreExit(studentId, courseId))
                {
                    if(score.insertScore(studentId, courseId, scoreValue, description))
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
                    MessageBox.Show("The score for this course has been already set","Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
