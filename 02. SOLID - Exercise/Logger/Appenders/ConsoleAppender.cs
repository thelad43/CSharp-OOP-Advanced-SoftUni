namespace Logger.Appenders
{
    using Enums;
    using Interfaces;
    using System;

    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout, ErrorLevel errorLevel)
        {
            this.Layout = layout;
            this.ErrorLevel = errorLevel;
            this.MessagesAppended = 0;
        }

        public ILayout Layout { get; }

        public ErrorLevel ErrorLevel { get; }

        public int MessagesAppended { get; private set; }

        public void Append(IError error)
        {
            var formattedError = this.Layout.FormatError(error);
            Console.WriteLine(formattedError);
            this.MessagesAppended++;
        }

        public override string ToString()
        {
            var appenderType = this.GetType().Name;
            var layoutType = this.Layout.GetType().Name;
            var errorLevel = this.ErrorLevel.ToString();

            var result = $"Appender type: {appenderType}, Layout type: {layoutType}, Report level: {errorLevel}, Messages appended: {this.MessagesAppended}";
            return result;
        }
    }
}