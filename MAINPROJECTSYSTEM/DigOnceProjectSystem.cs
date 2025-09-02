using DESIGNPATTERNPROJECT.COMPOSITES;
using DESIGNPATTERNPROJECT.ITERATOR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TODO: Safely rename namespaces without all caps.
namespace DESIGNPATTERNPROJECT.MAINPROJECTSYSTEM
{
    public class DigOnceProjectSystem
    {
        //TODO: Why are these made private?
        //Make eligibleISPs 'ISPs'? cause they havent be declared eligible.
        private ProjectPhase rootProject;
        private ProjectPhase ispSection;
        private List<ISPElement> eligibleISPs;
        private decimal totalProjectCost;
        private decimal sharedDuctCost;
        private decimal totalISPContributions;

        public DigOnceProjectSystem()
        {
            eligibleISPs = new List<ISPElement>();
            totalProjectCost = 0;
            sharedDuctCost = 60000000; // NGN60M for shared ducts
            totalISPContributions = 0;
            //Builds the skeleton of the project: All Project Phases and Stakeholder Phase.
            BuildProjectStructure();
        }

        private void BuildProjectStructure()
        {
            // Root project
            rootProject = new ProjectPhase("Umuahia-Aba Expressway Dig-Once Project",
                                          "45km expressway upgrade with shared telecommunications infrastructure");
            //TODO: Understand what exactly these phases are in real life.
            //and how you could add more realistic ones.
            // Infrastructure phases
            var preparationPhase = new ProjectPhase("Road Preparation", "Survey and preparation work");
            //IS there not a better way to add component without use of 'new ProjectTask'..
            //TODO: Make more tasks into these phases.
            preparationPhase.AddComponent(new ProjectTask("Route Survey", 8000000, "Detailed road survey and mapping", "Survey"));
            preparationPhase.AddComponent(new ProjectTask("Traffic Diversion", 5000000, "Setup traffic management systems", "Preparation"));

            var excavationPhase = new ProjectPhase("Road Excavation", "Primary road excavation work");
            excavationPhase.AddComponent(new ProjectTask("Primary Excavation", 35000000, "Main road excavation", "Excavation"));
            excavationPhase.AddComponent(new ProjectTask("Duct Preparation", 15000000, "Prepare trenches for ducts", "Excavation"));

            var ductPhase = new ProjectPhase("Shared Duct Installation", "Install shared telecommunications ducts");
            ductPhase.AddComponent(new ProjectTask("Main Duct System", 40000000, "Primary duct network installation", "Infrastructure"));
            ductPhase.AddComponent(new ProjectTask("Access Points", 20000000, "Install duct access points", "Infrastructure"));

            var restorationPhase = new ProjectPhase("Road Restoration", "Restore road surface and complete project");
            restorationPhase.AddComponent(new ProjectTask("Road Surface", 25000000, "Apply new road surface", "Restoration"));
            restorationPhase.AddComponent(new ProjectTask("Final Inspection", 2000000, "Complete project inspection", "Quality Control"));

            // ISP section (this will hold all ISPs)
            ispSection = new ProjectPhase("ISP Participants", "Internet Service Providers contributing to the project");

            // Add all phases to root
            rootProject.AddComponent(preparationPhase);
            rootProject.AddComponent(excavationPhase);
            rootProject.AddComponent(ductPhase);
            rootProject.AddComponent(ispSection);
            rootProject.AddComponent(restorationPhase);
            //TODO: {PAUSE}
        }

        public void AddISP(ISPElement isp)
        {
            ispSection.AddComponent(isp);
        }

        public void RunProjectAnalysis()
        {
            Console.WriteLine("=== STARTING PROJECT ANALYSIS ===\n");

            // Step 1: Display entire project structure using CompositeIterator
            DisplayProjectStructure();

            // Step 2: Process ISPs using the iterator
            ProcessISPs();

            // Step 3: Calculate totals and run cable installation
            DisplayFinalSummary();
        }

