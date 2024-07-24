

// Variables

using System.Security;

/// <summary>
/// Program purpose - What does this do?
/// Name: Angelo Encarnacion
/// Date Modified: July 23rd 2024
/// </summary>
const int MAX_SIZE = 15;
string exampleString = "";
bool isItTrue = false;
decimal exampleNum = 0m;

// Data

// These are parallel arrays.
string[] names  = new string[MAX_SIZE];
double[] grades = new double[MAX_SIZE];
int[] id        = new int[MAX_SIZE];

static string Prompt(string messagePrompt)
{
    string Output = "";
    Console.Write(messagePrompt+"\t");
    Output = Console.ReadLine();
    return Output;
}

/// <summary>
///  Displays the prompt string and returns user-entered bool. Will loop until a valid value is given.
/// </summary>
static bool PromptBool(string messagePrompt)
{
    bool Output = false;
    bool validInput = false;
    do
    {
        try
        {
            Console.Write(messagePrompt + "\t");
            Output = bool.Parse(Console.ReadLine());
            validInput = true;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: you did not enter true or false {e.Message}");
        }
    } while (!validInput);
    return Output;
}
/// <summary>
///  Displays the prompt string and returns user-entered decimal. Will loop until a valid value is given.
/// </summary>
static decimal DecimalPrompt(string messagePrompt)
{
    decimal Output = 0m;
    bool isValidOutput = false;
    do
    {
        Console.Write(messagePrompt + "\t");
        if (!isValidOutput && decimal.TryParse(Console.ReadLine(), out Output))
        {
            isValidOutput = true;
        }
        else
        {
            Console.WriteLine($"Error: you did not enter a valid decimal.");
        }
    } while (!isValidOutput);

    return Output;
}

isItTrue = PromptBool("Enter true or false");

Console.WriteLine(isItTrue);

exampleNum = DecimalPrompt("Enter a decimal number: ");
Console.WriteLine(exampleNum);