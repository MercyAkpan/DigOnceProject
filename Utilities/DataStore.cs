using DesignPatternProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject.Utilities
{
    namespace DataStore
    {

        ///<summary>    
        /// This represents a generic datastore structure for ProjectTask.
        /// </summary>
        internal struct ProjectTaskStore :IhasProjectTask
        {
            /// <summary>
            /// This is the name of the Project Task.
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// This is the description of the Project Task.
            /// </summary>
            public string Description { get; set; }
            /// <summary>
            /// This is the cost of the Project Task.
            /// </summary>
            public decimal Cost { get; set; }
    }
    /// <summary>
    /// This represents a generic datastore structure for Project Task.
    /// </summary>
    internal struct ProjectPhaseStore :IhasProjectPhase
        {

            /// <summary>
            /// This is the name of the Project Task.
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// This is the description of the Project Task.
            /// </summary>
            public string Description { get; set; }
            /// <summary>
            /// This initializes the Project Task Data structure.
            /// </summary>
            /// <param name="description"></param>
            /// <param name="cost"></param>
            ProjectPhaseStore(string name, string description, decimal cost)
            {
                this.Name = name;
                this.Description = description;
            }
        }

        /// <summary>
        /// This represents a generic datastore structure for Stakeholder.
        /// </summary>
        internal struct StakeholderStore : IhasStakeholder
        {
            /// <summary>
            /// This is the name of the Stakeholder.
            /// </summary>
            public string Name{ get; set; }
            /// <summary>
            /// This is current budget of the Stakeholder.
            /// </summary>
            public decimal Budget{ get; set; }
            /// <summary>
            /// This denotes whether the concerned Stakeholder has a permit.
            /// </summary>
            public bool HasPermit { get; set; }
            /// <summary>
            /// This is the permit number of the concerned Stakeholder.
            /// </summary>
            public string PermitNumber { get; set; }
            /// <summary>
            /// This initializes the Stakeholder Data structure.
            /// </summary>
            /// <param name="role"></param>
            /// <param name="contactInfo"></param>
            public StakeholderStore(string name, decimal budget, bool hasPermit, string permitNumber)
            {
                this.Name = name;
                this.Budget = budget;
                this.HasPermit = hasPermit;
                this.PermitNumber = permitNumber;
            }
        }
    }
}
