using System;
using System.Collections;
using Ssepan.Utility;
using System.Diagnostics;
using System.Reflection;

namespace Ssepan.Patterns
{
    public class Observable : IObservable
    {
        #region Declarations
        private ArrayList _Observers = new ArrayList();
        #endregion Declarations

        #region IObservable
        public void AddObserver(IObserver o)
        {
            try
            {
                _Observers.Add(o);
            }
            catch (Exception ex)
            {
                Log.Write(
                    ex,
                    System.Reflection.MethodBase.GetCurrentMethod(),
                    System.Diagnostics.EventLogEntryType.Error);
                    
            }
        }

        public void RemoveObserver(IObserver o)
        {
            try
            {
                _Observers.Remove(o);
            }
            catch (Exception ex)
            {
                Log.Write(
                    ex,
                    System.Reflection.MethodBase.GetCurrentMethod(),
                    System.Diagnostics.EventLogEntryType.Error);
                    
            }
        }

        public void NotifyObservers()
        {
            try
            {
                foreach (IObserver o in _Observers)
                {
                    o.Notify();
                }
            }
            catch (Exception ex)
            {
                Log.Write(
                    ex,
                    System.Reflection.MethodBase.GetCurrentMethod(),
                    System.Diagnostics.EventLogEntryType.Error);
                    
            }
        }
        #endregion IObservable
    }
}
