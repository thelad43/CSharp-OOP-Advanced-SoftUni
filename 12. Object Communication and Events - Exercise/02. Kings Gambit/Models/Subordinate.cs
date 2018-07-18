namespace _02._Kings_Gambit.Models
{
    using Interfaces;

    public abstract class Subordinate : ISubordinate
    {
        private readonly IWriter writer;

        protected Subordinate(string name, string action, IWriter writer)
        {
            this.Name = name;
            this.Action = action;
            this.IsAlive = true;
            this.writer = writer;
        }

        public string Name { get; }

        public bool IsAlive { get; private set; }

        public string Action { get; }

        public void Die() => this.IsAlive = false;

        public virtual void ReactToAttack()
        {
            if (this.IsAlive)
            {
                this.writer.WriteLine($"{this.GetType().Name} {this.Name} is {this.Action}!");
            }
        }
    }
}