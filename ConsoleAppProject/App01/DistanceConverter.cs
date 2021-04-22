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

        /// <summary>
        /// Shows the results of the conversion of the units to the user.
        /// </summary>
        public void OutputDistance()
        {
            Console.WriteLine($"\n {FromDistance} {FromUnit} is {ToDistance} {ToUnit}");
        }
        public void ConvertDistance()
        {
            ConsoleHelper.OutputHeading("Distance Converter", 0.6);
            FromUnit = SelectUnit(" Please select the 'from' distance unit: ");
            ToUnit = SelectUnit(" Please select the 'to' distance unit: ");

            Console.WriteLine($"\n Convert {FromUnit} to {ToUnit}");

            FromDistance = InputDistance($" Please enter the number of {FromUnit}: ");
            CalculateDistance();
            OutputDistance();
        }

        /// <summary>
        /// Ask the user for the unit in which they want to convert into another.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private DistanceUnits SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);
            DistanceUnits unit = ExecuteChoice(choice);
            return unit;
        }

        /// <summary>
        /// Calculate the conversion of the distances in put by the user
        /// </summary>
        public void CalculateDistance()
        {
            if (FromUnit == DistanceUnits.Miles && ToUnit == DistanceUnits.Feet)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Feet && ToUnit == DistanceUnits.Miles)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Feet && ToUnit == DistanceUnits.Metres)
            {
                ToDistance = FromDistance / FEET_IN_METRES;
            }
            else if (FromUnit == DistanceUnits.Metres && ToUnit == DistanceUnits.Feet)
            {
                ToDistance = FromDistance * FEET_IN_METRES;
            }
            else if (FromUnit == DistanceUnits.Miles && ToUnit == DistanceUnits.Metres)
            {
                ToDistance = FromDistance * METRES_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Metres && ToUnit == DistanceUnits.Miles)
            {
                ToDistance = FromDistance / METRES_IN_MILES;
            }
        }

        