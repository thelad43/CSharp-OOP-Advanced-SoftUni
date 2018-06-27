namespace _09._Custom_List_Iterator.Interfaces
{
    using System.Collections.Generic;

    public interface ICustomList<T> : IEnumerable<T>
    {
        void Add(T element);

        T Remove(int index);

        bool Contains(T item);

        void Swap(int index1, int index2);

        void Sort();

        int CountGreaterThan(T element);

        T Max();

        T Min();
    }
}