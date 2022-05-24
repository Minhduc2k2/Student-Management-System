using LoginForm.Result;
using Student_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.Show(this);
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentListForm studentListForm = new StudentListForm();
            studentListForm.Show(this);
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsForm staticsForm = new StaticsForm();
            staticsForm.Show();

        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentForm manageStudentForm = new ManageStudentForm();
            manageStudentForm.Show(this);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteStudentForm = new UpdateDeleteStudentForm();
            updateDeleteStudentForm.Show(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintSaveForm printSaveForm = new PrintSaveForm();
            printSaveForm.Show(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm removeCourseForm = new RemoveCourseForm();
            removeCourseForm.Show(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm editCourseForm = new EditCourseForm();
            editCourseForm.Show(this);
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm manageCourseForm = new ManageCourseForm();
            manageCourseForm.Show(this);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintSaveCourseForm printSaveCourseForm = new PrintSaveCourseForm();
            printSaveCourseForm.Show(this);
        }

        private void toolStripMenuItemAddScore_Click(object sender, EventArgs e)
        {
            ScoreForm addScoreForm = new ScoreForm();
            addScoreForm.Show(this);
        }

        private void toolStripMenuItemRemoveScore_Click(object sender, EventArgs e)
        {
            RemoveScoreForm removeScoreForm = new RemoveScoreForm();
            removeScoreForm.Show(this);
        }

        private void toolStripMenuItemManageScore_Click(object sender, EventArgs e)
        {
            ManageScoreForm manageScoreForm = new ManageScoreForm();
            manageScoreForm.Show(this);
        }

        private void toolStripMenuItemAVG_Click(object sender, EventArgs e)
        {
            AvgScoreForm avgScoreForm = new AvgScoreForm();
            avgScoreForm.ShowDialog(this);
        }

        private void toolStripMenuItemPrint_Click(object sender, EventArgs e)
        {
            PrintSaveScoreForm printSaveScoreForm = new PrintSaveScoreForm();
            printSaveScoreForm.Show(this);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm();
            resultForm.Show(this);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            StaticResultForm staticResultForm = new StaticResultForm();
            staticResultForm.Show(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm();
            resultForm.Show();
            resultForm.Close();
        }
    }
}
