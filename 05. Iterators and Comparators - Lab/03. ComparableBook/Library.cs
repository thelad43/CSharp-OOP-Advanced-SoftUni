namespace _03._ComparableBook
{
    using System.Collections;
    using System.Collections.Generic;

    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            this.Books = new SortedSet<Book>(books);
        }

        public SortedSet<Book> Books { get; }

        public IEnumerator<Book> GetEnumerator()
        {
            return this.Books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}