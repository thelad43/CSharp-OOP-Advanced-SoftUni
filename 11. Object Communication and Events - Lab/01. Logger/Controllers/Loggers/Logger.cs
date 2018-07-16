namespace _01._Logger.Controllers.Loggers
{
    using Enums;
    using Interfaces;

    public abstract class Logger : IHandler
    {
        private IHandler successor;

        public abstract void Handle(LogType logType, string message);

        public void SetSuccessor(IHandler handler)
        {
            this.successor = handler;
        }

        public void PassToSuccessor(LogType logType, string message)
        {
            if (this.successor != null)
            {
                this.successor.Handle(logType, message);
            }
        }
    }
}