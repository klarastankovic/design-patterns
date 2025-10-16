using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Billable
{
    public class ShippingService
    {
        private double pricePerKilogram;
        public ShippingService(double pricePerKilogram)
        {
            this.pricePerKilogram = pricePerKilogram;
        }

        public double CalculateShippingPrice(IShipable package)
        {
            return pricePerKilogram * package.Weight;
        }
    }
}
