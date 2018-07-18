namespace _02._Kings_Gambit.Models
{
    using Interfaces;
    using System.Collections.Generic;

    public class King : IKing
    {
        public event GetAttackedEventHandler GetAttackedEvent;

        private readonly ICollection<ISubordinate> subordinates;
        private readonly IWriter writer;

        public King(string name, ICollection<ISubordinate> subordinates, IWriter writer)
        {
            this.Name = name;
            this.subordinates = subordinates;
            this.writer = writer;
        }

        public IReadOnlyCollection<ISubordinate> Subordinates => (IReadOnlyCollection<ISubordinate>)this.subordinates;

        public string Name { get; }

        public void GetAttacked()
        {
            this.writer.WriteLine($"{this.GetType().Name} {this.Name} is under attack!");

            if (this.GetAttackedEvent != null)
            {
                this.GetAttackedEvent.Invoke();
            }
        }

        public void AddSubordinate(ISubordinate subordinate)
        {
            this.subordinates.Add(subordinate);
            this.GetAttackedEvent += subordinate.ReactToAttack;
        }
    }
}