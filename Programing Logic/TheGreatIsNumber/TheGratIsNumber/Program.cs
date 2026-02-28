Console.WriteLine("Enter three different numbers");
Console.Write("Enter the first number: ");
var numberString = Console.ReadLine();
var numberInt = int.Parse(numberString!);
Console.Write("Enter the second number: ");
var number2String = Console.ReadLine();
var number2Int = int.Parse(number2String!);
Console.Write("Enter the third number: ");
var number3String = Console.ReadLine();
var number3Int = int.Parse(number3String!);

if(numberInt > number2Int && numberInt > number3Int)
{
    Console.WriteLine($"The great number is: {numberInt}");
}
else if (number2Int > numberInt && number2Int > number3Int)
{
    Console.WriteLine($"The great number is: {number2Int}");
}
else if (number3Int > numberInt && number3Int > number2Int)
{
    Console.WriteLine($"The great number is: {number3Int}");
}
else if (numberInt == number2Int && numberInt == number3Int)
{
    Console.WriteLine("The trhee numbers are equals");
}
else
{
    Console.WriteLine("At least two numbers are equal");
}