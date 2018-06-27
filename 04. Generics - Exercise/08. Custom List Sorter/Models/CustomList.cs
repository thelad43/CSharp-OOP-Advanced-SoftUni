namespace _08._Custom_List_Sorter.Models
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CustomList<T> : IComparable<T>, ICustomList<T>
        where T : IComparable
    {
        private IList<T> items;

        public CustomList()
        {
            this.items = new List<T>();
        }

        public void Add(T element)
        {
            this.items.Add(element);
        }

        public T Remove(int index)
        {
            var removedItem = this.items[index];
            this.items.RemoveAt(index);
            return removedItem;
        }

        public bool Contains(T item)
        {
            if (this.items.Contains(item))
            {
                return true;
            }

            return false;
        }

        public void Swap(int index1, int index2)
        {
            var oldValue = this.items[index1];
            this.items[index1] = this.items[index2];
            this.items[index2] = oldValue;
        }

        public void Sort()
        {
            this.items = this.items
                .Take(this.items.Count)
                .OrderBy(n => n)
                .ToArray();
        }

        public int CountGreaterThan(T element)
        {
            var count = 0;

            foreach (var item in this.items)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public T Max()
        {
            return this.items.Max();
        }

        public T Min()
        {
            return this.items.Min();
        }

        public void PrintItems()
        {
            foreach (var item in this.items)
            {
                Console.WriteLine(item);
            }
        }

        public int CompareTo(T other)
        {
            return this.CountGreaterThan(other);
        }
    }
}