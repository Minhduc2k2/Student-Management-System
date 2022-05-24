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
    public partial class StaticScoreForm : Form
    {
        public StaticScoreForm()
        {
            InitializeComponent();
        }

        private void StaticScoreForm_Load(object sender, EventArgs e)
        {
            Score score = new Score();

            DataTable table = score.getAVG_Score_by_Course();
            chartScore.Titles["Title1"].Text = "Static Score of Student";
            chartScore.Series["Điểm"].IsValueShownAsLabel = true;
            chartScore.ChartAreas[0].AxisY.Maximum = 10;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                chartScore.Series["Điểm"].Points.AddXY(table.Rows[i].ItemArray[0].ToString(), table.Rows[i].ItemArray[1].ToString());
            }
        }
    }
}
