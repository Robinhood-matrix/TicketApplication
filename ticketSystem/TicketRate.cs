using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticketSystem
{
    public partial class TicketRate : Form
    {
       
        public TicketRate()
        {
            InitializeComponent();
            ShowTicketRate();
            
        }

        public void ShowTicketRate()
        {
            List<Ticket> TicketRateList = new List<Ticket>();
            string[] RateList = File.ReadAllLines("C:\\3rd_year\\Application_Development\\CW\\TicketRate.csv");
            foreach (string s in RateList)
            {
                try
                {
                    string[] st = s.Split(',');
                    if (st.Length != 6) continue;

                    Ticket tR = new Ticket();
                    tR.TicketType = st[0];
                    tR.Rate1Hr = Convert.ToInt32(st[1]);
                    tR.Rate2Hr = Convert.ToInt32(st[2]);
                    tR.Rate3Hr = Convert.ToInt32(st[3]);
                    tR.Rate4Hr = Convert.ToInt32(st[4]);


                    TicketRateList.Add(tR);
                }
                catch (FormatException)
                {
                    continue;
                }


            }
            rateView.DataSource = TicketRateList;
        }
        private void ReadHolidayFile()
        {
            List<Ticket> TicketRateList = new List<Ticket>();
            string[] RateList = File.ReadAllLines("C:\\3rd_year\\Application_Development\\CW\\Holiday.csv");
            foreach (string s in RateList)
            {
                try
                {
                    string[] st = s.Split(',');
                    if (st.Length != 6) continue;

                    Ticket tR = new Ticket();
                    tR.TicketType = st[0];
                    tR.Rate1Hr = Convert.ToInt32(st[1]);
                    tR.Rate2Hr = Convert.ToInt32(st[2]);
                    tR.Rate3Hr = Convert.ToInt32(st[3]);
                    tR.Rate4Hr = Convert.ToInt32(st[4]);


                    TicketRateList.Add(tR);
                }
                catch (FormatException)
                {
                    continue;
                }


            }
            rateView.DataSource = TicketRateList;
        }



        private void dayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = dayComboBox.SelectedIndex;
            if (index == 0)
            {
                ShowTicketRate();
            }
            else if (index == 1)
            {
                ReadHolidayFile();
            }
        }


        private void TicketRate_Load(object sender, EventArgs e)
        {

        }
    }
}
