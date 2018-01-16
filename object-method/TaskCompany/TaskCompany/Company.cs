using System;
using System.Collections.Generic;
using System.Text;

namespace TaskCompany
{
    class Company
    {
        //Muodostetaan kentät
        public string Title;
        public string Address;
        public int Phone;
        public double Income;
        public double Expense;

        //Methods
        public void AskData()
        {
            Console.WriteLine("Company name: ");
            Title = Console.ReadLine();
            Console.WriteLine("Company address: ");
            Address = Console.ReadLine();
            Console.WriteLine("Company phone: ");
            Phone = int.Parse(Console.ReadLine());
            Console.Write("Company income: ");
            Income = double.Parse(Console.ReadLine());
            Console.Write("Company expense: ");
            Expense = double.Parse(Console.ReadLine());
        }

        public void ShowCompanyInfo()
        {
            Console.WriteLine($"Your company is: {Title} " +
                $"\nCompany address is: {Address} " +
                $"\nCompany phone is: {Phone} " +
                $"\nCompany income: {Income} " +
                $"\nCompany expense: {Expense}");
        }


    }


}
