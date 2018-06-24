namespace Logger.Controllers
{
    using Enums;
    using Factories;
    using Interfaces;
    using System;
    using System.Globalization;

    public class Engine
    {
        private const string Format = "M/d/yyyy h:mm:ss tt";

        private readonly ILogger logger;
        private readonly ErrorFactory errorFactory;

        public Engine(ILogger logger, ErrorFactory errorFactory)
        {
            this.logger = logger;
            this.errorFactory = errorFactory;
        }

        public void Run()
        {
            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "END")
                {
                    break;
                }

                var errorInfo = inputLine
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);

                var errorLevel = (ErrorLevel)Enum.Parse(typeof(ErrorLevel), errorInfo[0]);
                var dateTime = DateTime.ParseExact(errorInfo[1], Format, CultureInfo.InvariantCulture);
                var message = errorInfo[2];

                var error = this.errorFactory.GetError(dateTime, errorLevel, message);
                this.logger.Log(error);
            }

            Console.WriteLine("Logger Info");

            foreach (var appender in this.logger.Appenders)
            {
                Console.WriteLine(appender);
            }
        }
    }
}