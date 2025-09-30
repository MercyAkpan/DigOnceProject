using DesignPatternProject.Interfaces;
using DesignPatternProject.Utilities.DataStore;
using NUnit.Framework;
using NUnit.Framework.Internal;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TestFactory = DesignPatternProject.Factory.DigOnceComponentFactory;
namespace DesignPatternProject.tests
{
    /// <summary>
    /// This tests all operations in the DigOnceComponentFactory class.
    /// </summary>
    [TestFixture]
    public class DigOnceProjectFactoryTests
    {
        /// <summary>
        /// Factory instance for testing.
        /// </summary>
        private TestFactory factory;
        /// <summary>
        /// Data store for Project Phase.
        /// </summary>
        private ProjectPhaseStore Phasedata;
        /// <summary>
        /// Data store for Project Phase.
        /// </summary>
        private ProjectTaskStore taskData;
        /// <summary>
        /// Data store for Stakeholder element.
        /// </summary>
        private StakeholderStore Stakeholderdata;
        [OneTimeSetUp]
        public void Setup()
        {
            factory = new TestFactory();
            Phasedata = new ProjectPhaseStore
            {
                Name = "Root Project",
                Description = "Umuahia-Aba expressway upgrade"
            };
            taskData = new ProjectTaskStore
            {
                Name = "Lay Cables",
                Description = "Laying of cables for the project",
                Cost = 1000000M
            };
            Stakeholderdata = new StakeholderStore
            {
                Name = "Government",
                Budget = 1000000,
                HasPermit = true,
                PermitNumber = "PN123456",
            };
        }
        [Test]
        ///<summary>
        /// This tests the CreateProjectPhase method of the DigOnceComponentFactory class.
        /// </summary>
        /// <remarks>
        /// Should create a Project Phase element in the Composite tree.
        /// </remarks>
        public void CreateProjectPhase()
        {
            var projectPhase = factory.CreateProjectPhase(Phasedata);
            ClassicAssert.NotNull(projectPhase);
        }
        [Test]
        ///<summary>
        /// This tests the CreateProjectTask method of the DigOnceComponentFactory class.
        /// </summary>
        /// <remarks>
        /// Should create a Project Task element in the Composite tree.
        /// </remarks>
        public void CreateProjectTask()
        {

            var projectTask = factory.CreateProjectTask(taskData);
            ClassicAssert.NotNull(projectTask);
        }
        [Test]
        ///<summary>
        /// This tests the CreateStakeholder method of the DigOnceComponentFactory class.
        /// </summary>
        /// <remarks>
        /// Should create a Stakeholder element in the Composite tree.
        /// </remarks>
        public void CreateStakeholder()
        {

            var stakeholder = factory.CreateStakeholder(Stakeholderdata);
            ClassicAssert.NotNull(stakeholder);
        }
        [Test]
        ///<summary>
        /// This tests if a Unique Id is created for each Project .
        /// </summary>
        public void UniqueIdCreation()
        {
            var stakeholder1 = factory.CreateStakeholder(Stakeholderdata);
            var stakeholder2 = factory.CreateStakeholder(Stakeholderdata);
            ClassicAssert.AreNotEqual(stakeholder1.Id, stakeholder2.Id);
        }
    }
}
