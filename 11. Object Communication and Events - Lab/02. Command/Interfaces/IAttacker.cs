namespace _02._Command.Interfaces
{
    public interface IAttacker
    {
        void Attack();

        void SetTarget(ITarget target);
    }
}