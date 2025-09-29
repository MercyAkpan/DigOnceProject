using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternProject.Interfaces;

namespace DesignPatternProject.Interfaces
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
        /// This creates a Project Phase element in the Composite tree.
        /// </summary>
        /// <param name="data">Contains details for the Project Phase element to be created</param>
        /// <returns>
        /// The Project Phase element created.
        /// </returns>
        IProjectElement CreateProjectPhase(IhasProjectPhase data);
        /// <summary>
        /// This creates a Project Task  in the Composite tree.
        /// </summary>
        /// <param name="data">Contains details for the Project Task element to be created</param>
        /// <returns>
        /// The Project Task created.
        /// </returns>
        IProjectElement CreateProjectTask(IhasProjectTask data);
        /// <summary>
        /// This creates a Stakeholder element in the Composite tree.
        /// </summary>
        /// <param name="data">Contains details for the Stakeholder element to be created</param>
        /// <returns>
        /// The Stakeholder created.
        /// </returns>
        IProjectElement CreateStakeholder(IhasStakeholder data);

        /// <summary>
        /// This adds an element to the Composite tree.
        /// </summary>
        /// <param name="parent">Project Phase element to add to</param >
        /// <param name="child"> Element to be added</param>
        void AddComponent(IProjectElement parent, IProjectElement child);
    }
}
