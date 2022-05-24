using Student_Management_System;
using System.Data;
using System.Data.SqlClient;

namespace LoginForm
{
    class Email
    {
        MY_DB myDB = new MY_DB();
        public bool insertEmail(string username, string email)
        {
            myDB.openConnection();
            SqlCommand command = new SqlCommand("INSERT INTO mail(username, email) VALUES(@username, @email)", myDB.getConnection);
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            if (command.ExecuteNonQuery() == 1)
                return true;
            else
                return false;
        }
        public string getEmail(string username)
        {
            myDB.openConnection();
            SqlCommand command = new SqlCommand("SELECT email FROM mail WHERE username = @username", myDB.getConnection);
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return table.Rows[0]["email"].ToString();
            else
                return "";
        }
        public bool chechIsExist(string username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mail WHERE username = @username", myDB.getConnection);
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
