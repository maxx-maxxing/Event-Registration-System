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
while (!int.TryParse(age, out int ageAsInt))
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

while ((!int.TryParse(daysAttended, out int daysAsInt)) || (daysAsInt < 1 || daysAsInt > 3))
{
    Console.WriteLine("Invalid input. Must be 1, 2, or 3. Try again.\n");
    Console.WriteLine("How many days will you be attending the conference? " +
                          "(Press 1, 2, or 3)");
    daysAttended = Console.ReadLine() ?? "";
}
Console.WriteLine($"{daysAttended} day stay accepted.");

// === Final Output ===
Console.WriteLine($"Registration Summary");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Days Attending: {daysAttended}");
Console.WriteLine($"Total Cost: {TotalCost(age, daysAttended)}");


// === Functions ===
string TotalCost(string visitorAge, string totalDays)
{
    int.TryParse(visitorAge, out int ageAsInt);
    int.TryParse(totalDays, out int daysAsInt);
    double registrationFeePerDay = 75.0;
    double basePrice = registrationFeePerDay * daysAsInt;
    if (ageAsInt < 25)
    {
        basePrice -= (basePrice * .10);
    }
    else if (ageAsInt > 60)
    {
        basePrice -= (basePrice * .15);
    }


    return basePrice.ToString("C");
}









