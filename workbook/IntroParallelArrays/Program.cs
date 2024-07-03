// See https://aka.ms/new-console-template for more information

// Corresponding / Parallel Arrays hold data related to each other.

// Max 5 items in these arrays.
const int ARRAY_SIZE = 5;

// These arrays will have related data and are the same size.
int[] ids = new int[ARRAY_SIZE];
string[] names = new string[ARRAY_SIZE];
float[] grades = new float[ARRAY_SIZE];

static void WriteStudentID(int index, int id, ref int[] array)
{
    array[index] = id;
}
static void WriteStudentName(int index, string name, ref string[] array)
{
    array[index] = name;
}
static void WriteStudentGrade(int index, float grade, ref float[] array)
{
    array[index] = grade;
}


WriteStudentID(0, 2004, ref ids);
WriteStudentName(0, "Angelo", ref names);
WriteStudentGrade(0, 49.9f, ref grades);
Console.WriteLine($"{ids[0]}, {names[0]}, {grades[0]}");

for (int i = 0; i < ARRAY_SIZE; i++)
{
    Console.Write("Enter an ID: ");
    int idExample = int.Parse(Console.ReadLine());
    WriteStudentID(i, idExample, ref ids);

    Console.Write($"Enter an name for {ids[i]}: ");
    string nameExample = Console.ReadLine();
    WriteStudentName(i, nameExample, ref names);
}
for (int i = 0; i < ARRAY_SIZE; i++)
{
    Console.WriteLine($"{ids[i]}, {names[i]}, {grades[i]}");
}
