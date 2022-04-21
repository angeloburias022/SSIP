using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Service Type is required")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Please enter a valid Service Type")]
        public string ServiceType { get; set; }

        [Required(ErrorMessage = "Aircon Type is required")]
        public string AirconType { get; set; }

        [Required(ErrorMessage = "Service Time is required")]
        public string ServiceTime { get; set; }

        [Required(ErrorMessage = "Schedule Date is required")]
        public string ScheduleDate { get; set; }

        public string RecordedBy { get; set; }
        public string Status { get; set; }
        public int CustomerID { get; set; }
    }

}
