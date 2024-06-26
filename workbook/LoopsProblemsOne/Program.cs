﻿// See https://aka.ms/new-console-template for more information


/// <summary>
/// Output to the user the sum of squares from 1 to the inputted number.
/// 
/// Name: Angeloe Encarnacion
/// Date: June 11 2024
/// </summary>

// User input variable - Following instructions for naming.
int MySquare;
int Sum = 0;

// Program Start
Console.WriteLine("///////////////");
Console.WriteLine("Square addition");
Console.WriteLine("///////////////");

// Prompt the user.
Console.WriteLine("I will add up the squares from 1 to your number.");
Console.Write("\tPlease enter an integer: ");
MySquare = int.Parse(Console.ReadLine());

// Do the math:
for (int i = 1; i <= MySquare; i++)
{
    Sum += (i * i);
}
// Output to the user - solve the problem
Console.WriteLine($"\nThe sum is {Sum}");

/// <summary>
/// Give the average of positive intergers inputted by the user. Stop the prompt when the user inputs 0.
/// 
/// Name: Angelo Encarnacion
/// Date: June 13th 2024
/// </summary>

// Numbers to calculate average.
decimal ageSum = 0;
int numberCount = 0;

// User input variable.
int userInput = 0;


// Start of program logic
Console.WriteLine("////////////////");
Console.WriteLine("Average Age Calc");
Console.WriteLine("////////////////");
do
{

    try
    {
        Console.Write("Enter an age (a positive whole number): ");
        userInput = int.Parse(Console.ReadLine());
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        userInput = -1;
    }
    if (userInput < 0)
    {
        Console.WriteLine("Number was not a positive integer.");
        Console.WriteLine("Please enter a positive number.");
    } // end if
    else if (userInput == 0)
    {
        Console.WriteLine("Ending input.");
    }
    else
    {
        ageSum += userInput;
        numberCount++;
    } // end else
} while (userInput != 0);
try
{
    Console.WriteLine($"The average of the {numberCount} numbers was {ageSum / (numberCount)}.");
}
catch (Exception e)
{
    // The ONLY error i would expect right here is a divide by zero BECAUSE of my defensive programming above.
    Console.WriteLine("There were no positive integers provided, so no average could be calcualted.");
}



/// <summary>
/// Print out the input backwards.
/// 
/// Name: Angelo Encarnacion
/// Date: June 11 2024
/// </summary>

// Variable - following problem naming convention:
string N = "";

// Program Start
Console.WriteLine("///////////////");
Console.WriteLine("Reverse Digits ");
Console.WriteLine("///////////////");

// Prompt the user.
Console.WriteLine("I will reverse the digits you provide to me.");
Console.Write("\tPlease enter an integer: ");
N = Console.ReadLine();

// Do our steps:
for (int i = N.Length - 1; i >= 0; i--)
{
    Console.WriteLine( N[i] );
}
//Test