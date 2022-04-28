using Student_Management_System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    class Score
    {
        MY_DB mydb = new MY_DB();

        public bool insertScore(int studentId, string courseId, float studentScore, string description)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO score(student_id, course_id, student_score, description) VALUES(@studentId, @courseId, @studentScore, @description)", mydb.getConnection);
            sqlCommand.Parameters.Add("@studentId", SqlDbType.Int).Value = studentId;
            sqlCommand.Parameters.Add("@courseId", SqlDbType.VarChar).Value = courseId;
            sqlCommand.Parameters.Add("@studentScore", SqlDbType.Float).Value = studentScore;
            sqlCommand.Parameters.Add("@description", SqlDbType.Text).Value = description;

            mydb.openConnection();
            if(sqlCommand.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool deleteScore(int studentId, string courseId)
        {
            SqlCommand command = new SqlCommand("DELETE FROM score WHERE student_id = @studentId and course_id = @courseId", mydb.getConnection);
            command.Parameters.Add("@studentId", SqlDbType.Int).Value = studentId;
            command.Parameters.Add("@courseId", SqlDbType.VarChar).Value = courseId;

            mydb.openConnection();
            if(command.ExecuteNonQuery() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool studentScoreExit(int studentId, string courseId)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM score WHERE student_id = @studentId and course_id = @courseId ", mydb.getConnection);
            sqlCommand.Parameters.Add("@studentId", SqlDbType.Int).Value = studentId;
            sqlCommand.Parameters.Add("@courseId", SqlDbType.VarChar).Value = courseId;

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if(table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }    
        }

        public DataTable getAVG_Score_by_Course()
        {
            SqlCommand command = new SqlCommand("SELECT course.label, avg(score.student_score) as AVG FROM course, score where course.id = score.student_id GROUP BY course.label");

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

            
        }
        public DataTable getStudentScore()
        {
            SqlCommand command = new SqlCommand("SELECT score.student_id as StudentID, student.fname as Fname, student.lname as Lname, score.course_id as CourseID, course.label as Course, score.student_score as Score FROM student INNER JOIN score ON student.id = score.student_id INNER JOIN course ON score.course_id = course.id", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Error");
            }
                return table;
        }
    }
}
