
namespace ticketSystem
{
    partial class AdminPanel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ticketRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualReportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketRateToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.visualReportToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1161, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
       
            // 
            // ticketRateToolStripMenuItem
            // 
            this.ticketRateToolStripMenuItem.Name = "ticketRateToolStripMenuItem";
            this.ticketRateToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.ticketRateToolStripMenuItem.Text = "Ticket Rate";
            this.ticketRateToolStripMenuItem.Click += new System.EventHandler(this.ticketRateToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportToolStripMenuItem.Text = " Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // visualReportToolStripMenuItem1
            // 
            this.visualReportToolStripMenuItem1.Name = "visualReportToolStripMenuItem1";
            this.visualReportToolStripMenuItem1.Size = new System.Drawing.Size(111, 24);
            this.visualReportToolStripMenuItem1.Text = "Visual Report";
            this.visualReportToolStripMenuItem1.Click += new System.EventHandler(this.visualReportToolStripMenuItem1_Click);
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLabel.ForeColor = System.Drawing.Color.Blue;
            this.logoutLabel.Location = new System.Drawing.Point(961, 9);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(52, 17);
            this.logoutLabel.TabIndex = 1;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.Click += new System.EventHandler(this.logoutLabel_Click_1);
            this.logoutLabel.MouseEnter += new System.EventHandler(this.logoutLabel_MouseEnter);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 642);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ticketRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.ToolStripMenuItem visualReportToolStripMenuItem1;
    }
}