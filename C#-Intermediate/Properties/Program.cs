using System;

namespace Properties
{
    public class Person
    {
        private DateTime _birthdate;

        public DateTime Birthdate 
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
