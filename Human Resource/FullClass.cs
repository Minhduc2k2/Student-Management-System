using Student_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm.Human_Resource
{
    public partial class FullClass : Form
    {
        int contact_id;
        Score score = new Score();
        MY_DB myDB = new MY_DB();
        public FullClass()
        {
            InitializeComponent();
        }
        public FullClass(int contact_id)
        {
            InitializeComponent();
            this.contact_id = contact_id;
            TextBoxId.Text = this.contact_id.ToString();

            SqlCommand command = new SqlCommand("SELECT course_label from class_pro WHERE contact_id = @contact_id", myDB.getConnection);
            command.Parameters.Add("@contact_id", SqlDbType.Int).Value = contact_id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            listBoxCourse.DataSource = dataTable;
            listBoxCourse.ValueMember = "course_label";
            listBoxCourse.DisplayMember = "course_label";
        }

        private void ButtonAssign_Click(object sender, EventArgs e)
        {
            AddClassForm addClassForm = new AddClassForm(contact_id.ToString());
            addClassForm.ShowDialog();
        }

        private void listBoxCourse_Click(object sender, EventArgs e)
        {
            string course_label = listBoxCourse.SelectedValue.ToString();

            SqlCommand command = new SqlCommand("SELECT id FROM course WHERE label = @course_label",myDB.getConnection);
            command.Parameters.Add("@course_label", SqlDbType.NVarChar).Value = course_label;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            string course_id = dataTable.Rows[0]["id"].ToString();
            dataTable = score.getStudentScoreByCourseId(course_id);
            FullStudent fullStudent = new FullStudent(dataTable);
            fullStudent.ShowDialog();
        }
    }
}
