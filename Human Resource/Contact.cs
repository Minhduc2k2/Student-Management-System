using Student_Management_System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoginForm.Human_Resource
{
    class Contact
    {
        MY_DB mydb = new MY_DB();

        //Function to insert a new user
        public bool insertContact(int id, string fname, string lname, string group_id, string phone,string email, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO contact (id, fname, lname, group_id, phone, email,address,pic,hr_id )" + " VALUES(@id, @fname, @lname, @group_id, @phone, @email,@address,@pic,@hr_id)", mydb.getConnection);

            //Gán giá trị cho parameter 
            //command.Parameters.Add("@parameter", type).Value = value
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@group_id", SqlDbType.NVarChar).Value = group_id;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@address", SqlDbType.Text).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@hr_id", SqlDbType.Int).Value = Globals.GlobalUserId;
            //Gọi hàm mở kết nối của mydb
            mydb.openConnection();

            //Thi hành SqlCommand bằng phương thức ExecuteNonQuery nó trả về kết quả là số dòng dữ liệu bị ảnh hưởng (số dòng xóa, số dòng update ...).
            //Thường dùng cách này để thi hành các truy vấn UPDATE, INSERT, DELETE. 
            if ((command.ExecuteNonQuery() == 1))
            {
                //Gọi hàm đóng kết nối của mydb
                //Trả về true
                mydb.closeConnection();
                return true;
            }
            else
            {
                //Gọi hàm đóng kết nối của mydb
                //Trả về false
                mydb.closeConnection();
                return false;
            }
        }
        public bool updateContact(int id, string fname, string lname, string group_id, string phone, string email, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE contact set fname = @fname, lname = @lname, group_id = @group_id, phone = @phone, email = @email, address = @address, pic = @pic WHERE id = @id", mydb.getConnection);

            //Gán giá trị cho parameter 
            //command.Parameters.Add("@parameter", type).Value = value
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@group_id", SqlDbType.NVarChar).Value = group_id;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@address", SqlDbType.Text).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            //Gọi hàm mở kết nối của mydb
            mydb.openConnection();

            //Thi hành SqlCommand bằng phương thức ExecuteNonQuery nó trả về kết quả là số dòng dữ liệu bị ảnh hưởng (số dòng xóa, số dòng update ...).
            //Thường dùng cách này để thi hành các truy vấn UPDATE, INSERT, DELETE. 
            if ((command.ExecuteNonQuery() == 1))
            {
                //Gọi hàm đóng kết nối của mydb
                //Trả về true
                mydb.closeConnection();
                return true;
            }
            else
            {
                //Gọi hàm đóng kết nối của mydb
                //Trả về false
                mydb.closeConnection();
                return false;
            }
        }
        public bool deleteContact(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM contact where id = @id ", mydb.getConnection);

            //Gán giá trị cho parameter 
            //command.Parameters.Add("@parameter", type).Value = value
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            //Gọi hàm mở kết nối của mydb
            mydb.openConnection();

            //Thi hành SqlCommand bằng phương thức ExecuteNonQuery nó trả về kết quả là số dòng dữ liệu bị ảnh hưởng (số dòng xóa, số dòng update ...).
            //Thường dùng cách này để thi hành các truy vấn UPDATE, INSERT, DELETE. 
            if ((command.ExecuteNonQuery() == 1))
            {
                //Gọi hàm đóng kết nối của mydb
                //Trả về true
                mydb.closeConnection();
                return true;
            }
            else
            {
                //Gọi hàm đóng kết nối của mydb
                //Trả về false
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable getContact()
        {
            SqlCommand command = new SqlCommand("SELECT * from contact", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable getContact(string id)
        {
            SqlCommand command = new SqlCommand("SELECT * from contact WHERE group_id =@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
