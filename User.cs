using Student_Management_System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterForm
{
    class User
    {
        MY_DB mydb = new MY_DB();

        //Function to insert a new user
        public bool insertUser(string username, string password )
        {
            //SqlCommand("câu lệnh Query trong SQL Server, được dùng để insert dữ liệu vào bảng Login", chuỗi kết nối tới SQL Server )
            SqlCommand command = new SqlCommand("INSERT INTO login (username,password)" + " VALUES(@username,@password)", mydb.getConnection);
            //Gán giá trị cho parameter 
            //command.Parameters.Add("@parameter", type).Value = value
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;

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
    }
}
