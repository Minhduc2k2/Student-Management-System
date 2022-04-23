using LoginForm.Course;
using System;
using System.Data;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
        bool checkValid()
        {
            //if (TextBoxCourseId.Text.Trim() == "" || TextBoxLabel.Text.Trim() == "" || TextBoxPeriod.Text.Trim() == "" || TextBoxDescription.Text.Trim() == "")
            //{
            //    MessageBox.Show("Empty field!","Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            //else if(!course.checkCourseId(TextBoxCourseId.Text.Trim()))
            //{
            //    MessageBox.Show("Course Id already exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            //else if(!course.checkCourseName(TextBoxLabel.Text.Trim(), TextBoxCourseId.Text.Trim()))
            //{
            //    MessageBox.Show("Course Name already exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            //else if(!int.TryParse(TextBoxPeriod.Text.Trim(), out _))
            //{
            //    MessageBox.Show("Period must be a number", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            //else if (int.TryParse(TextBoxPeriod.Text.Trim(), out _))
            //{
            //    if(int.Parse(TextBoxPeriod.Text.Trim()) <= 10)
            //    {
            //        MessageBox.Show("Period must be larger than 10", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return false;
            //    }
            //    return true;
            //}
            //else
            return true;
        }
        //private void ButtonAddCourse_Click(object sender, EventArgs e)
        //{
        //    if (checkValid())
        //    {
        //        //if (course.insertCourse(TextBoxCourseId.Text.Trim(), TextBoxLabel.Text.Trim(), int.Parse(TextBoxPeriod.Text.Trim()), TextBoxDescription.Text.Trim()))
        //        //{
        //        //    MessageBox.Show("New Course Added", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        //}
        //        //else
        //        //{
        //        //    MessageBox.Show("SomeThing Went Wrong", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        //}
        //    }
        //}

        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            // dùng combobox lay ten Course
            ComboBoxCourse.DataSource = course.getAllCourses();
            ComboBoxCourse.DisplayMember = "label";
            ComboBoxCourse.ValueMember = "id";
            ComboBoxCourse.SelectedItem = null;
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
            //try
            //{
            //    string id = ComboBoxCourse.Text.ToString();
            //    MessageBox.Show(id);
            //    DataTable table = new DataTable();
            //    table = course.getCourseById(id);
            //    TextBoxLabel.Text = table.Rows[0][1].ToString();
            //    NumericUpDownHours.Value = Int32.Parse(table.Rows[0][2].ToString());
            //    TextBoxDescription.Text = table.Rows[0][3].ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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

