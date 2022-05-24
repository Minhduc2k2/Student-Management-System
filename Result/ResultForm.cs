using Student_Management_System;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Aspose.Words;
using ThuVienWinform.Report.AsposeWordExtension;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;

namespace LoginForm
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }
        MY_DB myDB = new MY_DB();
        Course course = new Course();
        Score score = new Score();
        Student student = new Student();
        private void ResultForm_Load(object sender, EventArgs e)
        {
            int studentCount = int.Parse(student.getTotalStudent());
            int courseCount = int.Parse(course.totalCourse());
            SqlCommand command1 = new SqlCommand("select ID,fName as FirstName,lName as LastName from student ", myDB.getConnection);
            SqlCommand command2 = new SqlCommand("select id,label from course", myDB.getConnection);
            //Lấy Sinh Viên
            SqlDataAdapter adapter = new SqlDataAdapter(command1);
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            //Lấy Khoá Học
            System.Data.DataTable courseTable = new System.Data.DataTable();
            adapter = new SqlDataAdapter(command2);
            adapter.Fill(courseTable);
            for (int i = 0; i < courseCount; i++)
            {
                table.Columns.Add(courseTable.Rows[i].ItemArray[1].ToString(), typeof(string));
            }
            table.Columns.Add("Average Score", typeof(string));
            table.Columns.Add("Result", typeof(string));
            SqlCommand command3 = new SqlCommand();
            command3.Connection = myDB.getConnection;
            for (int i = 0; i < studentCount; i++)
            {
                string studentid = table.Rows[i].ItemArray[0].ToString();
                float AVGscore = 0;
                int count = 0;
                for (int j = 0; j < courseCount; j++)
                {

                    //command3.CommandText = ("SELECT label,student_score from score join course on score.course_id = course.id where student_id='" + studentid + "' and course_id='C" + (j+1) + "'");
                    //Fix 21/2/2022
                    command3.CommandText = ("SELECT label,student_score from score join course on score.course_id = course.id where student_id='" + studentid + "' and course_id='C" + (j + 1) + "' AND score.student_score IS NOT NULL");
                    //End
                    adapter = new SqlDataAdapter(command3);
                    System.Data.DataTable scoretable = new System.Data.DataTable();
                    adapter.Fill(scoretable);
                    if (scoretable.Rows.Count > 0)
                    {
                        table.Rows[i][scoretable.Rows[0].ItemArray[0].ToString()] = scoretable.Rows[0].ItemArray[1].ToString();
                        AVGscore += int.Parse(scoretable.Rows[0].ItemArray[1].ToString());
                        count++;
                    }
                }
                AVGscore = AVGscore / count;
                table.Rows[i]["Average Score"] = AVGscore.ToString();
                if(Score.flag == false)
                {
                    table.Rows[i]["Result"] = CheckResult(AVGscore);
                }
                else
                {
                    table.Rows[i]["Result"] = CheckResult_NOADD(AVGscore);
                }
            }
            DataGridView1.DataSource = table;
            Score.flag = true;
        }
        public string CheckResult(float AVGscore)
        {
            if (AVGscore >= 9)
            {
                Score.student_gioi += 1;
                Score.student_pass += 1;
                return "Pass";
            }
            else if (AVGscore >= 8)
            {
                Score.student_kha += 1;
                Score.student_pass += 1;
                return "Pass";
            }
            else if (AVGscore >= 5)
            {
                Score.student_trungbinh += 1;
                Score.student_pass += 1;
                return "Pass";
            }
            else
            {
                Score.student_yeu += 1;
                Score.student_fail += 1;
                return "Fail";
            }
        }
        public string CheckResult_NOADD(float AVGscore)
        {
            if (AVGscore >= 9)
            {
                return "Pass";
            }
            else if (AVGscore >= 8)
            {
                return "Pass";
            }
            else if(AVGscore >= 5)
            {
                return "Pass";
            }
            else
            {
                return "Fail";
            }
        }
        private void ButtonFind_Click(object sender, EventArgs e)
        {
            //SqlCommand command = new SqlCommand("Select * from student where CONCAT(fname, lname, address) LIKE N'%" + textBoxFind.Text + "%'");
            textBoxSearch.Text = TextBoxStudentId.Text + TextBoxFname.Text + TextBoxLname.Text;
            int studentCount = int.Parse(student.getTotalStudent());
            int courseCount = int.Parse(course.totalCourse());
            SqlCommand command1 = new SqlCommand("select ID,fName as FirstName,lName as LastName from student where CONCAT(id,fname, lname) LIKE N'%" + textBoxSearch.Text + "%'", myDB.getConnection);
            SqlCommand command2 = new SqlCommand("select id,label from course", myDB.getConnection);
            //Lấy Sinh Viên
            SqlDataAdapter adapter = new SqlDataAdapter(command1);
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            int myCol = table.Rows.Count;
            //Lấy Khoá Học
            System.Data.DataTable courseTable = new System.Data.DataTable();
            adapter = new SqlDataAdapter(command2);
            adapter.Fill(courseTable);
            for (int i = 0; i < courseCount; i++)
            {
                table.Columns.Add(courseTable.Rows[i].ItemArray[1].ToString(), typeof(string));
            }
            table.Columns.Add("Average Score", typeof(string));
            table.Columns.Add("Result", typeof(string));
            SqlCommand command3 = new SqlCommand();
            command3.Connection = myDB.getConnection;
            for (int i = 0; i < myCol; i++)
            {
                string studentid = table.Rows[i].ItemArray[0].ToString();
                float AVGscore = 0;
                int count = 0;
                for (int j = 0; j < courseCount; j++)
                {
                    command3.CommandText = ("SELECT label,student_score from score join course on score.course_id = course.id where student_id='" + studentid + "' and course_id='C" + (j + 1) + "'");
                    adapter = new SqlDataAdapter(command3);
                    System.Data.DataTable scoretable = new System.Data.DataTable();
                    adapter.Fill(scoretable);
                    if (scoretable.Rows.Count > 0)
                    {
                        table.Rows[i][scoretable.Rows[0].ItemArray[0].ToString()] = scoretable.Rows[0].ItemArray[1].ToString();
                        AVGscore += int.Parse(scoretable.Rows[0].ItemArray[1].ToString());
                        count++;
                    }
                }
                AVGscore = AVGscore / count;
                table.Rows[i]["Average Score"] = AVGscore.ToString();
                table.Rows[i]["Result"] = CheckResult_NOADD(AVGscore);
            }
            DataGridView1.DataSource = table;

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < DataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = DataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < DataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < DataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = DataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("D:\\DUc\\ResultOfStudent", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int RowCount = DataGridView1.Rows.Count;
            int ColumnCount = DataGridView1.Columns.Count;
            Word.Document oDoc = new Word.Document();
            oDoc.Application.Visible = true;
            oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
            //dynamic oRange = oDoc.Content.Application.Selection.Range;
            string oTemp = "";
            Object oMissing = System.Reflection.Missing.Value;
            /*oDoc.MailMerge.Execute(new[] {"MSSV"});
            oDoc.MailMerge.Execute(new[] { "Tên" });
            oDoc.MailMerge.Execute(new[] { "Tên lót" });
            oDoc.MailMerge.Execute(new[] { "Ngày sinh" });
            oDoc.MailMerge.Execute(new[] { "Giới tính" });
            oDoc.MailMerge.Execute(new[] { "Số điện thoại" });
            oDoc.MailMerge.Execute(new[] { "Địa chỉ" });
            oDoc.MailMerge.Execute(new[] { "Hình ảnh" });*/
            Microsoft.Office.Interop.Word.Range rng = oDoc.Range(0, 0);
            Table thongtin = oDoc.Tables.Add(rng, DataGridView1.Rows.Count, DataGridView1.Columns.Count);
            thongtin.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleDouble;
            thongtin.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;

            for (int r = 0; r < RowCount - 1; r++)
            {
                oTemp = "";
                for (int c = 0; c < ColumnCount; c++)
                {
                    //bdate.ToString("yyyy-MM-dd")
                    oTemp = oTemp + DataGridView1.Rows[r].Cells[c].Value + " | ";
                    thongtin.Cell(r + 1, c + 1).Range.InsertAfter(DataGridView1.Rows[r].Cells[c].Value.ToString());
                }
            }
        }
    }
}
