namespace _02._Extended_Database
{
    public class Person
    {
        public Person(int id, string userName)
        {
            this.Id = id;
            this.UserName = userName;
        }

        public int Id { get; private set; }

        public string UserName { get; private set; }

        public override string ToString()
        {
            return $"Id: {this.Id}, Username: {this.UserName}";
        }
    }
}