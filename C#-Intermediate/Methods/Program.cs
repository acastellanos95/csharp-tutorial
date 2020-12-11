using System;

namespace Methods
{
    class Program
    {
         static void AddtwoInt(ref int refnumber)
        {
            refnumber += 2;
            Console.WriteLine(refnumber);
        }
        static void Main(string[] args)
        {
            int num = 2;
            int num2 = 5;
            AddtwoInt(ref num);
            AddtwoInt(ref num2);
            Console.WriteLine(num);
            Console.WriteLine(num2);
            Console.WriteLine(num);
        }
    }
}
