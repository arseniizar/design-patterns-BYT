
namespace DesignPattern.Factory
{
    public class SqlServerDatabase : IDatabase
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to SQL Server database...");
        }

        public void ExecuteQuery(string query)
        {
            Console.WriteLine("Executing query in SQL Server database: " + query);
        }
    }
}
