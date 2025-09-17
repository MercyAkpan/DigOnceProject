using DesignPatternProject.Composites;
using DesignPatternProject.MainProjectSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" UMUAHIA-ABA EXPRESSWAY DIG-ONCE PROJECT");
            Console.WriteLine("==========================================\n");
            //TODO: Later -- since this a separate project of its own.
            //What happens when one adds a new project with its own new tree?
            //LATER -- integrate all trees into a single one, with one root, but stems are different
            //projects and branches are phases in that project.
            var project = new DigOnceProjectSystem();
            //TODO: shouldn't adding ISPs be encapsulated, in say the DigOnceProjectSystem,
            //Not in the Program.cs?
            // which is the department in charge of the Dig Once project(DOP)?
            //The (DOP) department is in charge of collecting details about each stakeholder, not the CEO(client),
            // Add ISPs with different permits and budgets
            project.AddISP(new ISPElement("MTN Nigeria", 15000000, true, "NCC/ISP/2023/001"));
            project.AddISP(new ISPElement("Airtel Networks", 12000000, true, "NCC/ISP/2023/002"));
            project.AddISP(new ISPElement("Glo Mobile", 10000000, false, "")); // No permit
            project.AddISP(new ISPElement("Joy", 10000000, false, "")); // No permit
            project.AddISP(new ISPElement("9mobile", 8000000, true, "NCC/ISP/2023/004"));
            project.AddISP(new ISPElement("Swift Networks", 6000000, true, "NCC/ISP/2023/005"));
            project.AddISP(new ISPElement("MainOne", 9000000, true, "NCC/ISP/2023/006"));
            project.AddISP(new ISPElement("Spectranet", 16000000, true, "NCC/ISP/2023/006"));

            // Run the complete analysis
            project.RunProjectAnalysis();

            //Console.WriteLine("\n === HOW THE STACK-BASED ITERATOR WORKS ===");
            //Console.WriteLine("1.STACK starts with root project's children");
            //Console.WriteLine("2.For each element:");
            //Console.WriteLine("   • Process current element (get cost, description)");
            //Console.WriteLine("   • If element has children, PUSH its iterator to stack");
            //Console.WriteLine("   • If ISP found, check permits & calculate access years");
            //Console.WriteLine("3. Continue until stack is empty (all elements processed)");
            //Console.WriteLine("4. Result: Complete project analysis with ISP coordination");

        }
    }
}
