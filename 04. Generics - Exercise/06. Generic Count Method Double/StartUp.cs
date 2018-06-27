namespace _06._Generic_Count_Method_Double
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var boxes = new List<Box<double>>(n);

            for (int i = 0; i < n; i++)
            {
                boxes.Add(new Box<double>(double.Parse(Console.ReadLine())));
            }

            var comparison = new Box<double>(double.Parse(Console.ReadLine()));
            Console.WriteLine(GetCountGreaterThanComparisonValue(boxes, comparison));
        }

        private static int GetCountGreaterThanComparisonValue<T>(IEnumerable<T> collection, T comparison)
            where T : IComparable<T>
        {
            var count = 0;

            foreach (var element in collection)
            {
                if (element.CompareTo(comparison) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}