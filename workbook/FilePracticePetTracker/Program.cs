// See https://aka.ms/new-console-template for more information


/// <summary>
/// Track details about pets - save information or load it to be displayed.
/// Author: Angelo Encarnacion
/// Date Modified: July 16th 2024
/// </summary>
/// 


// 1. Menu method
// 2. Prompt method
// 3. Save method
// 4. load method
//

const int PETS_MAX_COUNT = 10;
string userChoice = "";

string fileName = "";
StreamReader reader = null;
StreamWriter writer = null;


/// <summary>
/// Prompts the user with a message, returning their input.
/// </summary>
string Prompt(string messageToUser)
{
    string Output = "";
    Console.Write(messageToUser + "\t");
    Output = Console.ReadLine();

    return Output;
}

void DisplayMenu()
{
    Console.WriteLine("[1] - Create a new pet ");
    Console.WriteLine("[2] - View a pet ");
    Console.WriteLine("[3] - Edit an existing pet ");
    Console.WriteLine("[0] - Exit ");
}


do
{
    fileName = Prompt("Enter a file name");
} while (fileName == "");


do
{
    DisplayMenu();
    userChoice = Prompt("Please select 1, 2, 3");
    // Menu start
    switch (userChoice)
    {
        // Create pet
        case "1":
            string PetName;
            string PetFavNumber;

            try
            {
                writer = new StreamWriter(fileName, true);
                if (writer != null)
                {
                    PetName = Prompt("Enter a pet name");
                    PetFavNumber = Prompt("Enter a pet's favourite number");

                    writer.WriteLine($"{PetName},{PetFavNumber}");
                    writer.Close();
                    writer = null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong. Stream writer error {e.Message} ");
            }
            
            break;
        // View pet
        case "2":
            break;
        // Edit Pet
        case "3":
            break;
        default:
            break;
    }
} while (userChoice != "0");


