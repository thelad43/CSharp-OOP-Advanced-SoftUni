namespace _01._Database
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var db = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            db.Add(11);
            db.Add(12);
            db.Add(13);

            db.Remove();
            db.Remove();

            var result = db.Fetch();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}