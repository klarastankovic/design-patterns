using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Data
{
    public class MachineLearningDemo
    {
        public void RunExperiment()
        {
            Dataset iris = new Dataset("Iris");
            int sampleCount = 10;
            for (int i = 0; i < sampleCount; i++)
            {
                iris.AddSample(this.Measure());
            }
            Dataset normalized = FeatureManipulation.Normalize(iris);
        }
        private Sample Measure()
        {
            // implementation
            double[] data = new double[10];
            return new Sample(DateTime.Now, data);
        }
    }
}
