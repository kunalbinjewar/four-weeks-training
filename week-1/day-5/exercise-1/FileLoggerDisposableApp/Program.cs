namespace FileLoggerDisposableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use FileLogger and dispose of it properly
        }
    }

    class FileLogger : IDisposable
    {
        private StreamWriter _writer;

        public FileLogger(string filePath)
        {
            // Initialize StreamWriter instance
        }

        public void Dispose()
        {
            // Implement IDisposable pattern
        }

        public void Log(string message)
        {
            // Write message to the file
        }
    }
}

namespace FileLoggerDisposableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var logger = new FileLogger("hitarth.txt"))
            {
                logger.Log("My Name is Hitarth...!");
                // some code here
                logger.Log("I'm a fresher. Passing Out in 23.....!!");
                logger.Dispose();
            }
            // Use FileLogger and dispose of it properly
        }
    }
    class FileLogger : IDisposable
    {
        private StreamWriter _writer;
        public FileLogger(string filePath)
        {
            _writer = new StreamWriter(filePath);
            // Initialize StreamWriter instance
        }
        public void Dispose()
        {
            _writer.Dispose();
            // Implement IDisposable pattern
        }
        public void Log(string message)
        {
            _writer?.WriteLine(message);
            // Write message to the file
        }
    }
}

using System;
using System.IO;
// Create an interface called "IProcessor<in TInput, out TResult>" with a single method "TResult Process(TInput input)".
public interface IProcessor<in TInput, out TResult>
{
    TResult Process(TInput input);
}
// Create a class called "StringToIntProcessor" that implements "IProcessor<string, int>" and returns the length of the input string.
public class StringToIntProcessor : IProcessor<string, int>
{
    public int Process(string input)
    {
        return input.Length;
    }
}
// Create a class called "DoubleToStringProcessor" that implements "IProcessor<double, string>" and returns the string representation of the input double
public class DoubleToStringProcessor : IProcessor<double, string>
{
    public string Process(double input)
    {
        return input.ToString();
    }
}
class Program
{
    static void Main(string[] args)
    {
        StringToIntProcessor stringToIntProcessor = new StringToIntProcessor();
        int output1 = stringToIntProcessor.Process("Abhi this side..!");
        Console.WriteLine(output1);
        DoubleToStringProcessor doubleToStringProcessor = new DoubleToStringProcessor();
        string output2 = doubleToStringProcessor.Process(3.141146565546);
        Console.WriteLine(output2);
    }
}
























