namespace _05._BarrackWars_Return_of_the_Dependencies.Core
{
    using Attributes;
    using Interfaces;
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;

    public class CommandInterpreter : ICommandInterpreter
    {
        private const string CommandSuffix = "Command";

        private readonly IRepository repository;
        private readonly IUnitFactory unitFactory;

        public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            var fullCommandName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(commandName) + CommandSuffix;
            var assembly = Assembly.GetExecutingAssembly();
            var commandType = assembly.GetTypes().FirstOrDefault(t => t.Name == fullCommandName);

            if (commandType == null)
            {
                throw new InvalidOperationException("Invalid command!");
            }

            if (!typeof(IExecutable).IsAssignableFrom(commandType))
            {
                throw new ArgumentException($"{commandType} is not a valid command!");
            }

            var command = (IExecutable)Activator.CreateInstance(commandType, new[] { data });
            this.InjectDependancies(command);
            return command;
        }

        private void InjectDependancies(IExecutable command)
        {
            var type = typeof(InjectAttribute);

            var fields = command
                .GetType()
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(f => f.GetCustomAttributes().Any(a => a.GetType() == type));

            var interpreterFields = this.GetType()
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var fieldForInjection in fields)
            {
                fieldForInjection
                    .SetValue(command, interpreterFields
                    .First(f => f.FieldType == fieldForInjection.FieldType)
                    .GetValue(this));
            }
        }
    }
}