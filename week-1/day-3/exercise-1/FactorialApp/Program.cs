// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter NO: ");
        int number = int.Parse(Console.ReadLine());
        long factorial = CalculateFactorial(number);
        Console.WriteLine($" The Factorial Of {number} is {factorial}");
    }
    static long CalculateFactorial(int n)
    {
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}