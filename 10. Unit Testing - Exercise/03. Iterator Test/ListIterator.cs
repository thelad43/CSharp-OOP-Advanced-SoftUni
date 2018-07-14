namespace _03._Iterator_Test
{
    using System;
    using System.Collections.Generic;

    public class ListIterator
    {
        private readonly IList<string> data;
        private int currentIndex;

        public ListIterator(IList<string> data)
        {
            this.CheckNullData(data);
            this.data = data;
        }

        public bool Move()
        {
            if (this.currentIndex < this.data.Count - 1)
            {
                this.currentIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            return this.currentIndex < this.data.Count - 1;
        }

        public void Print()
        {
            if (this.data == null || this.data.Count == 0)
            {
                throw new InvalidOperationException("The collection is empty!");
            }

            Console.WriteLine(this.data[this.currentIndex]);
        }

        private void CheckNullData(IList<string> data)
        {
            if (data == null || data.Count == 0)
            {
                throw new ArgumentNullException("data", "The data cannot be null!");
            }
        }
    }
}