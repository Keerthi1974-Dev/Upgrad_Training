using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace ConsoleApp29
{
    internal class ProductData
    {
        private string connStr;

        public ProductData()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            connStr = config.GetConnectionString("DefaultConnection");
        }

        // INSERT
        public void InsertProduct(Product p)
        {
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("InsertProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@ProductName";
            p1.SqlDbType = SqlDbType.VarChar;
            p1.Value = p.ProductName;

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@Category";
            p2.SqlDbType = SqlDbType.VarChar;
            p2.Value = p.Category;

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@Price";
            p3.SqlDbType = SqlDbType.Decimal;
            p3.Value = p.Price;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // VIEW ALL (DISCONNECTED)
        public void GetAllProducts()
        {
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("GetAllProducts", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine(
                    row["ProductId"] + " " +
                    row["ProductName"] + " " +
                    row["Category"] + " " +
                    row["Price"]
                );
            }
        }

        // GET BY ID (DISCONNECTED)
        public void GetProductById(int id)
        {
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("GetProductById", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@ProductId";
            p1.SqlDbType = SqlDbType.Int;
            p1.Value = id;

            cmd.Parameters.Add(p1);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Console.WriteLine(
                        row["ProductId"] + " " +
                        row["ProductName"] + " " +
                        row["Category"] + " " +
                        row["Price"]
                    );
                }
            }
            else
            {
                Console.WriteLine("No product found");
            }
        }

        // UPDATE
        public void UpdateProduct(Product p)
        {
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("UpdateProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@ProductId";
            p1.SqlDbType = SqlDbType.Int;
            p1.Value = p.ProductId;

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@ProductName";
            p2.SqlDbType = SqlDbType.VarChar;
            p2.Value = p.ProductName;

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@Category";
            p3.SqlDbType = SqlDbType.VarChar;
            p3.Value = p.Category;

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@Price";
            p4.SqlDbType = SqlDbType.Decimal;
            p4.Value = p.Price;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // DELETE
        public void DeleteProduct(int id)
        {
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("DeleteProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@ProductId";
            p1.SqlDbType = SqlDbType.Int;
            p1.Value = id;

            cmd.Parameters.Add(p1);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}