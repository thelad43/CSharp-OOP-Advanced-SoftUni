namespace _03._Dependency_Inversion
{
    using Controllers;
    using IO;
    using Models;

    public class StartUp
    {
        public static void Main()
        {
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var calculator = new PrimitiveCalculator();

            var engine = new Engine(calculator, reader, writer);
            engine.Run();
        }
    }
}