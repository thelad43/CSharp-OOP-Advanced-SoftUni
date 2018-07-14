namespace _02._Extended_Database
{
    using System;
    using System.Linq;

    public class Database
    {
        private const int Capacty = 16;
        private const int MaxIndex = 16;

        private readonly Person[] people;
        private int currentIndex = 0;

        public Database()
        {
            this.people = new Person[Capacty];
        }

        public Database(params Person[] people)
        {
            this.CheckCountItems(people);
            this.people = new Person[Capacty];
            this.FillData(people);
        }

        public int Count => this.currentIndex;

        private void FillData(Person[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                this.people[this.currentIndex] = items[i];
                this.currentIndex++;
            }
        }

        private void CheckCountItems(Person[] people)
        {
            if (people.Length > 16)
            {
                throw new InvalidOperationException("Items cannot be more than 16!");
            }
        }

        public void Add(Person person)
        {
            this.CheckIndex();
            this.CheckDuplicateUsers(person);
            this.people[this.currentIndex] = person;
            this.currentIndex++;
        }

        private void CheckIndex()
        {
            if (this.currentIndex == MaxIndex)
            {
                throw new InvalidOperationException("The Database is full!");
            }
        }

        private void CheckDuplicateUsers(Person person)
        {
            var personWithUsername = this.people.FirstOrDefault(p => p != null && p.UserName == person.UserName);
            var personWithId = this.people.FirstOrDefault(p => p != null && p.Id == person.Id);

            if (personWithUsername != null)
            {
                throw new InvalidOperationException("Person already exists!");
            }

            if (personWithId != null)
            {
                throw new InvalidOperationException("Person already exists!");
            }
        }

        public void Remove()
        {
            if (this.currentIndex == 0)
            {
                throw new InvalidOperationException("The Database if empty!");
            }

            this.people[this.currentIndex] = null;
            this.currentIndex--;
        }

        public Person[] Fetch()
        {
            var result = new Person[this.currentIndex];
            Array.Copy(this.people, result, this.currentIndex);
            return result;
        }

        public Person FindById(long id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("id", "Id cannot be less than zero!");
            }

            var person = this.people.FirstOrDefault(p => p != null && p.Id == id);

            if (person == null)
            {
                throw new InvalidOperationException("There is no person corresponding to given one!");
            }

            return person;
        }

        public Person FindByUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentNullException("UserName", "Username cannot be null or empty!");
            }

            var person = this.people.FirstOrDefault(p => p != null && p.UserName == username);

            if (person == null)
            {
                throw new InvalidOperationException("There is no person corresponding to given one!");
            }

            return person;
        }
    }
}