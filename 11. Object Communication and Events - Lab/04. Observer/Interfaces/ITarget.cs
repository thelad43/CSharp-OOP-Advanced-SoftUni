namespace _04._Observer.Interfaces
{
    public interface ITarget : ISubject
    {
        bool IsDead { get; }

        void ReceiveDamage(int damage);
    }
}