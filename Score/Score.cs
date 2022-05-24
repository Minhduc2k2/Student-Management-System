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
    public class Score
    {
        MY_DB mydb = new MY_DB();
        public static int student_gioi = 0;
        public static int student_kha = 0;
        public static int student_trungbinh = 0;
        public static int student_yeu = 0;
        public static int student_pass = 0;
        public static int student_fail= 0;
        public static bool flag = false;
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
        public bool insertScore(int studentId, string courseId, int semester)
        {
            mydb.openConnection();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO score(student_id, course_id, semester) VALUES(@student_id, @course_id, @semester)", mydb.getConnection);
            sqlCommand.Parameters.Add("@student_id", SqlDbType.Int).Value = studentId;
            sqlCommand.Parameters.Add("@course_id", SqlDbType.VarChar).Value = courseId;
            sqlCommand.Parameters.Add("@semester", SqlDbType.Int).Value = semester;

            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool updateScore(int studentId, string courseId, float studentScore, string description, int semester)
        {
            mydb.openConnection();
            SqlCommand sqlCommand = new SqlCommand("UPDATE score SET student_score = @student_score, description = @description WHERE student_id = @student_id AND course_id = @course_id AND semester = @semester", mydb.getConnection);
            sqlCommand.Parameters.Add("@student_id", SqlDbType.Int).Value = studentId;
            sqlCommand.Parameters.Add("@course_id", SqlDbType.VarChar).Value = courseId;
            sqlCommand.Parameters.Add("@student_score", SqlDbType.Float).Value = studentScore;
            sqlCommand.Parameters.Add("@description", SqlDbType.Text).Value = description;
            sqlCommand.Parameters.Add("@semester", SqlDbType.Int).Value = semester;

            if (sqlCommand.ExecuteNonQuery() == 1)
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
            if(command.ExecuteNonQuery() > 0)
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
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM score WHERE student_id = @studentId and course_id = @courseId and student_score IS NOT NULL", mydb.getConnection);
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
            SqlCommand command = new SqlCommand("SELECT course.label as Course, avg(score.student_score) as AVG FROM course, score where course.id = score.course_id GROUP BY course.label", mydb.getConnection);
            mydb.openConnection();
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
        public DataTable getStudentScoreByCourseId(string course_id)
        {
            SqlCommand command = new SqlCommand("SELECT score.student_id as StudentID, student.fname as Fname, student.lname as Lname, score.course_id as CourseID, course.label as Course, score.student_score as Score FROM student INNER JOIN score ON student.id = score.student_id INNER JOIN course ON score.course_id = course.id WHERE score.course_id = @course_id", mydb.getConnection);
            command.Parameters.Add("@course_id", SqlDbType.NVarChar).Value = course_id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Error");
            }
            return table;
        }
        public string getCourseIdbyName(string name)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT course.id FROM course WHERE course.label = @name ", mydb.getConnection);
            sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            mydb.openConnection();
            MessageBox.Show(sqlCommand.ExecuteScalar().ToString());
            return sqlCommand.ExecuteScalar().ToString();
                
        }
    }
}
