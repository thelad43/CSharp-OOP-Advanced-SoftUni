namespace _02._Kings_Gambit.Interfaces
{
    using System.Collections.Generic;

    public interface IBoss : INameable
    {
        IReadOnlyCollection<ISubordinate> Subordinates { get; }

        void AddSubordinate(ISubordinate subordinate);
    }
}