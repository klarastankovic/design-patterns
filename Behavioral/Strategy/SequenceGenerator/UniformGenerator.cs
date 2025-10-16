using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.SequenceGenerator
{
    public class UniformGenerator : INumberGenerator
    {
        private static readonly Random Generator = new Random();
        public double Generate()
        {
            return Generator.NextDouble();
        }
    }
}
