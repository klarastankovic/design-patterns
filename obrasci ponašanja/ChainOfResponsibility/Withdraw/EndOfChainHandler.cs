using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Withdraw
{
    public class EndOfChainHandler : IWithdrawHandler
    {
        private static EndOfChainHandler instance;
        private EndOfChainHandler() { }
        public IWithdrawHandler Next
        {
            set
            {
                throw new InvalidOperationException("End of chain");
            }
        }
        public static EndOfChainHandler GetInstance()
        {
            if (instance == null)
            {
                instance = new EndOfChainHandler();
            }
            return instance;
        }
        public string Withdraw(int amount)
        {
            throw new InvalidOperationException("Illigal amount, go see the clerk or try again.");
        }
    }
}
