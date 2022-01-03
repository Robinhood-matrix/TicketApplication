using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticketSystem
{
    [Serializable()]// uses serializable class to store data
    class Customer
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Count { get; set; }
        public string Day { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }
        public int Cost { get; set; }
      
    }
}
