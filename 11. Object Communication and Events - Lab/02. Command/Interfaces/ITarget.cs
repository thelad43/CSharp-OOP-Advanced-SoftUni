namespace _02._Command.Interfaces
{
    public interface ITarget
    {
        bool IsDead { get; }

        void ReceiveDamage(int damage);
    }
}