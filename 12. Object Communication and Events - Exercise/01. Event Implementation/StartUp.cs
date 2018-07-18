namespace _01._Event_Implementation
{
    using IO;
    using Models;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var dispatcher = new Dispatcher();
            var handler = new Handler(new ConsoleWriter());

            dispatcher.NameChange += handler.OnDispatcherNameChange;

            while (true)
            {
                var dispatcherName = Console.ReadLine();

                if (dispatcherName == "End")
                {
                    break;
                }

                dispatcher.Name = dispatcherName;
            }
        }
    }
}