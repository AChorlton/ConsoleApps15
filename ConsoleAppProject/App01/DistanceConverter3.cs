using System;
{
    namespace ConsoleAppProject.App01

 /// <summary>
 /// This class offers methods for prompting the user
 /// select the from length unit and the to length unit.
 /// The user then inputs the number of from units, and then 
 /// calculates and outputs the equivalent number of to units
 /// </summary>
 /// <author>
 /// Derek Peacock
 /// </author>
public class LengthConverter
{
    public const int NUMBER_OF_UNITS = 4;

    private int fromUnit;
    private int toUnit;

    private double fromNumber;
    private double toNumber;

    private readonly string[] units = new string[]
    {
            "Feet",
            "Meters",
            "Kilometers",
            "Miles"
    };

    private readonly double[,] conversionFactors = new double[NUMBER_OF_UNITS, NUMBER_OF_UNITS]
    {
          {1.0,     0.3048,  0.0003048, 0.000189394},
          {3.28084, 1.0,     0.001,     0.000621371},
          {3280.84, 1000,    1.0,       0.621371},
          {5280,    1609.34, 1.60934,   1.0}
    };

    /// <summary>
    /// Prompt the user to enter a double number and return it
    /// </summary>
    private double InputNumber(string prompt)
    {
        Console.WriteLine();
        Console.Write(prompt);

        string value = Console.ReadLine();
        return Convert.ToDouble(value);
    }
}
