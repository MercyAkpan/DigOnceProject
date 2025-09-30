using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject.Utilities
{
    internal class IdGenerator
    {
        ///<summary>
        /// Generates a unique ID.
        /// </summary>
        public static string GenerateUniqueID()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 10);
        }
    }
}