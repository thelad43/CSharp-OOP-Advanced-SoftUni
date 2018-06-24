namespace Logger.Factories
{
    using Appenders;
    using Enums;
    using Interfaces;
    using Models;

    public class AppenderFactory
    {
        private readonly LayoutFactory layoutFactory;
        private int fileNumber;

        public AppenderFactory(LayoutFactory layoutFactory)
        {
            this.layoutFactory = layoutFactory;
        }

        public IAppender GetAppender(string appenderType, ErrorLevel errorLevel, string layoutType)
        {
            var layout = this.layoutFactory.GetLayout(layoutType);

            switch (appenderType)
            {
                case "ConsoleAppender":
                    return new ConsoleAppender(layout, errorLevel);

                case "FileAppender":
                    var logFile = new LogFile($"logFile{this.fileNumber}.txt");
                    this.fileNumber++;
                    return new FileAppender(layout, errorLevel, logFile);

                default:
                    return null;
            }
        }
    }
}