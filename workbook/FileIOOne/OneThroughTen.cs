
StreamWriter writer = null;
StreamReader reader = null;
const string FILE_NAME = "numbers.txt";
string output = "";

try
{
	writer = new StreamWriter(FILE_NAME);
}
catch (Exception e)
{
	Console.WriteLine(e.Message);
}

for (int numberIndex = 1; numberIndex <= 10; numberIndex++)
{
	writer.WriteLine(numberIndex);
}

writer.Close();

if (File.Exists(FILE_NAME))
{
	reader = new StreamReader(FILE_NAME);
	for (int numberIndex = 1; (numberIndex <= 10); numberIndex++)
	{
		string record = reader.ReadLine();
		if (numberIndex < 10)
		{
			output += $"{record}, ";
		}
		else
		{
			output += record;
		}
	}
	Console.WriteLine(output);
}
reader.Close();