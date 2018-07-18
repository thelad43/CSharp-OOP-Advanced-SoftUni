namespace _02._Kings_Gambit.Models
{
    using Interfaces;

    public class Footman : Subordinate
    {
        private new const string Action = "panicking";

        public Footman(string name, IWriter writer)
            : base(name, Action, writer)
        {
        }
    }
}