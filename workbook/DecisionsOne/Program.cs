﻿// See https://aka.ms/new-console-template for more information


int userChoice;
bool gameWon = false;
bool playAgain = false;

Random randomInstance = new Random();
int coinFlip = 0;


Console.Write("\t\t=============\n");
Console.Write("\t\t  Decisions  \n");
Console.Write("\t\t=============\n");



// In the future, we will replace the if-else with something else.
Console.WriteLine("Please select an option: ");
Console.WriteLine("[1] - Coin Flip Guesser ");
Console.WriteLine("[2] - Die Guesser ");

Console.Write("Enter the number of the menu item: ");
userChoice = int.Parse(Console.ReadLine());


switch (userChoice)
{
    case 1:
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
        break;

        case 2:
        do
        {
            int dieRoll = randomInstance.Next(1, 6);
            gameWon = false;

            Console.Clear();
            Console.Write("\t\t=============\n");
            Console.Write("\t\t  Dice Guess \n");
            Console.Write("\t\t=============\n");
            // Game Loop
            while (gameWon != true)
            {
                Console.Write("Choose a die face from 1 to 6: ");
                userChoice = int.Parse(Console.ReadLine());

                if (userChoice < 1 || userChoice > 6)
                {
                    Console.WriteLine("You inputted an invalid option.");
                }
                else
                {
                    if (userChoice == dieRoll)
                    {
                        Console.WriteLine("You guessed it right!");
                        gameWon = true;
                    }
                    else if (userChoice < dieRoll)
                    {
                        Console.WriteLine("You guessed too small!");
                    }
                    else if (userChoice > dieRoll)
                    {
                        Console.WriteLine("You guessed too big!");
                    }
                }
            } // END OF Game Loop
            Console.Write("Do you want to play again?\n\t[1] - Yes\n\t[2] - No\n\tPlease select (1 or 2): ");
            userChoice = int.Parse(Console.ReadLine());
            if (userChoice == 1)
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }
        } while (playAgain == true);
        break;

    default:
        Console.WriteLine($"{userChoice} was not a valid choice.");
        break;
}
