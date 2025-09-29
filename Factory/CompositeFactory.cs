using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternProject.Interfaces;
using DataStore = System.Collections.Generic.Dictionary<string, object>;

namespace DesignPatternProject.Factory
{
    /// <summary>
    /// This Factory Interface manages structure of elements in the Composite tree.
    /// </summary>
    /// <remarks>
    /// It is an Interface and not an abstract class because of varying logic in implementators.
    /// </remarks>
    internal interface IComponentFactory
    {
        /// <summary>
        /// This creates a Project Phase node in the Composite tree.
        /// </summary>
        /// <param name="name">Name of the Project Phase</param >
        /// <param name="description">Description of the Project Phase</param>
        /// <returns>
        /// The project Phase node created.
        /// </returns>
        IProjectElement CreatePhase(string name, string description);
        /// <summary>
        /// This creates a Project Task  in the Composite tree.
        /// </summary>
        /// <param name="name">Name of the Project Task</param >
        /// <param name="data">Description of the Project Task</param>
        /// <param name="type"> Type of Project Task created</param>
        /// <returns>
        /// The project Task node created.
        /// </returns>
        IProjectElement CreateTask(string name, DataStore data, string type = null);
        /// <summary>
        /// This adds an element to the Composite tree.
        /// </summary>
        /// <param name="parent">Parent element to add to</param >
        /// <param name="child">Element to the added</param>
        void AddComponent(IProjectElement parent, IProjectElement child);
    }
}
