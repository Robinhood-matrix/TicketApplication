
namespace ticketSystem
{
    partial class UserPanel
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
            this.mainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.EntryFormMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LabelDate = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Label();
            this.mainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormMenuStrip
            // 
            this.mainFormMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EntryFormMenu,
            this.exitFormToolStripMenuItem});
            this.mainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainFormMenuStrip.Name = "mainFormMenuStrip";
            this.mainFormMenuStrip.Size = new System.Drawing.Size(1161, 28);
            this.mainFormMenuStrip.TabIndex = 0;
            this.mainFormMenuStrip.Text = "menuStrip1";
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(751, 9);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(38, 17);
            this.LabelDate.TabIndex = 1;
            this.LabelDate.Text = "Date";
            this.LabelDate.Click += new System.EventHandler(this.LabelDate_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(978, 9);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(42, 17);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "User";
            // 
            // logoutBtn
            // 
            this.logoutBtn.AutoSize = true;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.logoutBtn.Location = new System.Drawing.Point(1069, 9);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(58, 17);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 666);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.mainFormMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainFormMenuStrip;
            this.Name = "UserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Panel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainFormMenuStrip.ResumeLayout(false);
            this.mainFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem EntryFormMenu;
        private System.Windows.Forms.ToolStripMenuItem exitFormToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label logoutBtn;
    }
}

