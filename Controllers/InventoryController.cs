using SSIP.Helper;
using SSIP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SSIP.Models.Inventories;

namespace SSIP.Controllers
{
    public class InventoryController
    {
        #region private fields
        private string ConString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RFBDesktopApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        #endregion

        #region declarations
        PasswordEncryptor enc = new PasswordEncryptor();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        #endregion

        #region product inventory main ops
        public bool AddProduct(ProductInventory inv)
        {        
            try
            {
                using (var con = new SqlConnection(ConString))
                {
                    using (var com = new SqlCommand("[SpAddProducts]", con))
                    {
                        con.Open();
                        com.CommandType = CommandType.StoredProcedure;

                        com.Parameters.AddWithValue("@Name", inv.Name);
                        com.Parameters.AddWithValue("@desc", inv.Description);
                        com.Parameters.AddWithValue("@price", inv.UnitPrice);
                        com.Parameters.AddWithValue("@code", inv.ProductCode);
                        com.Parameters.AddWithValue("@category", inv.Category);                 
                        com.Parameters.AddWithValue("@recordedBy", inv.RecordedBy);
                       
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
        public bool UpdateProduct(ProductInventory inv)
        {
            try
            {
                using (var con = new SqlConnection(ConString))
                {
                    con.Open();
                    using (var com = new SqlCommand("[SpUpdateProductByID]", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;

                        com.Parameters.AddWithValue("@id", inv.productID);
                        com.Parameters.AddWithValue("@Name", inv.Name);
                        com.Parameters.AddWithValue("@desc", inv.Description);
                        com.Parameters.AddWithValue("@price", inv.UnitPrice);
                        com.Parameters.AddWithValue("@category", inv.Category);
                        com.Parameters.AddWithValue("@recordedBy", inv.RecordedBy);

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
        public bool DeactivateProduct(string id)
        {
            try
            {
                using (var con = new SqlConnection(ConString))
                {
                    con.Open();
                    using (var com = new SqlCommand("[SpDeactivateProduct]", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;

                        com.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                      
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
        public DataTable GetProducts()
        {
            //      string ConString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RFBDesktopApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            try
            {
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    using (SqlCommand com = new SqlCommand("[SpGetProducts]", con))
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
        public DataTable FindProduct(string searched)
        {
            using (SqlConnection con = new SqlConnection(ConString))
            {
                try
                {
                    using (SqlCommand com = new SqlCommand("[SpSearchProducts]", con))
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

        #region equipment inventory main ops
        public bool AddItem(EquipmentInventory inv)
        {
            try
            {
                using (var con = new SqlConnection(ConString))
                {
                    using (var com = new SqlCommand("[SpAddEquipment]", con))
                    {
                        con.Open();
                        com.CommandType = CommandType.StoredProcedure;

                        com.Parameters.AddWithValue("@Name", inv.Name);
                        com.Parameters.AddWithValue("@desc", inv.Description);
                        com.Parameters.AddWithValue("@price", inv.UnitPrice);
                        com.Parameters.AddWithValue("@code", inv.ProductCode);
                        com.Parameters.AddWithValue("@recordedBy", inv.RecordedBy);
                        com.Parameters.AddWithValue("@datepurchased", inv.DatePurchased);

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
        public bool UpdateItem(EquipmentInventory inv)
        {
            try
            {
                using (var con = new SqlConnection(ConString))
                {
                    con.Open();
                    using (var com = new SqlCommand("[SpUpdateEquipByID]", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;

                        com.Parameters.AddWithValue("@id", inv.EquipmentID);
                        com.Parameters.AddWithValue("@Name", inv.Name);
                        com.Parameters.AddWithValue("@desc", inv.Description);
                        com.Parameters.AddWithValue("@price", inv.UnitPrice);
                        com.Parameters.AddWithValue("@recordedBy", inv.RecordedBy);
                        com.Parameters.AddWithValue("@datepurchased", inv.DatePurchased);
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
        public DataTable GetItems()
        {
          try
            {
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    using (SqlCommand com = new SqlCommand("[SpGetEquipments]", con))
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
        public DataTable FindItem(string searched)
        {      
            using (SqlConnection con = new SqlConnection(ConString))
            {
                try
                {
                    using (SqlCommand com = new SqlCommand("[SpSearchEquipment]", con))
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
