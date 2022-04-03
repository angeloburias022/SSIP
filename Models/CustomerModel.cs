using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSIP.Models
{
    public class CustomerModel
    {
        public User user_info { get; set; }
        public Address address_info { get; set; }
        public Employee employee_info { get; set; }
        public Email email_info { get; set; }
        public CustomerModel()
        {
            user_info = new User();
            address_info = new Address();
            employee_info = new Employee();
            email_info = new Email();
        }
    }
}
