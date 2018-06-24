namespace Logger.Models
{
    using Interfaces;
    using System;
    using System.IO;

    public class LogFile : ILogFile
    {
        public LogFile(string fileName)
        {
            this.Path = fileName;
        }

        public string Path { get; }

        public int Size { get; private set; }

        public void WriteToFile(string errorLog)
        {
            File.AppendAllText(this.Path, errorLog + Environment.NewLine);
            AddSize(errorLog);
        }

        private void AddSize(string errorLog)
        {
            for (int i = 0; i < errorLog.Length; i++)
            {
                this.Size += errorLog[i];
            }
        }
    }
}