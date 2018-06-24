namespace Logger.Factories
{
    using Enums;
    using Interfaces;
    using Models;
    using System;

    public class ErrorFactory
    {
        public IError GetError(DateTime dateTime, ErrorLevel errorLevel, string message)
        {
            return new Error(dateTime, errorLevel, message);
        }
    }
}