﻿namespace _02._Command.Controllers.Commands
{
    using Interfaces;

    public class TargetCommand : ICommand
    {
        private readonly IAttacker attacker;
        private readonly ITarget target;

        public TargetCommand(IAttacker attacker, ITarget target)
        {
            this.attacker = attacker;
            this.target = target;
        }

        public void Execute()
        {
            this.attacker.SetTarget(this.target);
        }
    }
}