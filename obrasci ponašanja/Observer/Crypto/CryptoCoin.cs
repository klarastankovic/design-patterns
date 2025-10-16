using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Crypto
{
    public class CryptoCoin
    {
        public String Type { get; private set; }
        private decimal price;
        private List<IInvestor> investors;
        public CryptoCoin(string type, decimal price)
        {
            this.Type = type;
            this.price = price;
            this.investors = new List<IInvestor>();
        }
        public void Attach(IInvestor investor) { investors.Add(investor); }
        public void Detach(IInvestor investor) { investors.Remove(investor); }
        public void Notify()
        {
            foreach(IInvestor investor in investors)
            {
                investor.Update(this);
            }
        }
        public decimal Price
        {
            get { return price; }
            set { if (price != value) { price = value; Notify(); } }
        }
    }
}
