var numberString = string.Empty;

do
{
    Console.Write("Enter the number or the string 'exit': ");
    numberString = Console.ReadLine();
    if (numberString!.ToLower() == "exit")
    {
        continue;
    }
    
    var numberint = 0;
    if (int.TryParse(numberString, out numberint))
    {

        if (numberint % 2 == 0)
        {
            Console.WriteLine($"the number: {numberint}, is even");
        }
        else
            Console.WriteLine($"The number: {numberint}, is odd");
    }
    else
    {
        Console.WriteLine($"The number: {numberString}, is not valid");
    }
} while (numberString!.ToLower() != "exit");
