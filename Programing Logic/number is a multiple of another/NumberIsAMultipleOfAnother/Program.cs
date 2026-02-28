Console.WriteLine("Enter two diferent numbers");
Console.Write("Enter the first number: ");
var numberString = Console.ReadLine();
var numberInt = int.Parse(numberString!);
Console.Write("Enter the second number: ");
var number2String = Console.ReadLine();
var number2Int = int.Parse(number2String!);

if (numberInt % number2Int == 0)
{
    Console.WriteLine($"The number: {number2Int}, is a multiple of: {numberInt}");
    Console.WriteLine("Congratulatión");
}
else
{
    Console.WriteLine($"The number: {number2Int}, is not a multiple of: {numberInt}");
    Console.WriteLine("Try again");
}
