namespace _01._Logger.Interfaces
{
    public interface ITarget
    {
        bool IsDead { get; }

        void ReceiveDamage(int damage);
    }
}