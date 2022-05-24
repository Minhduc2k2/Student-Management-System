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
    public partial class PassFailForm : Form
    {
        public PassFailForm()
        {
            InitializeComponent();
        }

        private void PassFailForm_Load(object sender, EventArgs e)
        {
            Student student = new Student();
            chartStudent.Titles["Title1"].Text = "Static Pass and Fail Per Total Student: " + student.getTotalStudent();
            chartStudent.Series["Series1"].IsValueShownAsLabel = true;
            chartStudent.Series["Series1"].Points.AddXY("Giỏi",Score.student_gioi);
            chartStudent.Series["Series1"].Points.AddXY("Khá", Score.student_kha);
            chartStudent.Series["Series1"].Points.AddXY("Trung Bình", Score.student_trungbinh);
            chartStudent.Series["Series1"].Points.AddXY("Yếu", Score.student_yeu);
        }
    }
}
