// See https://aka.ms/new-console-template for more information

/// <summary>
/// The purpose of the program is to calculate a tip based on total cost and tip percentage.
/// Author: Angelo Encarnacion
/// Date: May 23rd, 2024
/// </summary>


// I'm going to have the percentage as a decimal, but I will do math on it when I prompt for the input.

// Declare the percentage as a decimal.
decimal TipPercentage;

// Declare a total amount as a decimal.
decimal TotalAmount;

// Output a program description.
Console.WriteLine("I can calculate your tip.");

// Prompt user to enter the total amount.
Console.Write("Please enter your total amount:\t");
TotalAmount = decimal.Parse(Console.ReadLine());

// Prompt user to enter in tip percentage.
Console.Write("Please enter your desired tip percentage:\t");
TipPercentage = decimal.Parse(Console.ReadLine());

Console.WriteLine($"Your {TipPercentage}% tip for the ${TotalAmount} is ${TotalAmount * (TipPercentage / 100m):#,#.00}");
