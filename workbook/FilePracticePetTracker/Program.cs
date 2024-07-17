﻿// See https://aka.ms/new-console-template for more information


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
string[] loadedPetNames = new string[PETS_MAX_COUNT];
string[] loadedPetNumbers = new string[PETS_MAX_COUNT];

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

/// <summary>
/// Creates a new pet entry, with a name and number.
/// </summary>
void CreateNewPet()
{
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
}

/// <summary>
/// A naieve approach to displaying the content.
/// </summary>
void LoadExistingPets()
{
    int currentCount = 0;
    if (File.Exists(fileName))
    {
        reader = new StreamReader(fileName);
        while (reader != null && !reader.EndOfStream && currentCount < PETS_MAX_COUNT)
        {
            string record = reader.ReadLine();

            // LETS LOAD THEM INTO THE PROGRAM MEMORY PROPERLY!
            // HERE IS WHERE I PROCESS MY LINE!
            // I can split my string at the commas, saving it into an array of items.
            string[] items = record.Split(",");
            loadedPetNames[currentCount] = items[0];
            loadedPetNumbers[currentCount] = items[1];
            
            currentCount++;
        }
        // Working with the virutal size (the array with data, no empty spaces)
        for (int i = 0; i < currentCount; i++)
        {
            Console.WriteLine($"Pet name:\t{loadedPetNames[i]}");
            Console.WriteLine($"Pet fav number:\t{loadedPetNumbers[i]}");
        }
    }
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
            CreateNewPet();
            break;
        // View pet
        case "2":
            LoadExistingPets();
            DisplayExistingPets();
            break;
        // Edit Pet
        case "3":
            break;
        default:
            break;
    }
} while (userChoice != "0");

void DisplayExistingPets()
{
    
}