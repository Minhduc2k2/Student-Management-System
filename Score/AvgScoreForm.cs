using Student_Management_System;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class AvgScoreForm : Form
    {
        public AvgScoreForm()
        {
            InitializeComponent();
        }
        Score score = new Score();

        private void AvgScoreForm_Load(object sender, EventArgs e)
        {
            DataGridView1.ReadOnly = true;
            DataGridView1.DataSource = score.getAVG_Score_by_Course();
            DataGridView1.AllowUserToAddRows = false;

        }
    }
}
