# 🛣️ Dig-Once Infrastructure Coordination System
#### &emsp; License

This project is licensed under the [MIT License](LICENSE) - see the LICENSE file for details.

## 📌 Project Overview
The **Dig-Once Infrastructure Coordination System** is a **C# application** that demonstrates the practical implementation of **Composite** and **Iterator** design patterns to solve real-world infrastructure coordination challenges.  

Inspired by Nigeria's **Dig-Once policy** in *Abia State*, this system manages the complex coordination required when multiple telecommunications companies and utilities need to install infrastructure along the same road corridor.

---

## 🎯 Problem Statement
When upgrading the **Umuahia–Aba Expressway**, multiple stakeholders (ISPs, power companies, government agencies) traditionally dig separately, causing:

- 🚧 4× road disruptions instead of one coordinated excavation  
- 💰 Higher costs due to duplicate excavation work  
- 🚦 Traffic chaos from multiple construction periods  
- 🔀 Coordination nightmares between different organizations  

---

## 💡 Solution
This system applies **design patterns** to coordinate all stakeholders efficiently:

- **Composite Pattern** → Manages the hierarchical project structure *(Road → Phases → Tasks)*  
- **Iterator Pattern** → Processes stakeholders systematically with different coordination strategies  

---

## 🏫 Academic Context
- **Original Project**: August 2025 – University coursework: *“Composite meets Iterator Pattern”*  
- **Current Status**: Continuously improving and expanding with **additional design patterns** as part of ongoing software engineering learning  

---

## 🚀 Features
### Core Functionality
- ✅ **Project Structure Management** – Hierarchical breakdown of road construction phases  
- ✅ **Stakeholder Coordination** – Systematic processing of ISPs and utilities  
- ✅ **Permit Verification** – Automatic filtering of stakeholders without valid permits  
- ✅ **Budget Analysis** – Calculate contributions and free access years  
- ✅ **Cost Optimization** – Shared excavation costs across participants  
- ✅ **Timeline Coordination** – Sequential project phase execution  

### Design Patterns Implemented
#### 🏗️ Composite Pattern
```plaintext
Project Root
├── Road Preparation Phase
│   ├── Route Survey Task
│   ├── Traffic Diversion Task
│   └── Utility Mapping Task
├── Excavation Phase
│   ├── Primary Excavation Task
│   └── Secondary Trenching Task
└── Cable Installation Phase
    ├── ISP Cable Tasks (Dynamic)
    └── Power Cable Tasks (Dynamic)
```
## SAMPLE OUTPUT
 UMUAHIA-ABA EXPRESSWAY DIG-ONCE PROJECT
