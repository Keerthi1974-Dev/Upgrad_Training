using Microsoft.Data.SqlClient;


namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connStr = "Server=LAPTOP-C3A9ELOU\\SQLEXPRESS; Database=SQL; Integrated Security=true; TrustServerCertificate=True";

            SqlConnection con = new SqlConnection(connStr);

            string cmdText = "UPDATE Students SET Age = 21 WHERE Name = 'Sneha'";
            SqlCommand cmd = new SqlCommand(cmdText, con);

            con.Open();
            int n = cmd.ExecuteNonQuery();

            Console.WriteLine("Connected to SQL Server");
            Console.WriteLine("No. of Rows affected : " + n);

            con.Close();

            Console.ReadLine();
        }
    }
}
