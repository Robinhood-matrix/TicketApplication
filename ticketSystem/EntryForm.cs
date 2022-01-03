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
    public partial class EntryForm : Form
    {
        

        public EntryForm()
        {
            InitializeComponent();
            MethodHelper.ReadWeekdayFile();//call method ReadWeekdayFile()
            MethodHelper.ReadHolidayFile();
        }
                 

        private void EntryForm_Load(object sender, EventArgs e)
        {
            rateView.DataSource = GlobalValues.WeekdayRateList;//diplay weekday Ticket list when the form opens

        }
          

        private void entryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (countNumericUpDown.Value >= 5)//if the count is greater than 5 then show error
                {
                    MessageBox.Show("Try using Group option");
                }
                else
                {
                    Customer cust = new Customer();
                    cust.Id = (int)idNumericUpDown.Value;
                    cust.Type = typeComboBox.Text;
                    cust.Day = dayCombo.Text;
                    cust.Count = (int)countNumericUpDown.Value;
                    cust.EntryTime = DateTime.Now;
                    MethodHelper.AddCustToCsv(cust.Id, cust.Type, cust.Count, cust.Day, cust.EntryTime);//adds customer to csv file

                    idNumericUpDown.Value++;

                    //serialization
                    FileStream stream = new FileStream(@"C:\Users\USER\source\repos\ticketSystem\ticketSystem\bin\Debug\Customer", FileMode.Create);
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, GlobalValues.CustomerList);
                    stream.Close();
                    

                    GlobalValues.CustomerList.Add(cust);
                    MessageBox.Show("Data added sucessfully!!");
                    this.Refresh();
                    MethodHelper.GetCustFromCsv();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter valid data");
            }
            catch (Exception ec)
            {
                MessageBox.Show("Unkown error encountered");
            }
        }
 
        private void dayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = dayComboBox.SelectedIndex;//create int index for index changed event
            if (index == 0)
            {
                rateView.DataSource = GlobalValues.WeekdayRateList;
            }
            else if (index == 1)
            {
                rateView.DataSource = GlobalValues.HolidayRateList;
            }
        }

        private void rateView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rateView.ReadOnly = true;
        }
    }
}
