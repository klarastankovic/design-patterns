using Decorator.Rentable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class RentableDecorator : IRentable
    {
        private IRentable rentable;
        public RentableDecorator(IRentable rentable)
        {
            this.rentable = rentable;
        }
        public virtual double CalculatePrice()
        {
            return this.rentable.CalculatePrice();
        }
        public virtual String Description
        {
            get
            {
                return this.rentable.Description;
            }
        }
    }
}
