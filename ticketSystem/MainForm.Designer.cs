
namespace ticketSystem
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EntryFormMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TicketRateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LabelDate = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EntryFormMenu,
            this.exitFormToolStripMenuItem,
            this.TicketRateMenuItem,
            this.reportToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1161, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EntryFormMenu
            // 
            this.EntryFormMenu.Name = "EntryFormMenu";
            this.EntryFormMenu.Size = new System.Drawing.Size(90, 24);
            this.EntryFormMenu.Text = "EntryForm";
            this.EntryFormMenu.Click += new System.EventHandler(this.EntryFormMenu_Click);
            // 
            // exitFormToolStripMenuItem
            // 
            this.exitFormToolStripMenuItem.Name = "exitFormToolStripMenuItem";
            this.exitFormToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.exitFormToolStripMenuItem.Text = "ExitForm";
            this.exitFormToolStripMenuItem.Click += new System.EventHandler(this.exitFormToolStripMenuItem_Click);
            // 
            // TicketRateMenuItem
            // 
            this.TicketRateMenuItem.Name = "TicketRateMenuItem";
            this.TicketRateMenuItem.Size = new System.Drawing.Size(96, 24);
            this.TicketRateMenuItem.Text = "Ticket Rate";
            this.TicketRateMenuItem.Click += new System.EventHandler(this.TicketRateMenuItem_Click);
            // 
            // reportToolStripMenuItem1
            // 
            this.reportToolStripMenuItem1.Name = "reportToolStripMenuItem1";
            this.reportToolStripMenuItem1.Size = new System.Drawing.Size(68, 24);
            this.reportToolStripMenuItem1.Text = "Report";
            this.reportToolStripMenuItem1.Click += new System.EventHandler(this.reportToolStripMenuItem1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(839, 10);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(38, 17);
            this.LabelDate.TabIndex = 1;
            this.LabelDate.Text = "Date";
            this.LabelDate.Click += new System.EventHandler(this.LabelDate_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(1081, 10);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(38, 17);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = global::ticketSystem.Properties.Resources.icons_logos_emojis_user_icon_png_transparent_11563566676e32kbvynug;
            this.pictureBox1.Location = new System.Drawing.Point(1041, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 28);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
        
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 642);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EntryFormMenu;
        private System.Windows.Forms.ToolStripMenuItem exitFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TicketRateMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

