// See https://aka.ms/new-console-template for more information


// Always declare your array size (it'll always be a const.)
const int ARRAY_SIZE = 4;
// The default initialization.
string[] suits = new string[ARRAY_SIZE];
// Assigning values to each item of the array
suits[0] = "Diamonds";
suits[1] = "Hearts";
suits[2] = "Clubs";
suits[3] = "Spades";

// I can declare an array and load data into in manually.
string[] cardSuits = new string[ARRAY_SIZE]
{
    "Diamonds", "Hearts", "Clubs", "Spades"
};

// Basic usage of the array.
for (int i = 0; i < suits.Length; i++)
{
    Console.WriteLine(suits[i]);
}

// Getting the length of the array.
Console.WriteLine(cardSuits.Length);

// Get a specific item from the array:
Console.WriteLine(cardSuits[3]);

// Assign a value to a list, even if it already has data (overwrite)!
// cardSuits[3] = "Spades haha";

// Some methods from the array class.
Array.Sort(cardSuits);
Array.Reverse(cardSuits);
for (int i = 0; i < cardSuits.Length; i++)
{
    Console.WriteLine(cardSuits[i]);
}


// Creating a 2D array
const int DAYS_IN_WEEK = 7;
const int WEEKS_PRINTED = 5;
string[,] calendar = new string[DAYS_IN_WEEK, WEEKS_PRINTED];