namespace _06._Twitter.IO
{
    using Interfaces;
    using System;

    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}