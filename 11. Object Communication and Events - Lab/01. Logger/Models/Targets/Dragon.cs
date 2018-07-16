namespace _01._Logger.Models.Targets
{
    using Interfaces;
    using System;

    public class Dragon : ITarget
    {
        private const string ThisDiedEvent = "{0} dies";

        private readonly string id;
        private int hp;
        private readonly int reward;
        private bool eventTriggered;

        public Dragon(string id, int hp, int reward)
        {
            this.id = id;
            this.hp = hp;
            this.reward = reward;
        }

        public bool IsDead { get => this.hp <= 0; }

        public void ReceiveDamage(int damage)
        {
            if (!this.IsDead)
            {
                this.hp -= damage;
            }

            if (this.IsDead && !this.eventTriggered)
            {
                Console.WriteLine(ThisDiedEvent, this);
                this.eventTriggered = true;
            }
        }

        public override string ToString()
        {
            return this.id;
        }
    }
}