using DesignPattern.Adapter;
using DesignPattern.Factory;
using DesignPattern.Observer;
 
namespace DesignPattern;
class Program
{
    static void Main(string[] args)
    {
        dbEngines();
        Thread.Sleep(2000);
        Console.WriteLine();
        employeesAdapterDemo();
        Thread.Sleep(2000);
        Console.WriteLine();
        observingThings();
    }

    // No need to replace this code, it should work after implementing proper factory design pattern
    static void dbEngines()
    {
        var sqlEngine = new DataAnalyticsEngine(DatabaseFactory.CreateDatabase(DatabaseType.SqlServer));
        sqlEngine.ProcessData("Query to process data for SQL Server");

        var oracleEngine = new DataAnalyticsEngine(DatabaseFactory.CreateDatabase(DatabaseType.Oracle));
        oracleEngine.ProcessData("Query to process data for Oracle");
    }

    // No need to replace this code, just implement the adapter class for it to work properly
    static void employeesAdapterDemo()
    {
        string[,] employeesArray = new string[5, 4]
        {
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
        };

        Console.WriteLine("HR system passes employee string array to Adapter\n");
        ITarget target = new EmployeeAdapter();
        target.ProcessCompanySalary(employeesArray);
    }

    // No need to replace this code, just implement the ConcreteObserver class for it to work properly
    static void observingThings()
    {
        Subject RedMI = new("Red MI Mobile", 10000, "Out Of Stock");

        ConcreteObserver user1 = new("Anurag");
        user1.AddSubscriber(RedMI);

        ConcreteObserver user2 = new("Pranaya");
        user2.AddSubscriber(RedMI);

        ConcreteObserver user3 = new("Priyanka");
        user3.AddSubscriber(RedMI);

        Thread.Sleep(1000);

        Console.WriteLine("Red MI Mobile current state : " + RedMI.GetAvailability());
        Console.WriteLine();

        Thread.Sleep(1000);

        user3.RemoveSubscriber(RedMI);

        Thread.Sleep(1000);
        RedMI.SetAvailability("Available");
    }

}