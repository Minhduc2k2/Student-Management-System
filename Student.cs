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
            SqlCommand command = new SqlCommand("INSERT INTO student (id, fname, lname, bdate, gender, phone, address, picture)" + " VALUES(@id, @fname, @lname, @bdate, @gender, @phone, @address, @picture)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if((command.ExecuteNonQuery() == 1))
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
        public bool updateStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE student SET fname = @fname, lname =@lname , bdate = @bdate, gender = @gender, phone =@phone, address =@address, picture =@picture WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
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
        public bool deleteStudent(int id)
        {
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
        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
