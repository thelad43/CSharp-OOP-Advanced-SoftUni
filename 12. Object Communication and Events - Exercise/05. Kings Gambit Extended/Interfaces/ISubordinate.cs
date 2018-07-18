namespace _05._Kings_Gambit_Extended.Interfaces
{
    public interface ISubordinate : INameable, IDieable
    {
        string Action { get; }

        void ReactToAttack();
    }
}