using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Sort
{
    public static class SortTester
    {
        public static void Test()
        {
            double[] array = new double[] { 5, 7, 11, 13, 1, 23, 9 };
            NumberSequence sequence = new NumberSequence(array);

            SortStrategy strategy = new SequentialSort();
            sequence.SetSortStrategy(strategy);
            Console.WriteLine(DateTime.Now + Environment.NewLine);
            sequence.Sort();
            Console.WriteLine(sequence + Environment.NewLine + DateTime.Now);

            array = new double[] { 5, 7, 11, 13, 1, 23, 9 };
            strategy = new BubbleSort();
            sequence.SetSortStrategy(strategy);
            Console.WriteLine(DateTime.Now + Environment.NewLine);
            sequence.Sort();
            Console.WriteLine(sequence + Environment.NewLine + DateTime.Now);

            array = new double[] { 5, 7, 11, 13, 1, 23, 9 };
            strategy = new CombSort();
            sequence.SetSortStrategy(strategy);
            Console.WriteLine(DateTime.Now + Environment.NewLine);
            sequence.Sort();
            Console.WriteLine(sequence + Environment.NewLine + DateTime.Now);
        }
    }
}
