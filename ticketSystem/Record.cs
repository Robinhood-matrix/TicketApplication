using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticketSystem
{
    class Record
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Count { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }
        public int TotalCost { get; set; }
        public bool HasLeft { get; set; }
    }
}
