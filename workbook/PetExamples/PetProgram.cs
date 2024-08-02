// Why do we use OOP?
// It makes it easier to represent information and do things with the data we're represetning.


using PetExamples;

const int MaxPetCount = 3;


Pet[] pets = new Pet[MaxPetCount];


pets[0] = new Cat("Sully", "Domestic Short Hair", 3, "Tuxedo pattern");
pets[1] = new Cat("Mike", "Domestic Short Hair", 1, "Tuxedo pattern");
pets[2] = new Bird("Charlie", "Parrot", 973, "Green");

Console.WriteLine(pets[1].Name);

