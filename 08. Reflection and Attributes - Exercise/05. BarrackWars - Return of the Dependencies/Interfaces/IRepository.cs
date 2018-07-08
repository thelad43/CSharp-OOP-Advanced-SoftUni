namespace _05._BarrackWars_Return_of_the_Dependencies.Interfaces
{
    public interface IRepository
    {
        void AddUnit(IUnit unit);

        string Statistics { get; }

        void RemoveUnit(string unitType);
    }
}