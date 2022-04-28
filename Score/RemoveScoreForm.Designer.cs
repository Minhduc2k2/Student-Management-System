
namespace LoginForm
{
    partial class RemoveScoreForm
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
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButtonRemoveScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
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
            // DataGridView1
            // 
            this.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(12, 12);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(635, 487);
            this.DataGridView1.TabIndex = 0;
            // 
            // ButtonRemoveScore
            // 
            this.ButtonRemoveScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.ButtonRemoveScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemoveScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemoveScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ButtonRemoveScore.Location = new System.Drawing.Point(201, 518);
            this.ButtonRemoveScore.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonRemoveScore.Name = "ButtonRemoveScore";
            this.ButtonRemoveScore.Size = new System.Drawing.Size(259, 46);
            this.ButtonRemoveScore.TabIndex = 49;
            this.ButtonRemoveScore.Text = "Remove";
            this.ButtonRemoveScore.UseVisualStyleBackColor = false;
            this.ButtonRemoveScore.Click += new System.EventHandler(this.ButtonRemoveScore_Click);
            // 
            // RemoveScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(660, 577);
            this.Controls.Add(this.ButtonRemoveScore);
            this.Controls.Add(this.DataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RemoveScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveScoreForm";
            this.Load += new System.EventHandler(this.RemoveScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource myDBDataSetBindingSource;
        private myDBDataSet myDBDataSet;
        private myDBDataSet1 myDBDataSet1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private myDBDataSet1TableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button ButtonRemoveScore;
    }
}