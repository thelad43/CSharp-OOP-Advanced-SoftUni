namespace _10._Tuple
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var personAddress = ReadPersonAddress();
            Console.WriteLine(personAddress);

            var personBeer = ReadPersonBeer();
            Console.WriteLine(personBeer);

            var integerDouble = ReadIntegerDouble();
            Console.WriteLine(integerDouble);
        }

        private static Tuple<int, double> ReadIntegerDouble()
        {
            // wtf... the task is really CRINGE
            var integerDouble = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var integer = int.Parse(integerDouble[0]);
            var @double = double.Parse(integerDouble[1]);

            return new Tuple<int, double>(integer, @double);
        }

        private static Tuple<string, int> ReadPersonBeer()
        {
            var personBeerTokens = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var name = personBeerTokens[0];
            var beerInLiters = int.Parse(personBeerTokens[1]);

            return new Tuple<string, int>(name, beerInLiters);
        }

        private static Tuple<string, string> ReadPersonAddress()
        {
            var personAddressTokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var name = personAddressTokens[0] + " " + personAddressTokens[1];
            var address = personAddressTokens[2];

            return new Tuple<string, string>(name, address);
        }
    }
}