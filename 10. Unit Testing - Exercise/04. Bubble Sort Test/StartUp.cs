namespace _04._Bubble_Sort_Test
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = new List<int>
            {
                76,
                74,
                18,
                24,
                17,
                57,
                55,
                42,
                53,
                43,
                67,
                45,
                78,
                14,
                40,
            };

            var bubble = new Bubble<int>(numbers);
            Console.WriteLine(string.Join(", ", bubble));
        }
    }
}