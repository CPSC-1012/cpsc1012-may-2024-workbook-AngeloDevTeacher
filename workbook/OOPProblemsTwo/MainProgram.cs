using OOPProblemsTwo;

/// <summary>
/// This program allows the user to display the results of up to 25 quizzes and show them in a table.
/// Author: Angelo Encarnacion
/// Date Modified: August 1 2024
/// </summary>

/// <plan>
/// Setup variables.
/// Allow for entry.
/// Display quizzes entered.
/// Display average.
/// </plan>


// Variables
const int MaxQuizAmount = 25;
int quizCount = 0;
Quiz[] quizzes = new Quiz[MaxQuizAmount];
bool isCompleted = false;

// User Variables
string userInput = string.Empty;

// Main Program
do
{
    // Inputting the quizzes.
    int thisQuizTotal = PromptInteger("Please enter the quiz's total:");
    int thisQuizWeight = PromptInteger("Please enter the quiz's weight");
    quizzes[quizCount] = new Quiz(thisQuizTotal, thisQuizWeight);

    // Set the student name
    userInput = Prompt("Which student wrote the quiz?");
    quizzes[quizCount].SetStudentName(userInput);

    // Set the mark
    int mark = PromptInteger("What did the student earn?");
    quizzes[quizCount].SetMark(mark);

    quizCount++;

    // Asking if we want more quizzes.
    userInput = Prompt("Do you want to enter another quiz? [Y/N]");
    if(userInput.ToUpper() == "N")
    {
        isCompleted = true;
    }
    if (quizCount == MaxQuizAmount)
    {
        Console.WriteLine("Max amount of quizzes reached.");
        isCompleted = true;
    }
} while (isCompleted == false);

Console.WriteLine($"\n{quizCount} quizzes entered.");

// Do the table!
Console.WriteLine($"{"Student Name:",-16}\t\t{"Total:",6}\t\t{"Mark:",6}\t\t{"Percent",7}");
for (int currentQuizNumber = 0; currentQuizNumber < quizCount; currentQuizNumber++)
{
    Console.WriteLine($"{quizzes[currentQuizNumber].GetStudentName(),-16}\t\t{quizzes[currentQuizNumber].GetTotal(),6}\t\t{quizzes[currentQuizNumber].GetMark(),6}\t\t{quizzes[currentQuizNumber].GetPercentage(),7}");
}


// Do the average, I guess.



// Functions

static string Prompt(string messagePrompt)
{
    Console.Write(messagePrompt+"\t");
    return Console.ReadLine();
}

static int PromptInteger(string messagePrompt)
{
    int Output = -1;
    do
    {
        try
        {
            Console.Write(messagePrompt + "\t");
            Output = int.Parse(Console.ReadLine());
            if (Output <= 0)
            {
                Console.WriteLine("Sorry, please enter a positive, whole number.");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Please enter a number.");
            Output = -1;
        }
    } while (Output <= 0);
    return Output;
}