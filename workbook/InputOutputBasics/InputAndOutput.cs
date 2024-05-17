// See https://aka.ms/new-console-template for more information

string myFirstName = "Angelo";
string myLastName = "Encarnacion";

string inputtedName = String.Empty;
int inputtedNumber;

// We are concatinating - "Adding strings together". This has no space.
// Console.WriteLine(myFirstName + myLastName);

// I can concatinate a space in between - an space is a valid string.
// Console.WriteLine(myFirstName + " " + myLastName);


// This is a faster method! String interpolation!
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
// Console.WriteLine($"{myFirstName} {myLastName}");

// NOTE: When we generate lots of strings, we will be using a string formatter.


// READING INPUT:
// Console.ReadLine() is our basic function to reading a input.
Console.WriteLine("Please enter your name: ");
inputtedName = Console.ReadLine();

Console.WriteLine($"Hello {inputtedName}, it's nice to meet you!");

// READING INPUT PART 2:
// We will want to convert the string into a number if we're given a number and need to use it as such. We can "parse" it as a data type an try to see if it works!
Console.WriteLine("Please enter a whole number. I will add 21 to it.");
inputtedNumber = int.Parse(Console.ReadLine());

Console.WriteLine(inputtedNumber + 21);

