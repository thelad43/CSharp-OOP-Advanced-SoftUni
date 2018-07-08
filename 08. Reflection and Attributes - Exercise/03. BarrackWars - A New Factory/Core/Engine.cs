namespace _03._BarrackWars_A_New_Factory.Core
{
    using Interfaces;
    using System;

    public class Engine : IRunnable
    {
        private readonly IRepository repository;
        private readonly IUnitFactory unitFactory;

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    var input = Console.ReadLine();
                    var data = input.Split();
                    var commandName = data[0];
                    var result = InterpredCommand(data, commandName);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        // TODO: refactor for Problem 4
        private string InterpredCommand(string[] data, string commandName)
        {
            var result = string.Empty;

            switch (commandName)
            {
                case "add":
                    result = this.AddUnitCommand(data);
                    break;

                case "report":
                    result = this.ReportCommand(data);
                    break;

                case "fight":
                    Environment.Exit(0);
                    break;

                default:
                    throw new InvalidOperationException("Invalid command!");
            }

            return result;
        }

        private string ReportCommand(string[] data)
        {
            var output = this.repository.Statistics;
            return output;
        }

        private string AddUnitCommand(string[] data)
        {
            var unitType = data[1];
            var unitToAdd = this.unitFactory.CreateUnit(unitType);
            this.repository.AddUnit(unitToAdd);
            var output = unitType + " added!";
            return output;
        }
    }
}