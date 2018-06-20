namespace _02._Graphic_Editor.Shapes
{
    using Interfaces;
    using System;

    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I'm Circle");
        }
    }
}