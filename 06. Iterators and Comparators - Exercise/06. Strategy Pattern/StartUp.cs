namespace _06._Strategy_Pattern
{
    using Comparators;
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        private static SortedSet<Person> sortedPeople1;
        private static SortedSet<Person> sortedPeople2;

        public static void Main()
        {
            sortedPeople1 = new SortedSet<Person>(new PersonNameComparator());
            sortedPeople2 = new SortedSet<Person>(new PersonAgeComparator());
            FillSortedSets();
            PrintSortedSets(sortedPeople1, sortedPeople2);
        }

        private static void PrintSortedSets(SortedSet<Person> sortedPeople1, SortedSet<Person> sortedPeople2)
        {
            foreach (var person in sortedPeople1)
            {
                Console.WriteLine(person);
            }

            foreach (var person in sortedPeople2)
            {
                Console.WriteLine(person);
            }
        }

        private static void FillSortedSets()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var personInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);
                var person = new Person(name, age);

                sortedPeople1.Add(person);
                sortedPeople2.Add(person);
            }
        }
    }
}