using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Round
{
    public class SquarePegAdapter : IRound
    {
        private SquarePeg squarePeg;
        public SquarePegAdapter(SquarePeg squarePeg)
        {
            this.squarePeg = squarePeg;
        }
        public double GetRadius()
        {
            double width = squarePeg.GetWidth();
            double radius = Math.Sqrt(2 * width * width) / 2;
            return radius;
        }
    }
}
