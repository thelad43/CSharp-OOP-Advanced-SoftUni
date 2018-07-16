namespace _04._Observer.Controllers.Executors
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