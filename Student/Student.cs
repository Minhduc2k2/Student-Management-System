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
    class Student
    {
        MY_DB mydb = new MY_DB();

        //Function to insert a new student
        
        public bool insertStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            //SqlCommand("câu lệnh Query trong SQL Server, được dùng để insert dữ liệu vào bảng Student", chuỗi kết nối tới SQL Server )
            SqlCommand command = new SqlCommand("INSERT INTO student (id, fname, lname, bdate, gender, phone, address, picture)" + " VALUES(@id, @fname, @lname, @bdate, @gender, @phone, @address, @picture)", mydb.getConnection);

            //Gán giá trị cho parameter 
            //command.Parameters.Add("@parameter", type).Value = value
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate.Date;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
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
        public bool updateStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            //SqlCommand("câu lệnh Query trong SQL Server, được dùng để update dữ liệu trong bảng Student", chuỗi kết nối tới SQL Server )
            SqlCommand command = new SqlCommand("UPDATE student SET fname = @fname, lname =@lname , bdate = @bdate, gender = @gender, phone =@phone, address =@address, picture =@picture WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate.Date;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
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
        public bool deleteStudent(int id)
        {
            //SqlCommand("câu lệnh Query trong SQL Server, được dùng để delete dữ liệu trong bảng Student", chuỗi kết nối tới SQL Server )
            SqlCommand command = new SqlCommand("DELETE FROM student WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mydb.openConnection();
            if(command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        //Nhận vào một câu query
        //Trả ra một table (Student)
        public DataTable getStudents(SqlCommand command)
        {
            //Kết nối tới SQL Server
            command.Connection = mydb.getConnection;

            //DataAdapter là lớp tạo ra cầu nối giữa DataSet (các bảng) với nguồn dữ liệu (Database - Tabble) - từ đó có thể lấy dữ liệu nguồn về DataSet, dữ liệu được biên tập (insert, update, delete) trong DataSet - sau đó cập nhật trở lại nguồn.
            //SelectCommand thuộc tính chứa đối tượng SqlCommand, nó chạy khi lấy dữ liệu bằng cách gọi phương thực Fill
            //InsertCommand thuộc tính chứa đối tượng SqlCommand, chạy khi thực hiện thêm dữ liệu
            //UpdateCommand thuộc tính chứa đối tượng SqlCommand, chạy khi thực hiện cập nhật
            //DeleteCommand thuộc tính chứa đối tượng SqlCommand, chạy khi thực hiện xóa dòng dữ liệu
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            //DataTable là đối tượng chứa dữ liệu, nó có tên, các dòng, cột qua đó nó là ánh xạ của một bảng (Table) của CSDL.
            DataTable table = new DataTable();

            //Đổ dữ liệu từ adapter vào table
            adapter.Fill(table);
            return table;
        }

        private string executeTotal(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);

            mydb.openConnection();
            string total = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return total;
        }
        public string getTotalStudent()
        {
            return executeTotal("Select COUNT(*) from student");
        }
        public string getTotalStudentMale()
        {
            return executeTotal("Select COUNT(*) from student WHERE gender = N'Male'");
        }
        public string getTotalStudentFeMale()
        {
            return executeTotal("Select COUNT(*) from student WHERE gender = N'FeMale'");
        }

    }
}
