using Microsoft.Data.SqlClient;

namespace Final_Attempt
{
    public class DatabaseConnection
    {
        private static readonly string connectionString =
            @"Data Source=SIBALETHU-PC\SQLEXPRESS;Initial Catalog=merit_cert_verification;Integrated Security=True;Trust Server Certificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}