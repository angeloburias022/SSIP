using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSIP.Models
{
    public class Emailer
    {
        public string Receiver { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Attachments { get; set; }

    }
}
