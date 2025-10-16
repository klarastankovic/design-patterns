using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primjeri.Adapter
{
    public class SquarePeg
    {
        private double width;
        public SquarePeg(double width) { this.width = width; }
        public double GetWidth() { return width; }
        public double getArea()
        {
            double result = Math.Pow(this.width, 2);
            return result;
        }
    }
}
