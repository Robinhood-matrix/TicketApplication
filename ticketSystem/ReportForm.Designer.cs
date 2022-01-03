
namespace ticketSystem
{
    partial class ReportForm
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
            this.dailyReportView = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visitors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyReportRadioBtn = new System.Windows.Forms.RadioButton();
            this.weeklyReportRadioBtn = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportView)).BeginInit();
            this.SuspendLayout();
            // 
            // dailyReportView
            // 
            this.dailyReportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyReportView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.Visitors,
            this.Duration,
            this.Income});
            this.dailyReportView.Location = new System.Drawing.Point(71, 213);
            this.dailyReportView.Name = "dailyReportView";
            this.dailyReportView.RowHeadersWidth = 51;
            this.dailyReportView.RowTemplate.Height = 24;
            this.dailyReportView.Size = new System.Drawing.Size(551, 219);
            this.dailyReportView.TabIndex = 0;
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.MinimumWidth = 6;
            this.Day.Name = "Day";
            this.Day.Width = 125;
            // 
            // Visitors
            // 
            this.Visitors.HeaderText = "Entry Count";
            this.Visitors.MinimumWidth = 6;
            this.Visitors.Name = "Visitors";
            this.Visitors.Width = 125;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Total No. of Customers";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.Width = 125;
            // 
            // Income
            // 
            this.Income.HeaderText = "Total Income";
            this.Income.MinimumWidth = 6;
            this.Income.Name = "Income";
            this.Income.Width = 125;
            // 
            // dailyReportRadioBtn
            // 
            this.dailyReportRadioBtn.AutoSize = true;
            this.dailyReportRadioBtn.Location = new System.Drawing.Point(84, 68);
            this.dailyReportRadioBtn.Name = "dailyReportRadioBtn";
            this.dailyReportRadioBtn.Size = new System.Drawing.Size(171, 21);
            this.dailyReportRadioBtn.TabIndex = 1;
            this.dailyReportRadioBtn.TabStop = true;
            this.dailyReportRadioBtn.Text = "Generate Daily Report";
            this.dailyReportRadioBtn.UseVisualStyleBackColor = true;
            // 
            // weeklyReportRadioBtn
            // 
            this.weeklyReportRadioBtn.AutoSize = true;
            this.weeklyReportRadioBtn.Location = new System.Drawing.Point(84, 120);
            this.weeklyReportRadioBtn.Name = "weeklyReportRadioBtn";
            this.weeklyReportRadioBtn.Size = new System.Drawing.Size(186, 21);
            this.weeklyReportRadioBtn.TabIndex = 2;
            this.weeklyReportRadioBtn.TabStop = true;
            this.weeklyReportRadioBtn.Text = "Generate Weekly Report";
            this.weeklyReportRadioBtn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(771, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 642);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.weeklyReportRadioBtn);
            this.Controls.Add(this.dailyReportRadioBtn);
            this.Controls.Add(this.dailyReportView);
            this.Name = "ReportForm";
            this.Text = "Report Form";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dailyReportView;
        private System.Windows.Forms.RadioButton dailyReportRadioBtn;
        private System.Windows.Forms.RadioButton weeklyReportRadioBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visitors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Income;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}