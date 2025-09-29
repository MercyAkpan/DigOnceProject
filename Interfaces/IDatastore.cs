using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject.Interfaces
{
    /// <summary>
    /// This represents a generic interface that stores name attribute.
    /// </summary>
    public interface IhasName {
        /// <summary>
        /// Name of the element
        /// </summary>
        string Name { get; set; }
    }
    ///<summary>
    /// This represents a generic interface that stores cost attribute.
    /// </summary>
    public interface IhasCost {
        /// <summary>
        /// Cost of the element
        /// </summary>
        decimal Cost { get; set; }
    }
    ///<summary>
    /// This represnet a generic interfae that stores the budget attribiute
    /// </summary>
    public interface IhasBudget {
        /// <summary>
        /// Budget of the element
        /// </summary>
        decimal Budget { get; set; }
    }
    /// <summary>
    /// This represents a generic interface that stores description attribute.
    /// </summary>
    public interface IhasDescription {
        /// <summary>
        /// Description of the element
        /// </summary>
        string Description { get; set; }
    }
    ///<summary>
    /// This represents a generic interface that stores type attribute.
    /// </summary>
    public interface IhasType {
        /// <summary>
        /// Type of the element
        /// </summary>
        string Type { get; set; }
    }
    ///<summary>
    /// This represents a generic interface that stores hasPermit attribute.
    /// </summary>
    public interface IhasPermit {
        /// <summary>
        /// HasPermit of the element
        /// </summary>
        bool HasPermit { get; set; }
    }
    /// <summary>
    /// This represents a generic interface that stores the permit number attribute.
    /// </summary>
    public interface IhasPermitNumber {
        /// <summary>
        /// Permit number of the element
        /// </summary>
        string PermitNumber { get; set; }
    }
    ///<summary>
    ///  This represents the generic interface for a project phase.
    /// </summary>
    public interface IhasProjectPhase : IhasName, IhasDescription { }
    ///<summary>
    ///  This represents the generic interface for a project task.
    /// </summary>
    public interface IhasProjectTask: IhasName, IhasDescription, IhasCost { }
    ///<summary>
    /// Tshi repsrents the generica interface for a Stakeholder element.
    /// </summary>
    public interface IhasStakeholder : IhasName, IhasBudget,IhasPermit, IhasPermitNumber { }
}