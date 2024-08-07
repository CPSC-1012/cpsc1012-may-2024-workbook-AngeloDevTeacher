
// If I'm going to make an array, I will use the following syntax for it.

const int MaxSize = 25;
int[] marksArray = new int[MaxSize];

// *********** CREATING A LIST ******************
// The list version looks like this:
List<int> marksList = new List<int>();

int exampleNumberToInsert = 15;

// If I'm going to put it into my marks array, I need to be specific where I place it.
// I assign the value to the array.
marksArray[3] = exampleNumberToInsert;

// There are two way to add to a list:
// This is add - adds it to the end. We don't need to know WHERE we are adding it, but it will just add.
// If the list is full, the list will grow in size.
// *********** ADDING TO A LIST ******************
marksList.Add(exampleNumberToInsert + 1);
marksList.Add(exampleNumberToInsert + 2);
marksList.Add(exampleNumberToInsert + 3);
marksList.Add(exampleNumberToInsert + 4);
Console.WriteLine($"There are {marksList.Count} in the list.");

// We can insert items into the list, and it will shift things downwards.
// *********** INSERTING TO A LIST ******************
marksList.Insert(3, exampleNumberToInsert + 1);


// When I use an array, I can use a for loop easily:
// We can iterate through the loop using an index.
for (int i = 0; i < marksArray.Length; i++)
{
    Console.WriteLine(marksArray[i]);
}

// The foreach loop RETURNS the "item" for your use on each iteration,
// INSTEAD of us manually grabbing it from the collection using the index.
foreach (int item in marksList)
{
    Console.WriteLine(item); 
}

// I can also do a for loop with a list:
for (int i = 0;i < marksList.Count; i++)
{
    Console.WriteLine(marksList[i]);
}

// The foreach loop is easy to use, but isn't good at parallel arrays or collections.
// Instead, it has a focus on usage with OBJECTS (or instances).
// See the OOP example for more info.