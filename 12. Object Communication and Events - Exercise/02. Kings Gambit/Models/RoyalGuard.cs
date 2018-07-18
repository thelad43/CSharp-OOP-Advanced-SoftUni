namespace _02._Kings_Gambit.Models
{
    using Interfaces;

    public class RoyalGuard : Subordinate
    {
        private new const string Action = "defending";

        private readonly IWriter writer;

        public RoyalGuard(string name, IWriter writer)
            : base(name, Action, writer)
        {
            this.writer = writer;
        }

        public override void ReactToAttack()
        {
            if (this.IsAlive)
            {
                this.writer.WriteLine($"Royal Guard {this.Name} is {Action}!");
            }
        }
    }
}