namespace _04._BarrackWars_The_Commands_Strike_Back.Interfaces
{
    public interface IRepository
    {
        void AddUnit(IUnit unit);

        string Statistics { get; }

        void RemoveUnit(string unitType);
    }
}