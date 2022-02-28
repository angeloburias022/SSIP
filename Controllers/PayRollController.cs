using SSIP.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSIP.Controllers
{
    public class PayRollController
    {

        #region private fields
        string ConString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RFBDesktopApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        #endregion

        #region declarations
        PasswordEncryptor enc = new PasswordEncryptor();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        #endregion
        public DataTable Filter(string empName, DateTime frm, DateTime to)
        {

            using (SqlConnection con = new SqlConnection(ConString))
            {

                using (SqlCommand com = new SqlCommand("[SpFilterPayRoll]", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    try
                    {

                        com.Parameters.AddWithValue("@empName", empName);
                        com.Parameters.AddWithValue("@DateFrom", frm);
                        com.Parameters.AddWithValue("@DateTo", to);

                        con.Open();
                        DataTable dt = new DataTable();
                        dt.Load(com.ExecuteReader());
                     
                        com.ExecuteNonQuery();
                        con.Close();

                        return dt;
                    }
                    catch (Exception error)
                    {
                        error.ToString();
                    }

                }


            }


            return dt;
        }
    }
}
