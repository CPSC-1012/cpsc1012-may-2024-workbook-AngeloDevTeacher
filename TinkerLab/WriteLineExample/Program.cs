// See https://aka.ms/new-console-template for more information


string firstName;
string lastName;
string id;

string fileName;

StreamWriter writer = null;

Console.WriteLine("CSV example\n\n");
Console.Write("Enter the filename to save:\t");
fileName = Console.ReadLine();

try
{
	writer = new StreamWriter(fileName, true);
}
catch (Exception e)
{

	Console.WriteLine($"Something went wrong: {e.Message}");
}
if (writer != null)
{
	Console.Write("Enter the First Name\t");
	firstName = Console.ReadLine();

    Console.Write("Enter the Last Name\t");
    lastName = Console.ReadLine();

    Console.Write("Enter the ID\t");
    id = Console.ReadLine();

    writer.WriteLine($"{lastName}, {firstName}, {id}");

    writer.Close();

}
