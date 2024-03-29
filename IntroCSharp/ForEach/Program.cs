// See https://aka.ms/new-console-template for more information
Console.WriteLine("For Each");

// Create an array containing the fibonacci sequence
int[] fibonacciSequence = {0, 1, 1, 2, 3, 5, 8, 13};

foreach (int number in fibonacciSequence)
{
    Console.WriteLine($"{number} ");
}

// Create a list containing the fibonacci sequence
var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };

foreach (int element in fibNumbers) // fibNumbers is the collection being iterated over
{
    Console.WriteLine($"{element} ");
}
