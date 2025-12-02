namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem _thirdPartyBillingSystem = new();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            List<Employee> listEmployee = new List<Employee>();

            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                Employee employee = new Employee(
                    int.Parse(employeesArray[i, 0]),
                    employeesArray[i, 1],
                    employeesArray[i, 2],
                    decimal.Parse(employeesArray[i, 3])
                );
                listEmployee.Add(employee);
            }

            Console.WriteLine("Adapter converted array of employees to a list of employees.");
            Console.WriteLine("Then, the adapter called the ProcessSalary method of the third-party billing system.");

            _thirdPartyBillingSystem.ProcessSalary(listEmployee);
        }
    }
}
