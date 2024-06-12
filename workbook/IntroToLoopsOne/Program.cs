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
