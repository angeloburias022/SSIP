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
            private static string ConString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            #endregion

        #region declarations
        public EmployeesController()
        {
        }

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

                        com.ExecuteNonQuery();

                        con.Close();


                        // audit here
                        return true;
                    }

                }

            }
            catch (Exception error)
            {
                error.ToString();
                // audit here
                return false;
            }

        }
        public bool UpdateEmployee(Employee emp, User user, Address addr, Email email)
        {
            try
            {
                using (var con = new SqlConnection(ConString))
                {
                    con.Open();
                    using (var com = new SqlCommand("SpUpdateEmployee", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;

                        com.Parameters.AddWithValue("@EmployeeID", emp.EmployeeID);

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

                        com.ExecuteNonQuery();

                    }
                    con.Close();
                }

                // audit here
                return true;
            }
            catch (Exception error)
            {
                error.ToString();
                // audit here
            }
            // audit here
            return false;
        }
        #endregion

    }
}
