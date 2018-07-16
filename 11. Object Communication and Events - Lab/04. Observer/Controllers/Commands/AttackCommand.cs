﻿namespace _04._Observer.Controllers.Commands
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