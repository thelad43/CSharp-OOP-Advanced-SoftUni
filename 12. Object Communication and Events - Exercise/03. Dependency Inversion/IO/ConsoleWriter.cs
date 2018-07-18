﻿namespace _03._Dependency_Inversion.IO
{
    using Interfaces;
    using System;

    public class ConsoleWriter : IWriter
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}