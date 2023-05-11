namespace IteratorsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fibonacci = FibonacciSequence().Take(10);
            foreach (int number in fibonacci)
            {
                Console.WriteLine(number);
            }
        }
        // https://www.c-sharpcorner.com/UploadFile/5ef30d/understanding-yield-return-in-C-Sharp/
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/yield
        public static IEnumerable<int> FibonacciSequence()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

public class FibonacciIterator : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        int previousNumber = 0;
        int currentNumber = 1;
        int count = 0;

        while (count < 10) // Generating first 10 numbers
        {
            yield return previousNumber;
            int nextNumber = previousNumber + currentNumber;
            previousNumber = currentNumber;
            currentNumber = nextNumber;
            count++;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class Program
{
    static void Main(string[] args)
    {
        FibonacciIterator fibonacciIterator = new FibonacciIterator();

        foreach (int number in fibonacciIterator)
        {
            Console.WriteLine(number);
        }
    }
}
