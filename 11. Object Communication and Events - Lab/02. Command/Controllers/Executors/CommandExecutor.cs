namespace _02._Command.Controllers.Executors
{
    using Interfaces;

    public class CommandExecutor : IExecutor
    {
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
        }
    }
}