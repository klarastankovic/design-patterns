using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Withdraw
{
    public class ATM
    {
        IWithdrawHandler handler;
        public ATM()
        {
            MoneyDispenser fiveDispenser = new MoneyDispenser(5);
            MoneyDispenser tenDispenser = new MoneyDispenser(10);
            MoneyDispenser hunderedDispenser = new MoneyDispenser(100);
            hunderedDispenser.Next = tenDispenser;
            tenDispenser.Next = fiveDispenser;
            handler = hunderedDispenser;
        }
        public String Withdraw(int amount)
        {
            return this.handler.Withdraw(amount);
        }
    }
}
