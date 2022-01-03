using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticketSystem
{
    [Serializable]
    class HolidayTicket
    {
        public string TicketType { get; set; }
        public int HRate1Hr { get; set; }
        public int HRate2Hr { get; set; }
        public int HRate3Hr { get; set; }
        public int HRate4Hr { get; set; }
        public int HRateWholeDay { get; set; }

    }
}
