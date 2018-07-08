namespace _04._BarrackWars_The_Commands_Strike_Back.Interfaces
{
    public interface ICommandInterpreter
    {
        IExecutable InterpretCommand(string[] data, string commandName);
    }
}