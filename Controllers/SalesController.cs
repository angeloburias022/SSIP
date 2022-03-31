using SSIP.DbAccess;
using SSIP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSIP.Controllers
{
    public class SalesController
    {
        DataTable dt = new DataTable();
        ConnectionDB db = new ConnectionDB();
        public List<string> GetProductDetails(string code)
        {
            var details = new List<string>();

            using (var con = new SqlConnection(db.ConString()))
            {
                con.Open();
                using (var com = new SqlCommand("[SpProductByCode]", con))
                {
                    if (code != null)
                    {
                        com.CommandType = CommandType.StoredProcedure;

                        com.Parameters.AddWithValue("@code", code);

                        var reader = com.ExecuteReader();

                        while (reader.Read())
                        {
                            details.Add(reader["ProductID"].ToString());
                            details.Add(reader["ProductName"].ToString());
                            details.Add(reader["Price"].ToString());
                            details.Add(reader["ProductCode"].ToString());
                            details.Add(reader["Description"].ToString());
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
        public List<string> GetProduct(string search)
        {
            DataTable dt = new DataTable();
            var details = new List<string>();
            using (SqlConnection con = new SqlConnection(db.ConString()))
            {
                try
                {
                    using (var com = new SqlCommand("[SpFindProduct]", con))
                    {
                        con.Open();
                        if (search != null)
                        {
                            com.CommandType = CommandType.StoredProcedure;

                            com.Parameters.AddWithValue("@Search", search);

                            var reader = com.ExecuteReader();

                            while (reader.Read())
                            {
                                details.Add(reader["ProductID"].ToString());
                                details.Add(reader["ProductName"].ToString());
                                details.Add(reader["UnitPrice"].ToString());
                                details.Add(reader["ProductCode"].ToString());
                                details.Add(reader["Description"].ToString());
                                details.Add(reader["CategoryID"].ToString());
                                details.Add(reader["Quantity"].ToString());
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
                catch (Exception error)
                {

                    error.ToString();
                }
                
            }
            return details;
        }
        public DataTable GetProducts<T>(List<T> records)
        {
            DataTable dt = new DataTable();

            var type = typeof(T);

            // add rows

            for (int i = 0; i < records.Count(); i++)
            {
                dt.Rows.Add(dt.NewRow());
            }

            foreach (var prop in type.GetProperties())
            {
                DataColumn cl = new DataColumn(prop.Name);
                cl.DataType = prop.PropertyType;
                dt.Columns.Add(cl);

                // add values in each cell of table  
                int rowsindex = 0;

                foreach (var item in records)
                {
                    DataRow dr = dt.Rows[rowsindex++];
                    dr[prop.Name] = prop.GetValue(item);
                }
            }
            return dt;
        }
        public bool AddProducts<T>(List<T> records)
        {
            DataTable dt = GetProducts(records);

            using (var con = new SqlConnection(db.ConString()))
            {
                using (var bulk = new SqlBulkCopy(con))
                {
                    con.Open();
                    bulk.DestinationTableName = "Orders";
                    bulk.WriteToServer(dt);

                }
            }
            return true;
        }
        public void AddTransaction(DataGridViewRow dr, Sales sa)
        {
            try
            {
                using (var con = new SqlConnection(db.ConString()))
                {
                    using (var com = new SqlCommand("SpAddOrders", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        //     com.Parameters.AddWithValue("", dr.Cells["ProductID"].Value ?? DBNull.Value);

                        com.Parameters.AddWithValue("@ProductName", dr.Cells["Name"].Value ?? DBNull.Value);
                        com.Parameters.AddWithValue("@ProductQuantity", dr.Cells["Quantity"].Value ?? DBNull.Value);
                        com.Parameters.AddWithValue("@UnitPrice", dr.Cells["Unit Price"].Value ?? DBNull.Value);
                        com.Parameters.AddWithValue("@TotalPrice", dr.Cells["Total Price"].Value ?? DBNull.Value);
                        com.Parameters.AddWithValue("@ProductCode", dr.Cells["Code"].Value ?? DBNull.Value);
                        com.Parameters.AddWithValue("@TransCode", sa.code); 
                        
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception error)
            {
                error.ToString();
            }
        }
        public bool AddTransClientInfo(Sales sa)
        {
            try
            {
                using (var con = new SqlConnection(db.ConString()))
                {
                    using (var com = new SqlCommand("[SpAddOrderDetails]", con))
                    {
                        con.Open();

                        com.CommandType = CommandType.StoredProcedure;

                        com.Parameters.AddWithValue("@Name", sa.customerName);
                        com.Parameters.AddWithValue("@Address", sa.Address);
                        com.Parameters.AddWithValue("@AmountPaid", sa.AmountPaid);
                        com.Parameters.AddWithValue("@TotalPrice", sa.GrandTotal);
                        com.Parameters.AddWithValue("@Code", sa.code);
                        com.Parameters.AddWithValue("@ItemsTotal", sa.Quantity);
                        com.Parameters.AddWithValue("@Contact", sa.ContactNo);
                        com.Parameters.AddWithValue("@Email", sa.email_info.EmailAddress);
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
    }
}
