namespace _01._Database
{
    using System;

    public class Database
    {
        private const int Capacty = 16;
        private const int MaxIndex = 16;

        private readonly int[] data;
        private int currentIndex = 0;

        public Database()
        {
            this.data = new int[Capacty];
        }

        public Database(params int[] items)
        {
            this.CheckCountItems(items);
            this.data = new int[Capacty];
            this.FillData(items);
        }

        private void FillData(int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                this.data[this.currentIndex] = items[i];
                this.currentIndex++;
            }
        }

        private void CheckCountItems(int[] items)
        {
            if (items.Length > 16)
            {
                throw new InvalidOperationException("Items cannot be more than 16!");
            }
        }

        public void Add(int item)
        {
            if (this.currentIndex == MaxIndex)
            {
                throw new InvalidOperationException("The Database is full!");
            }

            this.data[this.currentIndex] = item;
            this.currentIndex++;
        }

        public void Remove()
        {
            if (this.currentIndex == 0)
            {
                throw new InvalidOperationException("The Database if empty!");
            }

            this.data[this.currentIndex] = 0;
            this.currentIndex--;
        }

        public int[] Fetch()
        {
            var result = new int[this.currentIndex];
            Array.Copy(this.data, result, this.currentIndex);
            return result;
        }
    }
}