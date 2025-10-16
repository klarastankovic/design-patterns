using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Crypto
{
    public class Bitcoin : CryptoCoin
    {
        public Bitcoin(string type, decimal price) : base(type, price)
        {
        }
    }
}
