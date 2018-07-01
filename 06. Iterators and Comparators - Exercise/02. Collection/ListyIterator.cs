namespace _02._Collection
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class ListyIterator<T> : IEnumerable<T>
    {
        private readonly IList<T> elements;
        private int currentIndex;

        public ListyIterator(IEnumerable<T> elements)
        {
            this.elements = new List<T>(elements);
        }

        public bool Move()
        {
            return ++this.currentIndex < this.elements.Count;
        }

        public bool HasNext()
        {
            return this.currentIndex < this.elements.Count - 1;
        }

        public void Print()
        {
            if (!this.elements.Any())
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            if (this.currentIndex > this.elements.Count - 1)
            {
                this.currentIndex = this.elements.Count - 1;
            }

            Console.WriteLine(this.elements[this.currentIndex]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.elements.Count; i++)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}