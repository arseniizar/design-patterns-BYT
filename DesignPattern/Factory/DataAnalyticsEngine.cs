namespace DesignPattern.Factory
{
    public class DataAnalyticsEngine(IDatabase database)
    {
        private readonly IDatabase _database = database;

        public void ProcessData(string query)
        {
            _database.Connect();
            _database.ExecuteQuery(query);
        }
    }
}
