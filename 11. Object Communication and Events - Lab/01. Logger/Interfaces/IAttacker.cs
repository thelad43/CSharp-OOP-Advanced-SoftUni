namespace _01._Logger.Interfaces
{
    public interface IAttacker
    {
        void Attack();

        void SetTarget(ITarget target);
    }
}