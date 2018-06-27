namespace _05._Generic_Count_Method_String
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var boxes = new List<Box<string>>(n);

            for (int i = 0; i < n; i++)
            {
                boxes.Add(new Box<string>(Console.ReadLine()));
            }

            var comparison = new Box<string>(Console.ReadLine());
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