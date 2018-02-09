using System;

namespace TaskBank
{
    class Program
    {
        static void Main(string[] args)
        {
            string machineFormat = BankUtil.CorrectNumber("5227082-33351");
            Console.WriteLine(BankUtil.CorrectNumber("5227082-33351"));
            Console.WriteLine(BankUtil.IsValidAccount(machineFormat));
            Console.WriteLine($"Press any key to exit...");
            Console.ReadKey();
        }
    }
}
