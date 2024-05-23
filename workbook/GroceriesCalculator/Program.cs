// See https://aka.ms/new-console-template for more information

/// <summary>
/// The purpose of this program is to calculate the amount of money a roommate will pay given the cost of the item categories divided among 4 roommates.
///  Author: Angelo Encarnacion
/// Date: May 21st, 2024
/// </summary>


// These are our variables, we are using camelCase right now.
float ProduceCosts;
float BreadCosts;
float DairyCosts;
float OtherCosts;

const int NUMBER_OF_ROOMMATES = 4;

// Describe what the program does
// Writeline makes a new line
Console.WriteLine("This calculator will display the breakdown of how much each roommate will pay.");


// Use Console.Write to stay on the same line for the readline prompt.
// Prompt the user to enter produce cost
Console.Write("Please enter the produce costs:\t");
// Set the cost to the produceCost variable.
ProduceCosts = float.Parse(Console.ReadLine());

// Prompt the user to enter bread cost
Console.Write("Please enter the bread costs:\t");
// Set the cost to the breadCost variable.
BreadCosts = float.Parse(Console.ReadLine());

// Prompt the user to enter the cost of dairy
Console.Write("Please enter the dairy cost:\t");
// Set the cost of the dairyCost variable.
DairyCosts = float.Parse(Console.ReadLine());

// Prompt the user to enter the cost of other items
Console.Write("Please enter the other item costs:\t");
// Set the cost of the otherCosts variable.
OtherCosts = float.Parse(Console.ReadLine());

Console.WriteLine($"Produce: {ProduceCosts / NUMBER_OF_ROOMMATES,20:$#,#.00}");
Console.WriteLine($"Bread: {BreadCosts / NUMBER_OF_ROOMMATES,20:$#,#.00}");
Console.WriteLine($"Dairy: {DairyCosts / NUMBER_OF_ROOMMATES,20:$#,#.00}");
Console.WriteLine($"Other: {OtherCosts / NUMBER_OF_ROOMMATES,20:$#,#.00}");

Console.WriteLine($"Total cost for a roommate: {(ProduceCosts + BreadCosts + DairyCosts + OtherCosts) / NUMBER_OF_ROOMMATES:$#,#.00}");