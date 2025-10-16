using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Crypto
{
    public static class CryptoTester
    {
        public static void Test()
        {
            Bitcoin bitcoin = new Bitcoin("BCO", 8000.00m);
            Investor rx580owner = new Investor("RX580 owner");
            Investor gtx1080Tiowner = new Investor("GTX1080Ti owner");
            bitcoin.Attach(rx580owner);
            bitcoin.Attach(gtx1080Tiowner);
            bitcoin.Price = 8010.00m;
            bitcoin.Price = 8500.02m;
            bitcoin.Detach(rx580owner);
            bitcoin.Price = 8710.54m;
            bitcoin.Price = 9000.45m;
        }
    }
}
