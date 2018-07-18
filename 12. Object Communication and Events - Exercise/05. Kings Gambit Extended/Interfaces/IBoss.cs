namespace _05._Kings_Gambit_Extended.Interfaces
{
    using System.Collections.Generic;

    public interface IBoss : INameable
    {
        IReadOnlyCollection<ISubordinate> Subordinates { get; }

        void AddSubordinate(ISubordinate subordinate);
    }
}