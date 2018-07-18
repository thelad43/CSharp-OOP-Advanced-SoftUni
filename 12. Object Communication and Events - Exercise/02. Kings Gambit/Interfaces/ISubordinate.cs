namespace _02._Kings_Gambit.Interfaces
{
    public interface ISubordinate : INameable, IDieable
    {
        string Action { get; }

        void ReactToAttack();
    }
}