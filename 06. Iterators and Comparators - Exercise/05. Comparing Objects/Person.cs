namespace _05._Comparing_Objects
{
    using System;

    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }

        public int CompareTo(Person other)
        {
            var comparison = this.Name.CompareTo(other.Name);

            if (comparison == 0)
            {
                comparison = this.Age.CompareTo(other.Age);
            }

            if (comparison == 0)
            {
                comparison = this.Town.CompareTo(other.Town);
            }

            return comparison;
        }
    }
}