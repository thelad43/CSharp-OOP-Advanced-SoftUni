namespace _02._Graphic_Editor
{
    using Editors;
    using Shapes;

    public class StartUp
    {
        public static void Main()
        {
            var editor = new GraphicEditor();

            var circle = new Circle();
            var square = new Square();
            var rectangle = new Rectangle();

            editor.DrawShape(circle);
            editor.DrawShape(square);
            editor.DrawShape(rectangle);
        }
    }
}