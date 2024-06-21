// See https://aka.ms/new-console-template for more information

// This is an exmaple of a list that was declared and initalized with values.
string[] rainbowColours = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };
string[] exampleStringArray = new string[10];
exampleStringArray[0] = "Hello";

// Get green from the array.
Console.WriteLine(rainbowColours[3]);

// Do a method for the data type of the value of the array.
Console.WriteLine(rainbowColours[5].ToUpper());

// Comment out line 6 for testing.
Console.WriteLine(exampleStringArray[0] == null);

string pigLatinMessage = ""; // ROYGBIV
for (int i = 0; i < rainbowColours.Length; i++)
{
    pigLatinMessage += rainbowColours[i].Substring(1, rainbowColours[i].Length - 1);
    pigLatinMessage += rainbowColours[i][0];
    pigLatinMessage += "ay ";
}
Console.WriteLine(pigLatinMessage);