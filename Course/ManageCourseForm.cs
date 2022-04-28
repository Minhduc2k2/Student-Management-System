using LoginForm;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class ManageCourseForm : Form
    {
        public ManageCourseForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
        int pos;
        bool checkValid()
        {
            if (TextBoxCourseId.Text.Trim() == "" || TextBoxLabel.Text.Trim() == "" || TextBoxPeriod.Text.Trim() == "" || TextBoxDescription.Text.Trim() == "")
            {
                MessageBox.Show("Empty field!", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!course.checkCourseId(TextBoxCourseId.Text.Trim()))
            {
                MessageBox.Show("Course Id already exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!course.checkCourseName(TextBoxLabel.Text.Trim(), TextBoxCourseId.Text.Trim()))
            {
                MessageBox.Show("Course Name already exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!int.TryParse(TextBoxPeriod.Text.Trim(), out _))
            {
                MessageBox.Show("Period must be a number", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (int.TryParse(TextBoxPeriod.Text.Trim(), out _))
            {
                if (int.Parse(TextBoxPeriod.Text.Trim()) <= 10)
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
            if (checkValid())
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

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }
        void reloadListBoxData()
        {
            listBoxData.DataSource = course.getAllCourses();
            listBoxData.ValueMember = "id";
            listBoxData.DisplayMember = "label";
            listBoxData.SelectedItem = null;
            labelTotalCourse.Text = "Total Courses: "+ course.totalCourse();
        }

        void showData(int index)
        {
            DataRow dr = course.getAllCourses().Rows[index];
            listBoxData.SelectedItem = index;
            TextBoxCourseId.Text = dr.ItemArray[0].ToString();
            TextBoxLabel.Text = dr.ItemArray[1].ToString();
            TextBoxPeriod.Text = dr.ItemArray[2].ToString();
            TextBoxDescription.Text = dr.ItemArray[3].ToString();
        }

        private void listBoxData_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)listBoxData.SelectedItem;
            pos = listBoxData.SelectedIndex;
            showData(pos);
        }

        private void ButtonEditCourse_Click(object sender, EventArgs e)
        {
            if (checkValid())
            {
                if (course.updateCourse(TextBoxCourseId.Text.Trim(), TextBoxLabel.Text.Trim(), int.Parse(TextBoxPeriod.Text.Trim()), TextBoxDescription.Text.Trim()))
                {
                    MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadListBoxData();
                }
                else
                    MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pos = 0;
            }
        }

        private void ButtonRemoveCourse_Click(object sender, EventArgs e)
        {
            if (checkValid())
            {
                if (course.deleteCourse(TextBoxCourseId.Text.Trim()))
                {
                    MessageBox.Show("Course Removed", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("SomeThing Went Wrong", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                pos = 0;
            }
        }

        private void ButtonFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }



        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (pos < (course.getAllCourses().Rows.Count - 1))
            {
                pos = pos + 1;
                showData(pos);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if(pos > 0)
            {
                pos = pos - 1;
                showData(pos);
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourses().Rows.Count - 1;
            showData(pos);
        }
    }
}
