

// Variables
using PetStore;

/// <summary>
/// Online Pet Store Program - Allows people to make orders for pickup
/// Author: Angelo Encarnacion
/// Modified Date: 08-13-2024
/// </summary>
/// 
string example = "";
StoreItem item = new StoreItem();
StoreItem greedyItem = new StoreItem("A100","Angelo's super litter box", 45.00);
// Main Program
item.ProductID = Prompt("Please enter in a product ID:\t");
Console.WriteLine(item.ProductID);


#region Static Methods


/// <summary>
/// Prompts the user to input based off of the messagePrompt.
/// </summary>
static string Prompt(string messagePrompt)
{
    Console.Write(messagePrompt);
    return Console.ReadLine();
}

static double PromptDouble(string messagePrompt)
{
    double Output = 0;
    bool ValidInput = false;
    do
    {
        try
        {
            Console.Write(messagePrompt);
            Output = double.Parse(Console.ReadLine());
            if (Output < 0)
            {
                Console.WriteLine("Please enter a positive number");
                ValidInput = false;
            }
            else
            {
                ValidInput = true;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    } while (!ValidInput);
    return Output;
}


#endregion