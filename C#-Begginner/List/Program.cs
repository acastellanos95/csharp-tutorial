using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> {5,6,7,1,9,8,3,5,2};
            numbers.Add(15);
            numbers.AddRange(new int[3] {17,28,99});

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Index of 7: " + numbers.IndexOf(7));
            Console.WriteLine("Last Index of 7: " + numbers.LastIndexOf(7));
            Console.WriteLine("Count: " + numbers.Count);
            numbers.Remove(9);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
