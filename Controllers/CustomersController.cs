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
    public class CustomersController
    {
        #region private fields
        // private static string ConString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        string ConString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RFBDesktopApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

     //   AuditController aud = new AuditController();
        #endregion

        #region declarations
        PasswordEncryptor enc = new PasswordEncryptor();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        #endregion
        
        #region customers operations
        public bool AddCustomer(Employee emp, User user, Address addr, Email email)
        {
            try
            {
                using (var con = new SqlConnection(ConString))
                {
                    using (var com = new SqlCommand("[SpAddNewCustomer]", con))
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

                        com.Parameters.AddWithValue("@Email", email.EmailAddress);
                        com.Parameters.AddWithValue("@Status", emp.EmployeeStatus);

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
            // audit here
            return false;
        }
        public bool UpdateCustomer(Employee emp, User user, Address addr, Email email)
        {
            try
            {
                using (var con = new SqlConnection(ConString))
                {
                    con.Open();
                    using (var com = new SqlCommand("[SpUpdateCustomerByID]", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;

                        com.Parameters.AddWithValue("@PersonID", user.UserID);

                        com.Parameters.AddWithValue("@FirstName", user.Firstname);
                        com.Parameters.AddWithValue("@LastName", user.Lastname);
                        com.Parameters.AddWithValue("@MobileNo", user.ContactNumber);
                        com.Parameters.AddWithValue("@TelephoneNo", user.TelephoneNo);

                        com.Parameters.AddWithValue("@HouseNo", addr.HouseNo);
                        com.Parameters.AddWithValue("@Street", addr.Street);
                        com.Parameters.AddWithValue("@Barangay", addr.Barangay);
                        com.Parameters.AddWithValue("@City", addr.City);

                        com.Parameters.AddWithValue("@Email", email.EmailAddress);
                        com.Parameters.AddWithValue("@Status", emp.EmployeeStatus);

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
        public DataTable GetCustomers()
        {     
            //      string ConString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RFBDesktopApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            try
            {
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    using (SqlCommand com = new SqlCommand("[SpGetCustomers]", con))
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
