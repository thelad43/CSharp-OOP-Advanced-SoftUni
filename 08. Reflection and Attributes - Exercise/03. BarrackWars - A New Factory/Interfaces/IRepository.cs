namespace _03._BarrackWars_A_New_Factory.Interfaces
{
    public interface IRepository
    {
        void AddUnit(IUnit unit);

        string Statistics { get; }

        void RemoveUnit(string unitType);
    }
}