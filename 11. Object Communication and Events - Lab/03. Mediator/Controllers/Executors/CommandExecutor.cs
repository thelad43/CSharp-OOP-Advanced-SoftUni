namespace _03._Mediator.Controllers.Executors
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