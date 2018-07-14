namespace _02._Extended_Database
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var people = new Person[]
            {
                new Person(1, "Pesho"),
                new Person(2, "Gosho"),
                new Person(3, "Stamat"),
                new Person(4, "Ivan"),
                new Person(5, "Penka"),
            };

            var db = new Database(people);
            var result = db.Fetch();

            Print(result);
            Console.WriteLine();

            var ivan = db.FindByUsername("Ivan");
            Console.WriteLine("Ivannncho: " + ivan);

            var personWithId5 = db.FindById(5);
            Console.WriteLine("Id{5} :" + personWithId5);
            Console.WriteLine();

            db.Remove();
            db.Remove();

            result = db.Fetch();
            Print(result);
        }

        private static void Print(Person[] result)
        {
            foreach (var person in result)
            {
                Console.WriteLine(person);
            }
        }
    }
}