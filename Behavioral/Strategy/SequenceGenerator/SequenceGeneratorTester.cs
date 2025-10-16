using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.SequenceGenerator
{
    public static class SequenceGeneratorTester
    {
        public static void Test()
        {
            SequenceGenerator generator = new SequenceGenerator(100000);
            IList<double> uniformNumbers = generator.GenerateRandomSequence();
            INumberGenerator gaussian = new GaussianGenerator(0.5, 0.25);
            generator.Strategy = gaussian;
            IList<double> gaussianNumbers = generator.GenerateRandomSequence();
            /*SimpleConsoleHistogram histogram = new SimpleConsoleHistogram();
            Console.WriteLine(histogram.Histogram(uniformNumbers));
            Console.WriteLine(histogram.Histogram(gaussianNumbers));
            */
        }
    }
}
