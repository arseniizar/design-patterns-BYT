using DesignPattern.Adapter;

namespace DesignPattern.Tests
{
    [TestFixture]
    public class AdapterTests
    {
        private StringWriter _stringWriter;
        private TextWriter _originalOutput;

        [SetUp]
        public void Setup()
        {
            _stringWriter = new StringWriter();
            _originalOutput = Console.Out;
            Console.SetOut(_stringWriter);
        }

        [TearDown]
        public void TearDown()
        {
            Console.SetOut(_originalOutput);
            _stringWriter.Dispose();
        }

        [Test]
        public void ProcessCompanySalary_WhenCalled_CorrectlyTransformsDataAndCallsBillingSystem()
        {
            string[,] employeesArray = {
                {"101", "John", "SE", "10000"},
                {"102", "Smith", "SE", "20000"}
            };
            ITarget adapter = new EmployeeAdapter();

            adapter.ProcessCompanySalary(employeesArray);

            string capturedOutput = _stringWriter.ToString();

            Assert.That(capturedOutput, Does.Contain("Salary Credited to John"));
            Assert.That(capturedOutput, Does.Contain("10000 Salary Credited"));
            Assert.That(capturedOutput, Does.Contain("Salary Credited to Smith"));
            Assert.That(capturedOutput, Does.Contain("20000 Salary Credited"));
        }
    }
}
