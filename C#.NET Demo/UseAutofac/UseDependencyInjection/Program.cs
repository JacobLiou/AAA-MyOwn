using System;
using System.IO;
using Microsoft.Extensions.DependencyInjection;

namespace UseDependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    interface IMessageWriter
    {
        void Write(string message);
    }

    class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine($"MessageWriter.Write(message: \"{message}\")");
        }
    }

    class FileMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            File.AppendAllText(@"Path", message);
        }
    }
}
