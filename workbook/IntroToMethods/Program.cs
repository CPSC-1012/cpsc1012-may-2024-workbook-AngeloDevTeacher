// See https://aka.ms/new-console-template for more information

// Functions and Methods are ways to reuse our code.
// Functions exist OUTSIDE and object, methods exist WITHIN an object.

// We've been using methods throughout our course.
// Console.<thing>() or <thing>.Parse() are examples

// A function is NOT defined within an object and is not used as a method.

int myNumber = 3;
int yourNumber = 10;



void GreaterThanFive(int numberToCompare)
{
    if (numberToCompare > 5)
    {
        Console.WriteLine("The number is greater than 5");
    }
}

GreaterThanFive(myNumber);
GreaterThanFive(yourNumber);
GreaterThanFive(15);

