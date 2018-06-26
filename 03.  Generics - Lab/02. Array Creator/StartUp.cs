namespace _02._Array_Creator
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var strings = ArrayCreator.Create(5, "Pesho");
            var integers = ArrayCreator.Create(10, 33);

            Console.WriteLine(string.Join(" ", strings));
            Console.WriteLine(string.Join(" ", integers));
        }
    }
}