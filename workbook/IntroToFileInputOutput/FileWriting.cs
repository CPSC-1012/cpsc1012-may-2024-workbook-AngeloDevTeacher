// See https://aka.ms/new-console-template for more information

// When we are writing to a file, we'll being OPENING a file, WRITING to it, and CLOSING it.
// Those are different steps.
// To do the steps, we will be using a file writer (as we are writing to the file.)

// This is the file we'd like to open, or create and open.
// We'll have an error if we can't open it!
// We'll also have an error if it gets changed or modified or moved when we open it!
string fileName;


// Think of having one car in the house (the file). If someone borrows your car (to write!), they should return it (close the file).
// We set it to null BECAUSE we want to see if it worked and didn't error out before writing.
// Think of asking permission to borrow the car before making plans.

// This is an "object varaible" - we're going to be doing stuff with it, like the random class.
StreamWriter writer = null;


// We're going to be writing with these!
string id;
string firstName;
string lastName;


// Program begin
Console.WriteLine("CSV File Writer\n\n");


// STEP 1: OPENING THE FILE
try
{
    // Prompt the user for the filename.
    Console.Write("Enter a file name to write to:\t");
    fileName = Console.ReadLine();
    // Make a new instamce of the StreamWriter.
    // The version below will overwrite the entire file.
    //writer = new StreamWriter(fileName);

    // This version will append, or "add to the end"
    writer = new StreamWriter(fileName, true);
}
catch (Exception e)
{
    Console.WriteLine($"Something went wrong. Stream writer error {e.Message} ");
}

// STEP 2: WRITE TO THE FILE!

// Only write to the file if it exists (not null)
if (writer != null)
{
    // same stuff as alwayds, this could have been done with a method as well.
    Console.Write("Enter the id:\t");
    id = Console.ReadLine();

    Console.Write("Enter the first name:\t");
    firstName = Console.ReadLine();

    Console.Write("Enter the last name:\t");
    lastName = Console.ReadLine();

    // this is where I write:
    // This is ~"it"~.
    writer.WriteLine($"{id}, {lastName}, {firstName}");

    // STEP 3: CLOSE the file (and handle with try-catch if needed).

    // this is also simple (without the try catch.)
    writer.Close();
}