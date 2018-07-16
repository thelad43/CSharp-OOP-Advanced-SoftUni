﻿namespace _01._Logger.Controllers.Loggers
{
    using Enums;
    using System;

    public class EventLogger : Logger
    {
        public override void Handle(LogType logType, string message)
        {
            switch (logType)
            {
                case LogType.EVENT:
                    Console.WriteLine($"{logType}: {message}");
                    break;
            }

            this.PassToSuccessor(logType, message);
        }
    }
}