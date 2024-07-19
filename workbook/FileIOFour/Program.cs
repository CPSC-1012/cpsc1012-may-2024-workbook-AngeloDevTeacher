/// <summary>
/// This program will display records with fields one at a time.
/// Author: Angelo Encarancion
/// Date Modified: July 18th 2024
/// </summary>

string filePath = "";
int currentRecord = 1;
StreamReader reader = null;


// STEP 1:
Console.Write("Please enter the file path:\t");
filePath = Console.ReadLine().Split(".")[0] + ".csv";

if (File.Exists(filePath))
{
    reader = new StreamReader(filePath);
    // While we have records ...
    while (reader != null && !reader.EndOfStream)
    {
        // Display the records nicely...
        Console.WriteLine($"Record {currentRecord}");
        Console.WriteLine("------------------------");
        // Take our record from the file...
        string record = reader.ReadLine();
        // Seperate the fields using .split on the comma...
        string[] fields = record.Split(",");

        // For each field...
        for (int item = 0; item < fields.Length; item++)
        {
            // Write out the field...
            Console.WriteLine($"Field {item+1}: {fields[item]}");
        }
        // Make a new a line...
        Console.WriteLine("");
        // .. update the current record.
        currentRecord += 1;
    }

    reader.Close();
}