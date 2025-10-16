using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.SequenceGenerator
{
    public class GaussianGenerator : INumberGenerator
    {
        private static readonly Random Generator = new Random();
        public double Mean { get; private set; }
        public double StdDev { get; private set; }
        public GaussianGenerator(double mean, double stdDev)
        {
            Mean = mean;
            StdDev = stdDev;
        }
        public double Generate()
        {
            double first = 1.0 - Generator.NextDouble();
            double second = 1.0 - Generator.NextDouble();
            double randomStandardNormal = 
                Math.Sqrt(-2.0 * Math.Log(first)) * Math.Sin(2.0 * Math.PI * second);
            return this.Mean + this.StdDev * randomStandardNormal;
        }
    }
}
