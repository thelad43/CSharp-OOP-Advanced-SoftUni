namespace _04._Observer.Interfaces
{
    using Enums;

    public interface IHandler
    {
        void Handle(LogType logType, string message);

        void SetSuccessor(IHandler handler);
    }
}