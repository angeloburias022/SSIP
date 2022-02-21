using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSIP.Models
{
    public class Email
    {
        public int EmailID { get; set; }
        // public List<Email> EmailAddress { get; set; } = new List<Email>();
        public string EmailAddress { get; set; }

        public User PersonID { get; set; }
    }
}
