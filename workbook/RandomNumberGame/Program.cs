// See https://aka.ms/new-console-template for more information


/// <summary>
/// The purpose of this program is to have a user type in a number, and have the computer
/// provide a random number, for the user to compare against themself.
/// 
/// Author: Angelo Encarnacion 
/// Date: May 28th, 2024
/// </summary>


// Our Plan:

// DECLARE a new instance of the random class
//    -  Note: the random class is NOT expected for you to know right now, and instead, we'll visit this again later!
// DECLARE RandomNumber As Integer
// DECLARE UserNumber As Interger

// DISPLAY "---Random Number Maker---"
// PROMPT "Enter a number between 1 and 10 for you to compare against: " UserNumber
// DISPLAY "The number was " RandomNumber " - did you get it right?"

// Note from Angelo: Don't worry about this section, or the comments on the side!
Random randomInstance = new Random(); // <- Don't worry about what this means!
int randomNumber;
int userNumber;

randomNumber = randomInstance.Next(1,10); // <- Same here
Console.WriteLine("---Random Number Maker---");
Console.Write("Enter a number between 1 and 10 for you to compare against: ");
userNumber = int.Parse(Console.ReadLine()); // <- currently does nothing, but we're gonna do something next after assignment 1.
Console.WriteLine($"The number was {randomNumber} - did you get it right?");
