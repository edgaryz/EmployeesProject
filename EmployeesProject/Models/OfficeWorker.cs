namespace EmployeesProject.Models
{
    public class OfficeWorker : Employee
    {
        public string Department { get; set; }

        public OfficeWorker() { }

        public OfficeWorker(string name, string surName, int age, string department) : base(name, surName, age)
        {
            Department = department;
        }

        public override string ToString()
        {
            return $"Office worker: {Name} {SurName}, Age: {Age}, Works in: {Department} department.";
        }
    }
}
