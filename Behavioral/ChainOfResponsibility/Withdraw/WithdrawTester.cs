using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Withdraw
{
    public static class WithdrawTester
    {
        public static void Test()
        {
            ATM atm = new ATM();
            Console.WriteLine("Enter the amount you wish to withdraw: ");
            String input = Console.ReadLine();
            try
            {
                int amount = int.Parse(input);
                String bills = atm.Withdraw(amount);
                Console.WriteLine(bills);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
