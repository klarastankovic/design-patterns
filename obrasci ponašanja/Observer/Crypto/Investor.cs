using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Crypto
{
    public class Investor : IInvestor
    {
        private String Name { get; set; }
        private CryptoCoin coin;
        public Investor (string name)
        {
            this.Name = name;
        }
        public void Update(CryptoCoin stock)
        {
            Console.WriteLine("Notified {0} of {1}'s change to {2:C}", Name, stock.Type, stock.Price);
        }
        public CryptoCoin Stock
        {
            get { return coin; }
            set { coin = value; }
        }
    }
}
