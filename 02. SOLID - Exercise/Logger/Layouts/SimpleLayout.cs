namespace Logger.Layouts
{
    using Interfaces;
    using System.Globalization;

    public class SimpleLayout : ILayout
    {
        private const string Format = "M/d/yyyy h:mm:ss tt";

        public string FormatError(IError error)
        {
            var formattedError = $"{error.DateTime.ToString(Format, CultureInfo.InvariantCulture)} - {error.ErrorLevel} - {error.Message}";
            return formattedError;
        }
    }
}