using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternProject.Interfaces;
using DesignPatternProject.Utilities;

namespace DesignPatternProject.Composites
{
    public class ProjectTask : IProjectElement
    {
        public string Name { get; private set; }
        //TODO: Why are these fields below made private and why not as properties?
        // Can i say the Name is a field that needs specific accesibility.
        private decimal cost; //Private fields
        private string description; //Protected from external access.
        private string taskType;
        ///<summary>
        /// This is the unique id of the Project Task element.
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// This initializes the Project Task in the Composite tree.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cost"></param>
        /// <param name="description"></param>

        public ProjectTask(string name, decimal cost, string description)
        {
            Name = name;
            this.cost = cost;
            this.description = description;
            Id = IdGenerator.GenerateUniqueID();
            //TODO: What is the taskType used for? 
            //this.taskType = taskType;
        }

        public decimal GetCost() => cost;
        public string GetDescription() => $"{description} (Type: {taskType})";

        public void DisplayInfo(int depth = 0)
        {
            string indent = new string(' ', depth);
            Console.WriteLine($"{indent}{Name}: NGN{cost:N0}");
            Console.WriteLine($"{indent}   {description}");
        }

        // Leaf returns empty iterator
        public IEnumerator<IProjectElement> CreateIterator()
        {
            yield break; // No children
        }
    }

}
