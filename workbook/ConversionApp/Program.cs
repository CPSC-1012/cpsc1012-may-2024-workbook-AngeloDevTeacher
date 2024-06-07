// See https://aka.ms/new-console-template for more information

/// <summary>
/// Create a program that will convert and display units of measurement, by prompting the user for the desired conversion and their provided value to convert.
/// Author: Angelo Encarnacion
/// Date: June 6 2024
/// </summary>

const decimal POUNDS_TO_KG = 1 / 2.2046m;
const decimal OUNCE_TO_LITER = 1 / 33.8140226m;
const decimal INCHES_TO_CM = 1 / 0.39370m;
//const decimal 

int userInput = 0;
decimal inputValue;
decimal outputValue;

Console.WriteLine("\t==================");
Console.WriteLine("\t= Unit Converter =");
Console.WriteLine("\t==================");

Console.WriteLine("\nMenu of Conversions: ");
Console.WriteLine("[1] - Pounds to Kilograms");
Console.WriteLine("[2] - Fluid Ounces to Liters");
Console.WriteLine("[3] - Inches to centimeters");
Console.WriteLine("[4] - Fahrenheit to Celsius");

Console.Write("\n\t Please enter a selection: ");
userInput =  int.Parse(Console.ReadLine());

switch (userInput)
{
	case 1:
        Console.WriteLine("\n= Pounds to Kilograms =\n");

        Console.Write("Please enter lbs to convert: ");
        inputValue = decimal.Parse(Console.ReadLine());

        outputValue = inputValue * POUNDS_TO_KG;
        Console.WriteLine($"\n{inputValue} lbs is {outputValue} kg.");
		break;
    case 2:
        Console.WriteLine("= Fluid Ounces to Liters =");

        break;
    case 3:
        Console.WriteLine("= Inches to centimeters =");

        break;
    case 4:
        Console.WriteLine("= Fahrenheit to Celsius =");

        break;
    default:
        Console.WriteLine($"{userInput} was not a valid choice.");
		break;
}
Console.WriteLine("\nEnd program.");