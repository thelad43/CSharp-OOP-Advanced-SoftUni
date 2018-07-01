namespace _03._Stack
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Stack<int> stack = null;

            while (true)
            {
                var inputTokens = Console.ReadLine()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (inputTokens[0] == "END")
                {
                    break;
                }

                try
                {
                    stack = ProcessCommand(stack, inputTokens);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, stack));
            Console.WriteLine(string.Join(Environment.NewLine, stack));
        }

        private static Stack<int> ProcessCommand(Stack<int> stack, string[] inputTokens)
        {
            switch (inputTokens[0])
            {
                case "Push":
                    var elements = inputTokens.Skip(1)
                        .Select(int.Parse)
                        .ToArray();

                    if (stack == null)
                    {
                        stack = new Stack<int>(elements);
                    }
                    else
                    {
                        for (int i = 0; i < elements.Length; i++)
                        {
                            stack.Push(elements[i]);
                        }
                    }

                    break;

                case "Pop":
                    stack.Pop();
                    break;

                default:
                    throw new ArgumentException();
            }

            return stack;
        }
    }
}