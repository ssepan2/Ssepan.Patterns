
namespace Ssepan.Patterns
{
    /// <summary>
    /// This interface is used by views that wish to be observers.
    /// </summary>
    public interface IObserver
    {
        void Notify();
    }
}
