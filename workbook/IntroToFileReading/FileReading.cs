// See https://aka.ms/new-console-template for more information

// Reading from a file is a little more complicated. This is because you'll be looking at the file "line by line"

// Just like writing, we'll have to open and close the reader. However, in between, we have to check to see if the file exists and that the file has not ended.
// The basic version of this is pretty simple.

string fileName;

StreamReader reader = null;

//string id;
//string firstName;

// Program Start!

// STEP 1: Opening the reader.
Console.Write("Enter a file name to read from:\t");
fileName = Console.ReadLine();

// We can use a try-catch, but also, we can use this File.Exists check.
if (File.Exists(fileName))
{
    reader = new StreamReader(fileName);

	// STEP 2: Reading from the file.

	// I'd like to read the entire file. I have no idea HOW big it is, and if try reading something that doesn't exist, we'll have issues, so let's read until we are at the end of the file.
	while (reader != null && reader.EndOfStream == false)
	{
		string record = reader.ReadLine();
		Console.WriteLine(record);
	}

	// STEP 3: Closing the reader.
	reader.Close();
}