using Aspose.Words;
using Aspose.Words.Tables;
using ThuVienWinform.Report.AsposeWordExtension;
//using Microsoft.Office.Interop.Word;
using Student_Management_System;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace LoginForm
{
    public partial class PrintSaveCourseForm : Form
    {
        public PrintSaveCourseForm()
        {
            InitializeComponent();
        }
        Student student = new Student();
        private void PrintSaveCourseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet2.course' table. You can move, or remove it, as needed.
            //this.courseTableAdapter.Fill(this.myDBDataSet2.course);

            SqlCommand command = new SqlCommand("Select * from course");
            DataGridView1.ReadOnly = true;
            //Processing img
            DataGridView1.RowTemplate.Height = 115;
            DataGridView1.DataSource = student.getStudents(command);
            DataGridView1.AllowUserToAddRows = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            Document baoCao = new Document("Template\\Cource.doc");

            // Add thông tin sinh viên vào word
            baoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format("TP Hồ Chí Minh, ngày {0} tháng {1} năm {2}", now.Day, now.Month, now.Year) });


            // Add thông tin điểm vào bảng
            Table bangCource = baoCao.GetChild(NodeType.Table, 1, true) as Table;

            int hangHienTai = 1;

            bangCource.InsertRows(hangHienTai, hangHienTai, DataGridView1.Rows.Count - 1);

            for (int i = 0; i < DataGridView1.Rows.Count; i++)
            {
                bangCource.PutValue(hangHienTai, 0, (i + 1).ToString());
                bangCource.PutValue(hangHienTai, 1, DataGridView1.Rows[i].Cells[1].Value.ToString().Trim());
                bangCource.PutValue(hangHienTai, 2, DataGridView1.Rows[i].Cells[2].Value.ToString().Trim());
                bangCource.PutValue(hangHienTai, 3, DataGridView1.Rows[i].Cells[3].Value.ToString().Trim());
                ++hangHienTai;
            }

            SaveFileDialog saveF = new SaveFileDialog();
            saveF.Title = "Export Word";
            saveF.Filter = "Word (*.doc)|*.doc";

            if (saveF.ShowDialog() == DialogResult.OK)
            {
                baoCao.Save(saveF.FileName);
                MessageBox.Show("Save Done", "Save Word", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Save Fail", "Save Word", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }
    }
}
