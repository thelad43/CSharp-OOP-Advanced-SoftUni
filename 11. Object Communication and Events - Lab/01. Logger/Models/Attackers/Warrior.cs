namespace _01._Logger.Models.Attackers
{
    using Controllers.Loggers;
    using Interfaces;
    using System;

    public class Warrior : AbstractHero
    {
        private const string AttackMessage = "{0} damages {1} for {2}";

        public Warrior(string id, int damage, Logger logger)
            : base(id, damage, logger)
        {
        }

        protected override void ExecuteClassSpecificAttack(ITarget target, int damage)
        {
            Console.WriteLine(AttackMessage, this, target, damage);
        }
    }
}