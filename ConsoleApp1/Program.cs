Console.WriteLine("Enter your full name: ");
string name = Console.ReadLine() ?? "";
while (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Name cannot be empty. Try Again.");
    Console.WriteLine("Enter your full name: ");
    name = Console.ReadLine() ?? "";
}
Console.WriteLine("Name accepted.\n");

Console.WriteLine("Enter age: ");
string age = Console.ReadLine() ?? "";
while (!int.TryParse(age, out int ageAsInt))
{
    Console.WriteLine("Invalid input. Try again.");
    Console.WriteLine("Enter age: ");
    age = Console.ReadLine() ?? "";
}
Console.WriteLine($"Age accepted.\n");


Console.WriteLine("How many days will you be attending the conference? " +
                  "(Press 1, 2, or 3)");

string daysAttended = Console.ReadLine() ?? "";

while ((!int.TryParse(daysAttended, out int daysAsInt)) || (daysAsInt < 1 || daysAsInt > 3))
{
    Console.WriteLine("Invalid input. Must be 1, 2, or 3. Try again.\n");
    Console.WriteLine("How many days will you be attending the conference? " +
                          "(Press 1, 2, or 3)");
    daysAttended = Console.ReadLine() ?? "";
}
Console.WriteLine($"{daysAttended} day stay accepted.");









