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
    
    class DistanceConverter3
    {
        // Conversion Factors
        public const int FeetInMiles = 5280;
        public const double MetresInMiles = 1609.34;
        public const double KilometresInMiles = 1.60934;

        public const double FeetInKilometres = 3280.84;
        public const double MetresInKilometres = 1000;
        public const double MilesInKilometres = 0.621371;

        public const double FeetInMetres = 1 / MetresInFeet;
        public const double KilometersInMetres = 1 / MetresInKilometres;
        public const double MilesInMetres = 1 / MetresInMiles;

        public const double MetresInFeet = 0.3048;
        public const double KilometresInFeet = 1 / FeetInKilometres;
        public const double MilesInFeet = 1.0 / FeetInMiles;
    }
}
