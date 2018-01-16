using System;
using System.Collections.Generic;
using System.Text;

namespace TaskCompany
{
    class Company
    {
        public string Title;
        public string Address;
        public int Phone;
        public double Income;
        public double Expense;

        public Company(Company company1)
        {
            Title = company1.Title;
            Address = company1.Address;
            Phone = company1.Phone;
            Income = company1.Income;
            Expense = company1.Expense;
        }

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

        public void OutcomePercentage(double money)
        {
            money = ((Income - Expense)/Expense * 100);
        }

        public void CompanySituation(double money)
        {
            if (money < Expense)
                Console.WriteLine($"Your company's profit is poor");
            if else ()
        }
    }


}
