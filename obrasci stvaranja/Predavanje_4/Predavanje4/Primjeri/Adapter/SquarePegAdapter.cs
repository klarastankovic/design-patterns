using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primjeri.Adapter
{
     public class SquarePegAdapter : RoundPeg {
        private SquarePeg squarePeg;
        public SquarePegAdapter(SquarePeg peg) { this.squarePeg = peg; }
        public override double GetRadius()
        {
            double width = squarePeg.GetWidth();
            double radius = Math.Sqrt(2 * width * width) / 2;
            return radius;
        }
    }
}
