namespace _03._Detail_Printer
{
    using Models;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var employee = new Employee("Employee");
            var manager = new Manager("Manager", new[] { "Doc 1", "Doc 2", "Doc 3" });
            var detailsPrinter = new DetailsPrinter(new List<Employee>(new[] { employee, manager }));
            detailsPrinter.PrintDetails();
        }
    }
}