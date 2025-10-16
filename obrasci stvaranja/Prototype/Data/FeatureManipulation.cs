using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Data
{
    public class FeatureManipulation
    {
        private static double minValue = 0.0, maxValue = 1.0;
        public static Dataset Normalize (Dataset dataset)
        {
            Dataset clone = (Dataset)dataset.Clone();
            // normalization
            return clone;
        }
    }
}
