using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required(ErrorMessage ="Firstname is required")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage ="Please enter a valid Firstname")]
        [MinLength(1, ErrorMessage ="Invalid length of Firstname")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Lastname is required")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Please enter a valid Lastname")]
        [MinLength(2, ErrorMessage = "Invalid length of Lastname")]
        public string Lastname { get; set; }

        [RegularExpression("^[0-9,-]*$", ErrorMessage ="Please enter a valid mobile number")]
        [MinLength(12, ErrorMessage ="Invalid length of Mobile number")]
        public string ContactNumber { get; set; }

        [RegularExpression("^[0-9,-]*$", ErrorMessage = "Please enter a valid Telephone number")]
        public string TelephoneNo { get; set; }
     //   public string EmailAddress { get; set; }
        public Address Address { get; set; }
        public string IsActive { get; set; }
        public void UserDetails(Address address)
        {
            Address = address;        
        }

    }



}
