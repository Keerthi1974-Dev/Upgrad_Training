using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;


namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            

            string connStr = config.GetConnectionString("DefaultConnection");

            while (true)
            {
                Console.WriteLine("\n1.Insert 2.View 3.Update 4.Delete 5.Exit");
                int choice = int.Parse(Console.ReadLine());

                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                if (choice == 1)
                {
                    cmd.CommandText = "InsertProduct";
                    cmd.CommandType = CommandType.StoredProcedure;

                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Category: ");
                    string category = Console.ReadLine();

                    Console.Write("Enter Price: ");
                    decimal price = decimal.Parse(Console.ReadLine());

                    SqlParameter p1 = new SqlParameter();
                    p1.ParameterName = "@ProductName";
                    p1.SqlDbType = SqlDbType.VarChar;
                    p1.Value = name;

                    SqlParameter p2 = new SqlParameter();
                    p2.ParameterName = "@Category";
                    p2.SqlDbType = SqlDbType.VarChar;
                    p2.Value = category;

                    SqlParameter p3 = new SqlParameter();
                    p3.ParameterName = "@Price";
                    p3.SqlDbType = SqlDbType.Decimal;
                    p3.Value = price;

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    Console.WriteLine("Inserted Successfully");
                }

                else if (choice == 2)
                {
                    cmd.CommandText = "GetAllProducts";
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine(
                            reader["ProductId"] + " " +
                            reader["ProductName"] + " " +
                            reader["Category"] + " " +
                            reader["Price"]
                        );
                    }

                    conn.Close();
                }

                else if (choice == 3)
                {
                    cmd.CommandText = "UpdateProduct";
                    cmd.CommandType = CommandType.StoredProcedure;

                    Console.Write("Enter Product ID: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("New Name: ");
                    string name = Console.ReadLine();

                    Console.Write("New Category: ");
                    string category = Console.ReadLine();

                    Console.Write("New Price: ");
                    decimal price = decimal.Parse(Console.ReadLine());

                    SqlParameter p1 = new SqlParameter();
                    p1.ParameterName = "@ProductId";
                    p1.SqlDbType = SqlDbType.Int;
                    p1.Value = id;

                    SqlParameter p2 = new SqlParameter();
                    p2.ParameterName = "@ProductName";
                    p2.SqlDbType = SqlDbType.VarChar;
                    p2.Value = name;

                    SqlParameter p3 = new SqlParameter();
                    p3.ParameterName = "@Category";
                    p3.SqlDbType = SqlDbType.VarChar;
                    p3.Value = category;

                    SqlParameter p4 = new SqlParameter();
                    p4.ParameterName = "@Price";
                    p4.SqlDbType = SqlDbType.Decimal;
                    p4.Value = price;

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    Console.WriteLine("Updated Successfully");
                }

                else if (choice == 4)
                {
                    cmd.CommandText = "DeleteProduct";
                    cmd.CommandType = CommandType.StoredProcedure;

                    Console.Write("Enter Product ID: ");
                    int id = int.Parse(Console.ReadLine());

                    SqlParameter p1 = new SqlParameter();
                    p1.ParameterName = "@ProductId";
                    p1.SqlDbType = SqlDbType.Int;
                    p1.Value = id;

                    cmd.Parameters.Add(p1);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    Console.WriteLine("Deleted Successfully");
                }

                else if (choice == 5)
                {
                    break;
                }
            }
        }
    }
}














        
    

