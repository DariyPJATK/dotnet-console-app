using System;

try
{
    Console.WriteLine("Enter first number:");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter second number:");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine($"Numbers entered: {a}, {b}");

    int sum = StatisticsHelper.Sum(a, b);
    Console.WriteLine($"Sum: {sum}");
}
catch
{
    Console.WriteLine("Something went wrong. Input numbers only");
}