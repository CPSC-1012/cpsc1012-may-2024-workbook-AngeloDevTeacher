// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string userInput = "";
string fullName = "";

Console.WriteLine("Type in the pattern 1 thing at a time [A, 1, than your name]");

if (WasLetterAPressedPrompt() && WasNumber1PressedPrompt() && ValidFullName(ref fullName))
{
	Console.WriteLine("All inputs valid");
    Console.WriteLine(fullName);
}
else
{
    Console.WriteLine("Invalid input.");
}


static bool WasLetterAPressedPrompt()
{
    bool success = false;
	string UserInput = "";
	try
	{
		Console.Write("Enter the first item: ");
        UserInput = Console.ReadLine();
		if(UserInput == "A")
		{
			success = true;
		}
		else
		{
			success = false;
		}
	}
	catch (Exception ex)
	{
		Console.WriteLine("Invald input.");
		success = false;
	}

    return success;
}

static bool WasNumber1PressedPrompt()
{
    bool success = false;
    string UserInput = "";
    try
    {
        Console.Write("Enter the second item: ");
        UserInput = Console.ReadLine();
        if (UserInput == "1")
        {
            success = true;
        }
        else
        {
            success = false;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Invald input.");
        success = false;
    }

    return success;
}

static bool ValidFullName(ref string name)
{
    bool success = false;
    string UserInput = "";
    try
    {
        Console.Write("Enter a full name (with a space between first and last name): ");
        UserInput = Console.ReadLine();
        if (UserInput.Contains(" "))
        {
            name = UserInput;
            success = true;
        }
        else
        {
            success = false;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Invald input.");
        success = false;
    }

    return success;
}