using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Crypto
{
    public interface IInvestor
    {
        void Update(CryptoCoin coin);
    }
}
