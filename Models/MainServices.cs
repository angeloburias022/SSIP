using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSIP.Models
{
    public class MainServices
    {
        public Schedule schedule_info { get; set; }
        public Dispatch dispatch_info { get; set; }

        public MainServices()
        {
            schedule_info = new Schedule();
            dispatch_info = new Dispatch();             
        }
    }   
}
