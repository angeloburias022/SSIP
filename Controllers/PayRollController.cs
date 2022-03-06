using SSIP.Helper;
using SSIP.Models;
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

        #region main operations
        public DataTable Filter(string empID, DateTime frm, DateTime to)
        {
            using (SqlConnection con = new SqlConnection(ConString))
            {
                using (SqlCommand com = new SqlCommand("[SpFilterPayRoll]", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    try
                    {

                        com.Parameters.AddWithValue("@empID", Convert.ToInt32(empID));
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
        public bool SavePayRoll(Payroll payroll, string recordedBy)
        {
            using (var con = new SqlConnection(ConString))
            {
                
                using (var com = new SqlCommand("[SpAddNewPayRoll]", con))
                {
                    con.Open();
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@Employee_ID", payroll.empID);
                    com.Parameters.AddWithValue("@HourlyRate", payroll.hrly_rate);
                    com.Parameters.AddWithValue("@workHrs", payroll.total_hrs);
                    com.Parameters.AddWithValue("@TotalAmount", payroll.total_amount);
                    com.Parameters.AddWithValue("@ca", payroll.cashAdvance);

                    com.Parameters.AddWithValue("@sss", payroll.sss);
                    com.Parameters.AddWithValue("@pbg", payroll.pagibig);
                    com.Parameters.AddWithValue("@philhealth", payroll.philhealth);
                    com.Parameters.AddWithValue("@other", payroll.other_deduc);
                    com.Parameters.AddWithValue("@paySlipDate", payroll.payRollDate);

                    com.Parameters.AddWithValue("@datefrom", payroll.DateFrom);
                    com.Parameters.AddWithValue("@dateto", payroll.DateTo);
                    com.Parameters.AddWithValue("@recordedBy", recordedBy);

                    com.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }        
        }
        public bool UpdatePayroll(Payroll payroll, string recordedBy)
        {
            using (var con = new SqlConnection(ConString))
            {
                using (var com = new SqlCommand("[SpUpdatePayrollByID]", con))
                {
                    con.Open();
                    com.CommandType = CommandType.StoredProcedure;


                    com.Parameters.AddWithValue("@PayrollID", payroll.payrollID);

                    com.Parameters.AddWithValue("@HourlyRate", payroll.hrly_rate);
                    com.Parameters.AddWithValue("@workHrs", payroll.total_hrs);
                    com.Parameters.AddWithValue("@TotalAmount", payroll.total_amount);
                    com.Parameters.AddWithValue("@ca", payroll.cashAdvance);

                    com.Parameters.AddWithValue("@sss", payroll.sss);
                    com.Parameters.AddWithValue("@pbg", payroll.pagibig);
                    com.Parameters.AddWithValue("@philhealth", payroll.philhealth);
                    com.Parameters.AddWithValue("@other", payroll.other_deduc);
                    com.Parameters.AddWithValue("@paySlipDate", payroll.payRollDate);

                    com.Parameters.AddWithValue("@datefrom", payroll.DateFrom);
                    com.Parameters.AddWithValue("@dateto", payroll.DateTo);
                    com.Parameters.AddWithValue("@recordedBy", recordedBy);
                    com.ExecuteNonQuery();


                    con.Close();
                    return true;
                }
            }
        }

        public DataTable FindPayRoll(string searched)
        {

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ConString))
            {
                try
                {

                    using (SqlCommand com = new SqlCommand("[SpSearchPayroll]", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;

                        com.Parameters.AddWithValue("@Search", searched);
                        SqlDataAdapter sds = new SqlDataAdapter(com); // passes the desired query

                        sds.Fill(dt);
                        con.Close();
                        return dt;
                    }
                }
                catch (Exception error)
                {

                    error.ToString();
                }
                return dt;
            }

        }
        public DataTable GetPayRolls()
        {
            using (SqlConnection con = new SqlConnection(ConString))
                {
                    using (SqlCommand com = new SqlCommand("[SpGetPayrollList]", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                        {
                            ds.Clear();
                            adapter.Fill(ds);

                            dt = ds.Tables[0];
                            con.Close();
                        return dt;
                         }
                    }
                }          
        } 
        #endregion
    }
}
