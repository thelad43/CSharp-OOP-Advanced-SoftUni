namespace _05._BarrackWars_Return_of_the_Dependencies.Core.Commands
{
    using Attributes;
    using Interfaces;

    public class AddCommand : Command
    {
        [Inject]
        private readonly IRepository repository;

        [Inject]
        private readonly IUnitFactory unitFactory;

        public AddCommand(string[] data)
            : base(data)
        {
        }

        public override string Execute()
        {
            var unitType = this.Data[1];
            var unitToAdd = this.unitFactory.CreateUnit(unitType);
            this.repository.AddUnit(unitToAdd);
            var output = unitType + " added!";
            return output;
        }
    }
}