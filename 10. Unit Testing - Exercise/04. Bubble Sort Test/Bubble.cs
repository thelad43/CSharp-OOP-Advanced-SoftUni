namespace _04._Bubble_Sort_Test
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Bubble<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        public Bubble(IList<T> items)
        {
            this.Data = items;
            this.SortItems();
        }

        public IList<T> Data { get; }

        public void Add(T item)
        {
            this.Data.Add(item);
            this.SortItems();
        }

        private void SortItems()
        {
            for (int i = 0; i < this.Data.Count; i++)
            {
                for (int k = 0; k < this.Data.Count - 1; k++)
                {
                    if (this.Data[k].CompareTo(this.Data[k + 1]) > 0)
                    {
                        var oldValue = this.Data[k + 1];
                        this.Data[k + 1] = this.Data[k];
                        this.Data[k] = oldValue;
                    }
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.Data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}