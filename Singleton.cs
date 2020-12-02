using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Ssepan.Patterns
{
    /// <summary>
    /// Courtesy of: 
    /// Andy Clymer @ http://andyclymer.blogspot.com/2008/02/true-generic-singleton.html
    /// Simon Hughes @ http://www.blogger.com/profile/17394832925629583851
    /// Chris Smith @ http://www.chrisjsmith.me.uk/
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Singleton<T> where T:class//, new()
    {
        private static T instance;
        private static object initLock = new object();

        public static T GetInstance()
        {
            if (instance == null)
            {
                CreateInstance();
            }
            return instance;
        }

        private static void CreateInstance()
        {
            lock (initLock)
            {
                if (instance == null)
                {
                    Type t = typeof(T);

                    // Ensure there are no public constructors...
                    ConstructorInfo[] ctors = t.GetConstructors();

                    if (ctors.Length > 0)
                    {
                        throw new InvalidOperationException(String.Format("{0} has at least one accesible ctor making it impossible to enforce singleton behaviour", t.Name));
                    }

                    // Create an instance via the private constructor
                    instance = (T)Activator.CreateInstance(t, true);
                }
            }
        }
    }
}
