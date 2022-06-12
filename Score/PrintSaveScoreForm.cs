using Student_Management_System;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing.Printing;
using Aspose.Words.Tables;
using Aspose.Words;
using ThuVienWinform.Report.AsposeWordExtension;

namespace LoginForm
{
    public partial class PrintSaveScoreForm : Form
    {
        public PrintSaveScoreForm()
        {
            InitializeComponent();
        }
        Score score = new Score();
        private void PrintSaveScoreForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet2.course' table. You can move, or remove it, as needed.
            //this.courseTableAdapter.Fill(this.myDBDataSet2.course);

            //SqlCommand command = new SqlCommand("Select id, fname, lname from student");
            DataGridView1.ReadOnly = true;
            //Processing img
            //DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            //DataGridView1.RowTemplate.Height = 115;
            DataGridView1.RowTemplate.Height = 115;
            DataGridView1.DataSource = score.getStudentScore();
            //picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            //picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            //if (DataGridView1.Rows.Count != 0)
            //{
            //    int RowCount = DataGridView1.Rows.Count;
            //    int ColumnCount = DataGridView1.Columns.Count;
            //    Word.Document oDoc = new Word.Document();
            //    Thread.Sleep(10000);
            //    oDoc.Application.Visible = true;
            //    oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
            //    //dynamic oRange = oDoc.Content.Application.Selection.Range;
            //    string oTemp = "";
            //    Object oMissing = System.Reflection.Missing.Value;
            //    for (int r = 0; r <= RowCount - 1; r++)
            //    {
            //        Thread.Sleep(10000);
            //        oTemp = "";
            //        for (int c = 0; c < ColumnCount - 1; c++)
            //        {
            //            oTemp = oTemp + DataGridView1.Rows[r].Cells[c].Value + "\t";
            //        }
            //        var oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            //        oPara1.Range.Text = oTemp;
            //        oPara1.Range.InsertParagraphAfter();
            //        byte[] imgbyte = (byte[])DataGridView1.Rows[r].Cells[7].Value;
            //        MemoryStream ms = new MemoryStream(imgbyte);
            //        System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);
            //        System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new
            //        Size(90, 90)));
            //        Clipboard.SetDataObject(finalPic);
            //        var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
            //        oPara2.Range.Paste();
            //        oPara2.Range.InsertParagraphAfter();
            //        //oTemp += "\n";
            //    }
            //    //save the file
            //    oDoc.SaveAs2(filename);
            //}

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "Word Documents (.docx)|.docx";
            //sfd.FileName = "student.docx";
            //if (sfd.ShowDialog() == DialogResult.OK)
            //{
            //    Export_Data_To_Word(DataGridView1, sfd.FileName);
            //    MessageBox.Show("Save successful!!!", "Save File docx", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}



            //// creating Excel Application  
            //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //// creating new WorkBook within Excel application  
            //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //// creating new Excelsheet in workbook  
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            //// see the excel sheet behind the program  
            //app.Visible = true;
            //// get the reference of first sheet. By default its name is Sheet1.  
            //// store its reference to worksheet  
            //worksheet = workbook.Sheets["Sheet1"];
            //worksheet = workbook.ActiveSheet;
            //// changing the name of active sheet  
            //worksheet.Name = "Exported from gridview";
            //// storing header part in Excel  
            //for (int i = 1; i < DataGridView1.Columns.Count + 1; i++)
            //{
            //    worksheet.Cells[1, i] = DataGridView1.Columns[i - 1].HeaderText;
            //}
            //// storing Each row and column value to excel sheet  
            //for (int i = 0; i < DataGridView1.Rows.Count; i++)
            //{
            //    for (int j = 0; j < DataGridView1.Columns.Count; j++)
            //    {
            //        worksheet.Cells[i + 2, j + 1] = DataGridView1.Rows[i].Cells[j].Value.ToString();
            //    }
            //}
            //// save the application  
            //workbook.SaveAs("D:\\DUc\\Score", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //// Exit from the application  
            //app.Quit();

            var now = DateTime.Now;
            Document baoCao = new Document("Template\\Score.doc");

            // Add thông tin sinh viên vào word
            baoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format("TP Hồ Chí Minh, ngày {0} tháng {1} năm {2}", now.Day, now.Month, now.Year) });


            // Add thông tin điểm vào bảng
            Table bangCource = baoCao.GetChild(NodeType.Table, 1, true) as Table;

            int hangHienTai = 1;

            bangCource.InsertRows(hangHienTai, hangHienTai, DataGridView1.Rows.Count - 1);

            for (int i = 0; i < DataGridView1.Rows.Count; i++)
            {
                bangCource.PutValue(hangHienTai, 0, DataGridView1.Rows[i].Cells[0].Value.ToString().Trim());
                bangCource.PutValue(hangHienTai, 1, DataGridView1.Rows[i].Cells[1].Value.ToString().Trim());
                bangCource.PutValue(hangHienTai, 2, DataGridView1.Rows[i].Cells[2].Value.ToString().Trim());
                bangCource.PutValue(hangHienTai, 3, DataGridView1.Rows[i].Cells[3].Value.ToString().Trim());
                bangCource.PutValue(hangHienTai, 4, DataGridView1.Rows[i].Cells[4].Value.ToString().Trim());
                bangCource.PutValue(hangHienTai, 5, DataGridView1.Rows[i].Cells[5].Value.ToString().Trim());
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
