using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSIP.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string ContactNumber { get; set; }
        public string TelephoneNo { get; set; }
        public string EmailAddress { get; set; }
        public Address Address { get; set; }
        public string IsActive { get; set; }
        public void UserDetails(Address address)
        {
            Address = address;        
        }

    }



}
