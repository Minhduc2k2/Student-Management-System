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
    public partial class StaticsForm : Form
    {
        public StaticsForm()
        {
            InitializeComponent();
        }

        private void StaticsForm_Load(object sender, EventArgs e)
        {
            Student student = new Student();
            chartStudent.Titles["Title1"].Text = "Total Student: " + student.getTotalStudent();
            chartStudent.Series["Series1"].IsValueShownAsLabel = true;
            chartStudent.Series["Series1"].Points.AddXY("Male", student.getTotalStudentMale());
            chartStudent.Series["Series1"].Points.AddXY("FeMale", student.getTotalStudentFeMale());
        }
    }
}
