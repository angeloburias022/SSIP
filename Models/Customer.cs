using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSIP.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public User CustomerDetails { get; set; }
        public Address Address { get; set; }
        public void FullDetails(User details, Address address)
        {
            CustomerDetails = details;
            Address = address;
        }
    }
}
