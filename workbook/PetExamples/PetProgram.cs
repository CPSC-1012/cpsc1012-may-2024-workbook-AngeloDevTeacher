// Why do we use OOP?
// It makes it easier to represent information and do things with the data we're represetning.


using PetExamples;

const int MaxPetCount = 3;


Pet[] pets = new Pet[MaxPetCount];
Cat sully = new Cat("Sully", "Domestic Short Hair", 3, "Tuxedo pattern");
Cat mike = new Cat("Mike", "Domestic Short Hair", 1, "Tuxedo pattern");

pets[0] = sully;
pets[1] = mike;
pets[2] = new Bird("Charlie", "Parrot", 973, "Green");

for (int i = 0; i < 7; i++)
{
    sully.Walk();
}

mike.Walk();

Console.WriteLine(sully.WalkCount);
Console.WriteLine(mike.WalkCount);

Console.WriteLine(sully.ToString());
