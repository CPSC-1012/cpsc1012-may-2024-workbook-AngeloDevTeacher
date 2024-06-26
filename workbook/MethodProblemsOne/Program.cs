// See https://aka.ms/new-console-template for more information



// User facing variables
using System.Diagnostics.CodeAnalysis;

/// <summary>
/// Purpose: Calculate the cost of admission for a group of people attending a show.
/// Author: Angelo Encarnacion
/// Date Modified: June 25th 2024
/// </summary>
/// <plan>
/// 
/// Display Menu
/// Prompt using GetTicketPrice
/// Output/Display total cost
/// 
/// </plan>
string userInput;
int userSelection;
string output;

const decimal CHILDREN_PRICING = 0.00m;
const decimal STUDENT_PRICING = 9.80m;
const decimal ADULT_PRICING = 11.35m;
const decimal SENIOR_PRICING = 10.00m;

decimal GetTicketPrice(int age)
{
    decimal PriceOutput = 0m;
    if (age > 0 && age <= 6)
    {
        PriceOutput = CHILDREN_PRICING;
    }
    else if (age > 6 && age <= 17)
    {
        PriceOutput = STUDENT_PRICING;
    }
    else if (age >= 18 && age <= 54)
    {
        PriceOutput = ADULT_PRICING;
    }
    else if (age >= 55)
    {
        PriceOutput = SENIOR_PRICING;
    }

    return PriceOutput;
}

// Program name display
void ProgramNameDisplay()
{
    Console.Clear();
    Console.WriteLine("\t\t==============");
    Console.WriteLine("\t\t TICKET BOOTH ");
    Console.WriteLine("\t\t==============");
    Console.WriteLine();
}


int ProgramMenu()
{
    Console.WriteLine("Please choose an option from the following:");
    Console.WriteLine("\t[1] - Display the ticket prices");
    Console.WriteLine("\t[2] - Buy 1 ticket");
    Console.WriteLine("\t[3] - Buy multiple tickets");
    Console.WriteLine("\t[4] - Quit Program");

    Console.Write("Please Select using 1, 2, 3, or 4:");
    userInput = Console.ReadLine();

    return int.Parse(userInput);
}

void DisplayTicketPrice(string priceTitle, decimal price)
{
    Console.WriteLine($"{priceTitle} Price: ${price:#,#.00}");
}


void TicketMainProgram()
{
    ProgramNameDisplay();

    userSelection = ProgramMenu();

    switch (userSelection)
    {
        case 1:
            break;
        case 2:
            Console.Write("Enter an age: ");
            userInput = Console.ReadLine();

            Console.WriteLine($"The ticket price is: {GetTicketPrice(int.Parse(userInput))}" );
            break;
        case 3:
            break;
        case 4:
            break;
        default:
            break;
    }
}

TicketMainProgram();

