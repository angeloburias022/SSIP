using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSIP.Models
{
    public class Payroll
    {
        public int empID { get; set; }
        public int payrollID { get; set; }
        public decimal hrly_rate { get; set; }
        public Decimal total_hrs { get; set; }
        public Decimal total_amount { get; set; }
        public decimal cashAdvance { get; set; }
        public decimal sss { get; set; }
        public decimal pagibig { get; set; }
        public decimal philhealth { get; set; }
        public decimal other_deduc { get; set; }
        public DateTime payRollDate { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
