using Microsoft.Data.SqlClient;
 
namespace ConnectingToDB;
 
public class Program
{
    public static void Main(string[] args)
    {
        string server = "127.0.0.1,1433"; // can use this instead "localhost,1433"
        string database = "TestDB";
        string username = "SA";
        string pwd = "P455Word";
 
        // string password = Environment.GetEnvironmentVariable("pwd").ToString();
 
        var connectionString = $"Server = {server};TrustServerCertificate=True;Database={database};User Id={username};Password={pwd};";
        var sql = "SELECT * FROM Inventory";
        var conn = new SqlConnection(connectionString);
 
        // use the sql query
        conn.Open();
        var cmd = new SqlCommand(sql, conn);
        var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine($"{reader["name"]}");
        }
        reader.Close();
        conn.Close();
    }
}