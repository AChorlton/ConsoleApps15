using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This application will be able to convert one set of measurement units into another set such as miles into feet.
    /// </summary>
    /// <author>
    /// Alex Chorlton version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        private double miles;

        private double feet;

        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }


        /// <summary>
        /// Get the users to enter the distance in miles
        /// Insert the miles as a double number
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please insert the number of miles >");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        /// <summary>
        /// 
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        /// <summary>
        /// 
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        }

        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("\n ---------------------------");
            Console.WriteLine("    Convert Miles to Feet     ");
            Console.WriteLine("       By Alex Chorlton       ");
            Console.WriteLine(" ---------------------------\n");
            Console.WriteLine();
        }

        public void ConvertMilesToFeet()
        {
            OutputHeading();
            InputMiles();

            feet = miles * FEET_IN_MILES;

            OutputFeet();
        }
    }
}
