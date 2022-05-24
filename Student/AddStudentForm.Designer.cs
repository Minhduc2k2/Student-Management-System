
namespace Student_Management_System
{
    partial class AddStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentForm));
            this.ButtonAddStudent = new System.Windows.Forms.Button();
            this.TextBoxStudentId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxFname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TextBoxLname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.ButtonUploadImage = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxNotiFName = new System.Windows.Forms.Label();
            this.textBoxNotiLName = new System.Windows.Forms.Label();
            this.textBoxNotiBirthday = new System.Windows.Forms.Label();
            this.textBoxNotiPhone = new System.Windows.Forms.Label();
            this.textBoxNotiStudentID = new System.Windows.Forms.Label();
            this.textBoxNotiAddress = new System.Windows.Forms.Label();
            this.PictureBoxStudentImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAddStudent
            // 
            this.ButtonAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.ButtonAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ButtonAddStudent.Location = new System.Drawing.Point(271, 785);
            this.ButtonAddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAddStudent.Name = "ButtonAddStudent";
            this.ButtonAddStudent.Size = new System.Drawing.Size(175, 46);
            this.ButtonAddStudent.TabIndex = 5;
            this.ButtonAddStudent.Text = "Add";
            this.ButtonAddStudent.UseVisualStyleBackColor = false;
            this.ButtonAddStudent.Click += new System.EventHandler(this.ButtonAddStudent_Click);
            // 
            // TextBoxStudentId
            // 
            this.TextBoxStudentId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TextBoxStudentId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxStudentId.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBoxStudentId.Location = new System.Drawing.Point(197, 177);
            this.TextBoxStudentId.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxStudentId.Name = "TextBoxStudentId";
            this.TextBoxStudentId.Size = new System.Drawing.Size(249, 23);
            this.TextBoxStudentId.TabIndex = 7;
            this.TextBoxStudentId.Tag = "";
            this.TextBoxStudentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxStudentId_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(73, 206);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 1);
            this.panel1.TabIndex = 8;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.Location = new System.Drawing.Point(73, 785);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(175, 46);
            this.ButtonCancel.TabIndex = 12;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Student ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "First Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(73, 273);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 1);
            this.panel2.TabIndex = 17;
            // 
            // TextBoxFname
            // 
            this.TextBoxFname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TextBoxFname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxFname.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBoxFname.Location = new System.Drawing.Point(197, 244);
            this.TextBoxFname.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxFname.Name = "TextBoxFname";
            this.TextBoxFname.Size = new System.Drawing.Size(249, 23);
            this.TextBoxFname.TabIndex = 16;
            this.TextBoxFname.Tag = "";
            this.TextBoxFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFname_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Last Name:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(73, 345);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 1);
            this.panel3.TabIndex = 20;
            // 
            // TextBoxLname
            // 
            this.TextBoxLname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TextBoxLname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLname.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBoxLname.Location = new System.Drawing.Point(197, 316);
            this.TextBoxLname.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxLname.Name = "TextBoxLname";
            this.TextBoxLname.Size = new System.Drawing.Size(249, 23);
            this.TextBoxLname.TabIndex = 19;
            this.TextBoxLname.Tag = "";
            this.TextBoxLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLname_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Phone:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(73, 544);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(373, 1);
            this.panel4.TabIndex = 29;
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TextBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPhone.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBoxPhone.Location = new System.Drawing.Point(197, 515);
            this.TextBoxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(249, 23);
            this.TextBoxPhone.TabIndex = 28;
            this.TextBoxPhone.Tag = "";
            this.TextBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPhone_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Gender:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(73, 472);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(75, 1);
            this.panel5.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Birthday:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(73, 405);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(75, 1);
            this.panel6.TabIndex = 23;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.RadioButtonFemale);
            this.panel7.Controls.Add(this.RadioButtonMale);
            this.panel7.Location = new System.Drawing.Point(193, 431);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(253, 42);
            this.panel7.TabIndex = 32;
            // 
            // RadioButtonFemale
            // 
            this.RadioButtonFemale.AutoSize = true;
            this.RadioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonFemale.Location = new System.Drawing.Point(113, 10);
            this.RadioButtonFemale.Name = "RadioButtonFemale";
            this.RadioButtonFemale.Size = new System.Drawing.Size(98, 29);
            this.RadioButtonFemale.TabIndex = 1;
            this.RadioButtonFemale.Text = "Female";
            this.RadioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.Checked = true;
            this.RadioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonMale.Location = new System.Drawing.Point(4, 10);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(76, 29);
            this.RadioButtonMale.TabIndex = 0;
            this.RadioButtonMale.TabStop = true;
            this.RadioButtonMale.Text = "Male";
            this.RadioButtonMale.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 582);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 25);
            this.label9.TabIndex = 35;
            this.label9.Text = "Address:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(73, 611);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(373, 1);
            this.panel8.TabIndex = 34;
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TextBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAddress.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBoxAddress.Location = new System.Drawing.Point(197, 582);
            this.TextBoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(249, 23);
            this.TextBoxAddress.TabIndex = 33;
            this.TextBoxAddress.Tag = "";
            this.TextBoxAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAddress_KeyPress);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.ForeColor = System.Drawing.SystemColors.Window;
            this.panel9.Location = new System.Drawing.Point(69, 679);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(75, 1);
            this.panel9.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(64, 650);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 25);
            this.label10.TabIndex = 38;
            this.label10.Text = "Avatar:";
            // 
            // ButtonUploadImage
            // 
            this.ButtonUploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ButtonUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUploadImage.ForeColor = System.Drawing.Color.White;
            this.ButtonUploadImage.Location = new System.Drawing.Point(88, 697);
            this.ButtonUploadImage.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonUploadImage.Name = "ButtonUploadImage";
            this.ButtonUploadImage.Size = new System.Drawing.Size(90, 35);
            this.ButtonUploadImage.TabIndex = 40;
            this.ButtonUploadImage.Text = "Upload";
            this.ButtonUploadImage.UseVisualStyleBackColor = false;
            this.ButtonUploadImage.Click += new System.EventHandler(this.ButtonUploadImage_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(193, 376);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 30);
            this.dateTimePicker1.TabIndex = 41;
            this.dateTimePicker1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePicker1_KeyPress);
            // 
            // textBoxNotiFName
            // 
            this.textBoxNotiFName.AutoSize = true;
            this.textBoxNotiFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotiFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.textBoxNotiFName.Location = new System.Drawing.Point(84, 291);
            this.textBoxNotiFName.Name = "textBoxNotiFName";
            this.textBoxNotiFName.Size = new System.Drawing.Size(0, 20);
            this.textBoxNotiFName.TabIndex = 46;
            // 
            // textBoxNotiLName
            // 
            this.textBoxNotiLName.AutoSize = true;
            this.textBoxNotiLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotiLName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.textBoxNotiLName.Location = new System.Drawing.Point(84, 354);
            this.textBoxNotiLName.Name = "textBoxNotiLName";
            this.textBoxNotiLName.Size = new System.Drawing.Size(0, 20);
            this.textBoxNotiLName.TabIndex = 47;
            // 
            // textBoxNotiBirthday
            // 
            this.textBoxNotiBirthday.AutoSize = true;
            this.textBoxNotiBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotiBirthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.textBoxNotiBirthday.Location = new System.Drawing.Point(84, 410);
            this.textBoxNotiBirthday.Name = "textBoxNotiBirthday";
            this.textBoxNotiBirthday.Size = new System.Drawing.Size(0, 20);
            this.textBoxNotiBirthday.TabIndex = 48;
            // 
            // textBoxNotiPhone
            // 
            this.textBoxNotiPhone.AutoSize = true;
            this.textBoxNotiPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotiPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.textBoxNotiPhone.Location = new System.Drawing.Point(84, 562);
            this.textBoxNotiPhone.Name = "textBoxNotiPhone";
            this.textBoxNotiPhone.Size = new System.Drawing.Size(0, 20);
            this.textBoxNotiPhone.TabIndex = 49;
            // 
            // textBoxNotiStudentID
            // 
            this.textBoxNotiStudentID.AutoSize = true;
            this.textBoxNotiStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotiStudentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.textBoxNotiStudentID.Location = new System.Drawing.Point(84, 215);
            this.textBoxNotiStudentID.Name = "textBoxNotiStudentID";
            this.textBoxNotiStudentID.Size = new System.Drawing.Size(0, 20);
            this.textBoxNotiStudentID.TabIndex = 50;
            // 
            // textBoxNotiAddress
            // 
            this.textBoxNotiAddress.AutoSize = true;
            this.textBoxNotiAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotiAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.textBoxNotiAddress.Location = new System.Drawing.Point(84, 630);
            this.textBoxNotiAddress.Name = "textBoxNotiAddress";
            this.textBoxNotiAddress.Size = new System.Drawing.Size(0, 20);
            this.textBoxNotiAddress.TabIndex = 51;
            // 
            // PictureBoxStudentImage
            // 
            this.PictureBoxStudentImage.Location = new System.Drawing.Point(249, 630);
            this.PictureBoxStudentImage.Name = "PictureBoxStudentImage";
            this.PictureBoxStudentImage.Size = new System.Drawing.Size(125, 125);
            this.PictureBoxStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxStudentImage.TabIndex = 39;
            this.PictureBoxStudentImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(509, 864);
            this.Controls.Add(this.textBoxNotiAddress);
            this.Controls.Add(this.textBoxNotiStudentID);
            this.Controls.Add(this.textBoxNotiPhone);
            this.Controls.Add(this.textBoxNotiBirthday);
            this.Controls.Add(this.textBoxNotiLName);
            this.Controls.Add(this.textBoxNotiFName);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ButtonUploadImage);
            this.Controls.Add(this.PictureBoxStudentImage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TextBoxLname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TextBoxFname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextBoxStudentId);
            this.Controls.Add(this.ButtonAddStudent);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudentForm";
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonAddStudent;
        private System.Windows.Forms.TextBox TextBoxStudentId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TextBoxFname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TextBoxLname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TextBoxPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton RadioButtonFemale;
        private System.Windows.Forms.RadioButton RadioButtonMale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox TextBoxAddress;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox PictureBoxStudentImage;
        private System.Windows.Forms.Button ButtonUploadImage;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label textBoxNotiFName;
        private System.Windows.Forms.Label textBoxNotiLName;
        private System.Windows.Forms.Label textBoxNotiBirthday;
        private System.Windows.Forms.Label textBoxNotiPhone;
        private System.Windows.Forms.Label textBoxNotiStudentID;
        private System.Windows.Forms.Label textBoxNotiAddress;
    }
}

