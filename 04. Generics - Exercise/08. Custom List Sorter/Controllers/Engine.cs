﻿namespace _08._Custom_List_Sorter.Controllers
{
    using System;

    public class Engine
    {
        private readonly CommandInterpreter commandInterpreter;

        public Engine()
        {
            this.commandInterpreter = new CommandInterpreter();
        }

        public void Run()
        {
            while (true)
            {
                var commandTokens = Console.ReadLine()
                   .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commandTokens[0] == "END")
                {
                    break;
                }

                this.commandInterpreter.ProcessCommand(commandTokens);
            }
        }
    }
}