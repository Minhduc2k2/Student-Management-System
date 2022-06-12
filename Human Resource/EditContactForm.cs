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
    public partial class EditContactForm : Form
    {
        public EditContactForm()
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
            if (PictureBoxContactImage.Image == null)
            {
                MessageBox.Show("Image is not valid", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!Regex.IsMatch(TextBoxEmail.Text, emailRegex))
            {
                MessageBox.Show("Email is InValid", "Add HumanResourse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void EditContactForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id from contact WHERE hr_id = @hr_id", myDB.getConnection);
            command.Parameters.Add("@hr_id", SqlDbType.Int).Value = Globals.GlobalUserId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBoxID.DataSource = table;
            comboBoxID.DisplayMember = "id";
            comboBoxID.ValueMember = "id";

            command = new SqlCommand("SELECT id from group_pro WHERE hr_id = @hr_id", myDB.getConnection); 
            command.Parameters.Add("@hr_id", SqlDbType.Int).Value = Globals.GlobalUserId;
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            comboBoxGroup.DataSource = table;
            comboBoxGroup.DisplayMember = "id";
            comboBoxGroup.ValueMember = "id";
        }

        private void comboBoxID_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!check_IsValid())
                    return;
                SqlCommand command = new SqlCommand("SELECT * from contact WHERE id = @id", myDB.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(comboBoxID.SelectedValue.ToString());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                TextBoxFname.Text = table.Rows[0]["fname"].ToString();
                TextBoxLname.Text = table.Rows[0]["lname"].ToString();
                MessageBox.Show(table.Rows[0]["group_id"].ToString());
                comboBoxGroup.SelectedValue = table.Rows[0]["group_id"].ToString();
                TextBoxPhone.Text = table.Rows[0]["phone"].ToString();
                TextBoxEmail.Text = table.Rows[0]["email"].ToString();
                TextBoxAddress.Text = table.Rows[0]["address"].ToString();
                byte[] pic = (byte[])table.Rows[0]["pic"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxContactImage.Image = Image.FromStream(picture);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!check_IsValid())
                    return;
                ProcessBarForm processBarForm = new ProcessBarForm();
                processBarForm.ShowDialog();

                int id = int.Parse(comboBoxID.SelectedValue.ToString());
                string fname = TextBoxFname.Text.Trim();
                string lname = TextBoxLname.Text.Trim();
                string group_id = comboBoxGroup.SelectedValue.ToString();
                string phone = TextBoxPhone.Text.Trim();
                string email = TextBoxEmail.Text.Trim();
                string address = TextBoxAddress.Text.Trim();
                MemoryStream picture = new MemoryStream();
                PictureBoxContactImage.Image.Save(picture, PictureBoxContactImage.Image.RawFormat);
                if (contact.updateContact(id, fname, lname, group_id, phone, email, address, picture))
                {
                    MessageBox.Show("Edit Contact Success", "Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Edit Contact Fail", "Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*gif)|*.jpg;*.png;*gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxContactImage.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
