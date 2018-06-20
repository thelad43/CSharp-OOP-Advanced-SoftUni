namespace _04._Recharge
{
    using Models;

    public class StartUp
    {
        public static void Main()
        {
            var employee = new Employee("1");
            var robot = new Robot("2", 4);

            employee.Work(4);
            employee.Sleep();

            robot.Work(15);
            robot.Recharge();
        }
    }
}