namespace _01._ListyIterator
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            ListyIterator<string> listyIterator = null;

            while (true)
            {
                var inputTokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (inputTokens[0] == "END")
                {
                    break;
                }

                try
                {
                    listyIterator = ProcessCommand(listyIterator, inputTokens);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static ListyIterator<string> ProcessCommand(ListyIterator<string> listyIterator, string[] inputTokens)
        {
            switch (inputTokens[0])
            {
                case "Create":
                    var elements = inputTokens.Skip(1).ToArray();
                    listyIterator = new ListyIterator<string>(elements);
                    break;

                case "Move":
                    Console.WriteLine(listyIterator.Move());
                    break;

                case "Print":
                    listyIterator.Print();
                    break;

                case "HasNext":
                    Console.WriteLine(listyIterator.HasNext());
                    break;

                default:
                    throw new ArgumentException();
            }

            return listyIterator;
        }
    }
}