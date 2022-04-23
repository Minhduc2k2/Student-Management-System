﻿using Student_Management_System;
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

        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DataGridView1.Rows.Count != 0)
            {
                int RowCount = DataGridView1.Rows.Count;
                int ColumnCount = DataGridView1.Columns.Count;
                Word.Document oDoc = new Word.Document();
                Thread.Sleep(10000);
                oDoc.Application.Visible = true;
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                //dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                Object oMissing = System.Reflection.Missing.Value;
                for (int r = 0; r <= RowCount - 1; r++)
                {
                    Thread.Sleep(10000);
                    oTemp = "";
                    for (int c = 0; c < ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataGridView1.Rows[r].Cells[c].Value + "\t";
                    }
                    var oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara1.Range.Text = oTemp;
                    oPara1.Range.InsertParagraphAfter();
                    byte[] imgbyte = (byte[])DataGridView1.Rows[r].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);
                    System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new
                    Size(90, 90)));
                    Clipboard.SetDataObject(finalPic);
                    var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara2.Range.Paste();
                    oPara2.Range.InsertParagraphAfter();
                    //oTemp += "\n";
                }
                //save the file
                oDoc.SaveAs2(filename);
            }

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
                    if (j == 7)
                    {
                        //worksheet.Cells[i + 2, j + 1] = DataGridView1.Rows[i].Cells[j].Value.ToString();
                        byte[] imgbyte = (byte[])DataGridView1.Rows[i].Cells[7].Value;
                        MemoryStream ms = new MemoryStream(imgbyte);
                        System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);
                        System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new
                        Size(90, 90)));
                        Clipboard.SetDataObject(finalPic);
                        worksheet.Cells[i + 2, j + 1] = DataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                        worksheet.Cells[i + 2, j + 1] = DataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("D:\\DUc\\Winform", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
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
