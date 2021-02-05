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

        private double miles;

        private double feet;

        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
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

        }

        /// <summary>
        /// 
        /// </summary>
        private void OutputFeet()
        {

        }
    }
}
