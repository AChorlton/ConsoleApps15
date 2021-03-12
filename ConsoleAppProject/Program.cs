using ConsoleAppProject.App01;
using System;

namespace ConsoleAppProject
{

    /// <summary>
    /// This class runs first and create a DistanceConverter
    /// allowing the user three ways of converting distances
    /// </summary>
    /// <author>
    /// Alex Chorlton
    /// </author>
    public static class Program
    {
        public static NetworkUI Network { get; set; }

        public static void Main()
        {
            UserLib.OutputHeading(" C# Console Applications 2020");

            string [] choices = { 
                "App01: Distance Converter", "Quit" };

            int choiceNo = UserLib.SelectChoice(choices);

            if (choiceNo == 1)
            {
                DistanceConverter1 converter = new DistanceConverter1();
                converter.ConvertDistance();
            }

        }
    }
}
