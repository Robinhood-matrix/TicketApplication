
namespace ticketSystem
{
    partial class VisualReportForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.countChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.weeklyReportBtn = new System.Windows.Forms.RadioButton();
            this.dailyReportBtn = new System.Windows.Forms.RadioButton();
            this.revenueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.countChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueChart)).BeginInit();
            this.SuspendLayout();
            // 
            // countChart
            // 
            chartArea1.Name = "ChartArea1";
            this.countChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.countChart.Legends.Add(legend1);
            this.countChart.Location = new System.Drawing.Point(765, 53);
            this.countChart.Name = "countChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.countChart.Series.Add(series1);
            this.countChart.Size = new System.Drawing.Size(300, 300);
            this.countChart.TabIndex = 0;
            this.countChart.Text = "chart1";
            // 
            // weeklyReportBtn
            // 
            this.weeklyReportBtn.AutoSize = true;
            this.weeklyReportBtn.Location = new System.Drawing.Point(78, 151);
            this.weeklyReportBtn.Name = "weeklyReportBtn";
            this.weeklyReportBtn.Size = new System.Drawing.Size(186, 21);
            this.weeklyReportBtn.TabIndex = 4;
            this.weeklyReportBtn.TabStop = true;
            this.weeklyReportBtn.Text = "Generate Weekly Report";
            this.weeklyReportBtn.UseVisualStyleBackColor = true;
            // 
            // dailyReportBtn
            // 
            this.dailyReportBtn.AutoSize = true;
            this.dailyReportBtn.Location = new System.Drawing.Point(78, 99);
            this.dailyReportBtn.Name = "dailyReportBtn";
            this.dailyReportBtn.Size = new System.Drawing.Size(171, 21);
            this.dailyReportBtn.TabIndex = 3;
            this.dailyReportBtn.TabStop = true;
            this.dailyReportBtn.Text = "Generate Daily Report";
            this.dailyReportBtn.UseVisualStyleBackColor = true;
            // 
            // revenueChart
            // 
            chartArea2.Name = "ChartArea1";
            this.revenueChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.revenueChart.Legends.Add(legend2);
            this.revenueChart.Location = new System.Drawing.Point(398, 53);
            this.revenueChart.Name = "revenueChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.revenueChart.Series.Add(series2);
            this.revenueChart.Size = new System.Drawing.Size(300, 300);
            this.revenueChart.TabIndex = 0;
            this.revenueChart.Text = "chart1";
            // 
            // VisualReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 642);
            this.Controls.Add(this.weeklyReportBtn);
            this.Controls.Add(this.dailyReportBtn);
            this.Controls.Add(this.revenueChart);
            this.Controls.Add(this.countChart);
            this.Name = "VisualReportForm";
            this.Text = "VisualReportForm";
            this.Load += new System.EventHandler(this.VisualReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart countChart;
        private System.Windows.Forms.RadioButton weeklyReportBtn;
        private System.Windows.Forms.RadioButton dailyReportBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart revenueChart;
    }
}