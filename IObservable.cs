
namespace Ssepan.Patterns
{
    /// <summary>
    /// This interface is generally used by models that wish to be observable.
    /// Note: It cannot be used if the 'model' class is static, which doesn't play well with an interface.
    /// </summary>
    public interface IObservable
    {
        void AddObserver(IObserver o);

        void RemoveObserver(IObserver o);

        void NotifyObservers();
    }
}
