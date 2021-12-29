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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitForm extForm = new ExitForm();
            extForm.MdiParent = this;
            extForm.Show();
        }

       

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (GlobalValues.IsAdmin == false)
            {
                TicketRateMenuItem.HideDropDown();
                reportToolStripMenuItem1.HideDropDown();
            }
            else
            {
                GlobalValues.IsAdmin = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LabelDate.Text = DateTime.Now.ToString();
        }

        private void LabelDate_Click(object sender, EventArgs e)
        {

        }

        private void EntryFormMenu_Click(object sender, EventArgs e)
        {
            EntryForm entryForm = new EntryForm();
            entryForm.MdiParent = this;
            entryForm.Show();
        }

        private void reportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
           reportForm.MdiParent = this;
            reportForm.Show();
        }

        private void TicketRateMenuItem_Click(object sender, EventArgs e)
        {
            TicketRate Rate = new TicketRate();
            Rate.MdiParent =this;
            Rate.Show();

        }

       
    }
}
