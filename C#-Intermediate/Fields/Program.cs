using System;
using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            // ...
        }
    }

    public class Order
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
           Customer customer = new Customer(1, "Andre");
           customer.Orders.Add(new Order());
           customer.Orders.Add(new Order());

           Console.WriteLine(customer.Orders.Count);

        }
    }
}
