namespace _05._Kings_Gambit_Extended.Models
{
    using Interfaces;

    public abstract class Subordinate : ISubordinate
    {
        private readonly IWriter writer;

        protected Subordinate(string name, string action, int health, IWriter writer)
        {
            this.Name = name;
            this.Action = action;
            this.Health = health;
            this.IsAlive = true;
            this.writer = writer;
        }

        public string Name { get; }

        public bool IsAlive { get; private set; }

        public string Action { get; }

        public int Health { get; private set; }

        public void Die() => this.IsAlive = false;

        public virtual void ReactToAttack()
        {
            if (this.IsAlive)
            {
                this.writer.WriteLine($"{this.GetType().Name} {this.Name} is {this.Action}!");
            }
        }

        public void TakeDamage()
        {
            if (--this.Health <= 0)
            {
                this.Die();
            }
        }
    }
}