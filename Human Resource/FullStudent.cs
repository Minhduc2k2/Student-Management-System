using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm.Human_Resource
{
    public partial class FullStudent : Form
    {
        public FullStudent()
        {
            InitializeComponent();
        }
        public FullStudent(DataTable dataTable)
        {
            InitializeComponent();
            dataGridViewStudent.DataSource = dataTable;
        } 
    }
}
