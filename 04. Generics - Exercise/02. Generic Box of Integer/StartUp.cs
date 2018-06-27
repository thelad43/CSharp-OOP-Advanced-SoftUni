namespace _02._Generic_Box_of_Integer
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var currentBox = new Box<int>(int.Parse(Console.ReadLine()));
                Console.WriteLine(currentBox);
            }
        }
    }
}