﻿namespace _04._BarrackWars_The_Commands_Strike_Back.Core.Commands
{
    using System;

    public class FightCommand : Command
    {
        public FightCommand(string[] data)
            : base(data)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return string.Empty;
        }
    }
}