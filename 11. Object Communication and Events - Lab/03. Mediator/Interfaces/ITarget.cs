namespace _03._Mediator.Interfaces
{
    public interface ITarget
    {
        bool IsDead { get; }

        void ReceiveDamage(int damage);
    }
}