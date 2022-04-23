using LoginForm;
using LoginForm.Course;
using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class RemoveCourseForm : Form
    {
        public RemoveCourseForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
        bool checkValid()
        {
            if (TextBoxCourseId.Text.Trim() == "" )
            {
                MessageBox.Show("Empty field!","Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(course.checkCourseId(TextBoxCourseId.Text.Trim()))
            {
                MessageBox.Show("Course Id no exists", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
        private void ButtonRemoveCourse_Click(object sender, EventArgs e)
        {
            if(checkValid())
            {
                if (course.deleteCourse(TextBoxCourseId.Text.Trim()))
                {
                    MessageBox.Show("Course Removed", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("SomeThing Went Wrong", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
