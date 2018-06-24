namespace Logger.Interfaces
{
    public interface IAppender : ILevel
    {
        ILayout Layout { get; }

        void Append(IError error);
    }
}