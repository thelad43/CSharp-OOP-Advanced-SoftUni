namespace Logger.Interfaces
{
    using System;

    public interface IError : ILevel
    {
        DateTime DateTime { get; }

        string Message { get; }
    }
}