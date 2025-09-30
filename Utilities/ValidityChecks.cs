using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject.Utilities
{
    /// <summary>
    /// This checks if an element is of required type.
    /// </summary>
    internal static class ValidityChecks
    {
        ///<summary>
        /// Checks if an element is of required type.
        /// </summary>
        /// <typeparam name="T"> Type to be checked against</typeparam>
        /// <param name="obj"> Object to be checked</param>
        public static bool IsOfType<T>(object obj)
        {
            return obj is T;
        }
        ///<summary>
        /// This ensures an element is of required type.
        /// </summary>
        /// <returns>
        /// Nothing else throws an exception if not of required type.
        /// </returns>
        public static void EnsureOfType<T>(object obj)
            {
                if (!IsOfType<T>(obj))
                {
                    throw new ArgumentException($"Object of type is not of the required type '{typeof(T).Name}'.");
                }
            }

        } 
}
