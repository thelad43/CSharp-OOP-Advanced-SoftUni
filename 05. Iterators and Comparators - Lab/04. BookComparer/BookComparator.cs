namespace _04._BookComparer
{
    using System.Collections.Generic;

    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            var comparison = x.Title.CompareTo(y.Title);

            if (comparison == 0)
            {
                comparison = y.Year.CompareTo(x.Year);
            }

            return comparison;
        }
    }
}