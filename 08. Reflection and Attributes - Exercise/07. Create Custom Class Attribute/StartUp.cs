namespace _07._Create_Custom_Class_Attribute
{
    using System;
    using System.Linq;

    [Info("Pesho", 3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", "Pesho", "Svetlio")]
    public class StartUp
    {
        public static void Main()
        {
            var attribute = (InfoAttribute)typeof(StartUp).GetCustomAttributes(false).First();

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                switch (command)
                {
                    case "Author":
                        Console.WriteLine($"Author: {attribute.Author}");
                        break;

                    case "Revision":
                        Console.WriteLine($"Revision: {attribute.Revision}");
                        break;

                    case "Description":
                        Console.WriteLine($"Class description: {attribute.Description}");
                        break;

                    case "Reviewers":
                        Console.WriteLine($"Reviewers: {string.Join(", ", attribute.Reviewers)}");
                        break;

                    default:
                        throw new ArgumentException();
                }
            }
        }
    }
}