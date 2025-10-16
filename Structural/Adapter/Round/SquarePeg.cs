using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Round
{
    public class SquarePeg
    {
        private double width;
        public SquarePeg(double width)
        {
            this.width = width;
        }
        public double GetWidth()
        {
            return width;
        }
        public double GetArea()
        {
            return Math.Pow(width, 2);
        }
    }
}
