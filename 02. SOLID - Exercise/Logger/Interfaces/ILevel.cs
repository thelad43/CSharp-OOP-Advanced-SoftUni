namespace Logger.Interfaces
{
    using Enums;

    public interface ILevel
    {
        ErrorLevel ErrorLevel { get; }
    }
}