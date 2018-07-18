namespace _05._Kings_Gambit_Extended.Interfaces
{
    public delegate void GetAttackedEventHandler();

    public interface IAttackable
    {
        event GetAttackedEventHandler GetAttackedEvent;

        void GetAttacked();
    }
}