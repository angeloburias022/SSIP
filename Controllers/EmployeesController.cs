using SSIP.Helper;
using SSIP.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSIP.Controllers
{
    public class EmployeesController
    {
        #region private fields
        // private static string ConString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        string ConString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RFBDesktopApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        AuditController aud = new AuditController();    
        #endregion

        #region declarations
        public EmployeesController()
        {
        }
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        PasswordEncryptor enc = new PasswordEncryptor();
        #endregion

        #region employee operations
        public bool AddEmployee(Employee emp, User user, Address addr, Email email)
        {
            try
            {
                using (var con = new SqlConnection(ConString))
                {
                    using (var com = new SqlCommand("[SpAddEmployee]", con))
                    {
                        con.Open();
                        com.CommandType = CommandType.StoredProcedure;

                        com.Parameters.AddWithValue("@FirstName", user.Firstname);
                        com.Parameters.AddWithValue("@LastName", user.Lastname);
                        com.Parameters.AddWithValue("@MobileNo", user.ContactNumber);
                        com.Parameters.AddWithValue("@TelephoneNo", user.TelephoneNo);

                        com.Parameters.AddWithValue("@HouseNo", addr.HouseNo);
                        com.Parameters.AddWithValue("@Street", addr.Street);
                        com.Parameters.AddWithValue("@Barangay", addr.Barangay);
                        com.Parameters.AddWithValue("@City", addr.City);

                        com.Parameters.AddWithValue("@DateHired", emp.DateHired);
                        com.Parameters.AddWithValue("@Status", emp.EmployeeStatus);
                        com.Parameters.AddWithValue("@Position", emp.Position);
                        com.Parameters.AddWithValue("@TypeOfContract", emp.TypeOfContract);

                        com.Parameters.AddWithValue("@Username", user.Username);
                        com.Parameters.AddWithValue("@Password", enc.PassWordEncryptor(user.Password));
                        com.Parameters.AddWithValue("@Email", email.EmailAddress);
                        com.Parameters.AddWithValue("@AccTypeID", emp.AccountTypeID);
                        com.Parameters.AddWithValue("@code", emp.code);

                        com.ExecuteNonQuery();

                        con.Close();

                        return true;
                    }

                }

            }
            catch (Exception error)
            {
                error.ToString();
              
            }
            
            return false;
        }
        public bool UpdateEmployee(Employee emp, User user, Address addr, Email email, string username)
        {
            try
            {
                using (var con = new SqlConnection(ConString))
                {
                    con.Open();
                    using (var com = new SqlCommand("SpUpdateEmployeeByID", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;

                        com.Parameters.AddWithValue("@EmployeeID", emp.EmployeeID);
                        com.Parameters.AddWithValue("@PersonID", user.UserID);

                        com.Parameters.AddWithValue("@FirstName", user.Firstname);
                        com.Parameters.AddWithValue("@LastName", user.Lastname);
                        com.Parameters.AddWithValue("@MobileNo", user.ContactNumber);
                        com.Parameters.AddWithValue("@TelephoneNo", user.TelephoneNo);

                        com.Parameters.AddWithValue("@HouseNo", addr.HouseNo);
                        com.Parameters.AddWithValue("@Street", addr.Street);
                        com.Parameters.AddWithValue("@Barangay", addr.Barangay);
                        com.Parameters.AddWithValue("@City", addr.City);

                        com.Parameters.AddWithValue("@DateHired", emp.DateHired);
                        com.Parameters.AddWithValue("@Status", emp.EmployeeStatus);
                        com.Parameters.AddWithValue("@Position", emp.Position);
                        com.Parameters.AddWithValue("@TypeOfContract", "none");

                  //      com.Parameters.AddWithValue("@Username", user.Username);
                  //      com.Parameters.AddWithValue("@Password", enc.PassWordEncryptor(user.Password));
                        com.Parameters.AddWithValue("@Email", email.EmailAddress);
                        com.Parameters.AddWithValue("@AccTypeID", emp.AccountTypeID);

                        com.ExecuteNonQuery();



                    }
                    con.Close();
                    return true;
                }

               
            }
            catch (Exception error)
            {
                error.ToString();           
               
            }
           
            return false;
        }
        public DataTable GetEmployees()
        {
         
      //      string ConString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RFBDesktopApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            try
            {
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    using (SqlCommand com = new SqlCommand("[SpGetEmployees]", con))
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
        public DataTable FindEmployees(string searched)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ConString))
            {
                try
                {

                    using (SqlCommand com = new SqlCommand("[SpSearchSchedules]", con))
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
        public DataTable GetEmployeeName()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    using (SqlCommand com = new SqlCommand("[SpGetEmployeeName]", con))
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

        #region attendace ops
        public List<string> GetEmployeeName(string code)
        {

            var details = new List<string>();

            using (var con = new SqlConnection(ConString))
            {
                con.Open();
                using (var com = new SqlCommand("[SpGetEmployeeNameByCode]", con))
                {
                    if (code != null)
                    {
                        com.CommandType = CommandType.StoredProcedure;

                        com.Parameters.AddWithValue("@code", code);

                        var reader = com.ExecuteReader();

                        while (reader.Read())
                        {
                            details.Add(reader["FirstName"].ToString());
                            details.Add(reader["LastName"].ToString());
                            details.Add(reader["EmployeeID"].ToString());
                        }
                        con.Close();
                        return details;
                    }
                    else
                    {
                        return details;
                    }
                }

            }
        }
        public bool AddAttendance(string id, string timein, string timeout, DateTime workdate, string workhrs)
        {
            using (var con = new SqlConnection(ConString))
            {
               
                using (var com = new SqlCommand("[SpAddAttendance]", con))
                {
                    con.Open();
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@employeeID", id);
                    com.Parameters.AddWithValue("@timein", timein);
                    com.Parameters.AddWithValue("@timeout", timeout);
                    com.Parameters.AddWithValue("@Workdate", workdate);
                    com.Parameters.AddWithValue("@workhrs", workhrs);
                    com.ExecuteNonQuery();

                    con.Close();
                    return true;

                }
            }
        }
        public bool UpdateAttendance(string id, string timein, string timeout, string workhrs, DateTime workdate)
        {
            using (var con = new SqlConnection(ConString))
            {

                using (var com = new SqlCommand("[SpUpdateAttendance]", con))
                {
                    con.Open();
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@employeeID", id);
                    com.Parameters.AddWithValue("@timein", timein);
                    com.Parameters.AddWithValue("@timeout", timeout);
                    com.Parameters.AddWithValue("@Workdate", workdate);
                    com.Parameters.AddWithValue("@workhrs", workhrs);
                    com.ExecuteNonQuery();

                    con.Close();
                    return true;

                }
            }
        }
        public DataTable GetAttendance()
        {
            using (var con = new SqlConnection(ConString))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("[SpGetAttendances]", con))
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
        public DataTable FindAttendance(string searched)
        {
          
            using (SqlConnection con = new SqlConnection(ConString))
            {
                try
                {

                    using (SqlCommand com = new SqlCommand("[SpSearchAttendances]", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;

                        com.Parameters.AddWithValue("@Search", searched);
                        SqlDataAdapter sds = new SqlDataAdapter(com); // passes the desired query
                        dt.Clear();
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
        #endregion

    }
}
