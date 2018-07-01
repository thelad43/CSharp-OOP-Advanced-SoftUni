namespace _05._Comparing_Objects
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        private static List<Person> people;

        public static void Main()
        {
            people = ReadPeople();
            var n = int.Parse(Console.ReadLine());
            var wantedPerson = people[n - 1];

            var equalPeople = 0;
            var differentPeople = 0;

            foreach (var person in people)
            {
                if (person.CompareTo(wantedPerson) == 0)
                {
                    equalPeople++;
                }
                else
                {
                    differentPeople++;
                }
            }

            PrintResult(equalPeople, differentPeople);
        }

        private static void PrintResult(int equalPeople, int differentPeople)
        {
            if (equalPeople > 1)
            {
                Console.Write(equalPeople + " ");
                Console.Write(differentPeople + " ");
                Console.WriteLine(equalPeople + differentPeople);
                return;
            }

            Console.WriteLine("No matches");
        }

        private static List<Person> ReadPeople()
        {
            var people = new List<Person>();

            while (true)
            {
                var inputTokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (inputTokens[0] == "END")
                {
                    break;
                }

                var name = inputTokens[0];
                var age = int.Parse(inputTokens[1]);
                var town = inputTokens[2];

                people.Add(new Person(name, age, town));
            }

            return people;
        }
    }
}