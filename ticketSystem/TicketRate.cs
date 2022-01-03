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
           ReadWeekdayTicketRate();
            
        }

        public void ReadWeekdayTicketRate()
        {
            List<Ticket> TicketRateList = new List<Ticket>();
            string[] RateList = File.ReadAllLines(GlobalValues.WeekdayRateFilepath);
            foreach (string s in RateList)
            {
                try
                {
                    string[] st = s.Split(',');
                    if (st.Length != 6) continue;// for checking valid records;

                    Ticket tR = new Ticket();
                    tR.TicketType = st[0];
                    tR.Rate1Hr = Convert.ToInt32(st[1]);
                    tR.Rate2Hr = Convert.ToInt32(st[2]);
                    tR.Rate3Hr = Convert.ToInt32(st[3]);
                    tR.Rate4Hr = Convert.ToInt32(st[4]);
                    tR.RateWholeDay = Convert.ToInt32(st[5]);


                    TicketRateList.Add(tR);
                }
                catch (FormatException)
                {
                    continue;
                }


            }
            rateView.DataSource = TicketRateList;
        }
        public void ReadHolidayTicketRate()
        {
            List<Ticket> HTicketRateList = new List<Ticket>();
            string[] RateList = File.ReadAllLines(GlobalValues.HolidayFilepath);
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
                    tR.RateWholeDay= Convert.ToInt32(st[5]);


                    HTicketRateList.Add(tR);
                }
                catch (FormatException)
                {
                    continue;
                }


            }
            rateView.DataSource = HTicketRateList;
        }



        private void dayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = dayComboBox.SelectedIndex;
            if (index == 0)
            {
                ReadWeekdayTicketRate();
            }
            else if (index == 1)
            {
                ReadHolidayTicketRate();
            }
        }


        private void TicketRate_Load(object sender, EventArgs e)
        {

        }

       
        private void reloadBtn_Click(object sender, EventArgs e)
        {
            int index = dayComboBox.SelectedIndex;
            if (index == 0)
            {
                if(GlobalValues.IsAdmin)
                {
                    TextWriter writer = new StreamWriter(GlobalValues.WeekdayRateFilepath);
                    for (int i=0;i< rateView.Rows.Count;i++)
                    {
                        for (int j=0;j<rateView.Columns.Count;j++)
                        {
                            writer.Write(rateView.Rows[i].Cells[j].Value.ToString());
                            if(j<rateView.Columns.Count - 1)
                            {
                                writer.Write(",");
                            }
                        }
                        writer.WriteLine("");
                    }
                    writer.Close();
                    MessageBox.Show("Ticket Rate Updated");
                }
                else
                {
                    MessageBox.Show("No permission");
                }
                ReadWeekdayTicketRate();
            }
            else if (index == 1)
            {
                if (GlobalValues.IsAdmin)
                {
                    TextWriter writer = new StreamWriter(GlobalValues.HolidayFilepath);
                    for (int i = 0; i < rateView.Rows.Count; i++)
                    {
                        for (int j = 0; j < rateView.Columns.Count; j++)
                        {
                            writer.Write(rateView.Rows[i].Cells[j].Value.ToString());
                            if (j < rateView.Columns.Count - 1)
                            {
                                writer.Write(",");
                            }
                        }
                        writer.WriteLine("");
                    }
                    writer.Close();
                    MessageBox.Show("Ticket Rate Updated");
                }
                else
                {
                    MessageBox.Show("No permission");
                }
                ReadHolidayTicketRate();
            }
        }
    }
}
