using System;
using Ssepan.Utility;
using System.Diagnostics;
using System.Reflection;

namespace Ssepan.Patterns
{
    public class EventObservable : IEventObservable
    {
        #region Declarations
        public event EventHandler<EventArgs> Notify;
        #endregion Declarations

        #region IEventObservable
        public void OnNotify(EventArgs e)
        {
            try
            {
                if (Notify != null)
                {
                    Notify(this, e);
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
        #endregion IEventObservable
    }
}
