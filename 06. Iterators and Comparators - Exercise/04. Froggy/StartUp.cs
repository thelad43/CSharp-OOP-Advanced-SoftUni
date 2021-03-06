﻿namespace _04._Froggy
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var elements = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var lake = new Lake<int>(elements);
            Console.WriteLine(string.Join(", ", lake));
        }
    }
}