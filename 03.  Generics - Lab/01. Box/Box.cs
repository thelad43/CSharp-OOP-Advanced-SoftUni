namespace _01._Box
{
    using System.Collections.Generic;

    public class Box<T>
    {
        private readonly List<T> data;

        public Box()
        {
            this.data = new List<T>();
        }

        public int Count => this.data.Count;

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public T Remove()
        {
            var elementForRemoving = this.data[this.data.Count - 1];
            this.data.RemoveAt(this.data.Count - 1);
            return elementForRemoving;
        }
    }
}