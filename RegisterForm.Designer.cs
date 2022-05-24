
namespace Student_Management_System
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.buttonRegister = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TextBoxRePassword = new System.Windows.Forms.TextBox();
            this.textBoxNotiUserName = new System.Windows.Forms.Label();
            this.textBoxNotiPassword = new System.Windows.Forms.Label();
            this.textBoxNotiRePassword = new System.Windows.Forms.Label();
            this.textBoxNotiEmail = new System.Windows.Forms.Label();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonRegister.Location = new System.Drawing.Point(72, 525);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(373, 46);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(209, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(72, 233);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 1);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(72, 319);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 1);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBoxPassword.Location = new System.Drawing.Point(209, 288);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(236, 23);
            this.TextBoxPassword.TabIndex = 10;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            this.TextBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassword_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "UserName: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TextBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUserName.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBoxUserName.Location = new System.Drawing.Point(209, 202);
            this.TextBoxUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(236, 23);
            this.TextBoxUserName.TabIndex = 15;
            this.TextBoxUserName.TextChanged += new System.EventHandler(this.TextBoxUserName_TextChanged);
            this.TextBoxUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxUserName_KeyPress);
            this.TextBoxUserName.Leave += new System.EventHandler(this.TextBoxUserName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Re-Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(72, 402);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 1);
            this.panel3.TabIndex = 17;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // TextBoxRePassword
            // 
            this.TextBoxRePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TextBoxRePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxRePassword.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBoxRePassword.Location = new System.Drawing.Point(209, 370);
            this.TextBoxRePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxRePassword.Name = "TextBoxRePassword";
            this.TextBoxRePassword.Size = new System.Drawing.Size(236, 23);
            this.TextBoxRePassword.TabIndex = 19;
            this.TextBoxRePassword.UseSystemPasswordChar = true;
            this.TextBoxRePassword.TextChanged += new System.EventHandler(this.TextBoxRePassword_TextChanged);
            this.TextBoxRePassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxRePassword_KeyPress);
            // 
            // textBoxNotiUserName
            // 
            this.textBoxNotiUserName.AutoSize = true;
            this.textBoxNotiUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotiUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.textBoxNotiUserName.Location = new System.Drawing.Point(84, 247);
            this.textBoxNotiUserName.Name = "textBoxNotiUserName";
            this.textBoxNotiUserName.Size = new System.Drawing.Size(0, 20);
            this.textBoxNotiUserName.TabIndex = 20;
            this.textBoxNotiUserName.Click += new System.EventHandler(this.textBoxNotiUserName_Click);
            // 
            // textBoxNotiPassword
            // 
            this.textBoxNotiPassword.AutoSize = true;
            this.textBoxNotiPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotiPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.textBoxNotiPassword.Location = new System.Drawing.Point(84, 335);
            this.textBoxNotiPassword.Name = "textBoxNotiPassword";
            this.textBoxNotiPassword.Size = new System.Drawing.Size(0, 20);
            this.textBoxNotiPassword.TabIndex = 21;
            this.textBoxNotiPassword.Click += new System.EventHandler(this.textBoxNotiPassword_Click);
            // 
            // textBoxNotiRePassword
            // 
            this.textBoxNotiRePassword.AutoSize = true;
            this.textBoxNotiRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotiRePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.textBoxNotiRePassword.Location = new System.Drawing.Point(84, 416);
            this.textBoxNotiRePassword.Name = "textBoxNotiRePassword";
            this.textBoxNotiRePassword.Size = new System.Drawing.Size(0, 20);
            this.textBoxNotiRePassword.TabIndex = 22;
            this.textBoxNotiRePassword.Click += new System.EventHandler(this.textBoxNotiRePassword_Click);
            // 
            // textBoxNotiEmail
            // 
            this.textBoxNotiEmail.AutoSize = true;
            this.textBoxNotiEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotiEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.textBoxNotiEmail.Location = new System.Drawing.Point(84, 491);
            this.textBoxNotiEmail.Name = "textBoxNotiEmail";
            this.textBoxNotiEmail.Size = new System.Drawing.Size(0, 20);
            this.textBoxNotiEmail.TabIndex = 26;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBoxEmail.Location = new System.Drawing.Point(209, 445);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(236, 23);
            this.TextBoxEmail.TabIndex = 25;
            this.TextBoxEmail.UseSystemPasswordChar = true;
            this.TextBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxEmail_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Email:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(72, 477);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(373, 1);
            this.panel4.TabIndex = 23;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(505, 614);
            this.Controls.Add(this.textBoxNotiEmail);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBoxNotiRePassword);
            this.Controls.Add(this.textBoxNotiPassword);
            this.Controls.Add(this.textBoxNotiUserName);
            this.Controls.Add(this.TextBoxRePassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TextBoxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TextBoxRePassword;
        private System.Windows.Forms.Label textBoxNotiUserName;
        private System.Windows.Forms.Label textBoxNotiPassword;
        private System.Windows.Forms.Label textBoxNotiRePassword;
        private System.Windows.Forms.Label textBoxNotiEmail;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
    }
}

