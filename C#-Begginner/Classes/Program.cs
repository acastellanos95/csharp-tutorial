using System;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            Person yo = new Person("Andre", "Castellanos", 25);
            Console.WriteLine(yo.getFirstName());
            Console.WriteLine(yo.getLastName());
            Console.WriteLine(yo.getAge());
        }
    }
}
