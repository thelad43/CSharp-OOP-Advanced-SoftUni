namespace _05._Kings_Gambit_Extended.Models
{
    using Interfaces;

    public class Footman : Subordinate
    {
        private new const string Action = "panicking";
        private new const int Health = 2;

        public Footman(string name, IWriter writer)
            : base(name, Action, Health, writer)
        {
        }
    }
}