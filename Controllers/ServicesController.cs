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
    public class ServicesController
    {

        private static string ConString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        AuditController aud = new AuditController();
        public ServicesController()
        {
        }

        public bool AddService(User user,Address address, Schedule sched, Dispatch dis)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConString))
                {
                    conn.Open();
   
                    if (sched.Status == "Dispatch") // add dispatch
                    {
                        if (sched.ScheduleID != 0) // new dispatch for a existing schedule
                        {
                            try
                            {
                                using (SqlCommand cmd = new SqlCommand("[SpInsertDispatch]", conn))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    // Customer's Details

                                    cmd.Parameters.Add("@TimeIn", SqlDbType.VarChar).Value = dis.TimeOut;
                                    cmd.Parameters.Add("@TimeOut", SqlDbType.VarChar).Value = dis.TimeOut;

                                    cmd.Parameters.Add("@Team1", SqlDbType.VarChar).Value = dis.AssignTeam;
                                    //cmd.Parameters.Add("@Team2", SqlDbType.VarChar).Value = dis.Team.Text;
                                    //cmd.Parameters.Add("@Team3", SqlDbType.VarChar).Value = tb_assign3.Text;

                                    cmd.Parameters.Add("@ServiceTime", SqlDbType.VarChar).Value = sched.ServiceTime;
                                    cmd.Parameters.Add("@ServiceDate", SqlDbType.DateTime).Value = sched.ScheduleDate;

                                    cmd.Parameters.Add("@Brand", SqlDbType.VarChar).Value = sched.Brand;
                                    cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = sched.Quantity;
                                    cmd.Parameters.Add("@ServiceType", SqlDbType.VarChar).Value = sched.ServiceType;
                                    cmd.Parameters.Add("@Actype", SqlDbType.VarChar).Value = sched.AirconType;

                                    cmd.Parameters.Add("@DispatchDate", SqlDbType.DateTime).Value = dis.dispatchdate;
                                    cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = sched.Status;
                                    cmd.Parameters.Add("@SchedID", SqlDbType.Int).Value = sched.ScheduleID;


                                    cmd.ExecuteNonQuery();

                                    var addDispatch = new AuditTrails
                                    {
                                        Username = user.Username,
                                        AuditActionTypeENUM = (Enums.ActionTypes)3,
                                        DateTimeStamp = DateTime.Now.ToString(),
                                        Result = "Succeed"
                                    };

                                    aud.Logs(addDispatch);

                                    return true;
                                }
                            }
                            catch (Exception error)
                            {
                                error.ToString();
                            }

                            var failedDispatch = new AuditTrails
                            {
                                Username = user.Username,
                                AuditActionTypeENUM = (Enums.ActionTypes)3,
                                DateTimeStamp = DateTime.Now.ToString(),
                                Result = "Failed"
                            };

                            aud.Logs(failedDispatch);


                            return false;
                        }
                        else // direct dispatch (customers with no records in the database)
                        {
                            try
                            {
                                using (SqlCommand cmd = new SqlCommand("[spAddNewCustomerDispatch]", conn))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    // Customer's Details
                                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = user.Firstname;
                                    cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = user.Lastname;
                                    cmd.Parameters.Add("@MobileNo", SqlDbType.VarChar).Value = user.ContactNumber;
                                    cmd.Parameters.Add("@TelephoneNo", SqlDbType.VarChar).Value = user.TelephoneNo;

                                    // address	
                                    cmd.Parameters.Add("@HouseNo", SqlDbType.Int).Value = address.HouseNo;
                                    cmd.Parameters.Add("@Street", SqlDbType.VarChar).Value = address.Street;
                                    cmd.Parameters.Add("@Barangay", SqlDbType.VarChar).Value = address.Barangay;
                                    cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = address.City;

                                    // Service Details
                                    cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = sched.Quantity;
                                    cmd.Parameters.Add("@ServiceType", SqlDbType.VarChar).Value = sched.ServiceType;
                                    cmd.Parameters.Add("@Brand", SqlDbType.VarChar).Value = sched.Brand;
                                    cmd.Parameters.Add("@AcType", SqlDbType.VarChar).Value = sched.AirconType;

                                    cmd.Parameters.Add("@ServiceTime", SqlDbType.VarChar).Value = sched.ServiceTime;
                                    cmd.Parameters.Add("@RecordedBy", SqlDbType.VarChar).Value = sched.RecordedBy;
                                    cmd.Parameters.Add("@ServiceDate", SqlDbType.DateTime).Value = sched.ScheduleDate;
                                    cmd.Parameters.Add("@ServiceStatus", SqlDbType.VarChar).Value = sched.Status;

                                    cmd.Parameters.Add("@TimeIn", SqlDbType.VarChar).Value = dis.TimeOut;
                                    cmd.Parameters.Add("@TimeOut", SqlDbType.VarChar).Value = dis.TimeOut;
                                    cmd.Parameters.Add("@Team1", SqlDbType.VarChar).Value = dis.AssignTeam;
                                    cmd.Parameters.Add("@DispatchDate", SqlDbType.DateTime).Value = dis.dispatchdate;

                                    cmd.ExecuteNonQuery();
                                      
                                    var newddispatch = new AuditTrails
                                    {
                                        Username = user.Username,
                                        AuditActionTypeENUM = (Enums.ActionTypes)3,
                                        DateTimeStamp = DateTime.Now.ToString(),
                                        Result = "Succeed"
                                    };

                                    aud.Logs(newddispatch);
                                    return true;
                                }
                            }
                            catch (Exception error)
                            {
                                error.ToString();
                            }

                            var faileddispatch = new AuditTrails
                            {
                                Username = user.Username,
                                AuditActionTypeENUM = (Enums.ActionTypes)3,
                                DateTimeStamp = DateTime.Now.ToString(),
                                Result = "Failed"
                            };

                            aud.Logs(faileddispatch);

                            return false;
                        }
                    }
                    else if (sched.Status == "Schedule")
                    {
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand("[SpInsertSchedule]", conn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.Add("@ExistingCustomerID", SqlDbType.Int).Value = user.UserID;

                                // Customer's Details
                                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = user.Firstname;
                                cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = user.Lastname;
                                cmd.Parameters.Add("@MobileNo", SqlDbType.VarChar).Value = user.ContactNumber;
                                cmd.Parameters.Add("@TelephoneNo", SqlDbType.VarChar).Value = user.TelephoneNo;

                                // address	
                                cmd.Parameters.Add("@HouseNo", SqlDbType.Int).Value = address.HouseNo;
                                cmd.Parameters.Add("@Street", SqlDbType.VarChar).Value = address.Street;
                                cmd.Parameters.Add("@Barangay", SqlDbType.VarChar).Value = address.Barangay;
                                cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = address.City;

                                // Service Details
                                cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = sched.Quantity;
                                cmd.Parameters.Add("@ServiceType", SqlDbType.VarChar).Value = sched.ServiceType;
                                cmd.Parameters.Add("@Brand", SqlDbType.VarChar).Value = sched.Brand;
                                cmd.Parameters.Add("@AcType", SqlDbType.VarChar).Value = sched.AirconType;

                                cmd.Parameters.Add("@ServiceTime", SqlDbType.VarChar).Value = sched.ServiceTime;
                                cmd.Parameters.Add("@RecordedBy", SqlDbType.VarChar).Value = sched.RecordedBy;
                                cmd.Parameters.Add("@ServiceDate", SqlDbType.DateTime).Value = sched.ScheduleDate;
                                cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = sched.Status;

                                cmd.ExecuteNonQuery();

                                return true;
                            }
                        }
                        catch (Exception error)
                        {
                            error.ToString();
                        }
                    }  
                        
                    conn.Close();
                }
            }
            catch (Exception error)
            {
                error.ToString();
            }
            return false;
        }

    }
}
