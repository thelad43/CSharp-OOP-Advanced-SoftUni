namespace _04._BarrackWars_The_Commands_Strike_Back.Core.Commands
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