// See https://aka.ms/new-console-template for more information

// Loops are used to repeat code!

// A while loop will happen WHILE the condition is true.
// This loop will not run.
while (false)
{
    Console.WriteLine("Hello World");
}


// FROM NOW ON: Menus are generally in a do-while with a switch
do
{
    Console.WriteLine("Hello world!");
} while (false);

//  init i,    condition, inc
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hello world {i}");
}

// Same as above in a while loop
int j = 0;
while (j < 10)
{
    Console.WriteLine($"Hello class {j}");
    j += 1;
    //j = j + 1;
}

// Example of something that will end:
string name = "Angelo Encarnacion";
for (int i = 0;i < name.Length; i++)
{
    Console.WriteLine(name[i]);
}

// Exmaple of a BAD for loop:
Console.WriteLine("Add a letter to Angelo's name");
for (int i = 0; i < 5; i++)
{
    Console.Write("Add a letter: ");
    Console.ReadLine();
}

// BONUS: Foreach loop does the entire collection.
foreach (var letter in "Angelo Encarnacion")
{
    Console.WriteLine(letter);
}
