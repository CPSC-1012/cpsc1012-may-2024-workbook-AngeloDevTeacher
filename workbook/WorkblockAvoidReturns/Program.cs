// See https://aka.ms/new-console-template for more information


const int MAX_PEOPLE = 10;


// This is now a descriptive loop - I can read this and figure out what's going on!
//for (int currentPerson = 0; currentPerson < MAX_PEOPLE; currentPerson++)
//{
//    // BELOW IS BAD PRACTICE!!
//    //if (currentPerson == 3)
//    //{
//    //    Console.WriteLine("It's the third person, let's break the loop!");
//    //    break;
//    //}
//    Console.WriteLine(currentPerson.ToString());
//}

// A better way to prevent code from running!

//Swap the isValid method to test!
bool isValid = false;
string userInput = "";
int numberToCheckNext = 0;

// This prevents the question if the answer lead to invalidate the program!
if (isValid)
{
    Console.Write("Please enter a number:\t");
    userInput = Console.ReadLine();


    if (isValid && int.TryParse(userInput, out numberToCheckNext))
    {
        Console.WriteLine(numberToCheckNext);
    }
    else
    {

    }
}

// This is an example to AVOID: multiple returns
string BadRainbowChoice(char choice)
{
    if(choice == 'Y')
    {
        return "Rainbow!";
    }
    else
    {
        return "";
    }
}

string GoodRainbowChoice(char choice)
{
    // Make an output variable the matches the return type.
    string Output = "";
    if (choice == 'Y')
    {
        // Instead of returning here, set the output value
        Output = "Rainbow";
    }

    //return output OUTSIDE of any loops/ifs, etc. at the bottom of the function.
    return Output;
}