using LoginForm;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        MY_DB db = new MY_DB();
        Email email = new Email();
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (radioButtonStudent.Checked)
            {

                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username = @User AND password = @Pass", db.getConnection);

                command.Parameters.Add("@User ", SqlDbType.VarChar).Value = TextBoxUserName.Text;
                command.Parameters.Add("@Pass ", SqlDbType.VarChar).Value = TextBoxPassword.Text;

                //SelectCommand thuộc tính chứa đối tượng SqlCommand, nó chạy khi lấy dữ liệu bằng cách gọi phương thực Fill
                adapter.SelectCommand = command;

                //Đổ dữ liệu từ adapter vào table
                adapter.Fill(table);

                //Nếu dữ liệu trong bảng lớn hơn 1 dòng => Thực hiện thành công
                if (table.Rows.Count > 0)
                {
                    //MessageBox.Show("Ok, next time will we go to Main Menu of App", "Announcement" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Invalid UserName Or PassWord", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand("SELECT * FROM hr WHERE uname = @uname AND pwd = @pwd", db.getConnection);

                command.Parameters.Add("@uname ", SqlDbType.NVarChar).Value = TextBoxUserName.Text;
                command.Parameters.Add("@pwd ", SqlDbType.NVarChar).Value = TextBoxPassword.Text;

                //SelectCommand thuộc tính chứa đối tượng SqlCommand, nó chạy khi lấy dữ liệu bằng cách gọi phương thực Fill
                adapter.SelectCommand = command;

                //Đổ dữ liệu từ adapter vào table
                adapter.Fill(table);

                //Nếu dữ liệu trong bảng lớn hơn 1 dòng => Thực hiện thành công
                if (table.Rows.Count > 0)
                {
                    //MessageBox.Show("Ok, next time will we go to Main Menu of App", "Announcement" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int id = int.Parse(table.Rows[0][0].ToString());
                    Globals.SetGlobalUserId(id);
                    this.DialogResult = DialogResult.Yes;
                }
                else
                    MessageBox.Show("Invalid UserName Or PassWord", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxUserName_Enter(object sender, EventArgs e)
        {
            //PlaceHolder
            if (TextBoxUserName.Text == "UserName")
            {
                TextBoxUserName.Text = "";
            }
        }

        private void TextBoxUserName_Leave(object sender, EventArgs e)
        {
            //PlaceHolder
            if (TextBoxUserName.Text == "")
            {
                TextBoxUserName.Text = "UserName";
            }
        }

        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            //PlaceHolder
            if (TextBoxPassword.Text == "Password")
            {
                TextBoxPassword.Text = "";
                TextBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            //PlaceHolder
            if (TextBoxPassword.Text == "")
            {
                TextBoxPassword.Text = "Password";
                TextBoxPassword.UseSystemPasswordChar = false;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (radioButtonStudent.Checked)
            {
                RegisterForm registerForm = new RegisterForm();
                registerForm.ShowDialog();

            }
            else
            {
                AddHRForm addHRForm = new AddHRForm();
                addHRForm.Show();
            }
        }

        private void labelForgot_Click(object sender, EventArgs e)
        {
            textBoxEmail.Visible = true;
            buttonGetPassword.Visible = true;
        }

        private void buttonGetPassword_Click(object sender, EventArgs e)
        {
            if (radioButtonStudent.Checked)
            {

                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username = @User", db.getConnection);

                command.Parameters.Add("@User ", SqlDbType.VarChar).Value = TextBoxUserName.Text;

                //SelectCommand thuộc tính chứa đối tượng SqlCommand, nó chạy khi lấy dữ liệu bằng cách gọi phương thực Fill
                adapter.SelectCommand = command;

                //Đổ dữ liệu từ adapter vào table
                adapter.Fill(table);

                //Nếu dữ liệu trong bảng lớn hơn 1 dòng => Thực hiện thành công
                if (table.Rows.Count > 0)
                {
                    try
                    {
                        //MessageBox.Show("Ok, next time will we go to Main Menu of App", "Announcement" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string username = table.Rows[0]["username"].ToString();
                        string password = table.Rows[0]["password"].ToString();
                        string mymail = email.getEmail(username);
                        if(!mymail.Equals(textBoxEmail.Text.Trim()))
                        {
                            MessageBox.Show("Email is not the same", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        var smtp = new SmtpClient();
                        var mail = new MailMessage();

                        smtp.EnableSsl = true;
                        smtp.Credentials = new NetworkCredential("kebatdungthugk@gmail.com", "bianmothuyenthoai");

                        mail.From = new MailAddress("kebatdungthugk@gmail.com", "Student_Management_System");
                        mail.BodyEncoding = mail.SubjectEncoding = Encoding.UTF8;
                        mail.IsBodyHtml = true;
                        mail.Priority = MailPriority.High;

                        mail.Body = "Password của bạn là: " + password;
                        mail.Subject = "Student_Management_System cấp lại mật khẩu";
                        mail.To.Add(mymail);
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;
                        smtp.Send(mail);
                        MessageBox.Show("Password has been send to your mail", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Email khong ton tai", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                    MessageBox.Show("Invalid UserName Or PassWord", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand("SELECT * FROM hr WHERE uname = @uname", db.getConnection);

                command.Parameters.Add("@uname ", SqlDbType.NVarChar).Value = TextBoxUserName.Text;

                //SelectCommand thuộc tính chứa đối tượng SqlCommand, nó chạy khi lấy dữ liệu bằng cách gọi phương thực Fill
                adapter.SelectCommand = command;

                //Đổ dữ liệu từ adapter vào table
                adapter.Fill(table);

                //Nếu dữ liệu trong bảng lớn hơn 1 dòng => Thực hiện thành công
                if (table.Rows.Count > 0)
                {
                    try
                    {

                        //MessageBox.Show("Ok, next time will we go to Main Menu of App", "Announcement" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string username = table.Rows[0]["uname"].ToString();
                        string password = table.Rows[0]["pwd"].ToString();
                        string mymail = email.getEmail(username);
                        if (!mymail.Equals(textBoxEmail.Text.Trim()))
                        {
                            MessageBox.Show("Email is not the same", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        var smtp = new SmtpClient();
                        var mail = new MailMessage();

                        smtp.EnableSsl = true;
                        smtp.Credentials = new NetworkCredential("kebatdungthugk@gmail.com", "bianmothuyenthoai");

                        mail.From = new MailAddress("kebatdungthugk@gmail.com", "Student_Management_System");
                        mail.BodyEncoding = mail.SubjectEncoding = Encoding.UTF8;
                        mail.IsBodyHtml = true;
                        mail.Priority = MailPriority.High;

                        mail.Body = "Password của bạn là: " + password;
                        mail.Subject = "Student_Management_System cấp lại mật khẩu";
                        mail.To.Add(mymail);
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;
                        smtp.Send(mail);
                        MessageBox.Show("Password has been send to your mail", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Email khong ton tai", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                    MessageBox.Show("Invalid UserName Or PassWord", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
