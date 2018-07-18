namespace _05._Kings_Gambit_Extended.Interfaces
{
    public interface IDieable
    {
        bool IsAlive { get; }

        int Health { get; }

        void TakeDamage();

        void Die();
    }
}