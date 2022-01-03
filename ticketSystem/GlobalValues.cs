using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticketSystem
{
    class GlobalValues
    {
        public static bool IsAdmin;

        public const string UserName = "admin";
        public const string Password = "admin";

        public const string DirPath = @"C:\Users\USER\source\repos\ticketSystem\ticketSystem\bin\Debug";
        public const string customerFile = "Customer.csv";
        public const string holidayFile = "Holiday.csv";
        public const string weekdayRateFile = "Weekday.csv";
        public const string exitCustomerFile = "ExitCustomer.csv";

        public static string CustomerFilepath => Path.Combine(DirPath, customerFile);

        public static string HolidayFilepath => Path.Combine(DirPath, holidayFile);
        public static string WeekdayRateFilepath => Path.Combine(DirPath,weekdayRateFile);

        public static string ExitCustomerFile => Path.Combine(DirPath, exitCustomerFile);

        public static List<Customer> CustomerList= new List<Customer>();
        public static List<Ticket> TicketRateList = new List<Ticket>();
        public static List<HolidayTicket> HolidayRateList = new List<HolidayTicket>();
        public static List<WeekdayTicket> WeekdayRateList = new List<WeekdayTicket>();
    }
}
