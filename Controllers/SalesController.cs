using SSIP.DbAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
