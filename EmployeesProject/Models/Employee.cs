namespace EmployeesProject.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }

        public Employee() { }

        public Employee(string name, string surName, int age)
        {
            Name = name;
            SurName = surName;
            Age = age;
        }
    }
}
