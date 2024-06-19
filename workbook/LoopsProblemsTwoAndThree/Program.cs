// See https://aka.ms/new-console-template for more information


// Variables
using static System.Runtime.InteropServices.JavaScript.JSType;

/// <summary>
/// Create a program that displays a standard calendar with the amount of days and the start day of week provided by the user.
/// 
/// Name: Angelo Encarnacion
/// Date: June 23th 2024
/// </summary>

// Variables
int daysInMonth;
int currentDate = 1;

string startDayOfWeek;
int offset;

string weekDisplay;


// Start of Program
Console.WriteLine("////////////////");
Console.WriteLine("Calendar display");
Console.WriteLine("////////////////");

Console.Write("Enter number of days in the month: ");
daysInMonth = int.Parse(Console.ReadLine());

Console.Write("Enter the starting day of the month: ");
startDayOfWeek = Console.ReadLine();

switch (startDayOfWeek)
{
    case "Sun":
        offset = 0;
        break;
    case "Mon":
        offset = 1;
        break;
    case "Tue":
        offset = 2;
        break;
    case "Wed":
        offset = 3;
        break;
    case "Thu":
        offset = 4;
        break;
    case "Fri":
        offset = 5;
        break;
    case "Sat":
        offset = 6;
        break;
    default:
        offset = 0;
        break;
}
// Angelo will make a video on how to do this another way during week 9 + 10
Console.WriteLine("Sun   Mon   Tue   Wed   Thu   Fri   Sat");
for (int week = 0; week < 6; week++)
{
    weekDisplay = "";
    for (int date = 1; date <= 7 && date + (week * 7) <= daysInMonth + offset; date++)
    {
        if (date + (week * 7) <= offset)
        {
            weekDisplay = weekDisplay + $"      ";
        }
        else
        {
            weekDisplay = weekDisplay + $" {(date - offset) + (week * 7),-5}";
        }
    }
    Console.WriteLine(weekDisplay);
}


/// <summary>
/// Make a grid of alternating "x"'s and "o"'s
/// 
/// Name: Angelo Encarnacion
/// Date: June 13th 2024
/// </summary>


int width = 0;
int height = 0;
string line = "";

do
{
    try
    {
        Console.Write("Enter a width: ");
        width = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Please enter a positive interger.");
    }
    try
    {
        Console.Write("Enter a height: ");
        height = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Please enter a positive interger.");
    }

} while (width < 1 && height < 1);


for (int i = 0; i < height; i++)
{
    line = "";
    for (int j = 0; j < width; j++)
    {
        if (i % 2 == j % 2)
        {
            line = line + "x";
        }
        else
        {
            line = line + "o";
        }
        
    }
    Console.WriteLine(line);
}


// XXXXXXX 7w,6h
// X     X
// X     X
// X     X
// X     X
// XXXXXXX

/// <summary>
/// Create an empty shape with a border based on provided width and height.
/// </summary>
/// 

int emptyWidth = 0;
int emptyHeight = 0;
string emptyLine = "";

Console.WriteLine("XXXXXXXXXXXXXXXX");
Console.WriteLine("  Empty  Shape  ");
Console.WriteLine("XXXXXXXXXXXXXXXX");


do
{
    try
    {
        Console.Write("Enter a width: ");
        emptyWidth = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Please enter a positive interger.");
    }
    try
    {
        Console.Write("Enter a height: ");
        emptyHeight = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Please enter a positive interger.");
    }

} while (emptyWidth < 1 && emptyHeight < 1);

emptyLine = "";
for (int y = 0; y < emptyHeight; y++)
{
    emptyLine = "";
    for (int x = 0; x < emptyWidth; x++)
    {
        if (x == 0 || y == 0 || x == emptyWidth - 1 || y == emptyHeight - 1)
        {
            emptyLine += "X";
        }
        else
        {
            emptyLine += "s";
        }
    }
    Console.WriteLine(emptyLine);
}
