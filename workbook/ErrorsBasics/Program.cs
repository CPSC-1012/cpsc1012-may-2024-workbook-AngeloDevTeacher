// See https://aka.ms/new-console-template for more information

// Start by making a simple method for example!
// This prompt requires no error handling, as the Console.ReadLine() is added to an empty string
// This means we will return a string no matter what.
using System.Xml;

static string BasicPrompt(string st)
{
    string output = "";
    Console.Write(st);
    output += Console.ReadLine();
    return output;
}

static int ErrorHandledPrompt(string st)
{
    int output;
	try
	{
        Console.Write(st);
        output = int.Parse(Console.ReadLine());
    }
	catch (Exception ex)
	{
        Console.WriteLine("Please enter a");

        output = -1;
		//throw;
	}
    return output;
}

int exampleValue;
exampleValue = ErrorHandledPrompt("Enter a number: ");
Console.WriteLine(exampleValue);