
namespace LoginForm.Human_Resource
{
    partial class FullClass
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBoxId = new System.Windows.Forms.TextBox();
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.ButtonAssign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(51, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(55, 110);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 1);
            this.panel1.TabIndex = 41;
            // 
            // TextBoxId
            // 
            this.TextBoxId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TextBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxId.Enabled = false;
            this.TextBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxId.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBoxId.Location = new System.Drawing.Point(180, 81);
            this.TextBoxId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.Size = new System.Drawing.Size(249, 23);
            this.TextBoxId.TabIndex = 40;
            this.TextBoxId.Tag = "";
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 16;
            this.listBoxCourse.Location = new System.Drawing.Point(56, 160);
            this.listBoxCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(372, 324);
            this.listBoxCourse.TabIndex = 43;
            this.listBoxCourse.Click += new System.EventHandler(this.listBoxCourse_Click);
            // 
            // ButtonAssign
            // 
            this.ButtonAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.ButtonAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAssign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ButtonAssign.Location = new System.Drawing.Point(488, 74);
            this.ButtonAssign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAssign.Name = "ButtonAssign";
            this.ButtonAssign.Size = new System.Drawing.Size(219, 39);
            this.ButtonAssign.TabIndex = 63;
            this.ButtonAssign.Text = "Assign";
            this.ButtonAssign.UseVisualStyleBackColor = false;
            this.ButtonAssign.Click += new System.EventHandler(this.ButtonAssign_Click);
            // 
            // FullClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(721, 521);
            this.Controls.Add(this.ButtonAssign);
            this.Controls.Add(this.listBoxCourse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextBoxId);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FullClass";
            this.Text = "FullClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBoxId;
        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.Button ButtonAssign;
    }
}