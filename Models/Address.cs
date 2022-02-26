using System.ComponentModel.DataAnnotations;

namespace SSIP.Models
{
    public class Address
    {

        public string HouseNo { get; set; }

        public string Street { get; set; }

        public string Barangay { get; set; }

        [Required(ErrorMessage ="City is required")]
        public string City { get; set; }
    }
}