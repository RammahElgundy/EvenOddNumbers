// See https://aka.ms/new-console-template for more information
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


PrintNumbers("All Numbers", numbers);
PrintNumbers("Even Numbers", numbers.Where(IsEven));
PrintNumbers("Odd Numbers", numbers.Where(IsOdd));

Console.WriteLine("Hello, World!");

static void PrintNumbers(string title, IEnumerable<int> numbers)
{
    Console.Write($"{title}: [");
	foreach (var n in numbers)
	{
        Console.Write($" {n}");
	}
    Console.WriteLine($" ]");
}



static bool IsEven(int number)
{
    if(number %2 == 0)
    {
       return true;
    }
    else
    {
        return false;
    }
}


static bool IsOdd(int number)
{
    if (number % 2 != 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

