using System;

namespace Ssepan.Patterns
{
    /// <summary>
    /// This interface is used by views that wish to be observers.
    /// </summary>
    public interface IEventObserver
    {
        //void Notify(Object sender, EventArgs e);
        // Renamed so that Notify handler and Notify event do not collide 
        // if a class that implements IEventObservable/inherits from EventObservable 
        // also wants to implement IEventObserver
        // so that nested objects may notify their parent
        void NotifyHandler(Object sender, EventArgs e);
    }
}
