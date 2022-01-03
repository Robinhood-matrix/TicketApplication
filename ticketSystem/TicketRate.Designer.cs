
namespace ticketSystem
{
    partial class TicketRate
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
            this.rateView = new System.Windows.Forms.DataGridView();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.reloadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rateView)).BeginInit();
            this.SuspendLayout();
            // 
            // rateView
            // 
            this.rateView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.rateView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rateView.Location = new System.Drawing.Point(146, 95);
            this.rateView.Name = "rateView";
            this.rateView.RowHeadersWidth = 51;
            this.rateView.RowTemplate.Height = 24;
            this.rateView.Size = new System.Drawing.Size(849, 389);
            this.rateView.TabIndex = 0;          // 
            // dayComboBox
            // 
            this.dayComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dayComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Items.AddRange(new object[] {
            "Weekdays",
            "Holidays"});
            this.dayComboBox.Location = new System.Drawing.Point(263, 55);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(597, 24);
            this.dayComboBox.TabIndex = 6;
            this.dayComboBox.SelectedIndexChanged += new System.EventHandler(this.dayComboBox_SelectedIndexChanged);
            // 
            // reloadBtn
            // 
            this.reloadBtn.Location = new System.Drawing.Point(454, 506);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(203, 46);
            this.reloadBtn.TabIndex = 7;
            this.reloadBtn.Text = "Reload";
            this.reloadBtn.UseVisualStyleBackColor = true;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // TicketRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 630);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.dayComboBox);
            this.Controls.Add(this.rateView);
            this.Name = "TicketRate";
            this.Text = "Ticket Rate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TicketRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rateView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView rateView;
        private System.Windows.Forms.ComboBox dayComboBox;
        private System.Windows.Forms.Button reloadBtn;
    }
}