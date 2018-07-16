namespace _04._Observer.Interfaces
{
    public interface IAttacker
    {
        void Attack();

        void SetTarget(ITarget target);
    }
}