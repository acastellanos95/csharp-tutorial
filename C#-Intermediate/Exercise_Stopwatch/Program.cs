using System;

namespace Exercise_Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            string input;
            while (true)
            {
                Console.WriteLine("To start a timer write 'start', to stop it write 'end'");
                input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "start":
                        stopwatch.Start();
                        break;
                    case "end":
                        stopwatch.End();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
