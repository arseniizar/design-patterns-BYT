namespace DesignPattern.Adapter
{
    public class Employee(int id, string name, string designation, decimal salary)
    {
        public int ID { get; set; } = id;
        public string Name { get; set; } = name;
        public string Designation { get; set; } = designation;
        public decimal Salary { get; set; } = salary;
    }
}
