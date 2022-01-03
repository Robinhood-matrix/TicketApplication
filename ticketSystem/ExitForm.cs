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
            ShowExitCustomer();

        }

        private void ExitForm_Load(object sender, EventArgs e)
        {
            CustomerDataViewer.DataSource = GlobalValues.CustomerList;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            bool found = false;
            try
            {
                string[] CustSearch = File.ReadAllLines(GlobalValues.CustomerFilepath);
                foreach (string s in CustSearch)
                {
                    string[] st = s.Split(',');
                  

                    if (ticketId.Value == Convert.ToInt32(st[0]))
                    {
                       
                        typeValue.Text = st[1];                     
                        countValue.Text = st[2];
                        dayValue.Text = st[3];
                        entryValue.Text = st[4];
                        exitValue.Text = (DateTime.Now).ToString();
                        found = true;

                        typeValue.Visible = true;
                        dayValue.Visible = true;
                        countValue.Visible = true;
                        entryValue.Visible = true;
                        exitValue.Visible = true;

                        exitValue.Text = "";
                        durationValue.Text = "";
                        costValue.Text = "";
                        break;
                    }
                    if (!found)
                    {
                        
                    }
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("The id doestnot exist");
            }

        }
       

        private void exitInfoBtn_Click(object sender, EventArgs e)
        {
            bool found = false;
            exitValue.Text = DateTime.Now.ToString();

            int hour =(Convert.ToDateTime(exitValue.Text)- Convert.ToDateTime(entryValue.Text)).Hours;
            int min = (Convert.ToDateTime(exitValue.Text) - Convert.ToDateTime(entryValue.Text)).Minutes;
            durationValue.Text = hour + "Hrs" + min + "mins";

            CalculateCost(hour, min);
            costValue.Text = total.ToString();

            found = true;
            exitValue.Visible = true;
            durationValue.Visible = true;
            costValue.Visible = true;
        }

        int cost;
        int total;
        public void CalculateCost(int durationHr, int durationMin)
        {

            if (dayValue.Text == "Weekday")
            {
                string[] RateList = File.ReadAllLines(GlobalValues.WeekdayRateFilepath);
                foreach (string s in RateList)
                {
                    string[] st = s.Split(',');
                    if (string.Equals(typeValue.Text, st[0]))
                        MessageBox.Show("");
                    {
                        if (durationHr == 0)
                        {
                            cost = ((durationMin % 60) * Convert.ToInt32(st[2])) / 100;

                        
                        }

                        else if (durationHr == 1) cost = durationHr * Convert.ToInt32(st[2]) + ((durationMin % 60) * Convert.ToInt32(st[3])) / 100;
                        else if (durationHr == 2) cost = durationHr * Convert.ToInt32(st[2]) + ((durationMin % 60) * Convert.ToInt32(st[3])) / 100;
                        else if (durationHr == 3) cost = durationHr * Convert.ToInt32(st[3]) + ((durationMin % 60) * Convert.ToInt32(st[4])) / 100;
                        else if (durationHr == 4) cost = durationHr * Convert.ToInt32(st[4]) + ((durationMin % 60) * Convert.ToInt32(st[4])) / 100;
                        else cost = Convert.ToInt32(st[5]);


                    }
                    total = Convert.ToInt32(countValue.Text) * cost; //calculates the total cost by total number of people entered. 
                    break;
                }
            }
            else
            {
                string[] RateList = File.ReadAllLines(GlobalValues.HolidayFilepath);
                foreach (string s in RateList)
                {
                    string[] st = s.Split(',');
                    if (string.Equals(typeValue.Text, st[0]))
                        MessageBox.Show("");
                    {
                        if (durationHr == 0)
                        {
                            cost = ((durationMin % 60) * Convert.ToInt32(st[2])) / 100;

                            //MessageBox.Show(cost.ToString());
                        }

                        else if (durationHr == 1) cost = durationHr * Convert.ToInt32(st[2]) + ((durationMin % 60) * Convert.ToInt32(st[3])) / 100;
                        else if (durationHr == 2) cost = durationHr * Convert.ToInt32(st[2]) + ((durationMin % 60) * Convert.ToInt32(st[3])) / 100;
                        else if (durationHr == 3) cost = durationHr * Convert.ToInt32(st[3]) + ((durationMin % 60) * Convert.ToInt32(st[4])) / 100;
                        else if (durationHr == 4) cost = durationHr * Convert.ToInt32(st[4]) + ((durationMin % 60) * Convert.ToInt32(st[4])) / 100;
                        else cost = Convert.ToInt32(st[5]);


                    }
                    total = Convert.ToInt32(countValue.Text) * cost;
                    //MessageBox.Show(totalcost.ToString());
                    break;

                }

            }
        }
         
        private void AddCustToCsv(int id, string type, int count, string day, DateTime entryTime,DateTime exitTime,int cost)
        {
            string newst = id + "," + type + "," + count + "," + day + "," + entryTime + "," + exitTime + "," + cost +"\n"; 
            File.AppendAllText(@"C:\Users\USER\source\repos\ticketSystem\ticketSystem\bin\Debug\ExitCustomer.csv",newst);
        }

        public void ShowExitCustomer()
        {
            GlobalValues.CustomerList = new List<Customer>();
            string[] exitList = File.ReadAllLines(GlobalValues.ExitCustomerFile);
            foreach (string line in exitList)
            {
                try
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
                    s.Day = st[3];
                    s.EntryTime = Convert.ToDateTime(st[4]);
                    s.ExitTime = Convert.ToDateTime(st[5]);
                    s.Cost = Convert.ToInt32(st[6]);
                  
                    GlobalValues.CustomerList.Add(s);

                }
                catch (FormatException)
                {
                    continue;
                }
            }
            CustomerDataViewer.DataSource = GlobalValues.CustomerList;
        }
        
        private void completeBtn_Click_1(object sender, EventArgs e)
        {
          
            AddCustToCsv(Convert.ToInt32(ticketId.Text), typeValue.Text, Convert.ToInt32(countValue.Text), dayValue.Text, Convert.ToDateTime(entryValue.Text), Convert.ToDateTime(exitValue.Text),total);
            MessageBox.Show("Successfully Exited");
            ShowExitCustomer();
        }
    }
}
