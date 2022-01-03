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
    public partial class UserPanel : Form
    {
        public UserPanel()
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm form = new LoginForm();
            form.Show();
        }
    }
}
