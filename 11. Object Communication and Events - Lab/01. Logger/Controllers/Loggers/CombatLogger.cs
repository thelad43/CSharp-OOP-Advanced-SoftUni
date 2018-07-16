namespace _01._Logger.Controllers.Loggers
{
    using Enums;
    using System;

    public class CombatLogger : Logger
    {
        public override void Handle(LogType logType, string message)
        {
            switch (logType)
            {
                case LogType.ATTACK:
                case LogType.MAGIC:
                    Console.WriteLine($"{logType}: {message}");
                    break;

                default:
                    throw new ArgumentException();
            }

            this.PassToSuccessor(logType, message);
        }
    }
}