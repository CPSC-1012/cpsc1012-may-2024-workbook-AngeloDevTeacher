// See https://aka.ms/new-console-template for more information

Console.BackgroundColor = ConsoleColor.Black;
string[] rainbowColours = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };
string[] colorReference;

//int myNumber = 0;

//int randomNumber = 0;
//Random randomInstance = new Random();

//// Start 
//randomNumber = randomInstance.Next(1, 10);

//Console.WriteLine($"The random number is {randomNumber}");
//myNumber = randomNumber;
//Console.ReadLine();
//Console.WriteLine($"My number is {myNumber}");
//Console.ReadLine();

//randomNumber = randomInstance.Next(1, 10); //re-randomizing randomnumber
//Console.ReadLine();
//Console.WriteLine($"The random number is {randomNumber}");
//Console.WriteLine($"My number is {myNumber}");

// THIS DOES NOT MAKE ITS OWN NEW ARRAY
// THIS WILL REFERENCE THE RAINBOWCOLORS ARRAY
//colorReference = rainbowColours;

// DO THIS INSTEAD
colorReference = new string[rainbowColours.Length];
rainbowColours.CopyTo(colorReference,0);


Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.Yellow;
for( int i = 0; i < rainbowColours.Length; i++)
{
    Console.WriteLine(rainbowColours[i]);   
}
Console.BackgroundColor = ConsoleColor.Gray;
for ( int i = 0; i < colorReference.Length; i++)
{
    Console.WriteLine(colorReference[i]);
}
// Rainbow colors is now allcaps
for (int i = 0; i < rainbowColours.Length; i++)
{
    rainbowColours[i] = rainbowColours[i].ToUpper() + rainbowColours[i].ToUpper() + rainbowColours[i].ToUpper();
}

Console.BackgroundColor = ConsoleColor.Yellow;
for (int i = 0; i < rainbowColours.Length; i++)
{
    Console.WriteLine(rainbowColours[i]);
}
Console.BackgroundColor = ConsoleColor.Gray;
for (int i = 0; i < colorReference.Length; i++)
{
    Console.WriteLine(colorReference[i]);
}



Console.BackgroundColor = ConsoleColor.Black;