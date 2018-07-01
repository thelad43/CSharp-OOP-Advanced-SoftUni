namespace _04._Froggy
{
    using System.Collections;
    using System.Collections.Generic;

    public class Lake<T> : IEnumerable<T>
    {
        private readonly IList<T> elements;

        public Lake(IEnumerable<T> stones)
        {
            this.elements = new List<T>(stones);
        }

        public IEnumerator<T> GetEnumerator()
        {
            var length = this.elements.Count;

            for (int i = 0; i < length; i += 2)
            {
                yield return this.elements[i];
            }

            if (this.elements.Count % 2 != 0)
            {
                length = this.elements.Count - 1;
            }

            for (int i = length - 1; i >= 0; i -= 2)
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