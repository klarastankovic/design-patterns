using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Round
{
    public class RoundHole
    {
        private double radious;
        public RoundHole(double radious)
        {
            this.radious = radious;
        }
        public double GetRadius()
        {
            return radious;
        }
        public bool WillFit(IRound peg)
        {
            return this.GetRadius() >= peg.GetRadius();
        }
    }
}