==========================================
```
=== STARTING PROJECT ANALYSIS ===

=== PROJECT STRUCTURE ANALYSIS {DRAFT PLAN} ===
Project: Umuahia-Aba Expressway Dig-Once Project
Description: 45km expressway upgrade with shared telecommunications infrastructure (Contains 5 components)

Iterating through all project components:

Component: Road Preparation
Cost: NGN13,000,000
Description: Survey and preparation work (Contains 2 components)

Component: Route Survey
Cost: NGN8,000,000
Description: Detailed road survey and mapping (Type: Survey)

Component: Traffic Diversion
Cost: NGN5,000,000
Description: Setup traffic management systems (Type: Preparation)

Component: ISP Participants
Cost: NGN86,000,000
Description: Internet Service Providers contributing to the project (Contains 8 components)

Component: MTN Nigeria
Budget: NGN15,000,000
Description: ISP Contribution: NGN15,000,000, Permit: NCC/ISP/2023/001

Component: Airtel Networks
Budget: NGN12,000,000
Description: ISP Contribution: NGN12,000,000, Permit: NCC/ISP/2023/002

Component: Glo Mobile
Budget: NGN10,000,000
Description: ISP Contribution: NGN10,000,000, Permit: MISSING

=== FINAL PROJECT SUMMARY ===

COST BREAKDOWN:
 Total Project Cost: NGN472,000,000
 Shared Duct Cost: NGN60,000,000
 ISP Contributions: NGN66,000,000
 Government Funding: NGN406,000,000

PARTICIPATING ISPs:
 Spectranet: NGN16,000,000 (4 years free access)
 MTN Nigeria: NGN15,000,000 (3 years free access)
 Airtel Networks: NGN12,000,000 (3 years free access)
 MainOne: NGN9,000,000 (2 years free access)
 9mobile: NGN8,000,000 (2 years free access)
 Swift Networks: NGN6,000,000 (1 years free access)

=== CABLE INSTALLATION PROGRESS ===
MTN Nigeria: Starting cable installation...
MTN Nigeria: Cable installation completed!
Airtel Networks: Starting cable installation...
Airtel Networks: Cable installation completed!
9mobile: Starting cable installation...
9mobile: Cable installation completed!
Swift Networks: Starting cable installation...
Swift Networks: Cable installation completed!
MainOne: Starting cable installation...
MainOne: Cable installation completed!
Spectranet: Starting cable installation...
Spectranet: Cable installation completed!

=== PROJECT COMPLETED SUCCESSFULLY ===
6 ISPs now have shared duct access!
Estimated savings: NGN60,000,000 (vs individual excavations)
==============================================
```
## 🛠️ Installation & Usage
### Prerequisites
.NET 6.0 or higher
Visual Studio 2022 or VS Code
C# 10.0+ support

## Quick Start
Clone the repository:
```
git clone https://github.com/yourusername/dig-once-project.git
cd dig-once-project
```
### Build and run:
```
dotnet build
dotnet run

// Example usage:
var project = new DigOnceExpresswayProject();

// Add ISPs with budget and permit status
project.AddISP(new ISP("MTN Nigeria", 15000000, true, "NCC/ISP/2023/001", "Major ISP"));
project.AddISP(new ISP("Airtel Networks", 12000000, false, "", "Major ISP")); // No permit

// Process applications and coordinate
project.ProcessISPApplications();
project.ExecuteCableInstallation();

```
## 📁 Project Structure
```
DigOnceProject/
├── src/
│   ├── Composites/
│   │   ├── ISPElement.cs
│   │   ├── ProjectPhase.cs
│   │   └── ProjectTask.cs
│   ├── Iterator/
│   │   └── ProjectCompositeIterator.cs
│   ├── Interfaces/
│   │   └── IProjectElement.cs
│   ├── MainProjectSystem/
│   │   └── DigOnceProjectSystem.cs
├── tests/
├── docs/
└── README.md
```
### 🎓 Learning Outcomes
This project demonstrates:

Composite Pattern – Managing complex hierarchical structures

Iterator Pattern – Systematic traversal with multiple strategies

Real-world Problem Solving – Applying patterns to infrastructure challenges

SOLID Principles – Clean code architecture & separation of concerns

### 🔄 Future Improvements
🚀 Planned Design Patterns
Strategy Pattern – Cost calculation strategies

Observer Pattern – Real-time project status updates

Factory Pattern – Dynamic creation of project types

Command Pattern – Undo/redo functionality

State Pattern – Project lifecycle management

### 🌟 Feature Roadmap
Database Integration (persist data)

REST API (project management endpoints)

Web Dashboard (visual project monitoring)

Reporting Module (PDF/analytics)

Multi-Project Support

Integration Testing

### 🤝 Contributing
This is a learning project, but contributions and suggestions are welcome!

Ways to contribute:

Report bugs/issues

Suggest new design pattern implementations

Propose feature enhancements

Share alternative solutions

### How to Contribute
Fork the repository
 Create a feature branch
`` git checkout -b feature/amazing-pattern
``

# Commit your changes
`` git commit -m 'Add amazing design pattern'
``

# Push to your branch
`` git push origin feature/amazing-pattern 
``

# Open a Pull Request
