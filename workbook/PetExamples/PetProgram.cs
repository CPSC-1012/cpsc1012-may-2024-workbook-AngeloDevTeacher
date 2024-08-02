// Why do we use OOP?
// It makes it easier to represent information and do things with the data we're represetning.


const int MaxCatCount = 3;

string catNameOne = "Sully";
string catNameTwo = "Piper";
string catNameThree = "Mike";

string catBreedOne = "Domestic Short Hair";
string catBreedTwo = "Tripoint Ragdoll";
string catBreedThree = "Domestic Short Hair";

int catAgeOne = 3;
int catAgeTwo = 2;
int catAgeThree = 1;

string catColorDescriptionOne = "Tuxedo pattern";
string catColorDescriptionTwo = "Tri Color";
string catColorDescriptionThree = "Tuxedo pattern";

//string[] catNames = new string[MaxCatCount];

string[] catNames = new string[] { "Sully", "Piper", "Mike" };
string[] catBreeds = new string[] { "Domestic Short Hair", "Tripoint Ragdoll", "Domestic Short Hair" };
int[] catAges = new int[] { 3, 2, 1 };
string[] catColorDescriptions = new string[] { "Tuxedo pattern", "Tri Color", "Tuxedo pattern" };

Console.WriteLine(catNames[0]);