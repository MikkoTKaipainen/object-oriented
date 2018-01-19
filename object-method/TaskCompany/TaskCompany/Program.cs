using System;

namespace TaskCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            //Company copyCompany = new Company(company);

            company.AskData();
            Console.WriteLine();
            company.ShowCompanyInfo();
            Console.WriteLine();
            company.OutcomePercentage();
            Console.WriteLine();
            //copyCompany.ShowCompanyInfo();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
