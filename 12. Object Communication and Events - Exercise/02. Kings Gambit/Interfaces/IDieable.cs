namespace _02._Kings_Gambit.Interfaces
{
    public interface IDieable
    {
        bool IsAlive { get; }

        void Die();
    }
}