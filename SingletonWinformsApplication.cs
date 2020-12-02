using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ssepan.Utility;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Reflection;

namespace Ssepan.Patterns
{
    public class SingletonWinformsApplication : WindowsFormsApplicationBase
    {
        //must call constructor to ensure correct initial base configuration
        public SingletonWinformsApplication(System.Windows.Forms.Form mainForm)
        {
            try
            {
                //specify mainform
                this.MainForm = mainForm;

                //this ensure underlying Single SDI framework is employed 
                //and OnStartupNextInstance is fired
                this.IsSingleInstance = true;

            }
            catch (Exception ex)
            {
                Ssepan.Utility.Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
                        
            }
        }
    }
}
