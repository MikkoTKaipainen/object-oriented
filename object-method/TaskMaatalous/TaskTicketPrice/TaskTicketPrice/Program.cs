using System;

namespace TaskTicketPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.AskAge();
            customer.AskStatus();
            customer.PrintFinalPrice();
            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}
