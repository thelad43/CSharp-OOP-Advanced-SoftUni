namespace _03._Mediator.Interfaces
{
    using Enums;

    public interface IHandler
    {
        void Handle(LogType logType, string message);

        void SetSuccessor(IHandler handler);
    }
}