using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternProject.Interfaces;
using DesignPatternProject.Composites;

namespace DesignPatternProject.Factory
{
    /// <summary>
    /// This Factory manages the structure of elements in the project structure.
    /// </summary>
    internal class DigOnceComponentFactory :IComponentFactory
    {
        /// <summary>
        /// This creates a Project Phase element in the Composite tree.
        /// </summary>
        /// <param name="data">Contains details for the Project Phase element to be created</param>
        /// <returns>
        /// The project Phase element created.
        /// </returns>
        public IProjectElement CreateProjectPhase(IhasProjectPhase data)
        {
            return new ProjectPhase(data.Name, data.Description);
        }
        /// <summary>
        /// This creates a Project Task  in the Composite tree.
        /// </summary>
        /// <param name="name">Name of the Project Task</param >
        /// <param name="data">Description of the Project Task</param>
        /// <param name="type"> Type of Project Task created</param>
        /// <returns>
        /// The project Task element created.
        /// </returns>
        public IProjectElement CreateProjectTask(IhasProjectTask data)
        {
            return new ProjectTask(data.Name, data.Cost, data.Description);
        }
        /// <summary>
        /// This creates a Stakeholder element in the Composite tree.
        /// </summary>
        /// <param name="name">Name of the Stakeholder</param >
        /// <param name="data">Description of the Stakeholder</param>
        /// <param name="type"> Type of Stakeholder to be created</param>
        /// <returns>
        /// The Stakeholder created.
        /// </returns>
        public IProjectElement CreateStakeholder(IhasStakeholder data)
        {
            return new ISPElement(data.Name,data.Budget, data.HasPermit, data.PermitNumber);
        }
        /// <summary>
        /// This adds an element to the Composite tree.
        /// </summary>
        /// <param name="parent">Parent element to add to</param >
        /// <param name="child">Element to the added</param>
        public void AddComponent(IProjectElement parent, IProjectElement child)
        { }
    }
}
