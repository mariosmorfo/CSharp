using Microsoft.Data.SqlClient;

namespace WebStarter7DBApp.Services.DBHelper
{
    public static class DBUtil
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection connection;
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsetting.json");
            var configuaration = builder.Build();
            string? url = configuaration.GetConnectionString("DefaultConnection");

            try
            {
                connection = new SqlConnection(url);
                return connection;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
