namespace _03._Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Stack<T> : IEnumerable<T>
    {
        private readonly IList<T> data;

        public Stack(IEnumerable<T> elements)
        {
            this.data = new List<T>(elements);
        }

        public void Push(T element)
        {
            this.data.Add(element);
        }

        public T Pop()
        {
            if (!this.data.Any())
            {
                throw new InvalidOperationException("No elements");
            }

            var poppedElement = this.data.LastOrDefault();
            this.data.Remove(poppedElement);
            return poppedElement;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.data.Count - 1; i >= 0; i--)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}