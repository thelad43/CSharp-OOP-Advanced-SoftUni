namespace _03._Mediator.Interfaces
{
    public interface IAttacker
    {
        void Attack();

        void SetTarget(ITarget target);
    }
}