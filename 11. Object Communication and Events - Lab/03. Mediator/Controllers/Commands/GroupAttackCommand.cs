namespace _03._Mediator.Controllers.Commands
{
    using Interfaces;

    public class GroupAttackCommand : ICommand
    {
        private readonly IAttackGroup attackGroup;

        public GroupAttackCommand(IAttackGroup attackGroup)
        {
            this.attackGroup = attackGroup;
        }

        public void Execute()
        {
            this.attackGroup.GroupAttack();
        }
    }
}