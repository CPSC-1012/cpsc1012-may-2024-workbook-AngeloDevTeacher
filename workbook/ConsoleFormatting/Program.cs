// See https://aka.ms/new-console-template for more information

// NOTE: This is only to demo the console formatting, and not about best practices 100%.

string name = "Angelo";
int number = 34;

decimal dollarAmount = 1234567.89m;
decimal angelosBankAccount = 1245.99m;
// String interpolation --> $""

// How to format dollar amounts.
Console.WriteLine($"Hello {name} (${dollarAmount:#,#.00})");


// How to do alignment.
Console.WriteLine($"{"Example Amount",-18}{dollarAmount,14:$#,#.00}");
Console.WriteLine($"{"AE Amount",-18}{angelosBankAccount,14:$#,#.00}");