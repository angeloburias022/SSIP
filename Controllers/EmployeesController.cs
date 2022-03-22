using SSIP.DbAccess;
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

        #endregion

        #region declarations
        public EmployeesController()
        {
        }
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        PasswordEncryptor enc = new PasswordEncryptor();
        AuditController aud = new AuditController();
        ConnectionDB db = new ConnectionDB();
        #endregion

        #region employee operations
        public bool AddEmployee(Employee emp)
        {
            try
            {
                using (var con = new SqlConnection(db.ConString()))
                {
                    using (var com = new SqlCommand("[SpAddEmployee]", con))
                    {
                        con.Open();
                        com.CommandType = CommandType.StoredProcedure;

                        com.Parameters.AddWithValue("@FirstName", emp.user_info.Firstname);
                        com.Parameters.AddWithValue("@LastName", emp.user_info.Lastname);
                        com.Parameters.AddWithValue("@MobileNo", emp.user_info.ContactNumber);
                        com.Parameters.AddWithValue("@TelephoneNo", emp.user_info.TelephoneNo);

                        com.Parameters.AddWithValue("@HouseNo", emp.address_info.HouseNo);
                        com.Parameters.AddWithValue("@Street", emp.address_info.Street);
                        com.Parameters.AddWithValue("@Barangay", emp.address_info.Barangay);
                        com.Parameters.AddWithValue("@City", emp.address_info.City);

                        com.Parameters.AddWithValue("@DateHired", emp.DateHired);
                        com.Parameters.AddWithValue("@Status", emp.EmployeeStatus);
                        com.Parameters.AddWithValue("@Position", emp.Position);
                        com.Parameters.AddWithValue("@TypeOfContract", emp.TypeOfContract);

                        com.Parameters.AddWithValue("@Username", emp.user_info.Username);
                        com.Parameters.AddWithValue("@Password", enc.PassWordEncryptor(emp.user_info.Password));
                        com.Parameters.AddWithValue("@Email", emp.email_info.EmailAddress);
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
        public bool UpdateEmployee(Employee emp, string username)
        {
            try
            {
                using (var con = new SqlConnection(db.ConString()))
                {
                    con.Open();
                    using (var com = new SqlCommand("SpUpdateEmployeeByID", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;

                        com.Parameters.AddWithValue("@EmployeeID", emp.EmployeeID);
                        com.Parameters.AddWithValue("@PersonID", emp.user_info.UserID);

                        com.Parameters.AddWithValue("@FirstName", emp.user_info.Firstname);
                        com.Parameters.AddWithValue("@LastName", emp.user_info.Lastname);
                        com.Parameters.AddWithValue("@MobileNo", emp.user_info.ContactNumber);
                        com.Parameters.AddWithValue("@TelephoneNo", emp.user_info.TelephoneNo);

                        com.Parameters.AddWithValue("@HouseNo", emp.address_info.HouseNo);
                        com.Parameters.AddWithValue("@Street", emp.address_info.Street);
                        com.Parameters.AddWithValue("@Barangay", emp.address_info.Barangay);
                        com.Parameters.AddWithValue("@City", emp.address_info.City);

                        com.Parameters.AddWithValue("@DateHired", emp.DateHired);
                        com.Parameters.AddWithValue("@Status", emp.EmployeeStatus);
                        com.Parameters.AddWithValue("@Position", emp.Position);
                        com.Parameters.AddWithValue("@TypeOfContract", "none");

                  //      com.Parameters.AddWithValue("@Username", user.Username);
                  //      com.Parameters.AddWithValue("@Password", enc.PassWordEncryptor(user.Password));
                        com.Parameters.AddWithValue("@Email", emp.email_info.EmailAddress);
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
                using (SqlConnection con = new SqlConnection(db.ConString()))
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
            using (SqlConnection con = new SqlConnection(db.ConString()))
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
                using (SqlConnection con = new SqlConnection(db.ConString()))
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

            using (var con = new SqlConnection(db.ConString()))
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
        public bool AddAttendance(string id, DateTime timein, DateTime timeout, DateTime workdate, string workhrs)
        {
            using (var con = new SqlConnection(db.ConString()))
            {
               
                using (var com = new SqlCommand("[SpAddAttendance]", con))
                {
                    con.Open();
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@employeeID", id);
                    com.Parameters.AddWithValue("@timein", timein);
                    com.Parameters.AddWithValue("@timeout", timeout);
                    com.Parameters.AddWithValue("@Workdate", DateTime.Now.ToShortDateString());
                    com.Parameters.AddWithValue("@workhrs", workhrs);
                    com.ExecuteNonQuery();

                    con.Close();
                    return true;

                }
            }
        }
        public bool UpdateAttendance(string id, DateTime timein, DateTime timeout, string workhrs, DateTime workdate)
        {
            using (var con = new SqlConnection(db.ConString()))
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
            using (var con = new SqlConnection(db.ConString()))
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
          
            using (SqlConnection con = new SqlConnection(db.ConString()))
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

        public List<string> HasTimeInToday(string code)
        {
            var details = new List<string>();
            using (var con = new SqlConnection(db.ConString()))
            {
                using (var com = new SqlCommand("[SpGetTimeIn]", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    var datenow = DateTime.Now.ToShortDateString();

                    com.Parameters.AddWithValue("@DateNow", datenow);
                    com.Parameters.AddWithValue("@code", code);

                    var reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        details.Add(reader["Time_in"].ToString());                       
                    }

                    con.Close();

                    return details;
                }
            }
          
        }
        #endregion

    }
}
