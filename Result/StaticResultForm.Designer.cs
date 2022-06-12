
namespace LoginForm.Result
{
    partial class StaticResultForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonShowPassFail = new System.Windows.Forms.Button();
            this.buttonShowScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(124, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "STATISTICS BY COURSE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(675, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "STATISTICS BY COURSE";
            // 
            // buttonShowPassFail
            // 
            this.buttonShowPassFail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.buttonShowPassFail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowPassFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowPassFail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonShowPassFail.Location = new System.Drawing.Point(681, 623);
            this.buttonShowPassFail.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowPassFail.Name = "buttonShowPassFail";
            this.buttonShowPassFail.Size = new System.Drawing.Size(296, 52);
            this.buttonShowPassFail.TabIndex = 63;
            this.buttonShowPassFail.Text = "Show Chart";
            this.buttonShowPassFail.UseVisualStyleBackColor = false;
            this.buttonShowPassFail.Click += new System.EventHandler(this.buttonShowPassFail_Click);
            // 
            // buttonShowScore
            // 
            this.buttonShowScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.buttonShowScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonShowScore.Location = new System.Drawing.Point(130, 623);
            this.buttonShowScore.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowScore.Name = "buttonShowScore";
            this.buttonShowScore.Size = new System.Drawing.Size(296, 52);
            this.buttonShowScore.TabIndex = 64;
            this.buttonShowScore.Text = "Show Chart";
            this.buttonShowScore.UseVisualStyleBackColor = false;
            this.buttonShowScore.Click += new System.EventHandler(this.buttonShowScore_Click);
            // 
            // StaticResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1125, 748);
            this.Controls.Add(this.buttonShowScore);
            this.Controls.Add(this.buttonShowPassFail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StaticResultForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.StaticResultForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonShowPassFail;
        private System.Windows.Forms.Button buttonShowScore;
    }
}