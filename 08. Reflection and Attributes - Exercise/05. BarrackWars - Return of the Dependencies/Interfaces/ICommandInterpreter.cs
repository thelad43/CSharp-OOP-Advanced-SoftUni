namespace _05._BarrackWars_Return_of_the_Dependencies.Interfaces
{
    public interface ICommandInterpreter
    {
        IExecutable InterpretCommand(string[] data, string commandName);
    }
}