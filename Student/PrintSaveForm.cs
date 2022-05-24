using Microsoft.Office.Interop.Word;
using Student_Management_System;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace LoginForm
{
    public partial class PrintSaveForm : Form
    {
        public PrintSaveForm()
        {
            InitializeComponent();
        }
        Student student = new Student();
        private void PrintSaveForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet1.student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.myDBDataSet1.student);

            SqlCommand command = new SqlCommand("Select * from student");
            DataGridView1.ReadOnly = true;
            //Processing img
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 115;
            DataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }

        private void ButtonCheck_Click(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM student ";
            if(radioButtonNo.Checked)
            {
                if(radioButtonMale.Checked)
                {
                    strSQL += "WHERE gender =N'Male'";
                }
                else if(radioButtonFemale.Checked)
                {
                    strSQL += "WHERE gender =N'FeMale'";
                }
            }
            else if(radioButtonYes.Checked)
            {
                DateTime start = dateTimePicker1.Value;
                DateTime end = dateTimePicker2.Value;
                if (radioButtonAll.Checked)
                    strSQL += "WHERE bdate BETWEEN '" + start.ToString() + "' AND '" + end.ToString() + "'";
                else if(radioButtonMale.Checked)
                    strSQL += "WHERE gender =N'Male'" + " AND " + "bdate BETWEEN '" + start.ToString() + "' AND '" + end.ToString() +"'";
                else if(radioButtonFemale.Checked)
                    strSQL += "WHERE gender =N'FeMale'" + " AND " + "bdate BETWEEN '" + start.ToString() + "' AND '" + end.ToString() + "'";
            }

            SqlCommand command = new SqlCommand(strSQL);
            DataGridView1.ReadOnly = true;
            //Processing img
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 115;
            DataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }

        public void Export_Data_To_Word(DataGridView DataGridView1, string filename)
        {
            //if (DataGridView1.Rows.Count != 0)
            //{
            //    int RowCount = DataGridView1.Rows.Count;
            //    int ColumnCount = DataGridView1.Columns.Count;
            //    Word.Document oDoc = new Word.Document();
            //    oDoc.Application.Visible = true;
            //    oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
            //    //dynamic oRange = oDoc.Content.Application.Selection.Range;
            //    string oTemp = "";
            //    Object oMissing = System.Reflection.Missing.Value;
            //    for (int r = 0; r <= RowCount - 1; r++)
            //    {
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
            if (DataGridView1.Rows.Count != 0)
            {
                int RowCount = DataGridView1.Rows.Count;
                int ColumnCount = DataGridView1.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DataGridView1.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;

                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                    Type.Missing, Type.Missing, ref ApplyBorders,
                    Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();


                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DataGridView1.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");

                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment =
                    Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                //oDoc.Tables[1].Cell(1, 4).Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorDarkRed;
                oDoc.Tables[1].Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorWhite;
                //oDoc.Application.Selection.Tables[1].Rows[1].Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorBrightGreen;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Color = Word.WdColor.wdColorBlack;
                //header text
                /*foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    //headerRange.Text = "STUDENT";
                    //headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }*/

                int n = DataGridView1.Rows.Count;
                for (int i = 0; i < n; i++)
                {
                    byte[] imgbyte = (byte[])DataGridView1.Rows[i].Cells[7].Value;
                    Object oMissing = System.Reflection.Missing.Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);
                    System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new
                        Size(90, 90)));
                    Clipboard.SetDataObject(finalPic);
                    var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oDoc.Tables[1].Cell(2 + i, 8).Range.Paste();
                }
                //save the file
                oDoc.SaveAs2(filename);
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (.doc)|.doc";
            sfd.FileName = "Student.doc";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(DataGridView1, sfd.FileName);
                MessageBox.Show("Save successful!!!", "Save File docx", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            //for (int i = 0; i < DataGridView1.Rows.Count - 1; i++)
            //{
            //    for (int j = 0; j < DataGridView1.Columns.Count; j++)
            //    {
            //        if (j == 7)
            //        {
            //            //worksheet.Cells[i + 2, j + 1] = DataGridView1.Rows[i].Cells[j].Value.ToString();
            //            byte[] imgbyte = (byte[])DataGridView1.Rows[i].Cells[7].Value;
            //            MemoryStream ms = new MemoryStream(imgbyte);
            //            System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);
            //            System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new
            //            Size(90, 90)));
            //            Clipboard.SetDataObject(finalPic);
            //            worksheet.Cells[i + 2, j + 1] = DataGridView1.Rows[i].Cells[j].Value.ToString();
            //        }
            //        else
            //            worksheet.Cells[i + 2, j + 1] = DataGridView1.Rows[i].Cells[j].Value.ToString();
            //    }
            //}
            //// save the application  
            //workbook.SaveAs("D:\\DUc\\Winform", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //// Exit from the application  
            //app.Quit();



            //int RowCount = DataGridView1.Rows.Count;
            //int ColumnCount = DataGridView1.Columns.Count;
            //Word.Document oDoc = new Word.Document();
            //oDoc.Application.Visible = true;
            //oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
            ////dynamic oRange = oDoc.Content.Application.Selection.Range;
            //string oTemp = "";
            //Object oMissing = System.Reflection.Missing.Value;
            ///*oDoc.MailMerge.Execute(new[] {"MSSV"});
            //oDoc.MailMerge.Execute(new[] { "Tên" });
            //oDoc.MailMerge.Execute(new[] { "Tên lót" });
            //oDoc.MailMerge.Execute(new[] { "Ngày sinh" });
            //oDoc.MailMerge.Execute(new[] { "Giới tính" });
            //oDoc.MailMerge.Execute(new[] { "Số điện thoại" });
            //oDoc.MailMerge.Execute(new[] { "Địa chỉ" });
            //oDoc.MailMerge.Execute(new[] { "Hình ảnh" });*/
            //Microsoft.Office.Interop.Word.Range rng = oDoc.Range(0, 0);
            //Table thongtin = oDoc.Tables.Add(rng, DataGridView1.Rows.Count, DataGridView1.Columns.Count);
            //thongtin.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleDouble;
            //thongtin.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;

            //for (int r = 0; r <= RowCount - 1; r++)
            //{
            //    oTemp = "";
            //    for (int c = 0; c < ColumnCount - 1; c++)
            //    {
            //        //bdate.ToString("yyyy-MM-dd")
            //        oTemp = oTemp + DataGridView1.Rows[r].Cells[c].Value + " | ";
            //        thongtin.Cell(r + 1, c + 1).Range.InsertAfter(DataGridView1.Rows[r].Cells[c].Value.ToString());
            //        if (c == 7)
            //        {
            //            var oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
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
            //        }
            //    }
            //}
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
