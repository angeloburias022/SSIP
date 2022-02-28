using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSIP.Models
{
    public class Dispatch
    {

        public int DispatchID { get; set; }
        public DateTime dispatchdate { get; set; }
        public string AssignTeam { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public string PaidAmount { get; set; }
    }
}
