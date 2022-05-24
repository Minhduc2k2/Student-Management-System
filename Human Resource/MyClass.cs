using Student_Management_System;
using System.Data;
using System.Data.SqlClient;

namespace LoginForm.Human_Resource
{
    class MyClass
    {
        MY_DB myDB = new MY_DB();

        public bool classExist(string courseLabel)
        {
            myDB.openConnection();
            SqlCommand command = new SqlCommand("SELECT * from class_pro WHERE course_label = @course_label", myDB.getConnection);
            command.Parameters.Add("@course_label", SqlDbType.NVarChar).Value = courseLabel;
            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool insertClass(string course_label, int contact_id)
        {
            myDB.openConnection();
            SqlCommand command = new SqlCommand("INSERT INTO class_pro(course_label, contact_id) VALUES(@course_label, @contact_id)", myDB.getConnection);
            command.Parameters.Add("@course_label", SqlDbType.NVarChar).Value = course_label;
            command.Parameters.Add("@contact_id", SqlDbType.Int).Value = contact_id;
            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
