namespace _03._Iterator_Test
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            ListIterator listIterator = null;

            try
            {
                listIterator = ProcessCommands(listIterator);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static ListIterator ProcessCommands(ListIterator listIterator)
        {
            while (true)
            {
                var commandTokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commandTokens[0] == "END")
                {
                    break;
                }

                switch (commandTokens[0])
                {
                    case "Create":
                        if (commandTokens.Length == 1)
                        {
                            throw new InvalidOperationException("Invalid Operation!");
                        }

                        listIterator = new ListIterator(commandTokens.Skip(1).ToList());
                        break;

                    case "Print":
                        listIterator.Print();
                        break;

                    case "Move":
                        Console.WriteLine(listIterator.Move());
                        break;

                    case "HasNext":
                        Console.WriteLine(listIterator.HasNext());
                        break;

                    default:
                        throw new ArgumentException();
                }
            }

            return listIterator;
        }
    }
}