using Student_Management_System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    class HumanResource
    {
        MY_DB mydb = new MY_DB();

        //Function to insert a new user
        public bool insertUser(int id, string f_name, string l_name, string uname, string pwd, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO hr (id, f_name, l_name, uname, pwd, fig)" + " VALUES(@id, @f_name, @l_name, @uname, @pwd, @picture)", mydb.getConnection);

            //Gán giá trị cho parameter 
            //command.Parameters.Add("@parameter", type).Value = value
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@f_name", SqlDbType.NVarChar).Value = f_name;
            command.Parameters.Add("@l_name", SqlDbType.NVarChar).Value = l_name;
            command.Parameters.Add("@uname", SqlDbType.NVarChar).Value = uname;
            command.Parameters.Add("@pwd", SqlDbType.NVarChar).Value = pwd;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();

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
