// See https://aka.ms/new-console-template for more information


/// <summary>
/// Learning that a string is a COLLECTION of characters!
/// </summary>
///                 6 +   6 +    11 + 2 spaces
string yourName = "Angelo Joseph Encarnacion";

Console.WriteLine($"The length of my {yourName} is: {yourName.Length}");
Console.WriteLine($"{yourName} in uppercase is {yourName.ToUpper()}");
Console.WriteLine($"This is {yourName} after calling ToUpper()");
Console.WriteLine($"The space in {yourName} is at {yourName.IndexOf(' ')}");
Console.WriteLine($"The space in {yourName} is at {yourName.LastIndexOf(' ')}");
Console.WriteLine($"The 'z' in {yourName} is at {yourName.IndexOf('⭐')}");
Console.WriteLine($"The \"Encarnacion\" in {yourName} is at {yourName.IndexOf("Encarnacion")}");

Console.WriteLine($"The first letter in {yourName} is: {yourName[0]}");
Console.WriteLine($"The last letter in {yourName} is: {yourName[yourName.Length-1]}");


Console.WriteLine($"The substring of {yourName} to the 10th character is: {yourName.Substring(0,10)}");
Console.WriteLine($"The first name in {yourName} is {yourName.Substring(0,yourName.IndexOf(' '))}");