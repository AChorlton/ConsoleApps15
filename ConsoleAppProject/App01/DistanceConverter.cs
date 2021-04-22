using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This is an application to convert the distance of one unit to another
    /// It will provide a cue for the user to chose a distance in one unit (fromUnit) to
    /// be converted into another unit (toUnit)
    /// 
    /// The units that can be converted are shown below.
    /// 1. Miles
    /// 2. Meters
    /// 3. Feet
    /// </summary>
    /// 
    /// <author>
    /// Alex Chorlton
    /// </author>

    public class DistanceConverter
    {
        // Setup the distance variables
        public DistanceUnits FromUnit { get; set; }
        public DistanceUnits ToUnit { get; set; }
        public double FromDistance { get; set; }
        public double ToDistance { get; set; }
        

        // Conversions
        public const int FEET_IN_MILES = 5280;
        public const double FEET_IN_METRES = 3.28084;
        public const double METRES_IN_MILES = 1609.34;

        public DistanceConverter()
        {
            FromUnit = DistanceUnits.Miles;
            ToUnit = DistanceUnits.Feet;
        }
