namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType databaseType)
        {
            switch (databaseType)
            {
                case DatabaseType.SqlServer:
                    return new SqlServerDatabase();
                case DatabaseType.Oracle:
                    return new OracleDatabase();
                default:
                    throw new ArgumentException("Invalid database type specified.");
            }
        }
    }
}
