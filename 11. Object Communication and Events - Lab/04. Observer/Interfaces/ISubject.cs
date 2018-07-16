namespace _04._Observer.Interfaces
{
    public interface ISubject
    {
        void Register(IObserver observer);

        void UnRegister(IObserver observer);

        void NotifyObservers();
    }
}