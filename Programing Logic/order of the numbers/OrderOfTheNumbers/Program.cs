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

var larger = numberInt;
var middle = number2Int;
var less = number3Int;

if (number2Int > numberInt && number2Int > number3Int)
{
    larger = number2Int;
}
else if (number3Int > numberInt && number3Int > number2Int)
{
    larger = number3Int;
}



if (numberInt > number2Int && number2Int < number3Int)
{
    middle = numberInt;
}
else if (numberInt > number3Int && numberInt < number2Int)
{
    middle = numberInt;
}
else if (number3Int > numberInt && number3Int < number2Int)
{
    middle = number3Int;
}
else if(number3Int > number2Int && number3Int < numberInt)
{
    middle = number3Int;
}



if (numberInt < number2Int && numberInt < number3Int)
{
    less = numberInt;
}
else if (number2Int < numberInt && number2Int < number3Int)
{
    less = number2Int;
}
else if (numberInt == number2Int && numberInt == number3Int)
{
    Console.WriteLine("The three numbers is equals");
}
else if (numberInt == number2Int && numberInt != number3Int)
{
    Console.WriteLine("Two numbers is equals");
}
else if (numberInt == number3Int && number3Int != number2Int)
{
    Console.WriteLine("Two numbers is equals");
}
else if (number2Int == numberInt && number2Int != number3Int)
{
    Console.WriteLine("Two numbers is equals");
}
else if (number2Int == number3Int && number2Int != numberInt)
{
    Console.WriteLine("Two numbers is equals");
}
else if (number3Int == numberInt && number3Int != number2Int)
{
    Console.WriteLine("Two numbers is equals");
}
else if (number3Int == number2Int && number3Int != numberInt)
{
    Console.WriteLine("Two numbers is equals");
}

Console.WriteLine($"The larger number is: {larger}");
Console.WriteLine($"The middle number is: {middle}");
Console.WriteLine($"THe less number is: {less}");
