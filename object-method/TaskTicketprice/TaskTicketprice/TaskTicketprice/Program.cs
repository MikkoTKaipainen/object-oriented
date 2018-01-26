using System;

namespace TaskTicketprice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter customer data: ");

            Console.Write("Enter name: ");
            var name = Console.ReadLine();
            var customer = new Customer(name);

            int age = -1;
            while (age < 0)
            {
                Console.Write("Enter age: ");
                if (int.TryParse(Console.ReadLine(), out age));
                {
                    Console.WriteLine("Invalid age");
                    age = -1;
                }
                else
                {
                    customer.Age = age;
                }

                customer.IsMTKmember = YesNo("Is customer a member of MTK");
                customer.IsConscript = YesNo("Is customer a conscript");
                customer.IsStudent = YesNo("Is customer a student");

                Console.WriteLine($"Price for {customer.Name} is {customer.GetPrice():F2}");
                Console.ReadKey();
            }
        }
    }
}
