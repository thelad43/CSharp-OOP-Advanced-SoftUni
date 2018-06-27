namespace _11._Threeuple
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var personInfo = ReadPersonInfo();
            Console.WriteLine(personInfo);

            var personBeer = ReadPersonBeer();
            Console.WriteLine(personBeer);

            var bankAccount = ReadBankAccount();
            Console.WriteLine(bankAccount);
        }

        private static Threeuple<string, decimal, string> ReadBankAccount()
        {
            var bankAccountInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var name = bankAccountInfo[0];
            var balance = decimal.Parse(bankAccountInfo[1]);
            var bankName = bankAccountInfo[2];

            return new Threeuple<string, decimal, string>(name, balance, bankName);
        }

        private static Threeuple<string, int, bool> ReadPersonBeer()
        {
            var personBeerTokens = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var name = personBeerTokens[0];
            var beerInLiters = int.Parse(personBeerTokens[1]);
            var drinkOrNot = personBeerTokens[2] == "drunk" ? true : false;

            return new Threeuple<string, int, bool>(name, beerInLiters, drinkOrNot);
        }

        private static Threeuple<string, string, string> ReadPersonInfo()
        {
            var personInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var name = personInfo[0] + " " + personInfo[1];
            var address = personInfo[2];
            var town = personInfo[3];

            return new Threeuple<string, string, string>(name, address, town);
        }
    }
}