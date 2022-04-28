using Student_Management_System;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class RemoveScoreForm : Form
    {
        public RemoveScoreForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
        Score score = new Score();
        Student student = new Student();

        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            DataGridView1.ReadOnly = true;
            DataGridView1.DataSource = score.getStudentScore();
            DataGridView1.AllowUserToAddRows = false;

        }

        private void ButtonRemoveScore_Click(object sender, EventArgs e)
        {
            try
            {
                int student_id = Int32.Parse( DataGridView1.CurrentRow.Cells[0].Value.ToString());
                string course_id = DataGridView1.CurrentRow.Cells[3].Value.ToString();
                if(score.deleteScore(student_id, course_id))
                    MessageBox.Show("Score has been removed", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Something went wrong", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
