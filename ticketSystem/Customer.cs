using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticketSystem
{
    class Customer
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Count { get; set; }

        public DateTime EntryTime { get; set; }
    }
}
