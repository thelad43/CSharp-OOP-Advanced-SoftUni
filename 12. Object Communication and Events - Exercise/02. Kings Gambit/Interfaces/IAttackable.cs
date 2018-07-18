namespace _02._Kings_Gambit.Interfaces
{
    public delegate void GetAttackedEventHandler();

    public interface IAttackable
    {
        event GetAttackedEventHandler GetAttackedEvent;

        void GetAttacked();
    }
}