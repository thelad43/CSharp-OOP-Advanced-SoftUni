namespace _01._Generic_Box_of_String
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var currentBox = new Box<string>(Console.ReadLine());
                Console.WriteLine(currentBox);
            }
        }
    }
}