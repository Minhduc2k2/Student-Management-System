
namespace LoginForm
{
    partial class AddSemesterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.myDBDataSet = new LoginForm.myDBDataSet();
            this.myDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet1 = new LoginForm.myDBDataSet1();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new LoginForm.myDBDataSet1TableAdapters.studentTableAdapter();
            this.listBoxSelectedCourse = new System.Windows.Forms.ListBox();
            this.listBoxAvailableCourse = new System.Windows.Forms.ListBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonAddCourse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumericUpDownSemester = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBoxStudentId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownSemester)).BeginInit();
            this.SuspendLayout();
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "myDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myDBDataSetBindingSource
            // 
            this.myDBDataSetBindingSource.DataSource = this.myDBDataSet;
            this.myDBDataSetBindingSource.Position = 0;
            // 
            // myDBDataSet1
            // 
            this.myDBDataSet1.DataSetName = "myDBDataSet1";
            this.myDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.myDBDataSet1;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // listBoxSelectedCourse
            // 
            this.listBoxSelectedCourse.FormattingEnabled = true;
            this.listBoxSelectedCourse.ItemHeight = 25;
            this.listBoxSelectedCourse.Location = new System.Drawing.Point(434, 189);
            this.listBoxSelectedCourse.Name = "listBoxSelectedCourse";
            this.listBoxSelectedCourse.Size = new System.Drawing.Size(280, 229);
            this.listBoxSelectedCourse.TabIndex = 56;
            // 
            // listBoxAvailableCourse
            // 
            this.listBoxAvailableCourse.FormattingEnabled = true;
            this.listBoxAvailableCourse.ItemHeight = 25;
            this.listBoxAvailableCourse.Location = new System.Drawing.Point(59, 189);
            this.listBoxAvailableCourse.Name = "listBoxAvailableCourse";
            this.listBoxAvailableCourse.Size = new System.Drawing.Size(280, 229);
            this.listBoxAvailableCourse.TabIndex = 55;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.Location = new System.Drawing.Point(345, 337);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(82, 37);
            this.ButtonCancel.TabIndex = 54;
            this.ButtonCancel.Text = "Save";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonAddCourse
            // 
            this.ButtonAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.ButtonAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ButtonAddCourse.Location = new System.Drawing.Point(345, 256);
            this.ButtonAddCourse.Name = "ButtonAddCourse";
            this.ButtonAddCourse.Size = new System.Drawing.Size(82, 39);
            this.ButtonAddCourse.TabIndex = 53;
            this.ButtonAddCourse.Text = "Add";
            this.ButtonAddCourse.UseVisualStyleBackColor = false;
            this.ButtonAddCourse.Click += new System.EventHandler(this.ButtonAddCourse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(489, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Selected Course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(113, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Available Course";
            // 
            // NumericUpDownSemester
            // 
            this.NumericUpDownSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDownSemester.Location = new System.Drawing.Point(527, 64);
            this.NumericUpDownSemester.Margin = new System.Windows.Forms.Padding(2);
            this.NumericUpDownSemester.Name = "NumericUpDownSemester";
            this.NumericUpDownSemester.Size = new System.Drawing.Size(187, 30);
            this.NumericUpDownSemester.TabIndex = 50;
            this.NumericUpDownSemester.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(430, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Semester:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(55, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Student ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(59, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 1);
            this.panel1.TabIndex = 46;
            // 
            // TextBoxStudentId
            // 
            this.TextBoxStudentId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TextBoxStudentId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxStudentId.Enabled = false;
            this.TextBoxStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxStudentId.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBoxStudentId.Location = new System.Drawing.Point(164, 66);
            this.TextBoxStudentId.Name = "TextBoxStudentId";
            this.TextBoxStudentId.Size = new System.Drawing.Size(175, 23);
            this.TextBoxStudentId.TabIndex = 45;
            this.TextBoxStudentId.Tag = "";
            // 
            // AddSemesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(775, 484);
            this.Controls.Add(this.listBoxSelectedCourse);
            this.Controls.Add(this.listBoxAvailableCourse);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAddCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericUpDownSemester);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextBoxStudentId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddSemesterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSemesterForm";
            this.Load += new System.EventHandler(this.AddSemesterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownSemester)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource myDBDataSetBindingSource;
        private myDBDataSet myDBDataSet;
        private myDBDataSet1 myDBDataSet1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private myDBDataSet1TableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.ListBox listBoxSelectedCourse;
        private System.Windows.Forms.ListBox listBoxAvailableCourse;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonAddCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumericUpDownSemester;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBoxStudentId;
    }
}