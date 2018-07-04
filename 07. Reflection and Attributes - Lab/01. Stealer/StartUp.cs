namespace _01._Stealer
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var spy = new Spy();
            var result = spy.StealFieldInfo("Hacker", "username", "password");
            Console.WriteLine(result);
        }
    }
}