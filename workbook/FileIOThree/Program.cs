/// <summary>
/// Save a user's first name, last name, and id number in csv format. Create the file where the user has inputted.
/// Author: Angelo Encarnacion
/// Last Modified: July 18th 2024
/// </summary>


string fileName = "";
StreamWriter writer = null;

string firstName = "";
string lastName = "";
string id;

string Prompt(string message)
{
    string Output;
    Console.Write(message+"\t");
    Output = Console.ReadLine();
    return Output;
}


// STEP 1 - Grab the file path and create the writer:
try
{
    Console.Write("Please enter a file path:\t");
    fileName =  Console.ReadLine().Split(".")[0];
    writer = new StreamWriter(fileName + ".csv");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

// STEP 2 - Ask user for data, then write data to file
firstName = Prompt("What is your first name?");
lastName = Prompt("What is your last name?");
id = Prompt("What is your id?");

writer.WriteLine($"{firstName},{lastName},{id}");


// STEP 3 - Close the writer!
writer.Close();