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
    public partial class EntryForm : Form
    {
        string filePath = @"C:\3rd_year\Application_Development\CW\Customer.csv";//declaring filepath to store data to customer.csv

        public EntryForm()
        {

            InitializeComponent(); 
            ReadWeekdayFile();//call method ReadWeekdayFile()
          
        }
                 

        private void EntryForm_Load(object sender, EventArgs e)
        {

        }
      
        
        private void AddCustToCsv(int id, string type, int count, DateTime entrytime)
        {
            string newSt = "\n" + id + "," + type + "," + count + "," + entrytime;
            // File.WriteAllText(filePath, newSt); //to overide old content
            File.AppendAllText(filePath, newSt);
        }

        private void entryBtn_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.Id = (int)idNumericUpDown.Value;
            cust.Type = typeComboBox.Text;
            cust.Count = (int)countNumericUpDown.Value;
            cust.EntryTime = DateTime.Now;

            AddCustToCsv(cust.Id, cust.Type, cust.Count, cust.EntryTime);

            Console.WriteLine("Data added sucessfully!!");

        }
      
        public void ReadWeekdayFile()
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

    

        private void outputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = dayComboBox.SelectedIndex;
            if (index == 0)
            {
                ReadWeekdayFile();
            }
            else if (index == 1)
            { 
                ReadHolidayFile(); 
            }
        }
    }
}
