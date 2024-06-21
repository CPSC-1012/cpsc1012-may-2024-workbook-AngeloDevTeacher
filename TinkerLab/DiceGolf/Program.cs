// See https://aka.ms/new-console-template for more information

using DiceGolf;

Random randomInstance = new Random(0);

const int DICE_COUNT = 5;
List<Die> diceList = new List<Die>();

string userInput = "";
bool playAgain = true;

for (int i = 0; i < DICE_COUNT; i++)
{
    diceList.Add(new Die());
}

void AttemptToRollDice()
{
    foreach (var dice in diceList)
    {
        if (dice.CanRoll)
        {
            dice.RollDie(randomInstance);
        }
    }
}

void DisplayDice() {
    Console.WriteLine($"[{diceList[0].DieValue}], [{diceList[1].DieValue}], [{diceList[2].DieValue}], [{diceList[3].DieValue}], [{diceList[4].DieValue}]");
}



do
{
    Console.Clear();
    Console.WriteLine("=====Dice Golf=====\n\n");
    AttemptToRollDice();
    DisplayDice();
    Console.Write("Do you want to roll again?");
    userInput = Console.ReadLine();

    if (userInput.ToLower()[0] != 'y')
    {
        playAgain = false;
    } 
} while (playAgain);

