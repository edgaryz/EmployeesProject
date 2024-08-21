namespace EmployeesProject.Models
{
    public class ProductionWorker : Employee
    {
        public string Shift { get; set; }

        public ProductionWorker() { }

        public ProductionWorker(string name, string surName, int age, string shift) : base(name, surName, age)
        {
            Shift = shift;
        }

        public override string ToString()
        {
            return $"Production worker: {Name} {SurName}, Age: {Age}, Working shift: {Shift}.";
        }
    }
}
