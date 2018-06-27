namespace _03._Generic_Swap_Method_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var boxes = new List<Box<string>>(n);

            for (int i = 0; i < n; i++)
            {
                var currentBox = new Box<string>(Console.ReadLine());
                boxes.Add(currentBox);
            }

            var swapIndices = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Swap(boxes, swapIndices[0], swapIndices[1]);
            Console.WriteLine(string.Join(Environment.NewLine, boxes));
        }

        private static void Swap<T>(IList<T> collection, int firstSwapIndex, int secondSwapIndex)
        {
            var oldValue = collection[firstSwapIndex];
            collection[firstSwapIndex] = collection[secondSwapIndex];
            collection[secondSwapIndex] = oldValue;
        }
    }
}