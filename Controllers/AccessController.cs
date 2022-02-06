using SSIP.Forms;
using SSIP.Helper;
using SSIP.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSIP.Controllers
{
    public class AccessController
    {
        #region declrations
        private static string ConString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        PasswordEncryptor enc = new PasswordEncryptor();
        #endregion

        #region Login
        public bool Login(User user)
        {
            try
            {
                if (user.Username == "" && user.Password == "")
                {
                    MessageBox.Show("Please Check your username and password");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(ConString))
                    {
                        // it will check the device if there is an existing database
                        if (CheckDatabaseExists(con, "RFBDesktopApp"))
                        {
                            using (SqlCommand cmd = new SqlCommand("[SpLoginUser]", con))
                            {
                                // Transaction tr = new Transaction();
                                Dashboard db = new Dashboard();
                                Login lgg = new Login();
                                cmd.CommandType = CommandType.StoredProcedure;
                                con.Open();
                                cmd.Parameters.Add("@Uname", SqlDbType.VarChar).Value = user.Username;
                                var pwdEncrypt = enc.PassWordEncryptor(user.Password);
                                cmd.Parameters.Add("@Pwd", SqlDbType.VarChar).Value = pwdEncrypt;

                                SqlDataAdapter da = new SqlDataAdapter(cmd);
                                DataTable dt = new DataTable();
                                da.Fill(dt);

                                if (dt.Rows.Count > 0)
                                {
                                   // db.ShowDialog();
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show("Your password or Username might incorrect. Please input it again. Thank you!");
                                }


                                con.Close();
                            }
                        }
                        else
                        {
                            CreateDatabase(con, "RFBDesktopApp");

                            using (SqlCommand cmd = new SqlCommand("[SpLoginUser]", con))
                            {
                                // Transaction tr = new Transaction();
                                Dashboard db = new Dashboard();
                                Login lgg = new Login();
                                cmd.CommandType = CommandType.StoredProcedure;
                                con.Open();
                                cmd.Parameters.Add("@Uname", SqlDbType.VarChar).Value = user.Username;
                                var pwdEncrypt = enc.PassWordEncryptor(user.Password);
                                cmd.Parameters.Add("@Pwd", SqlDbType.VarChar).Value = pwdEncrypt;

                                SqlDataAdapter da = new SqlDataAdapter(cmd);
                                DataTable dt = new DataTable();
                                da.Fill(dt);

                                if (dt.Rows.Count > 0)
                                {
                                    MessageBox.Show("Access Granted");
                                    db.Show();
                                    lgg.Close();

                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show("Your password or Username might incorrect. Please input it again. Thank you!");
                                }

                                con.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong" + error);
            }

            return true;
        }
        #endregion

        #region Create Database
        // Create an entire db if there is no existing one 
        public static bool CreateDatabase(SqlConnection connection, string txtDatabase)
        {
            //  String CreateDatabase;

            // Gets the path of this application
            string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            // Pass the value inside the GrantAccess function in order to be allow in creating database
            GrantAccess(appPath); //Need to assign the permission for current application to allow create database on server (if you are in domain).

            // Store the CheckDatabaseExists inside a boolean 
            bool IsExist = CheckDatabaseExists(connection, txtDatabase); //Check database exists in sql server.
            if (!IsExist)
            {
                //  string script = File.ReadAllText(@"C:\Users\home pc\source\repos\RFBDesktopSystem\RFBScript.sql");


                string script = File.ReadAllText(@"\RFBDesktopSystem\sql_script\9421RFBScript.sql");

                IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

                try
                {
                    foreach (string commandString in commandStrings)
                    {
                        using (SqlConnection con = new SqlConnection(ConString))
                        {
                            con.Open();
                            if (commandString.Trim() != "")
                            {
                                new SqlCommand(commandString, connection).ExecuteNonQuery();
                            }
                            con.Close();
                        }
                    }
                    //    CreateDatabase = ex.Execute(script, ConString);

                }


                catch (System.Exception exx)
                {
                    string Text = "hey";
                    MessageBox.Show("Please Check Server and Database name.Server and Database name are incorrect .'" + exx + "'", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
                using (SqlCommand com = new SqlCommand("[SpCreateTable]", connection))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    com.ExecuteNonQuery();

                }

                return true;
            }
            return true;
        }
        #endregion

        #region Grant access to this project to access a Database
        // Grants access to this app 
        public static bool GrantAccess(string fullPath)
        {
            try
            {
                DirectoryInfo info = new DirectoryInfo(fullPath);
                WindowsIdentity self = System.Security.Principal.WindowsIdentity.GetCurrent();
                DirectorySecurity ds = info.GetAccessControl();
                ds.AddAccessRule(new FileSystemAccessRule(self.Name,
                FileSystemRights.FullControl,
                InheritanceFlags.ObjectInherit |
                InheritanceFlags.ContainerInherit,
                PropagationFlags.None,
                AccessControlType.Allow));
                info.SetAccessControl(ds);

            }
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong" + error);

                return false;
            }


            return true;
        }
        #endregion

        #region Checks if the DB exist     
        public static bool CheckDatabaseExists(SqlConnection tmpConn, string databaseName)
        {
            string sqlCreateDBQuery;
            bool result = false;

            try
            {
                sqlCreateDBQuery = string.Format("SELECT database_id FROM sys.databases WHERE Name = '{0}'", databaseName);
                using (SqlCommand sqlCmd = new SqlCommand(sqlCreateDBQuery, tmpConn))
                {
                    tmpConn.Open();
                    object resultObj = sqlCmd.ExecuteScalar();
                    int databaseID = 0;
                    if (resultObj != null)
                    {
                        int.TryParse(resultObj.ToString(), out databaseID);
                    }
                    tmpConn.Close();
                    result = (databaseID > 0);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong" + error);
                result = false;
            }
            return result;
        }

        #endregion
    }
}
