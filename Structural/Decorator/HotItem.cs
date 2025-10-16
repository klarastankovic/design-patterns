using Decorator.Rentable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class HotItem : RentableDecorator
    {
        private readonly double HotItemBonus = 1.99;
        public HotItem(IRentable rentable) : base(rentable) {}
        public override double CalculatePrice()
        {
            return base.CalculatePrice() + this.HotItemBonus;
        }
        public override string Description
        {
            get
            {
                return "Trending: " + base.Description;
            }
        }
    }
}
