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

        Console.WriteLine("\nHow do you want to convert: ");
        Console.WriteLine("[1] - lbs to kg");
        Console.WriteLine("[2] - kg to lbs");

        Console.Write("Please enter 1 or 2: ");
        userInput = int.Parse(Console.ReadLine());

        // Try not to nest switches, but here is an example of a nested switch.
        switch (userInput)
        {
            case 1:
                Console.Write("Please enter lbs to convert: ");
                inputValue = decimal.Parse(Console.ReadLine());

                outputValue = inputValue * POUNDS_TO_KG;
                Console.WriteLine($"\n{inputValue} lbs is {outputValue} kg.");
                break;
            case 2:
                Console.Write("Please enter kg to convert: ");
                inputValue = decimal.Parse(Console.ReadLine());

                outputValue = inputValue / POUNDS_TO_KG;
                Console.WriteLine($"\n{inputValue} kg is {outputValue} lbs.");
                break;

            default:
                Console.WriteLine($"{userInput} was not a valid choice.");
                break;
        }
		break; // END OF case 1
    case 2:
        Console.WriteLine("\n= Fluid Ounces to Liters =\n");

        Console.WriteLine("How do you want to convert: ");
        Console.WriteLine("[1] - oz to L");
        Console.WriteLine("[2] - L to oz");

        Console.Write("Please enter 1 or 2: ");
        userInput = int.Parse(Console.ReadLine());
        // I prefer the IF statement in most cases for small menus nested in switches.
        if (userInput == 1)
        {
            Console.Write("Please enter oz to convert: ");
            inputValue = decimal.Parse(Console.ReadLine());

            outputValue = inputValue * OUNCE_TO_LITER;
            Console.WriteLine($"\n{inputValue} oz is {outputValue} L.");
        }
        else if (userInput == 2)
        {
            Console.Write("Please enter L to convert: ");
            inputValue = decimal.Parse(Console.ReadLine());

            outputValue = inputValue / OUNCE_TO_LITER;
            Console.WriteLine($"\n{inputValue} L is {outputValue} oz.");
        }
        else
        {
            Console.WriteLine($"{userInput} was not a valid choice.");
        }

        break; // END OF case 2

    case 3:
        Console.WriteLine("= Inches to centimeters =");

        break;
    case 4:
        Console.WriteLine("\n= Fahrenheit to Celsius =\n");

        Console.Write("Please enter temp in F to convert: ");
        inputValue = decimal.Parse(Console.ReadLine());

        outputValue = (inputValue - 32) / 1.800m;   
        Console.WriteLine($"\n{inputValue} in F is {outputValue} in C.");

        break;
    default:
        Console.WriteLine($"{userInput} was not a valid choice.");
		break;
}
Console.WriteLine("\nEnd program.");