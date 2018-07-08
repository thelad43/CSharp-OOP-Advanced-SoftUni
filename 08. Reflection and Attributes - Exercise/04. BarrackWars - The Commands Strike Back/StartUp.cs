namespace _04._BarrackWars_The_Commands_Strike_Back
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