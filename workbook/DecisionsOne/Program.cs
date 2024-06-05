// See https://aka.ms/new-console-template for more information

int userChoice = 0;

Random randomInstance = new Random();
int coinFlip = 0;


Console.Write("\t\t=============\n");
Console.Write("\t\t  Decisions  \n");
Console.Write("\t\t=============\n");



// In the future, we will replace the if-else with something else.
Console.WriteLine("Please select an option: ");
Console.WriteLine("[1] - Coin Flip Guesser ");

Console.Write("Enter the number of the menu item: ");
userChoice = int.Parse(Console.ReadLine());


// Coin flip
if (userChoice == 1)
{
    Console.Clear();
    Console.Write("\t\t=============\n");
    Console.Write("\t\t  Coin Flip  \n");
    Console.Write("\t\t=============\n");
    coinFlip = randomInstance.Next(0, 1);
    // Prompt the user to choose 0 or 1
    Console.Write("Choose [0] for heads and [1] for tails: ");
    userChoice = int.Parse(Console.ReadLine());

    if (!(userChoice == 0 || userChoice == 1))
    {
        Console.WriteLine("You did NOT choose 0 or 1.");
    }
    else
    {
        if (userChoice == coinFlip)
        {
            Console.WriteLine("You guessed it right!");
        }
        else
        {
            Console.WriteLine("Sorry, you got it wrong!");
        }
    }


}