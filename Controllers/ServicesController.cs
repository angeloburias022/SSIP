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

namespace SSIP.Controllers
{
    public class ServicesController
    {
        #region declarations
        AuditController aud = new AuditController();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        ConnectionDB db = new ConnectionDB();
        public ServicesController()
        {
        }
        #endregion

        #region Services operation
        public bool AddService(User user, Address address, Schedule sched, Dispatch dis)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(db.ConString()))
                {
                    conn.Open();

                    if (sched.Status == "Dispatch" || sched.Status == "Done / Paid") // add dispatch
                    {
                        if (sched.ScheduleID != 0) // new dispatch for a existing schedule
                        {
                            try
                            {
                                using (SqlCommand cmd = new SqlCommand("[SpAddDispatch]", conn))
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
                                    cmd.Parameters.Add("@Amount", SqlDbType.VarChar).Value = dis.PaidAmount;


                                    cmd.ExecuteNonQuery();

                                    var addDispatch = new AuditTrails
                                    {
                                        Username = user.Username,
                                        AuditActionTypeENUM = (Enums.ActionTypes)3,
                                        DateTimeStamp = DateTime.Now.ToString(),
                                        Result = "Succeed",
                                        Description = "Added Successfully on Schedule ID: " + sched.ScheduleID + " "
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
                                Result = "Failed",
                                Description = "Failed Adding dispatch in Schedule ID: " + sched.ScheduleID + " "
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
                                    cmd.Parameters.Add("@HouseNo", SqlDbType.VarChar).Value = address.HouseNo;
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

                                    cmd.Parameters.Add("@Amount", SqlDbType.VarChar).Value = dis.PaidAmount;

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

                                var newSched = new AuditTrails
                                {
                                    Username = user.Username,
                                    AuditActionTypeENUM = (Enums.ActionTypes)3,
                                    DateTimeStamp = DateTime.Now.ToString(),
                                    Result = "Succeed",
                                    Description = "Added schedule successfully "
                                };

                                aud.Logs(newSched);
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

        public bool UpdateService(User user, Customer cus, Address address, Schedule sched, Dispatch dis)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(db.ConString()))
                {
                    conn.Open();

                    if (sched.Status == "Dispatch" || sched.Status == "Done / Paid") // add dispatch
                    {
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand("[spUpdateDispatch]", conn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;


                                cmd.Parameters.Add("@DispatchID", SqlDbType.VarChar).Value = dis.DispatchID;
                                cmd.Parameters.Add("@ScheduleID", SqlDbType.VarChar).Value = sched.ScheduleID;
                                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = cus.CustomerID;

                                // Customer's Details
                                //cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = user.Firstname;
                                //cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = user.Lastname;
                                //cmd.Parameters.Add("@MobileNo", SqlDbType.VarChar).Value = user.ContactNumber;
                                //cmd.Parameters.Add("@TelephoneNo", SqlDbType.VarChar).Value = user.TelephoneNo;

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

                                cmd.Parameters.Add("@Amount", SqlDbType.VarChar).Value = dis.PaidAmount;


                                cmd.ExecuteNonQuery();

                                var updatedispatch = new AuditTrails
                                {
                                    Username = user.Username,
                                    AuditActionTypeENUM = (Enums.ActionTypes)4,
                                    DateTimeStamp = DateTime.Now.ToString(),
                                    Result = "Succeed",
                                    Description = "Updated Dispatch ID: " + dis.DispatchID + " "
                                };

                                aud.Logs(updatedispatch);
                                return true;
                            }
                        }
                        catch (Exception error)
                        {
                            error.ToString();
                        }

                        var failedUpdate = new AuditTrails
                        {
                            Username = user.Username,
                            AuditActionTypeENUM = (Enums.ActionTypes)4,
                            DateTimeStamp = DateTime.Now.ToString(),
                            Result = "Failed",
                            Description = "Failed Attempt Update on Dispatch ID: " + dis.DispatchID + " "
                        };

                        aud.Logs(failedUpdate);

                        return false;
                    }
                    else if (sched.Status == "Schedule")
                    {
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand("[SpUpdateSchedule]", conn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;


                                cmd.Parameters.Add("@ScheduleID", SqlDbType.VarChar).Value = sched.ScheduleID;
                                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = cus.CustomerID;

                                // Customer's Details
                                //cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = user.Firstname;
                                //cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = user.Lastname;
                                //cmd.Parameters.Add("@MobileNo", SqlDbType.VarChar).Value = user.ContactNumber;
                                //cmd.Parameters.Add("@TelephoneNo", SqlDbType.VarChar).Value = user.TelephoneNo;

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

                                cmd.ExecuteNonQuery();
                                var updateSched = new AuditTrails
                                {
                                    Username = user.Username,
                                    AuditActionTypeENUM = (Enums.ActionTypes)4,
                                    DateTimeStamp = DateTime.Now.ToString(),
                                    Result = "Succeed",
                                    Description = "Updated Schedule ID: " + sched.ScheduleID + " "
                                };

                                aud.Logs(updateSched);

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

        public DataTable GetDispatches()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(db.ConString()))
                {
                    using (SqlCommand com = new SqlCommand("[SpGetDispatched]", con))
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

        public DataTable GetSchedules()
        {
           try
            {


                using (SqlConnection con = new SqlConnection(db.ConString()))
                {
                    using (SqlCommand com = new SqlCommand("[SpGetSchedules]", con))
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

        public DataTable FindSchedule(string searched)
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

        public DataTable FindDispatch(string searched)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(db.ConString()))
            {

                try
                {

                    using (SqlCommand com = new SqlCommand("[SpSearchDispatches]", con))
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

        #endregion
    }
}
