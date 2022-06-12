using Student_Management_System;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LoginForm.Human_Resource
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }
        MY_DB myDB = new MY_DB();
        Contact contact = new Contact();
        //Regex
        //VIETNAM Phone number
        string phoneRegex = @"^(84|0[2|3|5|7|8|9])+([0-9]{8})\b$";

        //Email
        //địa chỉ email phải bắt đầu bằng 1 ký tự
        //địa chỉ email là tập hợp của các ký tự a-z, 0 - 9 và có thể có các ký tự như dấu chấm, dấu gạch dưới
        //độ dài tối thiểu của email là 5, độ dài tối đa là 32
        //tên miền của email có thể là tên miền cấp 1 or tên miền cấp 2
        //string emailRegex = @"^[a-z][a-z0-9_\.]{5,32}@[a-z0-9]{2,}(\.[a-z0-9]{2,4}){1,2}$";

        //Name
        //Chữ cái đầu tiên phải viết hoa
        string nameRegex = @"^[A-ZÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ][a-zàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđ]*(?:[ ][A-ZÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ][a-zàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđ]*)*$";
        string idRegex = @"^[0-9]*$";
        string emailRegex = @"^[a-z][a-z0-9_\.]{5,32}@[a-z0-9]{2,}(\.[a-z0-9]{2,4}){1,2}$";

        bool check_IsValid()
        {
            if (TextBoxId.Text == "" || !Regex.IsMatch(TextBoxId.Text, idRegex))
            {
                MessageBox.Show("ID is invalid", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Regex.IsMatch(TextBoxFname.Text, nameRegex))
            {
                MessageBox.Show("First Name is invalid", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Regex.IsMatch(TextBoxLname.Text, nameRegex))
            {
                MessageBox.Show("Last Name is invalid", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Regex.IsMatch(TextBoxPhone.Text, phoneRegex))
            {
                MessageBox.Show("Phone Number is invalid", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (TextBoxAddress.Text.Equals(""))
            {
                MessageBox.Show("Address is empty", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (PictureBoxStudentImage.Image == null)
            {
                MessageBox.Show("Image is not valid", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!Regex.IsMatch(TextBoxEmail.Text, emailRegex))
            {
                MessageBox.Show("Email is InValid", "Add HumanResourse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                myDB.openConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM contact WHERE id = @id", myDB.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(TextBoxId.Text.Trim());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if(table.Rows.Count > 0)
                {
                    MessageBox.Show("Id has already exist", "Add HumanResourse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        private void ButtonAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (!check_IsValid())
                    return;
                ProcessBarForm processBarForm = new ProcessBarForm();
                processBarForm.ShowDialog();

                int id = int.Parse(TextBoxId.Text.Trim());
                string fname = TextBoxFname.Text.Trim();
                string lname = TextBoxLname.Text.Trim();
                string group_id = comboBox1.SelectedValue.ToString();
                string phone = TextBoxPhone.Text.Trim();
                string email = TextBoxEmail.Text.Trim();
                string address = TextBoxAddress.Text.Trim();
                MemoryStream picture = new MemoryStream();
                PictureBoxStudentImage.Image.Save(picture, PictureBoxStudentImage.Image.RawFormat);
                if (contact.insertContact(id, fname, lname, group_id, phone, email, address, picture))
                {
                    MessageBox.Show("Add Contact Success", "Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Add Contact Fail", "Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id from group_pro WHERE hr_id = @hr_id", myDB.getConnection);
            command.Parameters.Add("@hr_id", SqlDbType.Int).Value = Globals.GlobalUserId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "id";
            comboBox1.ValueMember = "id";
        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*gif)|*.jpg;*.png;*gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
