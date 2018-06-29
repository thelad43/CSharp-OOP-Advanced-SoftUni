﻿namespace _03._ComparableBook
{
    using System;
    using System.Collections.Generic;

    public class Book : IComparable<Book>
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

        public int CompareTo(Book other)
        {
            var comparison = this.Year.CompareTo(other.Year);

            if (comparison == 0)
            {
                comparison = this.Title.CompareTo(other.Title);
            }

            return comparison;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}