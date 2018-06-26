namespace _03._Scale
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var intScale = new Scale<int>(5, 7);
            var stringScale = new Scale<string>("Pesho", "Gosho");

            Console.WriteLine(intScale.GetHeavier());
            Console.WriteLine(stringScale.GetHeavier());
        }
    }
}