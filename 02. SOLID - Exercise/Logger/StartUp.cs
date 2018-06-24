namespace Logger
{
    using Controllers;
    using Enums;
    using Factories;
    using Interfaces;
    using Models;
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var logger = InitializeLogger();
            var errorFactory = new ErrorFactory();
            var engine = new Engine(logger, errorFactory);
            engine.Run();
        }

        private static ILogger InitializeLogger()
        {
            var appenders = new List<IAppender>();
            var appendersCount = int.Parse(Console.ReadLine());
            var layoutFactory = new LayoutFactory();
            var appenderFactory = new AppenderFactory(layoutFactory);

            for (int i = 0; i < appendersCount; i++)
            {
                var inputTokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var appenderType = inputTokens[0];
                var layoutType = inputTokens[1];
                var errorLevel = ErrorLevel.INFO;

                if (inputTokens.Length == 3)
                {
                    errorLevel = (ErrorLevel)Enum.Parse(typeof(ErrorLevel), inputTokens[2]);
                }

                var appender = appenderFactory.GetAppender(appenderType, errorLevel, layoutType);
                appenders.Add(appender);
            }

            var logger = new Logger(appenders);
            return logger;
        }
    }
}