using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternProject.Utilities;

namespace DesignPatternProject.tests
{
    /// <summary>
    /// This tests all operations in the Utilities namespace.
    /// </summary>
    [TestFixture]
    internal class UtilitiesTest
    {
        private HashSet<string> generatedIds;
        /// <summary>
        ///  This setups the test environment.
        /// </summary>
        [OneTimeSetUp]
        public void SetUp()
        {
        }
        ///<summary>
        /// This tests the IdGenerator class.
        /// </summary>
        [Test]
        public void IdGeneratorTest()
        {
            generatedIds = new HashSet<string>();
            int count = 100;
            for (int i = 0; i < count; i++)
            {
                string newId = IdGenerator.GenerateUniqueID();
                ClassicAssert.IsFalse(generatedIds.Contains(newId), $"Duplicate ID generated: {newId}");
                generatedIds.Add(newId);
            }
            Assert.Pass();
        }
    }
}
