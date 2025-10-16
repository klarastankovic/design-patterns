using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.SequenceGenerator
{
    public class SequenceGenerator
    {
        public int Count { get; private set; }
        public INumberGenerator Strategy { get; set; }
        public SequenceGenerator(int count)
        {
            this.Count = count;
            this.Strategy = new UniformGenerator();
        }
        public IList<double> GenerateRandomSequence()
        {
            List<double> randomNumbers = new List<double>(this.Count);
            for (int i = 0; i < this.Count; i++)
            {
                randomNumbers.Add(this.Strategy.Generate());
            }
            return randomNumbers;
        }
    }
}
