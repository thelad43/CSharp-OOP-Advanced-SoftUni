namespace Logger.Layouts
{
    using Interfaces;
    using System;

    public class XmlLayout : ILayout
    {
        private const string DateFormat = "HH:mm:ss dd-MMM-yyyy";

        private readonly string Format =
            "<log>" + Environment.NewLine +
                "\t<date>{0}</date>" + Environment.NewLine +
                "\t<level>{1}</level>" + Environment.NewLine +
                "\t<message>{2}/message>" + Environment.NewLine +
            "</log>";

        public string FormatError(IError error)
        {
            var formattedError = string.Format(this.Format, error.DateTime, error.ErrorLevel, error.Message);
            return formattedError;
        }
    }
}