namespace _05._BarrackWars_Return_of_the_Dependencies
{
    using Core;
    using Data;
    using Factories;

    public class StartUp
    {
        public static void Main()
        {
            var repository = new UnitRepository();
            var unitFactory = new UnitFactory();
            var engine = new Engine(repository, unitFactory);
            engine.Run();
        }
    }
}