

Console.WriteLine("Enter your full name: ");
string name = Console.ReadLine() ?? "";
while (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Name cannot be empty. Try Again.");
    Console.WriteLine("Enter your full name: ");
    name = Console.ReadLine() ?? "";
}

Console.WriteLine("Age: ");
int age = Convert.ToInt32(Console.ReadLine());
// ^^ FIXME: Use try/catch OR TryParse, and range based check

Console.WriteLine("How many days will you be attending the conference? " +
                  "(Press 1, 2, or 3)");
int daysAttended = Convert.ToInt32(Console.ReadLine());
// ^^ FIXME: Use try/catch OR TryParse, and range based check






