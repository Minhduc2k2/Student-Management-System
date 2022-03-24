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
    public partial class ProcessBarForm : Form
    {
        public ProcessBarForm()
        {
            InitializeComponent();
        }

        private void ProcessBarForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if (progressBar1.Value >= progressBar1.Maximum )
            {
                Close();
            }
        }
    }
}
