using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGNPATTERNPROJECT.COMPOSITES
{
    // Composite: Project phases
    public class ProjectPhase : IProjectElement
    {
        // TODO: Why not readonly?
        public string Name { get; private set; }
        private List<IProjectElement> components;
        private string description;

        public ProjectPhase(string name, string description)
        {
            Name = name;
            //TODO: why this? why not simply 'description = description'?
            this.description = description;
            components = new List<IProjectElement>();
        }

        public void AddComponent(IProjectElement component)
        {
            components.Add(component);
        }

        public decimal GetCost() => components.Sum(c => c.GetCost());
        public string GetDescription() => $"{description} (Contains {components.Count} components)";
        //TODO: How is this used? How can it be used?
        public void DisplayInfo(int depth = 0)
        {
            string indent = new string(' ', depth);
            Console.WriteLine($"{indent}{Name}: NGN{GetCost():N0}");
            Console.WriteLine($"{indent}   {description}");
        }

        // Returns iterator for all child components
        public IEnumerator<IProjectElement> CreateIterator()
        {
            return components.GetEnumerator(); //Returns read-only access
        }

        public List<IProjectElement> GetComponents() => components;
    }

}
