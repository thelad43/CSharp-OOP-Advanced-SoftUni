namespace _07._Custom_List.Interfaces
{
    public interface ICustomList<T>
    {
        void Add(T element);

        T Remove(int index);

        bool Contains(T item);

        void Swap(int index1, int index2);

        int CountGreaterThan(T element);

        void PrintItems();

        T Max();

        T Min();
    }
}