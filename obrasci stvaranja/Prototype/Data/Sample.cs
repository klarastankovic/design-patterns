using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Data
{
    public class Sample : ICloneable
    {
        private DateTime timestamp;
        private double[] measurements;
        public Sample(DateTime timestamp, double[] data)
        {
            this.timestamp = timestamp;
            this.measurements = new double[data.Length];
            Array.Copy(data, this.measurements, this.measurements.Length);
        }
        public Sample (Sample sample) : this(sample.timestamp, sample.measurements) {}
        public object Clone() => new Sample(this);
    }
}
