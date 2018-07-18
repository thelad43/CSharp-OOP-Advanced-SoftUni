namespace _03._Dependency_Inversion.Interfaces
{
    public interface IWriter
    {
        void Write(string text);

        void WriteLine(string text);
    }
}