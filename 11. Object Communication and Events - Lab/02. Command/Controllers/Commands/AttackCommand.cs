﻿namespace _02._Command.Controllers.Commands
{
    using Interfaces;

    public class AttackCommand : ICommand
    {
        private readonly IAttacker attacker;

        public AttackCommand(IAttacker attacker)
        {
            this.attacker = attacker;
        }

        public void Execute()
        {
            this.attacker.Attack();
        }
    }
}