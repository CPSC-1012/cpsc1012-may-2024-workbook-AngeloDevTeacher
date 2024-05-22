// See https://aka.ms/new-console-template for more information
// First, list our "ingredinets" - the variables:
int numberOfStudentsAngeloHasConfused = 0;

Console.WriteLine("How many students has Angelo confused today?");

numberOfStudentsAngeloHasConfused = int.Parse(Console.ReadLine()) + 10;

Console.WriteLine("Angelo has confused " +  numberOfStudentsAngeloHasConfused + " students.");
