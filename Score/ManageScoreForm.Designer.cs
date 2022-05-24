
namespace LoginForm
{
    partial class ManageScoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageScoreForm));
            this.myDBDataSet = new LoginForm.myDBDataSet();
            this.myDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet1 = new LoginForm.myDBDataSet1();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new LoginForm.myDBDataSet1TableAdapters.studentTableAdapter();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TextBoxScore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBoxStudentId = new System.Windows.Forms.TextBox();
            this.ButtonAddScore = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButtonRemoveScore = new System.Windows.Forms.Button();
            this.buttonAVG = new System.Windows.Forms.Button();
            this.buttonShowStudent = new System.Windows.Forms.Button();
            this.buttonShowScore = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(229, 211);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(236, 28);
            this.comboBoxCourse.TabIndex = 60;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDescription.Location = new System.Drawing.Point(216, 361);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(249, 103);
            this.TextBoxDescription.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(87, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 58;
            this.label6.Text = "Description: ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(92, 390);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 1);
            this.panel4.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(87, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Score:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(92, 320);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 1);
            this.panel3.TabIndex = 55;
            // 
            // TextBoxScore
            // 
            this.TextBoxScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TextBoxScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxScore.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBoxScore.Location = new System.Drawing.Point(229, 291);
            this.TextBoxScore.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxScore.Name = "TextBoxScore";
            this.TextBoxScore.Size = new System.Drawing.Size(236, 19);
            this.TextBoxScore.TabIndex = 54;
            this.TextBoxScore.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(87, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Select Course:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(92, 248);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 1);
            this.panel2.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(87, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Student ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(92, 181);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 1);
            this.panel1.TabIndex = 50;
            // 
            // TextBoxStudentId
            // 
            this.TextBoxStudentId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TextBoxStudentId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxStudentId.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBoxStudentId.Location = new System.Drawing.Point(229, 152);
            this.TextBoxStudentId.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxStudentId.Name = "TextBoxStudentId";
            this.TextBoxStudentId.ReadOnly = true;
            this.TextBoxStudentId.Size = new System.Drawing.Size(236, 19);
            this.TextBoxStudentId.TabIndex = 49;
            this.TextBoxStudentId.Tag = "";
            // 
            // ButtonAddScore
            // 
            this.ButtonAddScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.ButtonAddScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ButtonAddScore.Location = new System.Drawing.Point(92, 499);
            this.ButtonAddScore.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAddScore.Name = "ButtonAddScore";
            this.ButtonAddScore.Size = new System.Drawing.Size(158, 46);
            this.ButtonAddScore.TabIndex = 48;
            this.ButtonAddScore.Text = "Add";
            this.ButtonAddScore.UseVisualStyleBackColor = false;
            this.ButtonAddScore.Click += new System.EventHandler(this.ButtonAddCourse_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(507, 43);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(847, 502);
            this.DataGridView1.TabIndex = 61;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // ButtonRemoveScore
            // 
            this.ButtonRemoveScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.ButtonRemoveScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemoveScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemoveScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ButtonRemoveScore.Location = new System.Drawing.Point(307, 499);
            this.ButtonRemoveScore.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonRemoveScore.Name = "ButtonRemoveScore";
            this.ButtonRemoveScore.Size = new System.Drawing.Size(158, 46);
            this.ButtonRemoveScore.TabIndex = 62;
            this.ButtonRemoveScore.Text = "Remove";
            this.ButtonRemoveScore.UseVisualStyleBackColor = false;
            this.ButtonRemoveScore.Click += new System.EventHandler(this.ButtonRemoveScore_Click);
            // 
            // buttonAVG
            // 
            this.buttonAVG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonAVG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAVG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAVG.ForeColor = System.Drawing.Color.White;
            this.buttonAVG.Location = new System.Drawing.Point(91, 558);
            this.buttonAVG.Name = "buttonAVG";
            this.buttonAVG.Size = new System.Drawing.Size(374, 37);
            this.buttonAVG.TabIndex = 63;
            this.buttonAVG.Text = "AVG Score By Course";
            this.buttonAVG.UseVisualStyleBackColor = false;
            this.buttonAVG.Click += new System.EventHandler(this.buttonAVG_Click);
            // 
            // buttonShowStudent
            // 
            this.buttonShowStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonShowStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowStudent.ForeColor = System.Drawing.Color.White;
            this.buttonShowStudent.Location = new System.Drawing.Point(595, 558);
            this.buttonShowStudent.Name = "buttonShowStudent";
            this.buttonShowStudent.Size = new System.Drawing.Size(310, 37);
            this.buttonShowStudent.TabIndex = 64;
            this.buttonShowStudent.Text = "Show Student";
            this.buttonShowStudent.UseVisualStyleBackColor = false;
            this.buttonShowStudent.Click += new System.EventHandler(this.buttonShowStudent_Click);
            // 
            // buttonShowScore
            // 
            this.buttonShowScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonShowScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowScore.ForeColor = System.Drawing.Color.White;
            this.buttonShowScore.Location = new System.Drawing.Point(972, 558);
            this.buttonShowScore.Name = "buttonShowScore";
            this.buttonShowScore.Size = new System.Drawing.Size(310, 37);
            this.buttonShowScore.TabIndex = 65;
            this.buttonShowScore.Text = "Show Score";
            this.buttonShowScore.UseVisualStyleBackColor = false;
            this.buttonShowScore.Click += new System.EventHandler(this.buttonShowScore_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(229, 43);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1366, 607);
            this.Controls.Add(this.buttonShowScore);
            this.Controls.Add(this.buttonShowStudent);
            this.Controls.Add(this.buttonAVG);
            this.Controls.Add(this.ButtonRemoveScore);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TextBoxScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextBoxStudentId);
            this.Controls.Add(this.ButtonAddScore);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManageScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource myDBDataSetBindingSource;
        private myDBDataSet myDBDataSet;
        private myDBDataSet1 myDBDataSet1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private myDBDataSet1TableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TextBoxScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBoxStudentId;
        private System.Windows.Forms.Button ButtonAddScore;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button ButtonRemoveScore;
        private System.Windows.Forms.Button buttonAVG;
        private System.Windows.Forms.Button buttonShowStudent;
        private System.Windows.Forms.Button buttonShowScore;
    }
}