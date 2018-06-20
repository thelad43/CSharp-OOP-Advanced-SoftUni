namespace _02._Graphic_Editor.Editors
{
    using Interfaces;

    public class GraphicEditor
    {
        public void DrawShape(IShape shape)
        {
            shape.Draw();
        }
    }
}