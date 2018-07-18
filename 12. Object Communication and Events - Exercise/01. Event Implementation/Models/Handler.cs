namespace _01._Event_Implementation.Models
{
    using Interfaces;

    public class Handler
    {
        private readonly IWriter writer;

        public Handler(IWriter writer)
        {
            this.writer = writer;
        }

        public void OnDispatcherNameChange(object sender, NameChangeEventArgs eventArgs)
        {
            this.writer.WriteLine($"Dispatcher's name changed to {eventArgs.Name}.");
        }
    }
}