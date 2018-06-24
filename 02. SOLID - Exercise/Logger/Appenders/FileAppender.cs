namespace Logger.Appenders
{
    using Enums;
    using Interfaces;
    using Models;

    public class FileAppender : IAppender
    {
        private readonly LogFile logFile;

        public FileAppender(ILayout layout, ErrorLevel errorLevel, LogFile logFile)
        {
            this.Layout = layout;
            this.ErrorLevel = errorLevel;
            this.logFile = logFile;
        }

        public ILayout Layout { get; }

        public ErrorLevel ErrorLevel { get; }

        public int MessagesAppended { get; private set; }

        public void Append(IError error)
        {
            var formattedError = this.Layout.FormatError(error);
            this.logFile.WriteToFile(formattedError);
            this.MessagesAppended++;
        }

        public override string ToString()
        {
            var appenderType = this.GetType().Name;
            var layoutType = this.Layout.GetType().Name;
            var errorLevel = this.ErrorLevel.ToString();

            var result = $"Appender type: {appenderType}, Layout type: {layoutType}, Report level: {errorLevel}, Messages appended: {this.MessagesAppended}, File size: {this.logFile.Size}";
            return result;
        }
    }
}