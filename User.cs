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

        //Function to insert a new student
        public bool insertUser(string username, string password )
        {
            SqlCommand command = new SqlCommand("INSERT INTO login (username,password)" + " VALUES(@username,@password)", mydb.getConnection);
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;

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
    }
}
