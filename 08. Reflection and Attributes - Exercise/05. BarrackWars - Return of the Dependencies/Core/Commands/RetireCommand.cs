namespace _05._BarrackWars_Return_of_the_Dependencies.Core.Commands
{
    using Attributes;
    using Interfaces;

    public class RetireCommand : Command
    {
        [Inject]
        private readonly IRepository repository;

        public RetireCommand(string[] data)
            : base(data)
        {
        }

        public override string Execute()
        {
            var unitType = this.Data[1];
            this.repository.RemoveUnit(unitType);
            return $"{unitType} retired!";
        }
    }
}