namespace _07._Equality_Logic
{
    using Comparators;
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        private static SortedSet<Person> sortedSetPeople;
        private static HashSet<Person> hashSetPeople;

        public static void Main()
        {
            sortedSetPeople = new SortedSet<Person>();
            hashSetPeople = new HashSet<Person>(new PersonEqualityComparator());
            FillSets();
            Console.WriteLine(sortedSetPeople.Count);
            Console.WriteLine(hashSetPeople.Count);
        }

        private static void FillSets()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var personInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);
                var person = new Person(name, age);

                sortedSetPeople.Add(person);
                hashSetPeople.Add(person);
            }
        }
    }
}