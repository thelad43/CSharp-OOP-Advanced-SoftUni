namespace _03._Dependency_Inversion.IO
{
    using Interfaces;
    using System;

    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}