        private void DisplayProjectStructure()
        {
            Console.WriteLine("=== PROJECT STRUCTURE ANALYSIS {DRAFT PLAN} ===");
            Console.WriteLine($"Project: {rootProject.Name}");
            Console.WriteLine($"Description: {rootProject.GetDescription()}\n");

            // Use our custom CompositeIterator to traverse the entire project
            using (var iterator = new ProjectCompositeIterator(rootProject))
            {
                Console.WriteLine("Iterating through all project components:\n");

                while (iterator.MoveNext())
                {
                    var element = iterator.Current;

                    // Calculate total cost as we iterate
                    totalProjectCost += element.GetCost();

                    // Display component info
                    Console.WriteLine($"Component: {element.Name}");
                    if (!(element is ISPElement isp))
                        Console.WriteLine($"Cost: NGN{element.GetCost():N0}");
                    else
                        Console.WriteLine($"Budget: NGN{element.GetCost():N0}");
                    Console.WriteLine($"Description: {element.GetDescription()}");
                    Console.WriteLine();
                }
            }

            Console.WriteLine($"Total Project Cost: NGN{totalProjectCost:N0}");
            Console.WriteLine($"Shared Duct Cost: NGN{sharedDuctCost:N0}\n");
        }

        private void ProcessISPs()
        {
            Console.WriteLine("=== PROCESSING ISP PARTICIPANTS ===\n");

            // Use CompositeIterator to find and process all ISPs
            //TODO: Add logic to traverse other kind of stakeholder later.
            using (var iterator = new ProjectCompositeIterator(rootProject))
            {
                while (iterator.MoveNext())
                {
                    var element = iterator.Current;

                    // Check if this element is an ISP
                    if (element is ISPElement isp)
                    {
                        Console.WriteLine($"Processing ISP: {isp.Name}");

                        // Check eligibility (permits and budget)
                        isp.ProcessEligibility(sharedDuctCost);

                        if (isp.IsEligible)
                        {
                            eligibleISPs.Add(isp);
                            totalISPContributions += isp.Budget;
                            Console.WriteLine($"{isp.Name}: APPROVED - NGN{isp.Budget:N0} contribution, {isp.FreeAccessYears} years free access");
                        }
                        else
                        {
                            Console.WriteLine($"{isp.Name}: REJECTED - {(isp.HasPermit ? "Insufficient budget" : "Missing permit")}");
                        }
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine($"Eligible ISPs: {eligibleISPs.Count}");
            Console.WriteLine($"Total ISP Contributions: NGN{totalISPContributions:N0}");

            if (totalISPContributions >= sharedDuctCost)
                Console.WriteLine("Shared duct construction is FULLY FUNDED!\n");
            else
                Console.WriteLine($"Still needs NGN{sharedDuctCost - totalISPContributions:N0} for duct construction\n");
        }

        private void DisplayFinalSummary()
        {
            Console.WriteLine("=== FINAL PROJECT SUMMARY ===\n");

            Console.WriteLine("COST BREAKDOWN:");
            Console.WriteLine($"• Total Project Cost: NGN{totalProjectCost:N0}");
            Console.WriteLine($"• Shared Duct Cost: NGN{sharedDuctCost:N0}");
            Console.WriteLine($"• ISP Contributions: NGN{totalISPContributions:N0}");
            Console.WriteLine($"• Government Funding: NGN{totalProjectCost - totalISPContributions:N0}");

            Console.WriteLine("\nPARTICIPATING ISPs:");
            foreach (var isp in eligibleISPs.OrderByDescending(i => i.Budget))
            {
                Console.WriteLine($"• {isp.Name}: NGN{isp.Budget:N0} ({isp.FreeAccessYears} years free access)");
            }

            Console.WriteLine("\n=== CABLE INSTALLATION PROGRESS ===");
            foreach (var isp in eligibleISPs)
            {
                isp.LayCables();
            }

            Console.WriteLine("\n=== PROJECT COMPLETED SUCCESSFULLY ===");
            Console.WriteLine($"{eligibleISPs.Count} ISPs now have shared duct access!");
            Console.WriteLine($"Estimated savings: NGN{eligibleISPs.Count * 10000000:N0} (vs individual excavations)");
        }
    }

}
