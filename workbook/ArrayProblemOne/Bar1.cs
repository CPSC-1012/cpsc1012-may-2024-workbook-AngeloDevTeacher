// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/// < summary>
/// Create a bar graph containing up to 10 bars that go from 0-50, read from an array.
/// Name: Angelo Encarnacion
/// Date Modified: June 27th 2024.
/// </summary>
/// 

// Variables
const int MAX_SIZE = 10;
int[] bars = new int[MAX_SIZE];
int numberOfBars = 0;

string userInput = "";
string programOutput = "";

void ValidateInput(string initalPrompt, string errorPrompt, int minValue, int maxValue, ref int output)
{
    do
    {
        try
        {
            Console.Write(initalPrompt);
            userInput = Console.ReadLine();
            output = int.Parse(userInput);
        }
        catch (Exception ex)
        {
            output = minValue - 1;
        }
        if (output < minValue || output > maxValue)
        {
            Console.WriteLine(errorPrompt);
        }
    } while (output < minValue || output > maxValue);
}

void DisplayBars()
{
    Console.WriteLine("0                                                 50");
    Console.WriteLine("|---------|---------|---------|---------|---------|");
    for (int currentBar = 0; currentBar < numberOfBars; currentBar++)
    {
        Console.Write("|");
        for (int currentStar = 0; currentStar < bars[currentBar]; currentStar++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

// Show program title
// Prompt "Enter the number of bars (1-10): "  bars
// Validate and ask again as required
// Prompt "Enter the size the {bars} bar: " bars[i]
// Validate and ask again as required
// Display Graph.

Console.WriteLine("\t\t======Bar1======");
Console.WriteLine();

// get bar number
ValidateInput("Enter the number of bars (1-10): ", "Error: Please enter a number between 1 and 10.", 1, 10, ref numberOfBars);

// get bars sizes
for (int currentBar = 0; currentBar < numberOfBars; currentBar++)
{
    ValidateInput($"Enter the size of bar {currentBar+1} (0-50): ", "Error: Please enter a number between 0 and 50.", 0, 50, ref bars[currentBar]);
}

//display bars
DisplayBars();

