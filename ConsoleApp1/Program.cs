using System;

try
{
    Console.WriteLine("Simple statistics console application");
    Console.WriteLine("Enter first number:");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter second number (integer):");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine($"Numbers entered: {a}, {b}");

    int[] numbers = { a, b };
    double avg = StatisticsHelper.CalculateAverage(numbers);
    Console.WriteLine($"Average: {avg}");
}
catch
{
    Console.WriteLine("Something went wrong. Input numbers only");
}