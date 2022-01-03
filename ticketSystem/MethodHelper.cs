using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticketSystem
{
    class MethodHelper
    {
        public static void AddCustToCsv(int id, string type, int count,string Day, DateTime entrytime)
        {
            string newCust =id + "," + type + "," + count + "," + Day + "," + entrytime  + "\n" ;
            File.AppendAllText(GlobalValues.CustomerFilepath, newCust);
        }

        public static void GetCustFromCsv()
        {
            GlobalValues.CustomerList = new List<Customer>();
            string[] lines = File.ReadAllLines(GlobalValues.CustomerFilepath);
            foreach (string line in lines)
            {
                string[] st = line.Split(',');
                if (st.Length != 7)
                {
                    continue;
                }
                Customer s = new Customer();
                s.Id = Convert.ToInt32(st[0]);
                s.Type = st[1];
                s.Count = Convert.ToInt32(st[2]);
                s.EntryTime = Convert.ToDateTime(st[3]);
                s.ExitTime = Convert.ToDateTime(st[4]);
                s.Cost = Convert.ToInt32(st[5]);
                GlobalValues.CustomerList.Add(s);
            }
        }

        
        public static void ReadWeekdayFile()
        {
            GlobalValues.WeekdayRateList= new List<WeekdayTicket>();
            string[] RateList = File.ReadAllLines(GlobalValues.WeekdayRateFilepath);
            foreach (string s in RateList)
            {
                try
                {
                    string[] st = s.Split(',');
                    if (st.Length != 6) continue;

                    WeekdayTicket tR = new WeekdayTicket();
                    tR.TicketType = st[0];
                    tR.Rate1Hr = Convert.ToInt32(st[1]);
                    tR.Rate2Hr = Convert.ToInt32(st[2]);
                    tR.Rate3Hr = Convert.ToInt32(st[3]);
                    tR.Rate4Hr = Convert.ToInt32(st[4]);
                    tR.RateWholeDay = Convert.ToInt32(st[5]);

                   GlobalValues.WeekdayRateList.Add(tR);
                }
                catch (FormatException)
                {
                    continue;
                }


            }
           
        }
        public static void ReadHolidayFile()//Reads holiday csv file
        {
            List<HolidayTicket> HolidayTicketRateList = new List<HolidayTicket>();
            string[] RateList = File.ReadAllLines(GlobalValues.HolidayFilepath);
            foreach (string s in RateList)
            {
                try
                {
                    string[] st = s.Split(',');
                    if (st.Length != 6) continue;

                    HolidayTicket HtR = new HolidayTicket();
                    HtR.TicketType = st[0];
                    HtR.HRate1Hr = Convert.ToInt32(st[1]);
                    HtR.HRate2Hr = Convert.ToInt32(st[2]);
                    HtR.HRate3Hr = Convert.ToInt32(st[3]);
                    HtR.HRate4Hr = Convert.ToInt32(st[4]);
                    HtR.HRateWholeDay = Convert.ToInt32(st[5]);

                    GlobalValues.HolidayRateList.Add(HtR);
                }
                catch (FormatException)
                {
                    continue;
                }


            }
            
        }
    }
}
