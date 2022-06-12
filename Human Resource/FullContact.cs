using Student_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm.Human_Resource
{
    public partial class FullContact : Form
    {
        public FullContact()
        {
            InitializeComponent();
        }
        MY_DB myDB = new MY_DB();
        Contact contact = new Contact();
        private void FullContact_Load(object sender, EventArgs e)
        {
            dataGridViewContact.AllowUserToAddRows = false;
            dataGridViewContact.RowTemplate.Height = 100;
            dataGridViewContact.DataSource = contact.getContact();
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridViewContact.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewContact.Columns[0].HeaderText = "ID";
            dataGridViewContact.Columns[1].HeaderText = "First Name";
            dataGridViewContact.Columns[2].HeaderText = "Last Name";
            dataGridViewContact.Columns[3].HeaderText = "Group ID";
            dataGridViewContact.Columns[4].HeaderText = "Phone";
            dataGridViewContact.Columns[5].HeaderText = "Email";
            dataGridViewContact.Columns[6].HeaderText = "Address";
            dataGridViewContact.Columns[7].HeaderText = "Avatar";
            dataGridViewContact.Columns[8].HeaderText = "HR ID";

            SqlCommand command = new SqlCommand("SELECT id from group_pro", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            listBoxGroup.DataSource = dataTable;
            listBoxGroup.ValueMember = "id";
            listBoxGroup.DisplayMember = "id";
        }

        private void listBoxGroup_Click(object sender, EventArgs e)
        {
            string group_id = listBoxGroup.SelectedValue.ToString();
            dataGridViewContact.DataSource = contact.getContact(group_id);
        }

        private void dataGridViewContact_Click(object sender, EventArgs e)
        {
            int contact_id = int.Parse(dataGridViewContact.CurrentRow.Cells[0].Value.ToString().Trim());
            FullClass fullClass = new FullClass(contact_id);
            fullClass.ShowDialog();
        }
    }
}
