namespace Logger.Models
{
    using Interfaces;
    using System.Collections.Generic;

    public class Logger : ILogger
    {
        private readonly ICollection<IAppender> appenders;

        public Logger(ICollection<IAppender> appenders)
        {
            this.appenders = appenders;
        }

        public IReadOnlyCollection<IAppender> Appenders => this.appenders as IReadOnlyCollection<IAppender>;

        public void Log(IError error)
        {
            foreach (var appender in this.appenders)
            {
                if (appender.ErrorLevel <= error.ErrorLevel)
                {
                    appender.Append(error);
                }
            }
        }
    }
}