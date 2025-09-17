using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternProject.Interfaces;

namespace DesignPatternProject.Composites
{
    /// <summary>
    /// Leaf type of the Composite Pattern
    /// </summary>
    public class ISPElement : IProjectElement
    {
        public string Name { get; private set; }
        public decimal Budget { get; private set; }
        public bool HasPermit { get; private set; }
        public string PermitNumber { get; private set; }
        public bool IsEligible { get; private set; }
        public int FreeAccessYears { get; private set; }
        public string CableStatus { get; private set; } = "Not Started";

        public ISPElement(string name, decimal budget, bool hasPermit, string permitNumber)
        {
            Name = name;
            Budget = budget;
            HasPermit = hasPermit;
            PermitNumber = permitNumber;
            IsEligible = false;
            FreeAccessYears = 0;
        }

        public decimal GetCost() => Budget;
        public string GetDescription() => $"ISP Contribution: NGN{Budget:N0}, Permit: {(HasPermit ? PermitNumber : "MISSING")}";

        public void ProcessEligibility(decimal totalDuctCost)
        {
            if (HasPermit && Budget > 0)
            {
                IsEligible = true;
                // Calculate free access years: (Budget / Total Duct Cost) * 15 years max
                double contributionRatio = (double)(Budget / totalDuctCost);
                FreeAccessYears = Math.Max(1, Math.Min(15, (int)(contributionRatio * 15)));
            }
            else
            {
                IsEligible = false;
                FreeAccessYears = 0;
            }
        }

        public void LayCables()
        {
            if (IsEligible)
            {
                CableStatus = "In Progress";
                Console.WriteLine($"{Name}: Starting cable installation...");

                // Simulate cable laying progress
                System.Threading.Thread.Sleep(3000);

                CableStatus = "Completed";
                Console.WriteLine($"{Name}: Cable installation completed!");
            }
        }

        public void DisplayInfo(int depth = 0)
        {
            string indent = new string(' ', depth);
            string eligibilityEmoji = IsEligible ? "Yes" : "No";

            Console.WriteLine($"{indent}{eligibilityEmoji} {Name} (ISP)");
            Console.WriteLine($"{indent}   Budget: NGN{Budget:N0}");
            Console.WriteLine($"{indent}   Permit: {(HasPermit ? $"{PermitNumber}" : "Missing")}");
            Console.WriteLine($"{indent}   Eligible: {(IsEligible ? "Yes" : "No")}");
            if (IsEligible)
            {
                Console.WriteLine($"{indent}   Free Access: {FreeAccessYears} years");
                Console.WriteLine($"{indent}   Cable Status: {CableStatus}");
            }
        }

        // ISP is leaf, no children
        public IEnumerator<IProjectElement> CreateIterator()
        {
            yield break;
        }
    }

}
