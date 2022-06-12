﻿using Student_Management_System;
using System;
using System.Data;
using System.Data.SqlClient;
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
        MY_DB myDB = new MY_DB();
        private void ScoreForm_Load(object sender, EventArgs e)
        {

            //comboBoxCourse.DataSource = course.getAllCourses();
            //comboBoxCourse.DisplayMember = "label";
            //comboBoxCourse.ValueMember = "id";



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

            SqlCommand commandCombo = new SqlCommand("SELECT course_id FROM score WHERE student_id = @student_id", myDB.getConnection);
            commandCombo.Parameters.Add("@student_id", SqlDbType.Int).Value = int.Parse(TextBoxStudentId.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(commandCombo);
            DataTable table = new DataTable();
            adapter.Fill(table);
            string id ="";
            DataTable tableCourse = new DataTable();
            DataTable tableCourse_pro = new DataTable();
            tableCourse_pro.Columns.Add("id", typeof(String));
            tableCourse_pro.Columns.Add("label", typeof(String));
            DataRow row;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                id = table.Rows[i]["course_id"].ToString().Trim().Trim();

                tableCourse = course.getCourseLikeId(id);

                row = tableCourse_pro.NewRow();

                row["id"] = tableCourse.Rows[0]["id"].ToString().Trim();
                row["label"] = tableCourse.Rows[0]["label"].ToString().Trim();
                tableCourse_pro.Rows.Add(row);
            }

            comboBoxCourse.DataSource = tableCourse_pro;
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";
        }
        bool check_IsValid()
        {
            if(TextBoxStudentId.Text.Trim() =="" || TextBoxScore.Text.Trim() == "" || TextBoxDescription.Text.Trim() == "")
            {
                MessageBox.Show("Empty Field", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(!int.TryParse(TextBoxStudentId.Text.Trim(), out int _))
            {
                MessageBox.Show("ID must be a number", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!int.TryParse(TextBoxScore.Text.Trim(), out int _))
            {
                MessageBox.Show("Score must be a number", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void ButtonAddCourse_Click(object sender, EventArgs e)
        {

            try
            {
                if (!check_IsValid())
                    return;
                int studentId = Int32.Parse(TextBoxStudentId.Text.Trim());
                string courseId = comboBoxCourse.SelectedValue.ToString();
                float scoreValue = Int32.Parse(TextBoxScore.Text.Trim());
                string description = TextBoxDescription.Text.Trim();

                if (!score.studentScoreExit(studentId, courseId))
                {
                    if (score.updateScore(studentId, courseId, scoreValue, description, 1))
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
