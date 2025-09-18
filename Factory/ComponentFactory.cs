using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternProject.Interfaces;

namespace DesignPatternProject.Factory
{
    /// <summary>
    /// This Factory Interface contains methods to create instances of nodes in the Composite tree.
    /// </summary>
    /// <remarks>
    /// It is an Interface and not an abstract class because of varying logic in implementators.
    /// </remarks>
    internal interface IComponentFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        IProjectElement CreatePhase(string name);
        IProjectElement CreateTask(string name, decimal cost);
        IProjectElement CreateStakeholder(string type, decimal budget, bool hasPermit, string permitNumber);

    }
}
