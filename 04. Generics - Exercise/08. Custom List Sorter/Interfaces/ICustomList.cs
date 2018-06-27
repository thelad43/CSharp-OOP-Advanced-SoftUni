namespace _08._Custom_List_Sorter.Interfaces
{
    public interface ICustomList<T>
    {
        void Add(T element);

        T Remove(int index);

        bool Contains(T item);

        void Swap(int index1, int index2);

        void Sort();

        int CountGreaterThan(T element);

        void PrintItems();

        T Max();

        T Min();
    }
}