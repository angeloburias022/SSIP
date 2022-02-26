using SSIP.DbAccess;
using SSIP.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SSIP.Controllers
{
    public class AuditController
    {
        //    private static string ConString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        private string ConString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RFBDesktopApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        public AuditController()
        {
           
        }
      
        public void Logs(AuditTrails audit)
        {
            try
            {
                
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    con.Open();

                    using (SqlCommand com = new SqlCommand("[spAddAudit]", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.AddWithValue("@Username", audit.Username);
                        com.Parameters.AddWithValue("@ActionType", audit.AuditActionTypeENUM);
                        com.Parameters.AddWithValue("@DateTimeStamp", audit.DateTimeStamp);
                        com.Parameters.AddWithValue("@DataModel", audit.DataModel);
                        com.Parameters.AddWithValue("@Changes", audit.Changes);
                        com.Parameters.AddWithValue("@ValueBefore", audit.ValueBefore);
                        com.Parameters.AddWithValue("@ValueAfter", audit.ValueAfter);
                        com.Parameters.AddWithValue("@Result", audit.Result);
                        com.Parameters.AddWithValue("@Description", audit.Description);
                        com.ExecuteNonQuery();
                    }           
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong" + error);
            }
        }

    }
}
