using System;

namespace Classes
{
    // Constructor class
    public class Person
    {
        private string Name;
        public Person(string name)
        {
            this.Name = name;
        }

        public string name
        {
            get { return Name; }
            set { this.Name = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Andre");
            Console.WriteLine(person.name);

            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Andre";

            Order order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
