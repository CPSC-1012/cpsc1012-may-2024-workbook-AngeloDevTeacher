/// <summary>
/// An exmaple program showing off how to load information from two different types of files.
/// This example will also make up file extensions for use in this program.
/// 
/// Author:  Angelo Encarnacion
/// Date modified: July 25 2024
/// </summary>

// Variables
string filePath = "";
string userChoice = "";

const int CAT_DATA_MAX_SIZE = 10;

string[] catName = new string[CAT_DATA_MAX_SIZE];
string[] catBreed = new string[CAT_DATA_MAX_SIZE];
int[] catAge = new int[CAT_DATA_MAX_SIZE];
double[] walkHours = new double[CAT_DATA_MAX_SIZE];

// Main Program
filePath = "../../../" + "catWalk-July-25.catWalk";
LoadCatData(catName, catBreed, walkHours, filePath);
//LoadCatDescription(catName, catBreed, filePath);
//WriteNewCatData(filePath);

// Menu


// Functions - Instructions that belong to the program instead of an object (or instance of an object).

/// <summary>
/// Prompts  the user and return the user input.
/// </summary>
static string Prompt(string messagePrompt)
{
    Console.WriteLine(messagePrompt+"\t");
    return Console.ReadLine();
}


/// <summary>
/// Loads the cat's name and breed from the catList.catData file into the correct paralell arrays. Returns the number of cats loaded.
/// </summary>
static int LoadCatDescription(string[] names, string[] breeds, string filePath)
{
    StreamReader reader = null;
    int count = 0;
    if (File.Exists(filePath))
    {
        reader = new StreamReader(filePath);
        while (reader!=null && !reader.EndOfStream)
        {
            string record = reader.ReadLine();
            string[] items = record.Split(",");

            names[count] = items[0];
            breeds[count] = items[1];
            // I don't need the age in this function!
            count++;
        }
        reader.Close();
    }
    return count;
}
/// <summary>
/// Loads all cat data from the catList.catData file into the correct paralell arrays. Returns the number of cats loaded.
/// </summary>
static int LoadCatData(string[] names, string[] breeds, double[] hours, string filePath)
{
    StreamReader reader = null;
    int count = 0;
    if (File.Exists(filePath))
    {
        reader = new StreamReader(filePath);
        while (reader != null && !reader.EndOfStream)
        {
            string record = reader.ReadLine();
            string[] items = record.Split(",");

            names[count] = items[0];
            breeds[count] = items[1];
            hours[count] = double.Parse(items[3]);
            // I don't need the age in this function!
            count++;
        }
        reader.Close();
    }
    return count;
}

/// <summary>
/// Writes some new cat data DIRECTLY to the file - adding it to the end.
/// </summary>
static void WriteNewCatData(string fileName)
{
    // Open, write, close
    StreamWriter Writer = null;

    try
    {
        Writer = new StreamWriter(fileName, true);


        string CatName;
        CatName = Prompt("What is your cat's name?");

        string CatBreed;
        CatBreed = Prompt("What is your cat's breed?");

        int CatAge;
        CatAge = int.Parse(Prompt("What is your cat's age?"));

        double HoursWalked;
        HoursWalked = double.Parse(Prompt("How long did your cat walk??"));

        Writer.WriteLine($"{CatName}, {CatBreed}, {CatAge}, {HoursWalked}");
        Writer.Close();
    }
    catch (Exception)
    {
        Console.WriteLine("Error - the writer could not be made");
    }
}

catName[5] = "Angelo";
Console.WriteLine();