using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBank
{
    class BankUtil
    {
        /// <summary>
        /// Change account to machineformat
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns> machineformat account </returns>
        public static string CorrectNumber(string accountNumber)
        {
            accountNumber = accountNumber.Replace("-","").Replace(" ","");

            int positionOfZeros = 0;
            if (accountNumber[0] == '1' || accountNumber[0] == '2' || accountNumber[0] == '4' || accountNumber[0] == '8')
                positionOfZeros = 6;
            else if (accountNumber[0] == '3')
            {
                if (accountNumber[1] == '0' || accountNumber[0] == '2' || accountNumber[0] == '5')
                    return "Account not valid or bank not found!";
                positionOfZeros = 6;
            }
            else if (accountNumber[0] == '4' || accountNumber[0] == '5')
                positionOfZeros = 7;
            else
            {
                return "Account incorrect or bank not found!";
            }
            for (int i = accountNumber.Length; i < 14; i++)
            {
                accountNumber = accountNumber.Insert(positionOfZeros, "0");
            }
                return accountNumber;
        }
        /// <summary>
        /// Checks the security number of machineformat account number
        /// </summary>
        /// <param name="machineformatNumber"></param>
        /// <returns> checked machineformat account </returns>
        public static bool IsValidAccount(string machineformatNumber)
        {
            char checkNumber = machineformatNumber[machineformatNumber.Length - 1];
            machineformatNumber = machineformatNumber.Remove(machineformatNumber.Length - 1, 1);
            int[] multiplex = new int[2]{2,1};
            int t = 0;
            for (int i = 0; i<machineformatNumber.Length; i++)
            {
                int n = int.Parse(machineformatNumber[i].ToString()) * multiplex[i%2];
                if (n <= 10)
                    t += n / 10 + (n - 10);
                else
                    t += n;
            }
            int calculatedCheckNumber = (t / 10 + 1) * 10;
            return checkNumber == calculatedCheckNumber;                
        }
    }
}
