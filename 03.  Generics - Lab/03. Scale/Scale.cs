﻿namespace _03._Scale
{
    using System;

    public class Scale<T>
        where T : IComparable<T>
    {
        public Scale(T left, T right)
        {
            this.Left = left;
            this.Right = right;
        }

        public T Left { get; set; }

        public T Right { get; set; }

        public T GetHeavier()
        {
            var comarison = this.Left.CompareTo(this.Right);

            if (comarison > 0)
            {
                return this.Left;
            }
            else if (comarison < 0)
            {
                return this.Right;
            }

            return default(T);
        }
    }
}