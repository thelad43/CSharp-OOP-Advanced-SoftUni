namespace _04._Recharge.Models
{
    using Interfaces;

    public class Employee : Worker, ISleeper
    {
        public Employee(string id)
            : base(id)
        {
        }

        public string Sleep()
        {
            return "Sleeeping....";
        }
    }
}