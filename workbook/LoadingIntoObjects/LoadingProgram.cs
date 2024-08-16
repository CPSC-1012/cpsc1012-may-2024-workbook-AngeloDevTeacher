// LOAD FROM A CSV INTO OBJECTS

// We've been able to load a csv into parallel arrays.
// Doing it into objects is easy and is clearer in my opinion.

using LoadingIntoObjects;

StreamReader reader = null;
string filePath = "students.csv";

List<Student> students = new List<Student>();


if (File.Exists(filePath))
{
    reader = new StreamReader(filePath);
    while(!reader.EndOfStream && reader != null)
    {
        string line = reader.ReadLine();
        string[] items = line.Split(",");

        // This is where things change!
        int thisID = int.Parse(items[0]);
        string thisFirstName = items[1];
        string thisLastName = items[2];
        double thisGrade = double.Parse(items[3]);

        // Load the items into the object instead of a parallel array.
        Student thisStudent = new Student(thisID,thisFirstName,thisLastName,thisGrade);

        // Save it into a list of "Student" type objects.
        students.Add(thisStudent);
    }
}

Console.WriteLine(students.Count);
