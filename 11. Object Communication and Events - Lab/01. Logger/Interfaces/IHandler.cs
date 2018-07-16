namespace _01._Logger.Interfaces
{
    using Enums;

    public interface IHandler
    {
        void Handle(LogType logType, string message);

        void SetSuccessor(IHandler handler);
    }
}