using System;
using DigiTrade.Utility;

namespace Bban
{
    class Program
    {
        static void Main(string[] args)
        {
            string machineFormat = "A227720-35988";
            bool isMachineFormat = BankUtil.CorrectNumber(ref machineFormat);
            if (isMachineFormat)
                Console.WriteLine($"{machineFormat} - {BankUtil.IsValidAccount(machineFormat)}");
            else
                Console.WriteLine("Account number incorrect!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
