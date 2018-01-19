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

        //public Company(Company copyCompany)
        //{
        //    Title = copyCompany.Title;
        //    Address = copyCompany.Address;
        //    Phone = copyCompany.Phone;
        //    Income = copyCompany.Income;
        //    Expense = copyCompany.Expense;
        //}

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

        public void OutcomePercentage()
        {
            double money = ((Income - Expense)/Expense * 100);
            CompanySituation(money);
        }

        private void CompanySituation(double money)
        {
            if (money < 100)
                Console.WriteLine($"Your company {Title} profit is poor");
            if (money >= 100 && money < 200)
                Console.WriteLine($"Your company {Title} profit is OK");
            if (money >= 200 && money < 300)
                Console.WriteLine($"Your company {Title} profit is superb");   
        }
    }


}
