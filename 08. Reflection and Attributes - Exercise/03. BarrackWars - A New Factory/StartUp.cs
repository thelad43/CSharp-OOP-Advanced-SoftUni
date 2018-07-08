namespace _03._BarrackWars_A_New_Factory
{
    using Core;
    using Core.Factories;
    using Data;

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