using Student_Management_System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.Course
{
    class Course
    {
        MY_DB mydb = new MY_DB();
        public bool insertCourse(string id, string courseName, int hoursNumber, string description)
        {
            //SqlCommand("câu lệnh Query trong SQL Server, được dùng để insert dữ liệu vào bảng Course", chuỗi kết nối tới SQL Server )
            SqlCommand command = new SqlCommand("INSERT INTO course (id, label, period, description)" + " VALUES(@id, @courseName, @hoursNumber, @description)", mydb.getConnection);

            //Gán giá trị cho parameter 
            //command.Parameters.Add("@parameter", type).Value = value
            command.Parameters.Add("@id", SqlDbType.Char).Value = id;
            command.Parameters.Add("@courseName", SqlDbType.NVarChar).Value = courseName;
            command.Parameters.Add("@hoursNumber", SqlDbType.Int).Value = hoursNumber;
            command.Parameters.Add("@description", SqlDbType.NVarChar).Value = description;

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
        public bool updateCourse(string id, string courseName, int hoursNumber, string description)
        {
            //SqlCommand("câu lệnh Query trong SQL Server, được dùng để update dữ liệu trong bảng Course", chuỗi kết nối tới SQL Server )
            SqlCommand command = new SqlCommand("UPDATE course SET label = @courseName, period =@hoursNumber, description = @description WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Char).Value = id;
            command.Parameters.Add("@courseName", SqlDbType.NVarChar).Value = courseName;
            command.Parameters.Add("@hoursNumber", SqlDbType.Int).Value = hoursNumber;
            command.Parameters.Add("@description", SqlDbType.NVarChar).Value = description;

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
        public bool deleteCourse(string id)
        {
            //SqlCommand("câu lệnh Query trong SQL Server, được dùng để delete dữ liệu trong bảng Course", chuỗi kết nối tới SQL Server )
            SqlCommand command = new SqlCommand("DELETE FROM course WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Char).Value = id;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
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
        public DataTable getCourseById(string id)
        {
            //Kết nối tới SQL Server
            SqlCommand command = new SqlCommand("Select * FROM course WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Char).Value = id;

           
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);
            return table;
        }
        public DataTable getAllCourses()
        {
            //Kết nối tới SQL Server
            SqlCommand command = new SqlCommand("Select * FROM course", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        //Tim Course trung ten
        public bool checkCourseName(string courseName, string courseId)
        {
            SqlCommand command = new SqlCommand("Select * FROM course WHERE label = @courseName AND id <> @courseId", mydb.getConnection);
            command.Parameters.Add("@courseId", SqlDbType.Char).Value = courseId;
            command.Parameters.Add("@courseName", SqlDbType.NVarChar).Value = courseName;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            if (table.Rows.Count > 0)

                return false;
            else
                return true;
        }
        public bool checkCourseId(string courseId)
        {
            SqlCommand command = new SqlCommand("Select * FROM course WHERE id = @courseId", mydb.getConnection);
            command.Parameters.Add("@courseId", SqlDbType.Char).Value = courseId;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return false;
            else
                return true;
        }
    }
}

