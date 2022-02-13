using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSIP.Models
{
    public class Schedule
    {
        public int ScheduleID { get; set; }
        //public Customer customer { get; set; }
        //public List<Address> Addresses { get; set; } = new List<Address>();
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public string ServiceType { get; set; }
        public string AirconType { get; set; }
        public string ServiceTime { get; set; }
        public string ScheduleDate { get; set; }
        public string RecordedBy { get; set; }
        public string Status { get; set; }
    }

}
