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
    /// Alex Chorlton Version 0.1
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

        // Available Distance Units
        public const string Feet = "Feet";
        public const string Metres = "Metres";
        public const string Kilometres = "Kilometres";
        public const string Miles = "Miles";
        public const string NoUnit = "No Unit";

        // Convert from distance value and unit
        private double fromValue;
        private DistanceUnit fromUnit;

        // Convert to distance value and unit
        private double toValue;
        private DistanceUnit toUnit;
    }

        /// <summary>
        /// This is a method which will calculate the final distance's value 
        /// depending on the distance input unit and the distance output unit.
        /// </summary>
        private void CalculateToValue()
        {
            if ((fromUnit == DistanceUnit.Miles) && 
                (toUnit == DistanceUnit.Feet))
            {
                toValue = fromValue * FeetInMiles;
            }
            else if ((fromUnit == DistanceUnit.Miles) && 
                     (toUnit == DistanceUnit.Metres))
            {
                toValue = fromValue * MetresInMiles;
            }
            else if ((fromUnit == DistanceUnit.Miles) && 
                (toUnit == DistanceUnit.Kilometres))
            {
                toValue = fromValue * KilometresInMiles;
            }
            else if ((fromUnit == DistanceUnit.Kilometres) && 
                     (toUnit == DistanceUnit.Miles))
            {
                toValue = fromValue * MilesInKilometres;
            }
            else if ((fromUnit == DistanceUnit.Kilometres) && 
                     (toUnit == DistanceUnit.Metres))
            {
                toValue = fromValue * MetresInKilometres;
            }
            else if ((fromUnit == DistanceUnit.Kilometres) && 
                     (toUnit == DistanceUnit.Feet))
            {
                toValue = fromValue * FeetInKilometres;
            }
        }

    /// <summary>
    /// Calculate how many toUnits there are in the given fromUnits
    /// </summary>
 
    public void Execute()
    {
        OutputHeading();

        fromUnit = SelectUnit(" Enter unit to convert from > ");

        if (fromUnit != DistanceUnit.NoUnit)
        {
            fromValue = InputNumber($" Enter the number of {fromUnit} > ");

            toUnit = SelectUnit(" Enter unit to convert to > ");

            if (toUnit != DistanceUnit.NoUnit)
            {
                    CalculateToValue();
                    OutputResult();
            }
        }
    }

        /// <summary>
        /// Output a Heading for the distance converter
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("  -----------------------------");
            Console.WriteLine("         Convert Distances     ");
            Console.WriteLine("         by Alex Chorlton      ");
            Console.WriteLine("  -----------------------------");
            Console.WriteLine();
        }

        /// <summary>
        /// Prompt the user to input a double number
        /// </summary>
        private double InputNumber(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// Output the number of metres in the given distance in miles
        /// </summary>
        private void OutputResult()
        {
            Console.WriteLine();
            Console.WriteLine($"  {fromValue} {fromUnit} is {toValue} {toUnit} !");
            Console.WriteLine();
        }

        
}
