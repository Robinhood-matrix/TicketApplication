
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
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.rateView)).BeginInit();
            this.SuspendLayout();
            // 
            // rateView
            // 
            this.rateView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rateView.Location = new System.Drawing.Point(105, 165);
            this.rateView.Name = "rateView";
            this.rateView.RowHeadersWidth = 51;
            this.rateView.RowTemplate.Height = 24;
            this.rateView.Size = new System.Drawing.Size(951, 389);
            this.rateView.TabIndex = 0;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(918, 700);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(91, 29);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3 Hour";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // dayComboBox
            // 
            this.dayComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dayComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Items.AddRange(new object[] {
            "Weekdays",
            "Holidays"});
            this.dayComboBox.Location = new System.Drawing.Point(280, 100);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(597, 24);
            this.dayComboBox.TabIndex = 6;
            this.dayComboBox.SelectedIndexChanged += new System.EventHandler(this.dayComboBox_SelectedIndexChanged);
            // 
            // TicketRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 642);
            this.Controls.Add(this.dayComboBox);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.rateView);
            this.Name = "TicketRate";
            this.Text = "Ticket Rate";
            this.Load += new System.EventHandler(this.TicketRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rateView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rateView;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ComboBox dayComboBox;
    }
}