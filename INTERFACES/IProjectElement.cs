using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


public interface IProjectElement
{
    // Read-only properties
    string Name { get; }
    decimal GetCost();
    string GetDescription();
    void DisplayInfo(int depth = 0);
    IEnumerator<IProjectElement> CreateIterator();
}