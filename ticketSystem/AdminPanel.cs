using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticketSystem
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void ticketRateToolStripMenuItem_Click(object sender, EventArgs e)//displays ticket rate form
        {
            TicketRate Rate = new TicketRate();
            Rate.MdiParent = this;
            Rate.Show();
        }

        private void logoutLabel_Click_1(object sender, EventArgs e)//displays loginform screen
        {
            this.Close();
            LoginForm form = new LoginForm();
            form.Show();
        }

        private void logoutLabel_MouseEnter(object sender, EventArgs e)//changes to hand cursor form pointer cursor
        {
            logoutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)//displays report form
        {
            ReportForm rep = new ReportForm();
            rep.MdiParent = this;
            rep.Show();
        }

        private void visualReportToolStripMenuItem1_Click(object sender, EventArgs e)//displays visual report form
        {
            VisualReportForm vrep = new VisualReportForm();
            vrep.MdiParent = this;
            vrep.Show();
        }
    }
}
