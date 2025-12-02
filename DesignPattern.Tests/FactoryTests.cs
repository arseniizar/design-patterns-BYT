using DesignPattern.Factory;

namespace DesignPattern.Tests
{
    [TestFixture]
    public class FactoryTests
    {
        [Test]
        public void CreateDatabase_GivenSqlServerType_ReturnsSqlServerDatabaseInstance()
        {
            var dbType = DatabaseType.SqlServer;

            var database = DatabaseFactory.CreateDatabase(dbType);

            Assert.That(database, Is.InstanceOf<SqlServerDatabase>());
        }

        [Test]
        public void CreateDatabase_GivenOracleType_ReturnsOracleDatabaseInstance()
        {
            var dbType = DatabaseType.Oracle;

            var database = DatabaseFactory.CreateDatabase(dbType);

            Assert.That(database, Is.InstanceOf<OracleDatabase>());
        }
    }
}
