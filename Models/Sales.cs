using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSIP.Models
{
    public class Sales
    {
        public string customerName { get; set; }
        public string Address { get; set; }
        public string ProductName { get; set; }
        public string code { get; set; }
        public decimal UnitPrice { get; set; }
        [Required(ErrorMessage ="Amount Paid is required")]
        public decimal AmountPaid { get; set; }
        public decimal GrandTotal { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public string ContactNo { get; set; }
        public Aircon aircon_info { get; set; }

        public Email email_info { get; set; }
        public Sales()
        {
            email_info = new Email();
            aircon_info = new Aircon();
        }
    }
}
