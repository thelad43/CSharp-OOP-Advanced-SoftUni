namespace _01._Library
{
    using System.Collections.Generic;

    public class Book
    {
        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = new List<string>(authors);
        }

        public string Title { get; }

        public int Year { get; }

        public IReadOnlyList<string> Authors { get; }
    }
}