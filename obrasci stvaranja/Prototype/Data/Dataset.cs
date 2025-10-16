using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Data
{
    public class Dataset : ICloneable
    {
        String name;
        List<Sample> samples;
        public Dataset(String name)
        {
            this.name = name;
            this.samples = new List<Sample>();
        }
        public Dataset (Dataset dataset) : this(dataset.name)
        {
            foreach (Sample sample in dataset.samples)
            {
                this.samples.Add((Sample)sample.Clone());
            }
        }
        public void AddSample (Sample sample) { this.samples.Add((Sample)sample.Clone()); }
        public object Clone() => new Dataset(this);
    }
}
