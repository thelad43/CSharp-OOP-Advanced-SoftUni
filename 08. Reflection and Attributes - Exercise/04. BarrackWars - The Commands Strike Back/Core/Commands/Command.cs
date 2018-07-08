namespace _04._BarrackWars_The_Commands_Strike_Back.Core.Commands
{
    using Interfaces;

    public abstract class Command : IExecutable
    {
        public Command(string[] data)
        {
            this.Data = data;
        }

        protected string[] Data { get; private set; }

        public abstract string Execute();
    }
}