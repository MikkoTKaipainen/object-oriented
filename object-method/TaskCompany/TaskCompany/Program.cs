using System;

namespace TaskCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();           

            company.AskData();
            Console.WriteLine();
            company.ShowCompanyInfo();

            Console.ReadKey();
        }
    }
}
