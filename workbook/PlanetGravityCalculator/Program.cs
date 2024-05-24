// See https://aka.ms/new-console-template for more information

/// <summary>
/// This program will display the distance an object to fall on different planets in a period of time.
/// Author: Angelo Encarnacion
/// Date: May 23rd, 2024
/// </summary> 

// We're going to make a lot of const data.

const decimal EARTH_GRAVITY_CONSTANT = -9.81m;
const decimal MOON_GRAVITY_CONSTANT = -1.62m;
const decimal MARS_GRAVITY_CONSTANT = -3.71m;

decimal InputtedItemMass;
decimal InputtedTime;

// Display to the user the program intro:
Console.WriteLine("\t\t===========");
Console.WriteLine("\t\tGravity Sim");
Console.WriteLine("\t\t===========");

// Prompt the user to enter the mass of an object:
Console.Write("Enter the mass of the object:\t");
InputtedItemMass = decimal.Parse(Console.ReadLine());

// Prompt the user to enter the distance:
Console.Write("Enter the time the object will travel:\t");
InputtedTime = decimal.Parse(Console.ReadLine());

// Display each of the results:

// We're being a bit goofy and having the string values be in the format pattern.
// The lesson here is the formatting itself - play around with it!
Console.WriteLine($"{"Earth",-6}[{EARTH_GRAVITY_CONSTANT,-5} m/s^2]{-4.905,8:#.#00}");
Console.WriteLine($"{"Moon", -6}[{MOON_GRAVITY_CONSTANT,-5} m/s^2]{-0.810,8:#.#00}");
Console.WriteLine($"{"Mars", -6}[{MARS_GRAVITY_CONSTANT,-5} m/s^2]{-1.855,8:#.#00}");


// formula is (1/2) * acceleration * time squared
// We will be casting our numbers to be able to square.
/*
Console.WriteLine($"Earth[{EARTH_GRAVITY_CONSTANT}]: {0.5m * EARTH_GRAVITY_CONSTANT * (decimal)Math.Pow((double)InputtedTime,2)}");
Console.WriteLine($"Moon[{MOON_GRAVITY_CONSTANT}]: {0.5m * MOON_GRAVITY_CONSTANT * (decimal)Math.Pow((double)InputtedTime, 2)}");
Console.WriteLine($"Mars[{MARS_GRAVITY_CONSTANT}]: {0.5m * MARS_GRAVITY_CONSTANT * (decimal)Math.Pow((double)InputtedTime, 2)}");
*/