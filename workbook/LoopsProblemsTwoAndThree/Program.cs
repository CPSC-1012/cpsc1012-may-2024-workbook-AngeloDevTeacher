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
