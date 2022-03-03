using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSIP.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public decimal PerHour { get; set; }
        public decimal Salary { get; set; }

        [Required(ErrorMessage ="Status is required")]
        [Display(Name="Status")]
        public string EmployeeStatus { get; set; }

        public string Position { get; set; }

        [Required(ErrorMessage ="Account Type is required")]
        [Display(Name = "Account Type")]
        public int AccountTypeID { get; set; }
        public string code { get; set; }
        public string TypeOfContract { get; set; }
        public DateTime DateHired { get; set; }
        public string Total_hrs { get; set; }

    }
}
