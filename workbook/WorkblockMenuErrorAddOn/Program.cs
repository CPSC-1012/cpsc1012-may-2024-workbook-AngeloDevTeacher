// See https://aka.ms/new-console-template for more information

// This is an example of a "" check ADDED to a menu.
// For Jane - July 4

string userInput = "";
int userChoice = 0;

try
{
    Console.Write("Please select 1, 2, or 3: ");
    userInput = Console.ReadLine();
    userChoice = int.Parse(userInput);
}
catch(Exception ex)
{
    Console.WriteLine($"Please enter in 1, 2, or 3, you entered in \"{userInput}\"");
}


int IntValidatedPrompt(string prompt, string errorResponse)
{
    int output = -1;
    string UserInput = "";
    do
    {
        try
        {
            Console.Write(prompt);
            UserInput =  Console.ReadLine();
            output = int.Parse(UserInput);
        }
        catch (Exception ex)
        {
            Console.WriteLine(errorResponse);
        }
    } while (output < 0);
    return output;
}