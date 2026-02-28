Console.Write("Enter the number: ");
var numberString = Console.ReadLine();
var numberInt = int.Parse(numberString!);
if (numberInt % 2 == 0)
{
    Console.WriteLine($"The number {numberInt}, is Even");
}
else
{
    Console.WriteLine($"The number {numberInt}, is Odd");
}