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
    public partial class VisualReportForm : Form
    {
        public VisualReportForm()
        {
            InitializeComponent();
        }

        private void VisualReportForm_Load(object sender, EventArgs e)
        {

        }
        string filePath = @"C:\3rd_year\Application_Development\CW\Customer.csv";
       
        int childNo = 0;
        int groupNo = 0;
        int adultNo = 0;

        int earningFromAdult = 0;
        int earningFromGroup = 0;
        int earningFromChild = 0;

        private void MakeCount()
        {
            string[] VisitorList = File.ReadAllLines(filePath);
            foreach (string s in VisitorList)
            {
                string[] st = s.Split(',');
                if (String.Equals("Child", st[1]))
                {
                    childNo += Convert.ToInt32(st[2]);
                    earningFromChild += Convert.ToInt32(st[5]);

                }
                else if (String.Equals("Adult", st[1]))
                {
                    adultNo += Convert.ToInt32(st[2]);
                    earningFromAdult += Convert.ToInt32(st[5]);
                }
                else
                {
                    groupNo += Convert.ToInt32(st[2]);
                    earningFromGroup += Convert.ToInt32(st[5]);
                }
            }
        }

        private void makeChart()
        {
            countChart.Series["Count"].Points.AddXY("Child", childNo);
            countChart.Series["Count"].Points.AddXY("Adult", adultNo);
            countChart.Series["Count"].Points.AddXY("Group", groupNo);


            revenueChart.Series["Income"].Points.AddXY("Child", earningFromChild);
            revenueChart.Series["Income"].Points.AddXY("Adult", earningFromAdult);
            revenueChart.Series["Income"].Points.AddXY("Group", earningFromGroup);
        }
    }
}
