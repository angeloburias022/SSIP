using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSIP.DbAccess
{
    public class ConnectionDB
    {
        private string Connectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RFBDesktopApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
     //  private string Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\HOME PC\DOCUMENTS\CAPSTONE\MAIN_SYSTEM\V2_SSIP\RFB_DB.MDF;Integrated Security=True;Connect Timeout=30";
        public string ConString()
        {
          return Connectionstring;
        }
    }
}
