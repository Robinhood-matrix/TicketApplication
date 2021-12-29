using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticketSystem
{
    public partial class ExitForm : Form
    {
        public ExitForm()
        {
            InitializeComponent();
        }

        private void ExitForm_Load(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            bool found = false;
            try
            {
                string[] VisitorSearch = File.ReadAllLines(@"C:\3rd_year\Application_Development\CW\Customer.csv");
                foreach (string s in VisitorSearch)
                {
                    string[] st = s.Split(',');
                    if (st.Length != 4) continue;

                    if (ticketId.Value == Convert.ToInt32(st[0]))
                    {
                       
                        typeLabel.Text = st[1];
                        countLabel.Text = st[2];
                        entryLabel.Text = st[3];
                        exitLabel.Text = (DateTime.Now).ToString();
                        found = true;


                      
                        typeLabel.Visible = true;
                        countLabel.Visible = true;
                        entryLabel.Visible = true;
                        exitLabel.Visible = true;
                        break;
                    }
                    if (!found)
                    {
                        MessageBox.Show("Visitor with given id not found");
                    }
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("The id doestnot exist");
            }

        }
        private void Duration()
        {

            
        }
    }
}
