// See https://aka.ms/new-console-template for more information


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