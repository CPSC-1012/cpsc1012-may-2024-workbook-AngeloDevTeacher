// See https://aka.ms/new-console-template for more information

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


// Start of Program
Console.WriteLine("////////////////");
Console.WriteLine("Calendar display");
Console.WriteLine("////////////////");

// EXAMPLE SECTION

// xoxox
// oxoxo ooooo
// xoxox
// oxoxo
// xoxox

/// <summary>
/// Make a grid of alternating "x"'s and "o"'s
/// 
/// Name: Angelo Encarnacion
/// Date: June 13th 2024
/// </summary>


int width;
int height;
string line = "";

Console.Write("Enter a width: ");
width = int.Parse(Console.ReadLine());

Console.Write("Enter a height: ");
height = int.Parse(Console.ReadLine());

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