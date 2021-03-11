using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// List of units used to measure distance
    /// </summary>
    /// /// <author>
    /// Alex Chorlton version 0.1
    /// </author>
    public enum DistanceUnits
    {
        NoUnit,
        Feet,
        Metres,
        Kilometres,
        Miles
    }

    /// <summary>
    /// This class provides methods for getting the user
    /// to select a distance unit to convert from, and a
    /// distance unit to convert to, and then calculates
    /// and outputs the number toUnits for the given 
    /// fromUnits.
    /// </summary>
    /// <author>
    /// Alex Chorlton
    /// </author>
}
