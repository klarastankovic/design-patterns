using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Rentable
{
    public class DiscountedItem : RentableDecorator
    {
        private double discount;
        public DiscountedItem(double discount, IRentable rentable) : base(rentable)
        {
            this.discount = discount;
        }
        public override double CalculatePrice()
        {
            return base.CalculatePrice() * ((100 - discount) / 100);
        }
        public override string Description
        {
            get
            {
                return base.Description + $" now at {discount}% off";
            }
        }

    }
}
