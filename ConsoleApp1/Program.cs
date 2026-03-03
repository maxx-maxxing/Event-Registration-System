// === Name ===
Console.WriteLine("Enter your full name: ");
string name = Console.ReadLine() ?? "";
while (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Name cannot be empty. Try Again.");
    Console.WriteLine("Enter your full name: ");
    name = Console.ReadLine() ?? "";
}
Console.WriteLine("Name accepted.\n");

// === Age ===
Console.WriteLine("Enter age: ");
string age = Console.ReadLine() ?? "";

int ageAsInt; // init an int to pass vals to
while (!int.TryParse(age, out ageAsInt))
{
    Console.WriteLine("Invalid input. Try again.");
    Console.WriteLine("Enter age: ");
    age = Console.ReadLine() ?? "";
}
Console.WriteLine($"Age accepted.\n");


// === Days ===
Console.WriteLine("How many days will you be attending the conference? " +
                  "(Press 1, 2, or 3)");

string daysAttended = Console.ReadLine() ?? "";

int daysAsInt; // init an int to pass vals to
while ((!int.TryParse(daysAttended, out daysAsInt)) || (daysAsInt < 1 || daysAsInt > 3))
{
    Console.WriteLine("Invalid input. Must be 1, 2, or 3. Try again.\n");
    Console.WriteLine("How many days will you be attending the conference? " +
                          "(Press 1, 2, or 3)");
    daysAttended = Console.ReadLine() ?? "";
}
Console.WriteLine($"{daysAsInt} day stay accepted.");

// === Final Output ===
Console.WriteLine($"Registration Summary");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {ageAsInt}");
Console.WriteLine($"Days Attending: {daysAsInt}");
Console.WriteLine($"Total Cost: {TotalCost(ageAsInt, daysAsInt)}");


// === Functions ===
static string TotalCost(int visitorAge, int totalDays)
{
    decimal registrationFeePerDay = 75m; // When dealing w currency, use decimal
    decimal basePrice = registrationFeePerDay * totalDays;
    if (visitorAge < 25)
    {
        basePrice -= (basePrice * .10m);
    }
    else if (visitorAge >= 60)
    {
        basePrice -= (basePrice * .15m);
    }


    return basePrice.ToString("C"); // Formats return to proper currency
}









