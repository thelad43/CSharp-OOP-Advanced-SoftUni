namespace _03._Detail_Printer.Models
{
    public class Employee
    {
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public override string ToString() => this.Name;
    }
}