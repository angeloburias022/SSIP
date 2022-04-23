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
        #region declaration
        ConnectionDB db = new ConnectionDB();
        public AuditController()
        {
        }
        #endregion

        #region audit ops
        public void Logs(AuditTrails audit)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(db.ConString()))
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
        public DataTable GetAudits()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {                
                using (SqlConnection con = new SqlConnection(db.ConString()))
                {
                    using (SqlCommand com = new SqlCommand("[SpGetAudits]", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                        {
                            ds.Clear();
                            adapter.Fill(ds);

                            dt = ds.Tables[0];
                            con.Close();

                        }
                    }
                }
                return dt;
            }
            catch (Exception error)
            {
                error.ToString();
            }
            return dt;
        }
        #endregion

    }
}
