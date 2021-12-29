using System;
using System.Collections.Generic;
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

      
        List<Ticket> TicketRateList = new List<Ticket>();
    }
}
