
namespace LoginForm
{
    partial class StaticScoreForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartScore = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartScore)).BeginInit();
            this.SuspendLayout();
            // 
            // chartScore
            // 
            chartArea1.Name = "ChartArea1";
            this.chartScore.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartScore.Legends.Add(legend1);
            this.chartScore.Location = new System.Drawing.Point(12, 12);
            this.chartScore.Name = "chartScore";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Điểm";
            this.chartScore.Series.Add(series1);
            this.chartScore.Size = new System.Drawing.Size(667, 507);
            this.chartScore.TabIndex = 0;
            this.chartScore.Text = "chartScore";
            title1.Name = "Title1";
            this.chartScore.Titles.Add(title1);
            // 
            // StaticScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(691, 531);
            this.Controls.Add(this.chartScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StaticScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaticScoreForm";
            this.Load += new System.EventHandler(this.StaticScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartScore;
    }
}