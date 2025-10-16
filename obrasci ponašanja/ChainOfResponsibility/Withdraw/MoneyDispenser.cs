using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Withdraw
{
    public class MoneyDispenser : IWithdrawHandler
    {
        private int bill;
        public IWithdrawHandler Next { private get; set; }
        public MoneyDispenser(int bill)
        {
            this.bill = bill;
            this.Next = EndOfChainHandler.GetInstance();
        }
        public string Withdraw(int amount)
        {
            String money = "";
            if (amount >= this.bill)
            {
                int totalBills = amount / this.bill;
                money += totalBills + "*" + this.bill + " bills" + Environment.NewLine;
                int reminder = amount % this.bill;
                if (reminder > 0)
                {
                    money += this.Next.Withdraw(reminder);
                }
            }
            else
            {
                money += this.Next.Withdraw(amount);
            }
            return money;
        }
    }
}
