using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = System.Environment.MachineName;
            Console.WriteLine($"Hello {name}!");
        }
    }
}
