using SSIP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSIP.Models
{
    public class AuditTrails
    {
        public int AuditID { get; set; }
        public int KeyFieldID { get; set; }
        public string Username { get; set; }
        public ActionTypes AuditActionTypeENUM { get; set; }
        public string DateTimeStamp { get; set; }
        public string DataModel { get; set; }
        public string Changes { get; set; }
        public string ValueBefore { get; set; }
        public string ValueAfter { get; set; }
        public string Result { get; set; }
        public string Description { get; set; }


    }
}
