Console.Write("Enter the year: ");
var añoString = Console.ReadLine();
var añoInt = int.Parse(añoString!);

if (añoInt % 5 == 0)
{
    Console.WriteLine("You went too far");
}
if (añoInt % 3 == 0)
{
    Console.WriteLine("almost but not quite");
}
if (añoInt % 400 == 0)
{
    Console.WriteLine($"The year: {añoInt}, is leap");
}
else if (añoInt % 100 == 0)
{
    Console.WriteLine($"The year: {añoInt}, is not leap");
}
else if (añoInt % 4 == 0)
{
    Console.WriteLine($"The year: {añoInt}, is leap");
}
else
{
    Console.WriteLine($"The year: {añoInt}, is not leap");
}
