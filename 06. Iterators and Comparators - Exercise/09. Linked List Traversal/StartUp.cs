namespace _09._Linked_List_Traversal
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var linkedList = new LinkedList<int>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var commandTokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commandTokens[0] == "Add")
                {
                    linkedList.Add(int.Parse(commandTokens[1]));
                }
                else
                {
                    linkedList.Remove(int.Parse(commandTokens[1]));
                }
            }

            Console.WriteLine(linkedList.Count);
            Console.WriteLine(string.Join(" ", linkedList));
        }
    }
}