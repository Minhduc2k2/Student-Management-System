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

namespace LoginForm.Result
{
    public partial class StaticResultForm : Form
    {
        public StaticResultForm()
        {
            InitializeComponent();
        }
        MY_DB myDB = new MY_DB();
        Score score = new Score();
        Student student = new Student();
        private void StaticResultForm_Load(object sender, EventArgs e)
        {
            DataTable table = score.getAVG_Score_by_Course();

            int POSX = 120;
            int POSY = 169;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Label mylab = new Label();
                mylab.Text = table.Rows[i].ItemArray[0].ToString() + ": " + table.Rows[i].ItemArray[1].ToString();
                mylab.Location = new Point(POSX, POSY);
                mylab.AutoSize = true;
                mylab.Font = new Font("Calibri", 18);
                mylab.ForeColor = Color.White;
                this.Controls.Add(mylab);
                POSY += 50;
            }
            Label mylabPass = new Label();
            mylabPass.Text = "Percent of Student Pass: "+(((float)Score.student_pass / int.Parse(student.getTotalStudent()))*100).ToString()+"%";
            mylabPass.Location = new Point(500, 169);
            mylabPass.AutoSize = true;
            mylabPass.Font = new Font("Calibri", 18);
            mylabPass.ForeColor = Color.White;
            this.Controls.Add(mylabPass);

            Label mylabFail= new Label();
            mylabFail.Text = "Percent of Student Fail: " + (((float)Score.student_fail / int.Parse(student.getTotalStudent())) * 100).ToString() + "%";
            mylabFail.Location = new Point(500, 220);
            mylabFail.AutoSize = true;
            mylabFail.Font = new Font("Calibri", 18);
            mylabFail.ForeColor = Color.White;
            this.Controls.Add(mylabFail);
        }

        private void buttonShowPassFail_Click(object sender, EventArgs e)
        {
            PassFailForm passFailForm = new PassFailForm();
            passFailForm.Show();
        }

        private void buttonShowScore_Click(object sender, EventArgs e)
        {
            StaticScoreForm staticScoreForm = new StaticScoreForm();
            staticScoreForm.Show();
        }
    }
}
