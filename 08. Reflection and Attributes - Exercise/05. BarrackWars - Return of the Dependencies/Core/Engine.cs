namespace _05._BarrackWars_Return_of_the_Dependencies.Core
{
    using Interfaces;
    using System;

    public class Engine : IRunnable
    {
        private readonly IRepository repository;
        private readonly IUnitFactory unitFactory;
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
            this.commandInterpreter = new CommandInterpreter(repository, unitFactory);
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

                    var result = this.commandInterpreter
                        .InterpretCommand(data, commandName)
                        .Execute();

                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}