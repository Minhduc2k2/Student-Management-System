using LoginForm;
using LoginForm.Course;
using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
        bool checkValid()
        {
            if (TextBoxCourseId.Text.Trim() == "" || TextBoxLabel.Text.Trim() == "" || TextBoxPeriod.Text.Trim() == "" || TextBoxDescription.Text.Trim() == "")
            {
                MessageBox.Show("Empty field!","Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(!course.checkCourseId(TextBoxCourseId.Text.Trim()))
            {
                MessageBox.Show("Course Id already exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(!course.checkCourseName(TextBoxLabel.Text.Trim(), TextBoxCourseId.Text.Trim()))
            {
                MessageBox.Show("Course Name already exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(!int.TryParse(TextBoxPeriod.Text.Trim(), out _))
            {
                MessageBox.Show("Period must be a number", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (int.TryParse(TextBoxPeriod.Text.Trim(), out _))
            {
                if(int.Parse(TextBoxPeriod.Text.Trim()) <= 10)
                {
                    MessageBox.Show("Period must be larger than 10", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            else
                return true;
        }
        private void ButtonAddCourse_Click(object sender, EventArgs e)
        {
            if(checkValid())
            {
                if (course.insertCourse(TextBoxCourseId.Text.Trim(), TextBoxLabel.Text.Trim(), int.Parse(TextBoxPeriod.Text.Trim()), TextBoxDescription.Text.Trim()))
                {
                    MessageBox.Show("New Course Added", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("SomeThing Went Wrong", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
