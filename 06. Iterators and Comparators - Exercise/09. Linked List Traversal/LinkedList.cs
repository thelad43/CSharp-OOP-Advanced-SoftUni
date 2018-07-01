namespace _09._Linked_List_Traversal
{
    using System.Collections;
    using System.Collections.Generic;

    public class LinkedList<T> : IEnumerable<T>
    {
        private LinkedListNode<T> firstElement;

        public LinkedList()
        {
        }

        public LinkedList(T item)
        {
            var node = new LinkedListNode<T>(item);
            this.Head = node;
            this.firstElement = node;
            this.Count = 1;
        }

        public int Count { get; private set; }

        public LinkedListNode<T> Head { get; private set; }

        public void Add(T item)
        {
            var node = new LinkedListNode<T>(item);

            if (this.Count == 0)
            {
                this.Head = node;
                this.firstElement = node;
            }
            else
            {
                this.Head.Next = node;
                node.Previous = this.Head;
                this.Head = node;
            }

            this.Count++;
        }

        public bool Remove(T key)
        {
            var node = this.firstElement;

            if (this.Count == 1)
            {
                this.Clear();
            }

            while (true)
            {
                if (node.Next == null)
                {
                    break;
                }

                if (node.Item.Equals(key))
                {
                    if (node.Previous != null)
                    {
                        node.Previous.Next = node.Next;
                    }
                    else
                    {
                        this.firstElement = this.firstElement.Next;
                        this.firstElement.Previous = null;
                    }

                    if (node.Next != null)
                    {
                        node.Next.Previous = node.Previous;
                    }
                    else
                    {
                        node.Previous.Next = null;
                    }

                    this.Count--;
                    return true;
                }

                node = node.Next;
            }

            return false;
        }

        public void Clear()
        {
            this.firstElement = null;
            this.Head = null;
            this.Count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = this.firstElement;

            while (true)
            {
                if (node == null)
                {
                    break;
                }

                yield return node.Item;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}