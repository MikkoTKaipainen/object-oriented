using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTicketPrice
{
    class Customer
    {
        public double Discount;
        public int Age;
        public double Price;

        public Customer()
        {
            Discount = 0.00;
            Age = 0;
            Price = 16;
        }

        public Customer(double discount, int age, double price)
        {
            Discount = discount;
            Age = age;
            Price = price;
        }

        public void AskAge()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
        }

        //public void DiscountForAge(int age, double discount, bool discounted)
        //{
        //    if (age <= 7)
        //    {
        //        discount = 100;
        //        discounted = true;
        //    }
        //    else if (age >= 7 && age <= 15)
        //    {
        //        discount = 50;
        //        discounted = true;
        //    }
        //    else if (age >= 65)
        //    {
        //        discount = 50;
        //        discounted = true;
        //    }
        //}

        public void AskStatus()
        {
            double discount = 0;
            bool discounted = false;
            int age = 0;

            if (age <= 7)
            {
                discount = 100;
                discounted = true;
            }
            else if (age >= 7 && age <= 15)
            {
                discount = 50;
                discounted = true;
            }
            else if (age >= 65)
            {
                discount = 50;
                discounted = true;
            }

            Console.WriteLine($"Are you a conscript?: Y/N ");
            string conscriptAnswer = Console.ReadLine().ToUpper();

            if (conscriptAnswer == "Y" && discounted == false)
            {
                discount = 50;
            }
            else
            {
                Console.WriteLine($"Are you a member of MTK? Y/N");
                string mtkAnswer = Console.ReadLine().ToUpper();

                Console.WriteLine($"Are you a student?: Y/N");
                string studentAnswer = Console.ReadLine().ToUpper();

                if (mtkAnswer == "Y" && discounted == false)
                {
                    discount = 15;
                }
                else
                {
                    if (studentAnswer == "Y" && discounted == false)
                    {
                        discount = 45;
                    }
                    else if (studentAnswer == "Y" && mtkAnswer == "Y" && discounted == false)
                    {
                        discount = 60;
                    }
                }
            }
        }
        
        public void PrintFinalPrice()
        {
            double price = 16;
            price = price - (price * (Discount/ 100));
            Console.WriteLine($"Your ticket price is: {Price}");
        }
    }
}