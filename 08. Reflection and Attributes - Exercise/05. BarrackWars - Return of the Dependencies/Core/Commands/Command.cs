namespace _05._BarrackWars_Return_of_the_Dependencies.Core.Commands
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