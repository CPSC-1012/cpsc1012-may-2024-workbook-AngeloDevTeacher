// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

const int MAX_SIZE = 15;

int[] ids = new int[MAX_SIZE];
int[] phoneNumbers = new int[MAX_SIZE];
string[] names = new string[MAX_SIZE];


string userInput = "";
bool isRunning = true;

Console.WriteLine("Choose an Option: ");
Console.WriteLine("[I] - ID");
Console.WriteLine("[P] - Phone Numbers");
Console.WriteLine("[N] - First Name");


do
{
	try
	{
		Console.Write("Please enter a choice: ");
		userInput = Console.ReadLine();
		userInput = userInput.ToUpper();
	}
	catch (Exception ex)
	{
		Console.WriteLine("Please choose \"I\", \"P\", \"N\" ");
	}
	if (userInput != "I" && userInput != "P" && userInput != "N")
	{
		Console.WriteLine("Please choose \"I\", \"P\", \"N\" ");
	}
} while (userInput != "I" && userInput != "P" && userInput != "N");


switch (userInput)
{
	case "I":
        Console.Write("Please enter an ID: ");
		ids[0] = int.Parse(Console.ReadLine());
        break;
	case "P":
        Console.Write("Please enter an phone number: ");
        phoneNumbers[0] = int.Parse(Console.ReadLine());
        break;
	case "N":
        Console.Write("Please enter an name: ");
        names[0] = Console.ReadLine();
        break;
	default:
		break;
}
Console.WriteLine($"{ids[0]},{phoneNumbers[0]},{names[0]}");