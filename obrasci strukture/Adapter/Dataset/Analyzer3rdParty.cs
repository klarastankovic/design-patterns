using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Dataset
{
    public class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }
        public double[] PerColumnAverage(double[][] data)
        {
            int columnCount = data.Length;
            double[] results = new double[columnCount];
            for (int i = 0; i < columnCount; i++)
            {
                results[i] = data.Select(row => row[i]).Average();
            }
            return results;
        }
    }
}
