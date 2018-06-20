namespace _02._Graphic_Editor.Shapes
{
    using Interfaces;
    using System;

    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I'm Square");
        }
    }
}