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
        public const double METRES_IN_MILES = 1609.34;
        public const double MILES_IN_KILOMETRES = 0.621371;

        

        // Distance Units
        private double miles;
        private double feet;
        private double metres;
        private double kiloMetres;

        /// <summary>
        /// Runs the program and carrys out any methods that have been writen allowing the user to begin to convert miles to feet
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
        /// Prompt the user to input the number of kilometres
        /// </summary>
        private void InputKilometres()
        {
            Console.Write("  Enter the number of Kilometres >");
            string value = Console.ReadLine();
            kiloMetres = Convert.ToDouble(value);
        }

        /// <summary>
        /// Prompt the user to input the number of miles
        /// </summary>
        private void InputMiles()
        {
            Console.Write("  Enter the number of miles >");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        /// <summary>
        /// Output how many feet there are in the given miles
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine();
            Console.WriteLine($"  {miles} miles is {feet} feet!");
            Console.WriteLine();
        }

        /// <summary>
        /// Output the number of metres in the given distance in miles
        /// </summary>
        private void OutputMetres()
        {
            Console.WriteLine();
            Console.WriteLine($"  {miles} miles is {metres} metres!");
            Console.WriteLine();
        }


        /// <summary>
        /// Output the number of miles in the given distance in Kilometres
        /// </summary>
        private void OutputMiles()
        {
            Console.WriteLine();
            Console.WriteLine("  " + kiloMetres + " Kilometres is " + miles + " miles!");
            Console.WriteLine();
        }

        /// <summary>
        /// This is the heading 'design' that will be output into the console show what the tool is and who created it.
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("\n ---------------------------");
            Console.WriteLine("     Convert Miles to Feet     ");
            Console.WriteLine("       By Alex Chorlton       ");
            Console.WriteLine(" ---------------------------\n");
            Console.WriteLine();
        }
    }

        /// <summary>
        /// Calculate how many metres there are in the given miles
        /// </summary>
        private void CalculateMetres()
        {
            OutputHeading();
            InputMiles();

            metres = miles * METRES_IN_MILES;

            OutputMetres();
        }

        /// <summary>
        /// Calculate how many Miles there are in the given Kilometres
        /// </summary>
        private void CalculateMiles()
        {
            OutputHeading();
            InputKilometres();

            miles = kiloMetres * MILES_IN_KILOMETRES;

            OutputMiles();
        }

        
}
