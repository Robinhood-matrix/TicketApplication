
namespace ticketSystem
{
    partial class EntryForm
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
            this.ticketLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.countNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.entryBtn = new System.Windows.Forms.Button();
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rateView = new System.Windows.Forms.DataGridView();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateView)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketLabel
            // 
            this.ticketLabel.AutoSize = true;
            this.ticketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketLabel.Location = new System.Drawing.Point(35, 95);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(89, 25);
            this.ticketLabel.TabIndex = 0;
            this.ticketLabel.Text = "Ticket ID";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(43, 157);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(57, 25);
            this.typeLabel.TabIndex = 1;
            this.typeLabel.Text = "Type";
            // 
            // typeComboBox
            // 
            this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Child",
            "Adult",
            "Group of 5",
            "Group of 10",
            "Group of 15"});
            this.typeComboBox.Location = new System.Drawing.Point(206, 157);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 33);
            this.typeComboBox.TabIndex = 8;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.Location = new System.Drawing.Point(35, 217);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(65, 25);
            this.countLabel.TabIndex = 10;
            this.countLabel.Text = "Count";
            // 
            // countNumericUpDown
            // 
            this.countNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countNumericUpDown.Location = new System.Drawing.Point(207, 217);
            this.countNumericUpDown.Name = "countNumericUpDown";
            this.countNumericUpDown.Size = new System.Drawing.Size(120, 30);
            this.countNumericUpDown.TabIndex = 11;
            // 
            // entryBtn
            // 
            this.entryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryBtn.Location = new System.Drawing.Point(206, 384);
            this.entryBtn.Name = "entryBtn";
            this.entryBtn.Size = new System.Drawing.Size(90, 42);
            this.entryBtn.TabIndex = 15;
            this.entryBtn.Text = "Entry";
            this.entryBtn.UseVisualStyleBackColor = true;
            this.entryBtn.Click += new System.EventHandler(this.entryBtn_Click);
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNumericUpDown.Location = new System.Drawing.Point(206, 95);
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.Size = new System.Drawing.Size(120, 30);
            this.idNumericUpDown.TabIndex = 17;
            // 
            // rateView
            // 
            this.rateView.AllowUserToAddRows = false;
            this.rateView.AllowUserToDeleteRows = false;
            this.rateView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rateView.Location = new System.Drawing.Point(586, 189);
            this.rateView.Name = "rateView";
            this.rateView.RowHeadersWidth = 51;
            this.rateView.RowTemplate.Height = 24;
            this.rateView.Size = new System.Drawing.Size(538, 353);
            this.rateView.TabIndex = 19;
            // 
            // dayComboBox
            // 
            this.dayComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Items.AddRange(new object[] {
            "Weekdays",
            "Holidays"});
            this.dayComboBox.Location = new System.Drawing.Point(637, 95);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(401, 33);
            this.dayComboBox.TabIndex = 20;
            this.dayComboBox.SelectedIndexChanged += new System.EventHandler(this.dayComboBox_SelectedIndexChanged);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 642);
            this.Controls.Add(this.dayComboBox);
            this.Controls.Add(this.rateView);
            this.Controls.Add(this.idNumericUpDown);
            this.Controls.Add(this.entryBtn);
            this.Controls.Add(this.countNumericUpDown);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.ticketLabel);
            this.Name = "EntryForm";
            this.Text = "Entry Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ticketLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.NumericUpDown countNumericUpDown;
        private System.Windows.Forms.Button entryBtn;
        private System.Windows.Forms.NumericUpDown idNumericUpDown;
        private System.Windows.Forms.DataGridView rateView;
        private System.Windows.Forms.ComboBox dayComboBox;
    }
}