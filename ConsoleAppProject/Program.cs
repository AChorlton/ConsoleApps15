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
            Use.OutputHeading(" C# Console Applications 2020");

            string [] choices = { 
                "App01: Distance Converter", "Quit" };

            int choiceNo = Use.SelectChoice(choices);

            if (choiceNo == 1)
            {
                DistanceConverter1 converter = new DistanceConverter1();
                converter.ConvertDistance();
            }
            else if (choiceNo == 2)
            {
                BMI bmi = new BMI();
                bmi.CalculateIndex();
            }
            else if (choiceNo == 3)
            {
                StudentGrades app = new StudentGrades();
                app.OutputMenu();
            }
            else if (choiceNo == 4)
            {
                NetworkUI network = new NetworkUI();
                network.DisplayMenu();
            }
            else if (choiceNo == 5)
            {
                GameView view = new GameView();

                view.PlayGame();
            }

        }
    }
}
