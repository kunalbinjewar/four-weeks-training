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
