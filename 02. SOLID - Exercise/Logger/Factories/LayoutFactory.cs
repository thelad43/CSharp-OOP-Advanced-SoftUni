namespace Logger.Factories
{
    using Interfaces;
    using Layouts;

    public class LayoutFactory
    {
        public ILayout GetLayout(string layoutType)
        {
            switch (layoutType)
            {
                case "SimpleLayout":
                    return new SimpleLayout();

                case "XmlLayout":
                    return new XmlLayout();

                default:
                    return null;
            }
        }
    }
}