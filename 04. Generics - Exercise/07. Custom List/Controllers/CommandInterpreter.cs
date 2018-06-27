namespace _07._Custom_List.Controllers
{
    using Interfaces;
    using Models;
    using System;

    public class CommandInterpreter
    {
        private readonly ICustomList<string> customList;

        public CommandInterpreter()
        {
            this.customList = new CustomList<string>();
        }

        public void ProcessCommand(string[] commandTokens)
        {
            switch (commandTokens[0])
            {
                case "Add":
                    this.customList.Add(commandTokens[1]);
                    break;

                case "Remove":
                    this.customList.Remove(int.Parse(commandTokens[1]));
                    break;

                case "Contains":
                    Console.WriteLine(this.customList.Contains(commandTokens[1]));
                    break;

                case "Swap":
                    this.customList.Swap(int.Parse(commandTokens[1]), int.Parse(commandTokens[2]));
                    break;

                case "Greater":
                    Console.WriteLine(this.customList.CountGreaterThan(commandTokens[1]));
                    break;

                case "Max":
                    Console.WriteLine(this.customList.Max());
                    break;

                case "Min":
                    Console.WriteLine(this.customList.Min());
                    break;

                case "Print":
                    this.customList.PrintItems();
                    break;

                default:
                    throw new ArgumentException("Invalid Command!");
            }
        }
    }
}