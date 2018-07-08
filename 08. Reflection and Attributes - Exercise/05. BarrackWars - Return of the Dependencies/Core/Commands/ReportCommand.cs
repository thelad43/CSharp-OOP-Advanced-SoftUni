namespace _05._BarrackWars_Return_of_the_Dependencies.Core.Commands
{
    using Attributes;
    using Interfaces;

    public class ReportCommand : Command
    {
        [Inject]
        private readonly IRepository repository;

        public ReportCommand(string[] data) : base(data)
        {
        }

        public override string Execute() => this.repository.Statistics;
    }
}