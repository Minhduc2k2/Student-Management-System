using System;
using System.Data;
using System.Windows.Forms;
using LoginForm;

namespace Student_Management_System
{
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            // dùng combobox lay ten Course
            ComboBoxCourse.DisplayMember = "label";
            ComboBoxCourse.ValueMember = "id";
            ComboBoxCourse.SelectedItem = null;
            ComboBoxCourse.DataSource = course.getAllCourses();
        }
        public void fillCombo(int index)
        {
            ComboBoxCourse.DataSource = course.getAllCourses();
            ComboBoxCourse.DisplayMember = "label";
            ComboBoxCourse.ValueMember = "id";
            ComboBoxCourse.SelectedIndex = index;
        }

        private void ComboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string id = ComboBoxCourse.SelectedValue.ToString();
                DataTable table = new DataTable();
                table = course.getCourseById(id);
                TextBoxLabel.Text = table.Rows[0][1].ToString();
                NumericUpDownHours.Value = Int32.Parse(table.Rows[0][2].ToString());
                TextBoxDescription.Text = table.Rows[0][3].ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ComboBoxCourse_SelectedValueChanged(object sender, EventArgs e)
        {
        }
        private void ButtonEditCourse_Click(object sender, EventArgs e)
        {
            string id = ComboBoxCourse.SelectedValue.ToString();
            string name = TextBoxLabel.Text;
            int hrs = (int)NumericUpDownHours.Value;
            string descr = TextBoxDescription.Text;

            // lay lai phan kiem tra ten course
            if (!course.checkCourseName(name, ComboBoxCourse.SelectedValue.ToString()))
            {
                MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (course.updateCourse(id, name, hrs, descr))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillCombo(ComboBoxCourse.SelectedIndex);
            }
            else
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}

