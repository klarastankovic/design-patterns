using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primjeri.Adapter
{
    public class RoundPeg
    {
        private double radius;
        public RoundPeg() { this.radius = 1; }
        public RoundPeg(double radius)
        {
            this.radius = radius;
        }
        public virtual double GetRadius()
        {
            return radius;
        }
    }
}
