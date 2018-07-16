namespace _02._Command.Interfaces
{
    using Enums;

    public interface IHandler
    {
        void Handle(LogType logType, string message);

        void SetSuccessor(IHandler handler);
    }
}