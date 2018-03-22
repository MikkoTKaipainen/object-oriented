using System;
using System.Collections.Generic;

namespace TaskInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Product> product = new List<Product>();
            product.Add(new Product("Keppihevonen",13 ,3));
            product.Add(new Product("Pullasuti",24 ,2));
            product.Add(new Product("Seinämaali",2 ,5));

            Console.WriteLine(product[0].GetProduct("Keppihevonen"));
            Console.WriteLine(product[0].CountValue(0));

            foreach(var s in product)
            {
                Console.WriteLine(s.ToString());
            }

            List<Customer> customer = new List<Customer>();
            customer.Add(new Customer("Dick Johnson", 1200.20));
            customer.Add(new Customer("John McMace", 5500.20));
            customer.Add(new Customer("Pepe", 3200.55));

            Console.WriteLine(customer[1].GetCustomer("John McMace "));
            Console.WriteLine(customer[1].CountBonus(0.00,0.00));

            foreach (var c in customer)
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
