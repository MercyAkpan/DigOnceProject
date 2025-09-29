using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternProject.Interfaces
{
    /// <summary>
    /// This interface contains common behavior for all elements in the Composite tree.
    /// </summary>
    public interface IProjectElement
    {
        string Name { get; }
        /// <summary>
        /// This is the unique id of the Stakeholder.
        /// </summary>
        string Id { get; }
        /// <summary>
        /// Gets the cost of the project element.   
        /// </summary>
        /// <returns>
        /// The cost of the project element.
        /// </returns>
        decimal GetCost();
        string GetDescription();
        void DisplayInfo(int depth = 0);
        IEnumerator<IProjectElement> CreateIterator();
    }
    ///<summary>
    /// This interface contains leaf-specific behavior in the Composite tree.
    /// </summary>
    public interface IProjectUnit : IProjectElement
    {
        // Leaf-specific methods would be added here.
    }
    ///<summary>
    /// This interface contains composite-specific behavior in the Composite tree.
    ///</summary>
    public interface IProjectPhase : IProjectElement
    {
        /// <summary>
        /// This adds an element to the Composite tree.
        /// </summary>
        /// <param name="component"></param>
        void AddComponent(IProjectElement component);
        List<IProjectElement> GetComponents();
    }

}