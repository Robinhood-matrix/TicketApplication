
namespace ticketSystem
{
    partial class ExitForm
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
            this.countLabel = new System.Windows.Forms.Label();
            this.CustomerDataViewer = new System.Windows.Forms.DataGridView();
            this.typeLabel = new System.Windows.Forms.Label();
            this.ticketLabel = new System.Windows.Forms.Label();
            this.completeBtn = new System.Windows.Forms.Button();
            this.entryLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.exitLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.ticketId = new System.Windows.Forms.NumericUpDown();
            this.typeValue = new System.Windows.Forms.Label();
            this.countValue = new System.Windows.Forms.Label();
            this.entryValue = new System.Windows.Forms.Label();
            this.durationValue = new System.Windows.Forms.Label();
            this.costValue = new System.Windows.Forms.Label();
            this.exitValue = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.exitInfoBtn = new System.Windows.Forms.Button();
            this.dayLabel = new System.Windows.Forms.Label();
            this.dayValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketId)).BeginInit();
            this.SuspendLayout();
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.Location = new System.Drawing.Point(41, 163);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(65, 25);
            this.countLabel.TabIndex = 22;
            this.countLabel.Text = "Count";
            // 
            // CustomerDataViewer
            // 
            this.CustomerDataViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataViewer.Location = new System.Drawing.Point(77, 337);
            this.CustomerDataViewer.Name = "CustomerDataViewer";
            this.CustomerDataViewer.RowHeadersWidth = 51;
            this.CustomerDataViewer.RowTemplate.Height = 24;
            this.CustomerDataViewer.Size = new System.Drawing.Size(992, 280);
            this.CustomerDataViewer.TabIndex = 21;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(41, 100);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(57, 25);
            this.typeLabel.TabIndex = 18;
            this.typeLabel.Text = "Type";
            // 
            // ticketLabel
            // 
            this.ticketLabel.AutoSize = true;
            this.ticketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketLabel.Location = new System.Drawing.Point(41, 38);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(89, 25);
            this.ticketLabel.TabIndex = 17;
            this.ticketLabel.Text = "Ticket ID";
            // 
            // completeBtn
            // 
            this.completeBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.completeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.completeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeBtn.Location = new System.Drawing.Point(907, 230);
            this.completeBtn.Name = "completeBtn";
            this.completeBtn.Size = new System.Drawing.Size(121, 64);
            this.completeBtn.TabIndex = 26;
            this.completeBtn.Text = "Complete";
            this.completeBtn.UseVisualStyleBackColor = false;
            this.completeBtn.Click += new System.EventHandler(this.completeBtn_Click_1);
            // 
            // entryLabel
            // 
            this.entryLabel.AutoSize = true;
            this.entryLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.entryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryLabel.Location = new System.Drawing.Point(41, 271);
            this.entryLabel.Name = "entryLabel";
            this.entryLabel.Size = new System.Drawing.Size(106, 25);
            this.entryLabel.TabIndex = 25;
            this.entryLabel.Text = "Entry Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.Location = new System.Drawing.Point(453, 107);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(93, 25);
            this.exitLabel.TabIndex = 28;
            this.exitLabel.Text = "Exit Time";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.durationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLabel.Location = new System.Drawing.Point(453, 164);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(85, 25);
            this.durationLabel.TabIndex = 29;
            this.durationLabel.Text = "Duration";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(455, 230);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(53, 25);
            this.costLabel.TabIndex = 30;
            this.costLabel.Text = "Cost";
            // 
            // ticketId
            // 
            this.ticketId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketId.Location = new System.Drawing.Point(174, 38);
            this.ticketId.Name = "ticketId";
            this.ticketId.Size = new System.Drawing.Size(120, 30);
            this.ticketId.TabIndex = 33;
            // 
            // typeValue
            // 
            this.typeValue.AutoSize = true;
            this.typeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeValue.Location = new System.Drawing.Point(212, 107);
            this.typeValue.Name = "typeValue";
            this.typeValue.Size = new System.Drawing.Size(31, 25);
            this.typeValue.TabIndex = 34;
            this.typeValue.Text = "ID";
            this.typeValue.Visible = false;
            // 
            // countValue
            // 
            this.countValue.AutoSize = true;
            this.countValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countValue.Location = new System.Drawing.Point(212, 163);
            this.countValue.Name = "countValue";
            this.countValue.Size = new System.Drawing.Size(31, 25);
            this.countValue.TabIndex = 35;
            this.countValue.Text = "ID";
            this.countValue.Visible = false;
            // 
            // entryValue
            // 
            this.entryValue.AutoSize = true;
            this.entryValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryValue.Location = new System.Drawing.Point(212, 271);
            this.entryValue.Name = "entryValue";
            this.entryValue.Size = new System.Drawing.Size(31, 25);
            this.entryValue.TabIndex = 36;
            this.entryValue.Text = "ID";
            this.entryValue.Visible = false;
            // 
            // durationValue
            // 
            this.durationValue.AutoSize = true;
            this.durationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationValue.Location = new System.Drawing.Point(624, 164);
            this.durationValue.Name = "durationValue";
            this.durationValue.Size = new System.Drawing.Size(31, 25);
            this.durationValue.TabIndex = 37;
            this.durationValue.Text = "ID";
            this.durationValue.Visible = false;
            // 
            // costValue
            // 
            this.costValue.AutoSize = true;
            this.costValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costValue.Location = new System.Drawing.Point(624, 230);
            this.costValue.Name = "costValue";
            this.costValue.Size = new System.Drawing.Size(31, 25);
            this.costValue.TabIndex = 38;
            this.costValue.Text = "ID";
            this.costValue.Visible = false;
            // 
            // exitValue
            // 
            this.exitValue.AutoSize = true;
            this.exitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitValue.Location = new System.Drawing.Point(624, 107);
            this.exitValue.Name = "exitValue";
            this.exitValue.Size = new System.Drawing.Size(31, 25);
            this.exitValue.TabIndex = 36;
            this.exitValue.Text = "ID";
            this.exitValue.Visible = false;
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(334, 31);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(121, 42);
            this.searchbtn.TabIndex = 26;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // exitInfoBtn
            // 
            this.exitInfoBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exitInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitInfoBtn.Location = new System.Drawing.Point(907, 100);
            this.exitInfoBtn.Name = "exitInfoBtn";
            this.exitInfoBtn.Size = new System.Drawing.Size(121, 64);
            this.exitInfoBtn.TabIndex = 26;
            this.exitInfoBtn.Text = "Display Cost";
            this.exitInfoBtn.UseVisualStyleBackColor = false;
            this.exitInfoBtn.Click += new System.EventHandler(this.exitInfoBtn_Click);
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.Location = new System.Drawing.Point(41, 216);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(47, 25);
            this.dayLabel.TabIndex = 22;
            this.dayLabel.Text = "Day";
            // 
            // dayValue
            // 
            this.dayValue.AutoSize = true;
            this.dayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayValue.Location = new System.Drawing.Point(212, 216);
            this.dayValue.Name = "dayValue";
            this.dayValue.Size = new System.Drawing.Size(31, 25);
            this.dayValue.TabIndex = 39;
            this.dayValue.Text = "ID";
            this.dayValue.Visible = false;
            // 
            // ExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1161, 642);
            this.Controls.Add(this.dayValue);
            this.Controls.Add(this.costValue);
            this.Controls.Add(this.durationValue);
            this.Controls.Add(this.exitValue);
            this.Controls.Add(this.entryValue);
            this.Controls.Add(this.countValue);
            this.Controls.Add(this.typeValue);
            this.Controls.Add(this.ticketId);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.CustomerDataViewer);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.ticketLabel);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.exitInfoBtn);
            this.Controls.Add(this.completeBtn);
            this.Controls.Add(this.entryLabel);
            this.Name = "ExitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exit Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.DataGridView CustomerDataViewer;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label ticketLabel;
        private System.Windows.Forms.Button completeBtn;
        private System.Windows.Forms.Label entryLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label costValue;
        private System.Windows.Forms.Label durationValue;
        private System.Windows.Forms.Label entryValue;
        private System.Windows.Forms.Label countValue;
        private System.Windows.Forms.Label typeValue;
        private System.Windows.Forms.NumericUpDown ticketId;
        private System.Windows.Forms.Label exitValue;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button exitInfoBtn;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label dayValue;
    }
}